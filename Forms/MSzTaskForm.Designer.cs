namespace MarcinSzymanski.Shared
{
    partial class MSzTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSzTaskForm));
            this.taskSplitContainer = new System.Windows.Forms.SplitContainer();
            this.menuTree = new System.Windows.Forms.TreeView();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.lblNodeTitle = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.taskFormPanel = new System.Windows.Forms.Panel();
            this.btnViewCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.taskSplitContainer)).BeginInit();
            this.taskSplitContainer.Panel1.SuspendLayout();
            this.taskSplitContainer.Panel2.SuspendLayout();
            this.taskSplitContainer.SuspendLayout();
            this.taskFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskSplitContainer
            // 
            resources.ApplyResources(this.taskSplitContainer, "taskSplitContainer");
            this.taskSplitContainer.Name = "taskSplitContainer";
            // 
            // taskSplitContainer.Panel1
            // 
            this.taskSplitContainer.Panel1.Controls.Add(this.menuTree);
            // 
            // taskSplitContainer.Panel2
            // 
            this.taskSplitContainer.Panel2.Controls.Add(this.controlPanel);
            this.taskSplitContainer.Panel2.Controls.Add(this.lblNodeTitle);
            this.taskSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.taskSplitContainer_SplitterMoved);
            // 
            // menuTree
            // 
            resources.ApplyResources(this.menuTree, "menuTree");
            this.menuTree.Name = "menuTree";
            this.menuTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.menuTree_AfterSelect);
            // 
            // controlPanel
            // 
            resources.ApplyResources(this.controlPanel, "controlPanel");
            this.controlPanel.Name = "controlPanel";
            // 
            // lblNodeTitle
            // 
            resources.ApplyResources(this.lblNodeTitle, "lblNodeTitle");
            this.lblNodeTitle.Name = "lblNodeTitle";
            this.lblNodeTitle.Click += new System.EventHandler(this.lblNodeTitle_Click);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // taskFormPanel
            // 
            this.taskFormPanel.Controls.Add(this.taskSplitContainer);
            resources.ApplyResources(this.taskFormPanel, "taskFormPanel");
            this.taskFormPanel.Name = "taskFormPanel";
            // 
            // btnViewCode
            // 
            resources.ApplyResources(this.btnViewCode, "btnViewCode");
            this.btnViewCode.Name = "btnViewCode";
            this.btnViewCode.UseVisualStyleBackColor = true;
            this.btnViewCode.Click += new System.EventHandler(this.btnViewCode_Click);
            // 
            // MSzTaskForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnViewCode);
            this.Controls.Add(this.taskFormPanel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MSzTaskForm";
            this.taskSplitContainer.Panel1.ResumeLayout(false);
            this.taskSplitContainer.Panel2.ResumeLayout(false);
            this.taskSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskSplitContainer)).EndInit();
            this.taskSplitContainer.ResumeLayout(false);
            this.taskFormPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNodeTitle;
        private System.Windows.Forms.TreeView menuTree;
        private System.Windows.Forms.Panel taskFormPanel;
        private System.Windows.Forms.SplitContainer taskSplitContainer;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button btnViewCode;
    }
}