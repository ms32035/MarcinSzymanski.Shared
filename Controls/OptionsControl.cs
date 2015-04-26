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
using MarcinSzymanski.Shared.Classess;

namespace MarcinSzymanski.Shared
{
    public partial class OptionsControl : TaskControl
    {
        public OptionsControl()
        {
            InitializeComponent();

        }

        private void loadSelector(object sender, EventArgs e)
        {
         

        }

        public override List<TaskSettingItem> GetSettings()
        {

            List<TaskSettingItem> setttingItems = new List<TaskSettingItem>();

            TaskSettingItem setttingItem = new TaskSettingItem("Options", "Pre-code", txtPreCode.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Options", "Post-code", txtPostCode.Text);
            setttingItems.Add(setttingItem);

            return setttingItems;

        }

        public override void RestoreSettings(List<TaskSettingItem> settingsList)
        {

            try
            {
                txtPreCode.Text = settingsList.Find(o => o.Group == "Options" && o.Setting == "Pre-code").Value;
                txtPostCode.Text = settingsList.Find(o => o.Group == "Options" && o.Setting == "Post-code").Value;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"OptionsControl");
            }  

        }

    }
}
