namespace gazugafan.fingerpass
{
	partial class SettingsForm
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
      this.saveButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.startupCheckbox = new System.Windows.Forms.CheckBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.SoundSelect = new System.Windows.Forms.ComboBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label2 = new System.Windows.Forms.Label();
      this.timeoutNumeric = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.managePasswordsButton = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.timeoutNumeric)).BeginInit();
      this.SuspendLayout();
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(234, 202);
      this.saveButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(132, 41);
      this.saveButton.TabIndex = 0;
      this.saveButton.Text = "Save Changes";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelButton.Location = new System.Drawing.Point(140, 202);
      this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(91, 41);
      this.cancelButton.TabIndex = 1;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // startupCheckbox
      // 
      this.startupCheckbox.AutoSize = true;
      this.startupCheckbox.Location = new System.Drawing.Point(16, 32);
      this.startupCheckbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.startupCheckbox.Name = "startupCheckbox";
      this.startupCheckbox.Size = new System.Drawing.Size(170, 20);
      this.startupCheckbox.TabIndex = 24;
      this.startupCheckbox.Text = "Run at startup (in the tray)";
      this.startupCheckbox.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.button1.Font = new System.Drawing.Font("Webdings", 10F);
      this.button1.Location = new System.Drawing.Point(320, 61);
      this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(26, 25);
      this.button1.TabIndex = 27;
      this.button1.Text = "4";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label7
      // 
      this.label7.Location = new System.Drawing.Point(2, 65);
      this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label7.Name = "label7";
      this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.label7.Size = new System.Drawing.Size(133, 16);
      this.label7.TabIndex = 25;
      this.label7.Text = "Scan Failure Sound:";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // SoundSelect
      // 
      this.SoundSelect.FormattingEnabled = true;
      this.SoundSelect.Location = new System.Drawing.Point(140, 61);
      this.SoundSelect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.SoundSelect.Name = "SoundSelect";
      this.SoundSelect.Size = new System.Drawing.Size(174, 24);
      this.SoundSelect.TabIndex = 26;
      this.SoundSelect.SelectedIndexChanged += new System.EventHandler(this.SoundSelect_SelectedIndexChanged);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.timeoutNumeric);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.startupCheckbox);
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.SoundSelect);
      this.groupBox1.Location = new System.Drawing.Point(10, 12);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.groupBox1.Size = new System.Drawing.Size(356, 133);
      this.groupBox1.TabIndex = 28;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Options";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(287, 100);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(51, 16);
      this.label2.TabIndex = 30;
      this.label2.Text = "minutes";
      // 
      // timeoutNumeric
      // 
      this.timeoutNumeric.Location = new System.Drawing.Point(195, 97);
      this.timeoutNumeric.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.timeoutNumeric.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
      this.timeoutNumeric.Name = "timeoutNumeric";
      this.timeoutNumeric.Size = new System.Drawing.Size(88, 23);
      this.timeoutNumeric.TabIndex = 29;
      this.timeoutNumeric.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(4, 100);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(187, 16);
      this.label1.TabIndex = 28;
      this.label1.Text = "Keep Database Unlocked For:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // managePasswordsButton
      // 
      this.managePasswordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.managePasswordsButton.Location = new System.Drawing.Point(58, 151);
      this.managePasswordsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.managePasswordsButton.Name = "managePasswordsButton";
      this.managePasswordsButton.Size = new System.Drawing.Size(248, 45);
      this.managePasswordsButton.TabIndex = 31;
      this.managePasswordsButton.Text = "Manage Password Database";
      this.managePasswordsButton.UseVisualStyleBackColor = true;
      this.managePasswordsButton.Click += new System.EventHandler(this.managePasswordsButton_Click);
      // 
      // SettingsForm
      // 
      this.AcceptButton = this.saveButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cancelButton;
      this.ClientSize = new System.Drawing.Size(378, 255);
      this.ControlBox = false;
      this.Controls.Add(this.managePasswordsButton);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.saveButton);
      this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SettingsForm";
      this.ShowIcon = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FingerPass Settings";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.SettingsForm_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.timeoutNumeric)).EndInit();
      this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.CheckBox startupCheckbox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox SoundSelect;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown timeoutNumeric;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button managePasswordsButton;
	}
}