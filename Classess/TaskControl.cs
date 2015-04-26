using System.Windows.Forms;
using System.Collections.Generic;

namespace MarcinSzymanski.Shared.Classess
{
    public class TaskControl : UserControl
    {

        public string NodeName { get; set; }
        public string NodeText { get; set; }

        public TaskControl() : base ()
        {

        }

        public void SetTree(string nodeName, string nodeText)
        {
            NodeName = nodeName;
            NodeText = nodeText;
        }

        public virtual List<TaskSettingItem> GetSettings()
        {
            return new List<TaskSettingItem>();
        }

        public virtual void RestoreSettings(List<TaskSettingItem> settingsList)
        {

            foreach (TaskSettingItem settingItem in settingsList)
            {
                string abc = settingItem.Group + " | " + settingItem.Setting + " | " + settingItem.Value;
                MessageBox.Show(abc);
            }

        }

    }


}
