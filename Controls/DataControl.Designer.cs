using SAS.EG.Controls;

namespace MarcinSzymanski.Shared
{
    partial class DataControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sasVarSelector = new SASVariableSelector();
            this.SuspendLayout();
            // 
            // sasVarSelector
            // 
            this.sasVarSelector.CacheDirtyFlag = false;
            this.sasVarSelector.CachePath = null;
            this.sasVarSelector.ColumnRolesTitle = "";
            this.sasVarSelector.ColumnsToAssignTitle = "";
            this.sasVarSelector.Location = new System.Drawing.Point(3, 57);
            this.sasVarSelector.Name = "sasVarSelector";
            this.sasVarSelector.Size = new System.Drawing.Size(730, 440);
            this.sasVarSelector.TabIndex = 0;
            // 
            // DataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sasVarSelector);
            this.Name = "DataControl";
            this.Size = new System.Drawing.Size(835, 500);
            this.Load += new System.EventHandler(this.loadSelector);
            this.ResumeLayout(false);

        }

        #endregion

        private SASVariableSelector sasVarSelector;


    }
}
