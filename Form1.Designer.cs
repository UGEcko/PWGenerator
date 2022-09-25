namespace PWGenerator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.genButton = new System.Windows.Forms.Button();
            this.createFileButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.AdvSettingsToggle = new System.Windows.Forms.CheckBox();
            this.createFolderButton = new System.Windows.Forms.Button();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.passGenTextBox = new System.Windows.Forms.TextBox();
            this.lengthPass = new System.Windows.Forms.NumericUpDown();
            this.lengthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lengthPass)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Exit.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Orange;
            this.Exit.Location = new System.Drawing.Point(499, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(29, 30);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.label1_Click);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            this.Exit.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Moccasin;
            this.label2.Location = new System.Drawing.Point(12, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Designed by UGEcko";
            // 
            // genButton
            // 
            this.genButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genButton.ForeColor = System.Drawing.Color.Moccasin;
            this.genButton.Location = new System.Drawing.Point(401, 434);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(127, 46);
            this.genButton.TabIndex = 3;
            this.genButton.Text = "Generate";
            this.toolTip1.SetToolTip(this.genButton, "Generate Password");
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // createFileButton
            // 
            this.createFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createFileButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFileButton.ForeColor = System.Drawing.Color.Moccasin;
            this.createFileButton.Location = new System.Drawing.Point(401, 335);
            this.createFileButton.Name = "createFileButton";
            this.createFileButton.Size = new System.Drawing.Size(127, 32);
            this.createFileButton.TabIndex = 4;
            this.createFileButton.Text = "Create File";
            this.toolTip1.SetToolTip(this.createFileButton, "Create File, file contains password, and site name. ");
            this.createFileButton.UseVisualStyleBackColor = true;
            this.createFileButton.Click += new System.EventHandler(this.createFileButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.ForeColor = System.Drawing.Color.Moccasin;
            this.copyButton.Location = new System.Drawing.Point(401, 486);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(127, 42);
            this.copyButton.TabIndex = 5;
            this.copyButton.Text = "Copy";
            this.toolTip1.SetToolTip(this.copyButton, "Copy generated password to your clipboard.");
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // AdvSettingsToggle
            // 
            this.AdvSettingsToggle.AutoSize = true;
            this.AdvSettingsToggle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AdvSettingsToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AdvSettingsToggle.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvSettingsToggle.ForeColor = System.Drawing.Color.Moccasin;
            this.AdvSettingsToggle.Location = new System.Drawing.Point(401, 249);
            this.AdvSettingsToggle.Name = "AdvSettingsToggle";
            this.AdvSettingsToggle.Size = new System.Drawing.Size(127, 20);
            this.AdvSettingsToggle.TabIndex = 6;
            this.AdvSettingsToggle.Text = "Advanced Settings";
            this.toolTip1.SetToolTip(this.AdvSettingsToggle, "Toggle Advanced Settings");
            this.AdvSettingsToggle.UseVisualStyleBackColor = false;
            this.AdvSettingsToggle.CheckedChanged += new System.EventHandler(this.AdvSettingsToggle_CheckedChanged);
            // 
            // createFolderButton
            // 
            this.createFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createFolderButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFolderButton.ForeColor = System.Drawing.Color.Moccasin;
            this.createFolderButton.Location = new System.Drawing.Point(401, 275);
            this.createFolderButton.Name = "createFolderButton";
            this.createFolderButton.Size = new System.Drawing.Size(127, 26);
            this.createFolderButton.TabIndex = 9;
            this.createFolderButton.Text = "Folder";
            this.toolTip1.SetToolTip(this.createFolderButton, "Select folder to send file to");
            this.createFolderButton.UseVisualStyleBackColor = true;
            this.createFolderButton.Click += new System.EventHandler(this.createFolderButton_Click);
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.BackColor = System.Drawing.Color.Moccasin;
            this.filenameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filenameTextBox.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameTextBox.HideSelection = false;
            this.filenameTextBox.Location = new System.Drawing.Point(401, 307);
            this.filenameTextBox.MaxLength = 19;
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(127, 22);
            this.filenameTextBox.TabIndex = 7;
            this.filenameTextBox.Text = "Filename";
            this.filenameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.filenameTextBox, "Filename for password");
            // 
            // passGenTextBox
            // 
            this.passGenTextBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.passGenTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passGenTextBox.Location = new System.Drawing.Point(70, 144);
            this.passGenTextBox.MaxLength = 30;
            this.passGenTextBox.Name = "passGenTextBox";
            this.passGenTextBox.ReadOnly = true;
            this.passGenTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passGenTextBox.Size = new System.Drawing.Size(390, 20);
            this.passGenTextBox.TabIndex = 10;
            this.passGenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lengthPass
            // 
            this.lengthPass.BackColor = System.Drawing.Color.Moccasin;
            this.lengthPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lengthPass.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthPass.Location = new System.Drawing.Point(401, 408);
            this.lengthPass.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.lengthPass.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.lengthPass.Name = "lengthPass";
            this.lengthPass.Size = new System.Drawing.Size(127, 25);
            this.lengthPass.TabIndex = 12;
            this.lengthPass.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.ForeColor = System.Drawing.Color.Moccasin;
            this.lengthLabel.Location = new System.Drawing.Point(434, 384);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(63, 21);
            this.lengthLabel.TabIndex = 13;
            this.lengthLabel.Text = "Length";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(540, 540);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.lengthPass);
            this.Controls.Add(this.passGenTextBox);
            this.Controls.Add(this.createFolderButton);
            this.Controls.Add(this.filenameTextBox);
            this.Controls.Add(this.AdvSettingsToggle);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.createFileButton);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordGenerator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lengthPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.Button createFileButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox AdvSettingsToggle;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.Button createFolderButton;
        private System.Windows.Forms.TextBox passGenTextBox;
        private System.Windows.Forms.NumericUpDown lengthPass;
        private System.Windows.Forms.Label lengthLabel;
    }
}

