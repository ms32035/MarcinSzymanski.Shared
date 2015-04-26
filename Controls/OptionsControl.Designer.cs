namespace MarcinSzymanski.Shared
{
    partial class OptionsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsControl));
            this.lblPreCode = new System.Windows.Forms.Label();
            this.txtPreCode = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPreCode
            // 
            resources.ApplyResources(this.lblPreCode, "lblPreCode");
            this.lblPreCode.Name = "lblPreCode";
            // 
            // txtPreCode
            // 
            resources.ApplyResources(this.txtPreCode, "txtPreCode");
            this.txtPreCode.Name = "txtPreCode";
            // 
            // txtPostCode
            // 
            resources.ApplyResources(this.txtPostCode, "txtPostCode");
            this.txtPostCode.Name = "txtPostCode";
            // 
            // lblPostCode
            // 
            resources.ApplyResources(this.lblPostCode, "lblPostCode");
            this.lblPostCode.Name = "lblPostCode";
            // 
            // OptionsControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.txtPreCode);
            this.Controls.Add(this.lblPreCode);
            this.Name = "OptionsControl";
            this.Load += new System.EventHandler(this.loadSelector);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreCode;
        private System.Windows.Forms.TextBox txtPreCode;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label lblPostCode;





    }
}
