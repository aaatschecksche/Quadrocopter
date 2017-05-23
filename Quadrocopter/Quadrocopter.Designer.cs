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
            this.KP_RollButton = new System.Windows.Forms.Button();
            this.KD_RollButton = new System.Windows.Forms.Button();
            this.KI_RollButton = new System.Windows.Forms.Button();
            this.KP_RollBox = new System.Windows.Forms.RichTextBox();
            this.KD_RollBox = new System.Windows.Forms.RichTextBox();
            this.KI_RollBox = new System.Windows.Forms.RichTextBox();
            this.KI_PitchBox = new System.Windows.Forms.RichTextBox();
            this.KD_PitchBox = new System.Windows.Forms.RichTextBox();
            this.KP_PitchBox = new System.Windows.Forms.RichTextBox();
            this.KI_PitchButton = new System.Windows.Forms.Button();
            this.KD_PitchButton = new System.Windows.Forms.Button();
            this.KP_PitchButton = new System.Windows.Forms.Button();
            this.KP_YawButton = new System.Windows.Forms.Button();
            this.KI_YawButton = new System.Windows.Forms.Button();
            this.KP_YawBox = new System.Windows.Forms.RichTextBox();
            this.KI_YawBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusLabel.Font = new System.Drawing.Font("Exo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Location = new System.Drawing.Point(496, 9);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(462, 40);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Connecting";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.Font = new System.Drawing.Font("Exo", 15F);
            this.SendButton.ForeColor = System.Drawing.Color.Black;
            this.SendButton.Location = new System.Drawing.Point(12, 165);
            this.SendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(465, 43);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SendBox
            // 
            this.SendBox.BackColor = System.Drawing.Color.White;
            this.SendBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SendBox.DetectUrls = false;
            this.SendBox.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBox.Location = new System.Drawing.Point(290, 132);
            this.SendBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendBox.Multiline = false;
            this.SendBox.Name = "SendBox";
            this.SendBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.SendBox.Size = new System.Drawing.Size(187, 25);
            this.SendBox.TabIndex = 2;
            this.SendBox.Text = "";
            // 
            // RecieveBox
            // 
            this.RecieveBox.BackColor = System.Drawing.Color.White;
            this.RecieveBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecieveBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RecieveBox.ForeColor = System.Drawing.Color.Black;
            this.RecieveBox.Location = new System.Drawing.Point(12, 304);
            this.RecieveBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecieveBox.Name = "RecieveBox";
            this.RecieveBox.ReadOnly = true;
            this.RecieveBox.Size = new System.Drawing.Size(465, 437);
            this.RecieveBox.TabIndex = 3;
            this.RecieveBox.Text = "";
            this.RecieveBox.TextChanged += new System.EventHandler(this.RecieveBox_TextChanged);
            // 
            // CommandSelector
            // 
            this.CommandSelector.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.CommandSelector.BackColor = System.Drawing.Color.White;
            this.CommandSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CommandSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CommandSelector.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandSelector.ItemHeight = 17;
            this.CommandSelector.Location = new System.Drawing.Point(12, 133);
            this.CommandSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CommandSelector.Name = "CommandSelector";
            this.CommandSelector.Size = new System.Drawing.Size(272, 25);
            this.CommandSelector.TabIndex = 4;
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel.Font = new System.Drawing.Font("Exo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Black;
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(465, 40);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Quadrocopter Gold Edition";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Command";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(290, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Log";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearLog
            // 
            this.ClearLog.AutoSize = true;
            this.ClearLog.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearLog.Font = new System.Drawing.Font("Exo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLog.ForeColor = System.Drawing.Color.Black;
            this.ClearLog.Location = new System.Drawing.Point(147, 259);
            this.ClearLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearLog.Name = "ClearLog";
            this.ClearLog.Size = new System.Drawing.Size(113, 35);
            this.ClearLog.TabIndex = 5;
            this.ClearLog.Text = "CLEAR";
            this.ClearLog.UseVisualStyleBackColor = true;
            this.ClearLog.Click += new System.EventHandler(this.ClearConsole_Click);
            // 
            // DebugBox
            // 
            this.DebugBox.BackColor = System.Drawing.Color.White;
            this.DebugBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DebugBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DebugBox.ForeColor = System.Drawing.Color.Black;
            this.DebugBox.Location = new System.Drawing.Point(496, 304);
            this.DebugBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.ReadOnly = true;
            this.DebugBox.Size = new System.Drawing.Size(462, 437);
            this.DebugBox.TabIndex = 3;
            this.DebugBox.Text = "";
            // 
            // ListeningCheckBox
            // 
            this.ListeningCheckBox.Checked = true;
            this.ListeningCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ListeningCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListeningCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListeningCheckBox.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeningCheckBox.Location = new System.Drawing.Point(266, 259);
            this.ListeningCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListeningCheckBox.Name = "ListeningCheckBox";
            this.ListeningCheckBox.Size = new System.Drawing.Size(113, 34);
            this.ListeningCheckBox.TabIndex = 6;
            this.ListeningCheckBox.Text = "Listening";
            this.ListeningCheckBox.UseVisualStyleBackColor = true;
            this.ListeningCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // KP_RollButton
            // 
            this.KP_RollButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.KP_RollButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KP_RollButton.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KP_RollButton.ForeColor = System.Drawing.Color.Black;
            this.KP_RollButton.Location = new System.Drawing.Point(571, 131);
            this.KP_RollButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KP_RollButton.Name = "KP_RollButton";
            this.KP_RollButton.Size = new System.Drawing.Size(75, 23);
            this.KP_RollButton.TabIndex = 7;
            this.KP_RollButton.Text = "Set KP";
            this.KP_RollButton.UseVisualStyleBackColor = true;
            this.KP_RollButton.Click += new System.EventHandler(this.KP_RollButton_Click);
            // 
            // KD_RollButton
            // 
            this.KD_RollButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.KD_RollButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KD_RollButton.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KD_RollButton.ForeColor = System.Drawing.Color.Black;
            this.KD_RollButton.Location = new System.Drawing.Point(571, 159);
            this.KD_RollButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KD_RollButton.Name = "KD_RollButton";
            this.KD_RollButton.Size = new System.Drawing.Size(75, 23);
            this.KD_RollButton.TabIndex = 8;
            this.KD_RollButton.Text = "Set KD";
            this.KD_RollButton.UseVisualStyleBackColor = true;
            this.KD_RollButton.Click += new System.EventHandler(this.KD_RollButton_Click);
            // 
            // KI_RollButton
            // 
            this.KI_RollButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.KI_RollButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KI_RollButton.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KI_RollButton.ForeColor = System.Drawing.Color.Black;
            this.KI_RollButton.Location = new System.Drawing.Point(571, 187);
            this.KI_RollButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KI_RollButton.Name = "KI_RollButton";
            this.KI_RollButton.Size = new System.Drawing.Size(75, 23);
            this.KI_RollButton.TabIndex = 9;
            this.KI_RollButton.Text = "Set KI";
            this.KI_RollButton.UseVisualStyleBackColor = true;
            this.KI_RollButton.Click += new System.EventHandler(this.KI_RollButton_Click);
            // 
            // KP_RollBox
            // 
            this.KP_RollBox.BackColor = System.Drawing.Color.White;
            this.KP_RollBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KP_RollBox.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KP_RollBox.Location = new System.Drawing.Point(496, 131);
            this.KP_RollBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KP_RollBox.Name = "KP_RollBox";
            this.KP_RollBox.Size = new System.Drawing.Size(69, 24);
            this.KP_RollBox.TabIndex = 10;
            this.KP_RollBox.Text = "";
            // 
            // KD_RollBox
            // 
            this.KD_RollBox.BackColor = System.Drawing.Color.White;
            this.KD_RollBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KD_RollBox.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KD_RollBox.Location = new System.Drawing.Point(496, 159);
            this.KD_RollBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KD_RollBox.Name = "KD_RollBox";
            this.KD_RollBox.Size = new System.Drawing.Size(69, 24);
            this.KD_RollBox.TabIndex = 10;
            this.KD_RollBox.Text = "";
            // 
            // KI_RollBox
            // 
            this.KI_RollBox.BackColor = System.Drawing.Color.White;
            this.KI_RollBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KI_RollBox.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KI_RollBox.Location = new System.Drawing.Point(496, 187);
            this.KI_RollBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KI_RollBox.Name = "KI_RollBox";
            this.KI_RollBox.Size = new System.Drawing.Size(69, 24);
            this.KI_RollBox.TabIndex = 10;
            this.KI_RollBox.Text = "";
            // 
            // KI_PitchBox
            // 
            this.KI_PitchBox.BackColor = System.Drawing.Color.White;
            this.KI_PitchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KI_PitchBox.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KI_PitchBox.Location = new System.Drawing.Point(652, 187);
            this.KI_PitchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KI_PitchBox.Name = "KI_PitchBox";
            this.KI_PitchBox.Size = new System.Drawing.Size(69, 24);
            this.KI_PitchBox.TabIndex = 14;
            this.KI_PitchBox.Text = "";
            // 
            // KD_PitchBox
            // 
            this.KD_PitchBox.BackColor = System.Drawing.Color.White;
            this.KD_PitchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KD_PitchBox.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KD_PitchBox.Location = new System.Drawing.Point(652, 159);
            this.KD_PitchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KD_PitchBox.Name = "KD_PitchBox";
            this.KD_PitchBox.Size = new System.Drawing.Size(69, 24);
            this.KD_PitchBox.TabIndex = 15;
            this.KD_PitchBox.Text = "";
            // 
            // KP_PitchBox
            // 
            this.KP_PitchBox.BackColor = System.Drawing.Color.White;
            this.KP_PitchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KP_PitchBox.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KP_PitchBox.Location = new System.Drawing.Point(652, 131);
            this.KP_PitchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KP_PitchBox.Name = "KP_PitchBox";
            this.KP_PitchBox.Size = new System.Drawing.Size(69, 24);
            this.KP_PitchBox.TabIndex = 16;
            this.KP_PitchBox.Text = "";
            // 
            // KI_PitchButton
            // 
            this.KI_PitchButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.KI_PitchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KI_PitchButton.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KI_PitchButton.ForeColor = System.Drawing.Color.Black;
            this.KI_PitchButton.Location = new System.Drawing.Point(727, 187);
            this.KI_PitchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KI_PitchButton.Name = "KI_PitchButton";
            this.KI_PitchButton.Size = new System.Drawing.Size(75, 24);
            this.KI_PitchButton.TabIndex = 13;
            this.KI_PitchButton.Text = "Set KI";
            this.KI_PitchButton.UseVisualStyleBackColor = true;
            this.KI_PitchButton.Click += new System.EventHandler(this.KI_PitchButton_Click);
            // 
            // KD_PitchButton
            // 
            this.KD_PitchButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.KD_PitchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KD_PitchButton.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KD_PitchButton.ForeColor = System.Drawing.Color.Black;
            this.KD_PitchButton.Location = new System.Drawing.Point(727, 159);
            this.KD_PitchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KD_PitchButton.Name = "KD_PitchButton";
            this.KD_PitchButton.Size = new System.Drawing.Size(75, 23);
            this.KD_PitchButton.TabIndex = 12;
            this.KD_PitchButton.Text = "Set KD";
            this.KD_PitchButton.UseVisualStyleBackColor = true;
            this.KD_PitchButton.Click += new System.EventHandler(this.KD_PitchButton_Click);
            // 
            // KP_PitchButton
            // 
            this.KP_PitchButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.KP_PitchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KP_PitchButton.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KP_PitchButton.ForeColor = System.Drawing.Color.Black;
            this.KP_PitchButton.Location = new System.Drawing.Point(727, 131);
            this.KP_PitchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KP_PitchButton.Name = "KP_PitchButton";
            this.KP_PitchButton.Size = new System.Drawing.Size(75, 23);
            this.KP_PitchButton.TabIndex = 11;
            this.KP_PitchButton.Text = "Set KP";
            this.KP_PitchButton.UseVisualStyleBackColor = true;
            this.KP_PitchButton.Click += new System.EventHandler(this.KP_PitchButton_Click);
            // 
            // KP_YawButton
            // 
            this.KP_YawButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.KP_YawButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KP_YawButton.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KP_YawButton.ForeColor = System.Drawing.Color.Black;
            this.KP_YawButton.Location = new System.Drawing.Point(883, 133);
            this.KP_YawButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KP_YawButton.Name = "KP_YawButton";
            this.KP_YawButton.Size = new System.Drawing.Size(75, 23);
            this.KP_YawButton.TabIndex = 11;
            this.KP_YawButton.Text = "Set KP";
            this.KP_YawButton.UseVisualStyleBackColor = true;
            this.KP_YawButton.Click += new System.EventHandler(this.KP_YawButton_Click);
            // 
            // KI_YawButton
            // 
            this.KI_YawButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.KI_YawButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KI_YawButton.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KI_YawButton.ForeColor = System.Drawing.Color.Black;
            this.KI_YawButton.Location = new System.Drawing.Point(883, 188);
            this.KI_YawButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KI_YawButton.Name = "KI_YawButton";
            this.KI_YawButton.Size = new System.Drawing.Size(75, 23);
            this.KI_YawButton.TabIndex = 12;
            this.KI_YawButton.Text = "Set KI";
            this.KI_YawButton.UseVisualStyleBackColor = true;
            this.KI_YawButton.Click += new System.EventHandler(this.KI_YawButton_Click);
            // 
            // KP_YawBox
            // 
            this.KP_YawBox.BackColor = System.Drawing.Color.White;
            this.KP_YawBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KP_YawBox.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KP_YawBox.Location = new System.Drawing.Point(808, 132);
            this.KP_YawBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KP_YawBox.Name = "KP_YawBox";
            this.KP_YawBox.Size = new System.Drawing.Size(69, 24);
            this.KP_YawBox.TabIndex = 16;
            this.KP_YawBox.Text = "";
            // 
            // KI_YawBox
            // 
            this.KI_YawBox.BackColor = System.Drawing.Color.White;
            this.KI_YawBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KI_YawBox.Font = new System.Drawing.Font("Exo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KI_YawBox.Location = new System.Drawing.Point(808, 187);
            this.KI_YawBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KI_YawBox.Name = "KI_YawBox";
            this.KI_YawBox.Size = new System.Drawing.Size(69, 24);
            this.KI_YawBox.TabIndex = 15;
            this.KI_YawBox.Text = "";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(496, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Roll";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(652, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pitch";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(808, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yaw";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(496, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 35);
            this.label7.TabIndex = 17;
            this.label7.Text = "Monitor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quadrocopter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(973, 752);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.KI_PitchBox);
            this.Controls.Add(this.KI_YawBox);
            this.Controls.Add(this.KD_PitchBox);
            this.Controls.Add(this.KP_YawBox);
            this.Controls.Add(this.KP_PitchBox);
            this.Controls.Add(this.KI_YawButton);
            this.Controls.Add(this.KI_PitchButton);
            this.Controls.Add(this.KP_YawButton);
            this.Controls.Add(this.KD_PitchButton);
            this.Controls.Add(this.KP_PitchButton);
            this.Controls.Add(this.KI_RollBox);
            this.Controls.Add(this.KD_RollBox);
            this.Controls.Add(this.KP_RollBox);
            this.Controls.Add(this.KI_RollButton);
            this.Controls.Add(this.KD_RollButton);
            this.Controls.Add(this.KP_RollButton);
            this.Controls.Add(this.ListeningCheckBox);
            this.Controls.Add(this.ClearLog);
            this.Controls.Add(this.CommandSelector);
            this.Controls.Add(this.DebugBox);
            this.Controls.Add(this.RecieveBox);
            this.Controls.Add(this.SendBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.StatusLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Quadrocopter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "What a Quadrocopter";
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
        private System.Windows.Forms.Button KP_RollButton;
        private System.Windows.Forms.Button KD_RollButton;
        private System.Windows.Forms.Button KI_RollButton;
        private System.Windows.Forms.RichTextBox KP_RollBox;
        private System.Windows.Forms.RichTextBox KD_RollBox;
        private System.Windows.Forms.RichTextBox KI_RollBox;
        private System.Windows.Forms.RichTextBox KI_PitchBox;
        private System.Windows.Forms.RichTextBox KD_PitchBox;
        private System.Windows.Forms.RichTextBox KP_PitchBox;
        private System.Windows.Forms.Button KI_PitchButton;
        private System.Windows.Forms.Button KD_PitchButton;
        private System.Windows.Forms.Button KP_PitchButton;
        private System.Windows.Forms.Button KP_YawButton;
        private System.Windows.Forms.Button KI_YawButton;
        private System.Windows.Forms.RichTextBox KP_YawBox;
        private System.Windows.Forms.RichTextBox KI_YawBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}