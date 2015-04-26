using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarcinSzymanski.Shared.Classess
{
    public class TaskSettingItem
    {
        public string Group { get; set; }
        public string Setting { get; set; }
        public string Value { get; set; }


        public TaskSettingItem() { }

        public TaskSettingItem(string group, string setting, string value)
        {
            Group = group;
            Setting = setting;
            Value = value;
        }

        public bool Checked()
        {
            if (Value == "True")
                return true;
            else return false;
        }

    }
}
