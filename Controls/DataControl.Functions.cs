using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Resources;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;
using SAS.EG.Controls;
using SAS.Tasks.Toolkit;
using SAS.Shared.AddIns;
using MarcinSzymanski.Shared.Classess;

namespace MarcinSzymanski.Shared
{
    public partial class DataControl : TaskControl
    {
        private Dictionary<string, string> roleMappings;
        public string SourceDataset { get; set; }

        private SASVariableSelector.AddVariableParams getVarParms(ISASTaskDataColumn colInfo)
        {
            SASVariableSelector.AddVariableParams var_params = new SASVariableSelector.AddVariableParams();

            var_params.Name = colInfo.Name;
            var_params.Label = colInfo.Label;
            var_params.Format = colInfo.Format;
            var_params.Informat = colInfo.Informat;
            var_params.MaxLength = colInfo.Length;

            if (colInfo.Group == VariableGroup.Character)
                var_params.Type = VARTYPE.Character;
            else
                var_params.Type = VARTYPE.Numeric;

            return var_params;
        }

        public void getSourceColumns(ISASTaskData2 taskData)
        {
            ISASTaskDataAccessor accessor = taskData.Accessor;
            SASVariableSelector.AddVariableParams var_params;
            ISASTaskDataColumn2 data_column;

            accessor.Open();

            for (int i = 0; i < accessor.ColumnCount; i++)
            {
                data_column = accessor.ColumnInfoByIndex(i) as ISASTaskDataColumn2;
                var_params = var_params = getVarParms(data_column);
                sasVarSelector.AddVariable(var_params);
            }
            accessor.Close();
        }

        public void addColumnRole(string roleName, string roleCode, SASVariableSelector.ROLETYPE columnTypes, int minCols, int maxCols, bool unique)
        {
            roleMappings.Add(roleName, roleCode);
            SASVariableSelector.AddRoleParams roleParms = new SASVariableSelector.AddRoleParams();
            roleParms.Name = roleName;
            roleParms.Type = columnTypes;
            roleParms.MinNumVars = minCols;
            if (maxCols > 0) roleParms.MaxNumVars = maxCols;
            roleParms.Unique = unique;
            sasVarSelector.AddRole(roleParms);
        }

        public override List<TaskSettingItem> GetSettings()
        {
            string roleName;
            List<TaskSettingItem> setttingItems = new List<TaskSettingItem>();
            TaskSettingItem SetttingItem;

            for (int i = 0; i < sasVarSelector.GetRoleCount(); i++)
            {
                roleName = sasVarSelector.GetRoleAt(i);
                for (int j = 0; j < sasVarSelector.GetNumberOfAssignedVariables(roleName); j++)
                {
                    SetttingItem = new TaskSettingItem("Variables", roleMappings[roleName], sasVarSelector.GetAssignedVariable(roleName, j));
                    setttingItems.Add(SetttingItem);
                }

            }

            SetttingItem = new TaskSettingItem("Data", "Input", SourceDataset);
            setttingItems.Add(SetttingItem);

            return setttingItems;

        }

        public override void RestoreSettings(List<TaskSettingItem> settingsList)
        {

            foreach (TaskSettingItem settingItem in settingsList.FindAll(o => o.Group == "Variables"))
            {
                try
                {
                    sasVarSelector.AssignVariable(roleMappings.FirstOrDefault(x => x.Value == settingItem.Setting).Key, settingItem.Value);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error at variable: " + settingItem.Value + " " + e.Message,"DataControl");
                }

            }

        }

    }

}

