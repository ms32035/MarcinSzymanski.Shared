using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

namespace MarcinSzymanski.Shared.Classess
{
    public class TaskSettings
    {

        public string TaskCategory { get; set; }
        public string TaskDescription { get; set; }
        public string TaskName { get; set; }
        public string TaskXmlName { get; set; }
        public string FormTitle { get; set; }
        public List<TaskSettingItem> TaskSettingsList { get; set; }
        public List<TaskPanel> TaskPanels { get; set; }
        private TaskCodeGenerator CodeGenerator { set; get; }
        public SAS.Shared.AddIns.ISASTaskConsumer3 SASConsumer { get; set; }

        public TaskSettings()
        {
            TaskSettingsList = new List<TaskSettingItem>();
            TaskPanels = new List<TaskPanel>();
        }

        public string GenerateSasCode()
        {
            return CodeGenerator.GenerateSasCode(TaskSettingsList);
        }

        public void setCodeGenerator(TaskCodeGenerator codeGenerator)
        {
            CodeGenerator = codeGenerator;
        }

        public void updateSettingList()
        {

            TaskSettingsList.Clear();
            foreach (TaskPanel tmpPanel in TaskPanels)
            {
                foreach (TaskSettingItem tmpSetting in tmpPanel.controlObject.GetSettings())
                {
                    TaskSettingsList.Add(tmpSetting);
                }
            }

        }


        public string ToXml()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement xmlTask = doc.CreateElement(this.TaskXmlName);

            foreach (TaskSettingItem TmpSetting in TaskSettingsList)
            {
                XmlElement xmlSetting = doc.CreateElement("SettingItem");
                xmlSetting.SetAttribute("Group", TmpSetting.Group);
                xmlSetting.SetAttribute("Setting", TmpSetting.Setting);
                xmlSetting.SetAttribute("Value", TmpSetting.Value);
                xmlTask.AppendChild(xmlSetting);
            }

            
            updateSettingList();

            return xmlTask.OuterXml;
        }

        public void FromXml(string xml)
        {

            XmlDocument doc = new XmlDocument();
            try
            {
                TaskSettingsList.Clear();
                doc.LoadXml(xml);
                XmlElement XmlTask = doc[this.TaskXmlName];

                foreach (XmlElement XmlSetting in XmlTask)
                {
                    TaskSettingItem SettingItem = new TaskSettingItem(XmlSetting.GetAttribute("Group"), XmlSetting.GetAttribute("Setting"), XmlSetting.GetAttribute("Value"));
                    TaskSettingsList.Add(SettingItem);
                }

            }
            catch (XmlException)
            {
            }
            catch (Exception)
            {
            }

        }

        public virtual int OutputDataCount()
        {
            return 0;
        }

        public virtual bool ValidateTask()
        {
            return true;
        }

    }
}
