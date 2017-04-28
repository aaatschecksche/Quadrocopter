namespace Quadrocopter
{
    partial class Quadrocopter
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
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.SendBox = new System.Windows.Forms.RichTextBox();
            this.RecieveBox = new System.Windows.Forms.RichTextBox();
            this.CommandSelector = new System.Windows.Forms.ComboBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearLog = new System.Windows.Forms.Button();
            this.DebugBox = new System.Windows.Forms.RichTextBox();
            this.ListeningCheckBox = new System.Windows.Forms.CheckBox();
            this.KPButton = new System.Windows.Forms.Button();
            this.KDButton = new System.Windows.Forms.Button();
            this.KIButton = new System.Windows.Forms.Button();
            this.KPBox = new System.Windows.Forms.RichTextBox();
            this.KDBox = new System.Windows.Forms.RichTextBox();
            this.KIBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(381, 9);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(161, 40);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Connecting";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.Maroon;
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(380, 85);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(161, 80);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SendBox
            // 
            this.SendBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SendBox.DetectUrls = false;
            this.SendBox.Location = new System.Drawing.Point(147, 137);
            this.SendBox.Multiline = false;
            this.SendBox.Name = "SendBox";
            this.SendBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.SendBox.Size = new System.Drawing.Size(227, 24);
            this.SendBox.TabIndex = 2;
            this.SendBox.Text = "";
            // 
            // RecieveBox
            // 
            this.RecieveBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RecieveBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RecieveBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RecieveBox.ForeColor = System.Drawing.Color.Black;
            this.RecieveBox.Location = new System.Drawing.Point(12, 289);
            this.RecieveBox.Name = "RecieveBox";
            this.RecieveBox.ReadOnly = true;
            this.RecieveBox.Size = new System.Drawing.Size(416, 451);
            this.RecieveBox.TabIndex = 3;
            this.RecieveBox.Text = "";
            this.RecieveBox.TextChanged += new System.EventHandler(this.RecieveBox_TextChanged);
            // 
            // CommandSelector
            // 
            this.CommandSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CommandSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CommandSelector.ItemHeight = 16;
            this.CommandSelector.Location = new System.Drawing.Point(147, 91);
            this.CommandSelector.Name = "CommandSelector";
            this.CommandSelector.Size = new System.Drawing.Size(227, 24);
            this.CommandSelector.TabIndex = 4;
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(361, 40);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Quadrocopter v. 0.04";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Command";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Log";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearLog
            // 
            this.ClearLog.AutoSize = true;
            this.ClearLog.BackColor = System.Drawing.Color.DimGray;
            this.ClearLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearLog.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLog.Location = new System.Drawing.Point(148, 251);
            this.ClearLog.Name = "ClearLog";
            this.ClearLog.Size = new System.Drawing.Size(113, 35);
            this.ClearLog.TabIndex = 5;
            this.ClearLog.Text = "CLEAR";
            this.ClearLog.UseVisualStyleBackColor = false;
            this.ClearLog.Click += new System.EventHandler(this.ClearConsole_Click);
            // 
            // DebugBox
            // 
            this.DebugBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DebugBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DebugBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DebugBox.ForeColor = System.Drawing.Color.Black;
            this.DebugBox.Location = new System.Drawing.Point(438, 289);
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.ReadOnly = true;
            this.DebugBox.Size = new System.Drawing.Size(416, 451);
            this.DebugBox.TabIndex = 3;
            this.DebugBox.Text = "";
            // 
            // ListeningCheckBox
            // 
            this.ListeningCheckBox.Checked = true;
            this.ListeningCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ListeningCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListeningCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListeningCheckBox.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeningCheckBox.Location = new System.Drawing.Point(12, 168);
            this.ListeningCheckBox.Name = "ListeningCheckBox";
            this.ListeningCheckBox.Size = new System.Drawing.Size(194, 63);
            this.ListeningCheckBox.TabIndex = 6;
            this.ListeningCheckBox.Text = "Listening";
            this.ListeningCheckBox.UseVisualStyleBackColor = true;
            this.ListeningCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // KPButton
            // 
            this.KPButton.Location = new System.Drawing.Point(685, 91);
            this.KPButton.Name = "KPButton";
            this.KPButton.Size = new System.Drawing.Size(75, 23);
            this.KPButton.TabIndex = 7;
            this.KPButton.Text = "Set KP";
            this.KPButton.UseVisualStyleBackColor = true;
            this.KPButton.Click += new System.EventHandler(this.KPButton_Click);
            // 
            // KDButton
            // 
            this.KDButton.Location = new System.Drawing.Point(685, 121);
            this.KDButton.Name = "KDButton";
            this.KDButton.Size = new System.Drawing.Size(75, 23);
            this.KDButton.TabIndex = 8;
            this.KDButton.Text = "Set KD";
            this.KDButton.UseVisualStyleBackColor = true;
            this.KDButton.Click += new System.EventHandler(this.KDButton_Click);
            // 
            // KIButton
            // 
            this.KIButton.Location = new System.Drawing.Point(685, 151);
            this.KIButton.Name = "KIButton";
            this.KIButton.Size = new System.Drawing.Size(75, 23);
            this.KIButton.TabIndex = 9;
            this.KIButton.Text = "Set KI";
            this.KIButton.UseVisualStyleBackColor = true;
            this.KIButton.Click += new System.EventHandler(this.KIButton_Click);
            // 
            // KPBox
            // 
            this.KPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KPBox.Location = new System.Drawing.Point(589, 91);
            this.KPBox.Name = "KPBox";
            this.KPBox.Size = new System.Drawing.Size(90, 24);
            this.KPBox.TabIndex = 10;
            this.KPBox.Text = "";
            // 
            // KDBox
            // 
            this.KDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KDBox.Location = new System.Drawing.Point(589, 121);
            this.KDBox.Name = "KDBox";
            this.KDBox.Size = new System.Drawing.Size(90, 24);
            this.KDBox.TabIndex = 10;
            this.KDBox.Text = "";
            // 
            // KIBox
            // 
            this.KIBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KIBox.Location = new System.Drawing.Point(589, 151);
            this.KIBox.Name = "KIBox";
            this.KIBox.Size = new System.Drawing.Size(90, 24);
            this.KIBox.TabIndex = 10;
            this.KIBox.Text = "";
            // 
            // Quadrocopter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 752);
            this.Controls.Add(this.KIBox);
            this.Controls.Add(this.KDBox);
            this.Controls.Add(this.KPBox);
            this.Controls.Add(this.KIButton);
            this.Controls.Add(this.KDButton);
            this.Controls.Add(this.KPButton);
            this.Controls.Add(this.ListeningCheckBox);
            this.Controls.Add(this.ClearLog);
            this.Controls.Add(this.CommandSelector);
            this.Controls.Add(this.DebugBox);
            this.Controls.Add(this.RecieveBox);
            this.Controls.Add(this.SendBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.StatusLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Quadrocopter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quadrocopter";
            this.Load += new System.EventHandler(this.Quadrocopter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.RichTextBox SendBox;
        private System.Windows.Forms.RichTextBox RecieveBox;
        private System.Windows.Forms.ComboBox CommandSelector;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearLog;
        private System.Windows.Forms.RichTextBox DebugBox;
        private System.Windows.Forms.CheckBox ListeningCheckBox;
        private System.Windows.Forms.Button KPButton;
        private System.Windows.Forms.Button KDButton;
        private System.Windows.Forms.Button KIButton;
        private System.Windows.Forms.RichTextBox KPBox;
        private System.Windows.Forms.RichTextBox KDBox;
        private System.Windows.Forms.RichTextBox KIBox;
    }
}