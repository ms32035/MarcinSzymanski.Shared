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
        public DataControl()
        {
            InitializeComponent();
            roleMappings = new Dictionary<string, string>();
        }

        private void loadSelector(object sender, EventArgs e)
        {

        }

    }
}

