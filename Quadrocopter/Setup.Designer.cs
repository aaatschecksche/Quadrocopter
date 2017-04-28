namespace Quadrocopter
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.B_START = new System.Windows.Forms.Button();
            this.BaudSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PortSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AutoConnect = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // B_START
            // 
            resources.ApplyResources(this.B_START, "B_START");
            this.B_START.Name = "B_START";
            this.B_START.UseVisualStyleBackColor = true;
            this.B_START.Click += new System.EventHandler(this.B_START_Click);
            // 
            // BaudSelector
            // 
            this.BaudSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BaudSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.BaudSelector, "BaudSelector");
            this.BaudSelector.Items.AddRange(new object[] {
            resources.GetString("BaudSelector.Items"),
            resources.GetString("BaudSelector.Items1"),
            resources.GetString("BaudSelector.Items2"),
            resources.GetString("BaudSelector.Items3"),
            resources.GetString("BaudSelector.Items4"),
            resources.GetString("BaudSelector.Items5"),
            resources.GetString("BaudSelector.Items6"),
            resources.GetString("BaudSelector.Items7"),
            resources.GetString("BaudSelector.Items8"),
            resources.GetString("BaudSelector.Items9"),
            resources.GetString("BaudSelector.Items10")});
            this.BaudSelector.Name = "BaudSelector";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // PortSelector
            // 
            this.PortSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PortSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.PortSelector, "PortSelector");
            this.PortSelector.Name = "PortSelector";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // AutoConnect
            // 
            resources.ApplyResources(this.AutoConnect, "AutoConnect");
            this.AutoConnect.Checked = true;
            this.AutoConnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoConnect.Name = "AutoConnect";
            this.AutoConnect.UseVisualStyleBackColor = true;
            // 
            // Setup
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AutoConnect);
            this.Controls.Add(this.BaudSelector);
            this.Controls.Add(this.PortSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_START);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_START;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PortSelector;
        private System.Windows.Forms.ComboBox BaudSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox AutoConnect;
    }
}