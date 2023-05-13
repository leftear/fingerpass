﻿namespace gazugafan.fingerpass
{
	partial class MasterPasswordPromptForm
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
      this.continueButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.currentPasswordLabel = new System.Windows.Forms.Label();
      this.passwordTextbox = new System.Windows.Forms.TextBox();
      this.instructionsLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // continueButton
      // 
      this.continueButton.Location = new System.Drawing.Point(436, 216);
      this.continueButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.continueButton.Name = "continueButton";
      this.continueButton.Size = new System.Drawing.Size(121, 41);
      this.continueButton.TabIndex = 2;
      this.continueButton.Text = "Continue";
      this.continueButton.UseVisualStyleBackColor = true;
      this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelButton.Location = new System.Drawing.Point(340, 216);
      this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(91, 41);
      this.cancelButton.TabIndex = 1;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // currentPasswordLabel
      // 
      this.currentPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.currentPasswordLabel.Location = new System.Drawing.Point(0, 156);
      this.currentPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.currentPasswordLabel.Name = "currentPasswordLabel";
      this.currentPasswordLabel.Size = new System.Drawing.Size(208, 23);
      this.currentPasswordLabel.TabIndex = 1;
      this.currentPasswordLabel.Text = "Your Master Password:";
      this.currentPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // passwordTextbox
      // 
      this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.passwordTextbox.Location = new System.Drawing.Point(212, 153);
      this.passwordTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.passwordTextbox.Name = "passwordTextbox";
      this.passwordTextbox.Size = new System.Drawing.Size(345, 24);
      this.passwordTextbox.TabIndex = 0;
      this.passwordTextbox.UseSystemPasswordChar = true;
      // 
      // instructionsLabel
      // 
      this.instructionsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.instructionsLabel.Location = new System.Drawing.Point(48, 23);
      this.instructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.instructionsLabel.Name = "instructionsLabel";
      this.instructionsLabel.Size = new System.Drawing.Size(476, 108);
      this.instructionsLabel.TabIndex = 8;
      this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MasterPasswordPromptForm
      // 
      this.AcceptButton = this.continueButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cancelButton;
      this.ClientSize = new System.Drawing.Size(569, 272);
      this.ControlBox = false;
      this.Controls.Add(this.instructionsLabel);
      this.Controls.Add(this.passwordTextbox);
      this.Controls.Add(this.currentPasswordLabel);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.continueButton);
      this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MasterPasswordPromptForm";
      this.ShowIcon = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FingerPass";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.MasterPasswordPromptForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button continueButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label currentPasswordLabel;
		private System.Windows.Forms.TextBox passwordTextbox;
		private System.Windows.Forms.Label instructionsLabel;
	}
}