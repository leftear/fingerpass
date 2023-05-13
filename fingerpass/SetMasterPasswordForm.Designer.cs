﻿namespace gazugafan.fingerpass
{
	partial class SetMasterPasswordForm
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
      this.currentPasswordLabel = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.currentPasswordTextbox = new System.Windows.Forms.TextBox();
      this.newPasswordTextbox = new System.Windows.Forms.TextBox();
      this.confirmPasswordTextbox = new System.Windows.Forms.TextBox();
      this.instructionsLabel = new System.Windows.Forms.Label();
      this.deleteLink = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(429, 280);
      this.saveButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(121, 41);
      this.saveButton.TabIndex = 4;
      this.saveButton.Text = "Save Changes";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelButton.Location = new System.Drawing.Point(334, 280);
      this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(91, 41);
      this.cancelButton.TabIndex = 3;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // currentPasswordLabel
      // 
      this.currentPasswordLabel.Location = new System.Drawing.Point(20, 148);
      this.currentPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.currentPasswordLabel.Name = "currentPasswordLabel";
      this.currentPasswordLabel.Size = new System.Drawing.Size(178, 16);
      this.currentPasswordLabel.TabIndex = 2;
      this.currentPasswordLabel.Text = "Current Master Password:";
      this.currentPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(16, 189);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(182, 16);
      this.label2.TabIndex = 3;
      this.label2.Text = "New Master Password:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(13, 232);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(186, 16);
      this.label3.TabIndex = 4;
      this.label3.Text = "Retype New Master Password:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // currentPasswordTextbox
      // 
      this.currentPasswordTextbox.Location = new System.Drawing.Point(201, 144);
      this.currentPasswordTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.currentPasswordTextbox.Name = "currentPasswordTextbox";
      this.currentPasswordTextbox.Size = new System.Drawing.Size(349, 23);
      this.currentPasswordTextbox.TabIndex = 0;
      this.currentPasswordTextbox.UseSystemPasswordChar = true;
      // 
      // newPasswordTextbox
      // 
      this.newPasswordTextbox.Location = new System.Drawing.Point(201, 185);
      this.newPasswordTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.newPasswordTextbox.Name = "newPasswordTextbox";
      this.newPasswordTextbox.Size = new System.Drawing.Size(349, 23);
      this.newPasswordTextbox.TabIndex = 1;
      this.newPasswordTextbox.UseSystemPasswordChar = true;
      // 
      // confirmPasswordTextbox
      // 
      this.confirmPasswordTextbox.Location = new System.Drawing.Point(201, 228);
      this.confirmPasswordTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.confirmPasswordTextbox.Name = "confirmPasswordTextbox";
      this.confirmPasswordTextbox.Size = new System.Drawing.Size(349, 23);
      this.confirmPasswordTextbox.TabIndex = 2;
      this.confirmPasswordTextbox.UseSystemPasswordChar = true;
      // 
      // instructionsLabel
      // 
      this.instructionsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.instructionsLabel.Location = new System.Drawing.Point(44, 4);
      this.instructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.instructionsLabel.Name = "instructionsLabel";
      this.instructionsLabel.Size = new System.Drawing.Size(476, 112);
      this.instructionsLabel.TabIndex = 8;
      this.instructionsLabel.Text = "To change your master password, first enter your current master password. If you " +
    "don\'t know it, you\'ll need to delete your password database and start over.";
      this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // deleteLink
      // 
      this.deleteLink.AutoSize = true;
      this.deleteLink.LinkColor = System.Drawing.Color.Red;
      this.deleteLink.Location = new System.Drawing.Point(14, 296);
      this.deleteLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.deleteLink.Name = "deleteLink";
      this.deleteLink.Size = new System.Drawing.Size(101, 16);
      this.deleteLink.TabIndex = 5;
      this.deleteLink.TabStop = true;
      this.deleteLink.Text = "Delete Database";
      this.deleteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deleteLink_LinkClicked);
      // 
      // SetMasterPasswordForm
      // 
      this.AcceptButton = this.saveButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cancelButton;
      this.ClientSize = new System.Drawing.Size(564, 335);
      this.ControlBox = false;
      this.Controls.Add(this.deleteLink);
      this.Controls.Add(this.instructionsLabel);
      this.Controls.Add(this.confirmPasswordTextbox);
      this.Controls.Add(this.newPasswordTextbox);
      this.Controls.Add(this.currentPasswordTextbox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.currentPasswordLabel);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.saveButton);
      this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SetMasterPasswordForm";
      this.ShowIcon = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FingerPass";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.SetMasterPasswordForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label currentPasswordLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox currentPasswordTextbox;
		private System.Windows.Forms.TextBox newPasswordTextbox;
		private System.Windows.Forms.TextBox confirmPasswordTextbox;
		private System.Windows.Forms.Label instructionsLabel;
		private System.Windows.Forms.LinkLabel deleteLink;
	}
}