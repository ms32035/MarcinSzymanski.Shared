using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Resources;
using System.Collections.Generic;
using MarcinSzymanski.Shared.Classess;
using SAS.Tasks.Toolkit.Controls;

namespace MarcinSzymanski.Shared
{
    /// <summary>
    /// This windows form inherits from the TaskForm class, which
    /// includes a bit of special handling for SAS Enterprise Guide.
    /// </summary>
    /// 
    public partial class MSzTaskForm : SAS.Tasks.Toolkit.Controls.TaskForm
    {
        public TaskSettings TaskInstanceSettings { get; set; }
        public List<TaskControl> TaskControlsList { get; set; }
        public ResourceManager RStrings { get; set; }
        SASCodeViewDialog CodeView;


        public MSzTaskForm(SAS.Shared.AddIns.ISASTaskConsumer3 consumer, TaskSettings settings, List<TaskControl> taskControlList)
        {
            Consumer = consumer;
            TaskInstanceSettings = settings;
            TaskControlsList = taskControlList;

            InitializeComponent();

            // provide a handle to the SAS Enterprise Guide application

            InitializeForm();
        }

        // initialize the form with the values from the settings
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.controlPanel.Controls.Clear();
            //wczytanie 1-go panelu i ustawienie etykiety
            this.controlPanel.Controls.Add(TaskControlsList[0]);
            this.lblNodeTitle.Text = TaskControlsList[0].NodeText;


        }

        // save any values from the dialog into the settings class
        protected override void OnClosing(CancelEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {

                //Settings.SasOption = txtOption.Text;
            }

            base.OnClosing(e);
        }

        private void menuTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

            foreach (TaskControl TmpPanel in TaskControlsList)
            {
                if (e.Node.Name == TmpPanel.NodeName)
                {
                    this.controlPanel.Controls.Clear();
                    this.controlPanel.Controls.Add(TmpPanel);
                    this.lblNodeTitle.Text = TmpPanel.NodeText;
                }
            }

        }

        private void taskSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            menuTree.Width = e.X - 5;
        }

        private void InitializeForm()
        {

            InitializeTree();
        }

        private void lblNodeTitle_Click(object sender, EventArgs e)
        {

        }


        private void InitializeTree()
        {
            foreach (TaskControl TmpControl in TaskControlsList)
            {
                menuTree.Nodes.Add(TmpControl.NodeName, TmpControl.NodeText);
            }
        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (CodeView.Visible == false)
                {
                    UpdateSettings();
                    CodeView = new SASCodeViewDialog(this, "", TaskInstanceSettings.GenerateSasCode());
                    CodeView.Show();
                }
            }
            catch (NullReferenceException)
            {
                UpdateSettings();
                CodeView = new SASCodeViewDialog(this, "", TaskInstanceSettings.GenerateSasCode());
                CodeView.Show();
            }

        }


        public void UpdateSettings()
        {

            TaskInstanceSettings.TaskSettingsList.Clear();

            foreach (TaskControl TmpControl in TaskControlsList)
            {
                TaskInstanceSettings.TaskSettingsList.AddRange(TmpControl.GetSettings());
            }

        }

        public void RestoreFromSettings()
        {
            if (TaskInstanceSettings.TaskSettingsList.Count > 0)
            {
                foreach (TaskControl TmpControl in TaskControlsList)
                {
                    TmpControl.RestoreSettings(TaskInstanceSettings.TaskSettingsList);
                }
            }
            

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UpdateSettings();
            if (TaskInstanceSettings.ValidateTask())
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.None;
 
        }


    }
}
