﻿namespace gazugafan.fingerpass
{
	partial class DatabaseForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseForm));
      this.closeButton = new System.Windows.Forms.Button();
      this.passwordMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.copyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.moveToTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.moveToBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.changeMasterPasswordButton = new System.Windows.Forms.Button();
      this.exportButton = new System.Windows.Forms.Button();
      this.importButton = new System.Windows.Forms.Button();
      this.passwordsDataGrid = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.programLabel = new System.Windows.Forms.Label();
      this.windowLabel = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.currentMatchLabel = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.instructionsPictureBox = new System.Windows.Forms.PictureBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnInsert = new System.Windows.Forms.Button();
      this.passwordMenuStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.passwordsDataGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.instructionsPictureBox)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // closeButton
      // 
      this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.closeButton.Location = new System.Drawing.Point(673, 383);
      this.closeButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(94, 41);
      this.closeButton.TabIndex = 1;
      this.closeButton.Text = "Done";
      this.closeButton.UseVisualStyleBackColor = true;
      this.closeButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // passwordMenuStrip
      // 
      this.passwordMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.passwordMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyPasswordToolStripMenuItem,
            this.moveToTopToolStripMenuItem,
            this.moveToBottomToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deleteToolStripMenuItem});
      this.passwordMenuStrip.Name = "contextMenuStrip1";
      this.passwordMenuStrip.Size = new System.Drawing.Size(168, 98);
      // 
      // copyPasswordToolStripMenuItem
      // 
      this.copyPasswordToolStripMenuItem.Name = "copyPasswordToolStripMenuItem";
      this.copyPasswordToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
      this.copyPasswordToolStripMenuItem.Text = "Copy Password";
      this.copyPasswordToolStripMenuItem.Click += new System.EventHandler(this.copyPasswordToolStripMenuItem_Click);
      // 
      // moveToTopToolStripMenuItem
      // 
      this.moveToTopToolStripMenuItem.Name = "moveToTopToolStripMenuItem";
      this.moveToTopToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
      this.moveToTopToolStripMenuItem.Text = "Move to Top";
      this.moveToTopToolStripMenuItem.Click += new System.EventHandler(this.moveToTopToolStripMenuItem_Click);
      // 
      // moveToBottomToolStripMenuItem
      // 
      this.moveToBottomToolStripMenuItem.Name = "moveToBottomToolStripMenuItem";
      this.moveToBottomToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
      this.moveToBottomToolStripMenuItem.Text = "Move to Bottom";
      this.moveToBottomToolStripMenuItem.Click += new System.EventHandler(this.moveToBottomToolStripMenuItem_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(164, 6);
      // 
      // deleteToolStripMenuItem
      // 
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      this.deleteToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
      this.deleteToolStripMenuItem.Text = "Delete";
      this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
      // 
      // changeMasterPasswordButton
      // 
      this.changeMasterPasswordButton.Location = new System.Drawing.Point(10, 383);
      this.changeMasterPasswordButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.changeMasterPasswordButton.Name = "changeMasterPasswordButton";
      this.changeMasterPasswordButton.Size = new System.Drawing.Size(215, 41);
      this.changeMasterPasswordButton.TabIndex = 29;
      this.changeMasterPasswordButton.Text = "Change Master Password";
      this.changeMasterPasswordButton.UseVisualStyleBackColor = true;
      this.changeMasterPasswordButton.Click += new System.EventHandler(this.changeMasterPasswordButton_Click);
      // 
      // exportButton
      // 
      this.exportButton.Location = new System.Drawing.Point(231, 383);
      this.exportButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.exportButton.Name = "exportButton";
      this.exportButton.Size = new System.Drawing.Size(139, 41);
      this.exportButton.TabIndex = 30;
      this.exportButton.Text = "Export Database";
      this.exportButton.UseVisualStyleBackColor = true;
      this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
      // 
      // importButton
      // 
      this.importButton.Location = new System.Drawing.Point(374, 383);
      this.importButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.importButton.Name = "importButton";
      this.importButton.Size = new System.Drawing.Size(147, 41);
      this.importButton.TabIndex = 31;
      this.importButton.Text = "Import Database";
      this.importButton.UseVisualStyleBackColor = true;
      this.importButton.Click += new System.EventHandler(this.importButton_Click);
      // 
      // passwordsDataGrid
      // 
      this.passwordsDataGrid.AllowDrop = true;
      this.passwordsDataGrid.AllowUserToResizeRows = false;
      this.passwordsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.passwordsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
      this.passwordsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.passwordsDataGrid.ContextMenuStrip = this.passwordMenuStrip;
      this.passwordsDataGrid.Location = new System.Drawing.Point(10, 130);
      this.passwordsDataGrid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.passwordsDataGrid.MultiSelect = false;
      this.passwordsDataGrid.Name = "passwordsDataGrid";
      this.passwordsDataGrid.RowHeadersWidth = 51;
      this.passwordsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.passwordsDataGrid.RowTemplate.Height = 24;
      this.passwordsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.passwordsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.passwordsDataGrid.Size = new System.Drawing.Size(757, 167);
      this.passwordsDataGrid.TabIndex = 32;
      this.passwordsDataGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.passwordsDataGrid_CellBeginEdit);
      this.passwordsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.passwordsDataGrid_CellContentClick);
      this.passwordsDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.passwordsDataGrid_CellFormatting);
      this.passwordsDataGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.passwordsDataGrid_EditingControlShowing);
      this.passwordsDataGrid.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.passwordsDataGrid_RowValidating);
      this.passwordsDataGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.passwordsDataGrid_UserDeletingRow);
      this.passwordsDataGrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.passwordsDataGrid_DragDrop);
      this.passwordsDataGrid.DragOver += new System.Windows.Forms.DragEventHandler(this.passwordsDataGrid_DragOver);
      this.passwordsDataGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.passwordsDataGrid_Paint);
      this.passwordsDataGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passwordsDataGrid_MouseDown);
      this.passwordsDataGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.passwordsDataGrid_MouseMove);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(2, 0);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(197, 26);
      this.label1.TabIndex = 33;
      this.label1.Text = "Current Program Name:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(2, 26);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(197, 26);
      this.label2.TabIndex = 34;
      this.label2.Text = "Current Window Title:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // programLabel
      // 
      this.programLabel.AutoEllipsis = true;
      this.programLabel.AutoSize = true;
      this.programLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.programLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.programLabel.Location = new System.Drawing.Point(203, 0);
      this.programLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.programLabel.Name = "programLabel";
      this.programLabel.Size = new System.Drawing.Size(546, 26);
      this.programLabel.TabIndex = 35;
      this.programLabel.Text = "This window will stay on top. Click on another window to see";
      this.programLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // windowLabel
      // 
      this.windowLabel.AutoEllipsis = true;
      this.windowLabel.AutoSize = true;
      this.windowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.windowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.windowLabel.Location = new System.Drawing.Point(203, 26);
      this.windowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.windowLabel.Name = "windowLabel";
      this.windowLabel.Size = new System.Drawing.Size(546, 26);
      this.windowLabel.TabIndex = 36;
      this.windowLabel.Text = "how FingerPass reads its Program Name and Window Title,";
      this.windowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(8, 111);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(106, 16);
      this.label3.TabIndex = 37;
      this.label3.Text = "Saved Passwords:";
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
      this.label4.Location = new System.Drawing.Point(62, 300);
      this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(722, 71);
      this.label4.TabIndex = 38;
      this.label4.Text = resources.GetString("label4.Text");
      // 
      // currentMatchLabel
      // 
      this.currentMatchLabel.AutoEllipsis = true;
      this.currentMatchLabel.AutoSize = true;
      this.currentMatchLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.currentMatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.currentMatchLabel.Location = new System.Drawing.Point(203, 52);
      this.currentMatchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.currentMatchLabel.Name = "currentMatchLabel";
      this.currentMatchLabel.Size = new System.Drawing.Size(546, 26);
      this.currentMatchLabel.TabIndex = 40;
      this.currentMatchLabel.Text = "then use that to create your password entries below...";
      this.currentMatchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(2, 52);
      this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(197, 26);
      this.label6.TabIndex = 39;
      this.label6.Text = "Current Matching Entry:";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // instructionsPictureBox
      // 
      this.instructionsPictureBox.Location = new System.Drawing.Point(13, 303);
      this.instructionsPictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.instructionsPictureBox.Name = "instructionsPictureBox";
      this.instructionsPictureBox.Size = new System.Drawing.Size(47, 68);
      this.instructionsPictureBox.TabIndex = 41;
      this.instructionsPictureBox.TabStop = false;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.programLabel, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.currentMatchLabel, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.windowLabel, 1, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(751, 78);
      this.tableLayoutPanel1.TabIndex = 42;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.tableLayoutPanel1);
      this.groupBox1.Location = new System.Drawing.Point(10, 8);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(757, 100);
      this.groupBox1.TabIndex = 43;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Process Info";
      // 
      // btnInsert
      // 
      this.btnInsert.Location = new System.Drawing.Point(689, 114);
      this.btnInsert.Name = "btnInsert";
      this.btnInsert.Size = new System.Drawing.Size(75, 23);
      this.btnInsert.TabIndex = 44;
      this.btnInsert.Text = "Insert";
      this.btnInsert.UseVisualStyleBackColor = true;
      this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
      // 
      // DatabaseForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.closeButton;
      this.ClientSize = new System.Drawing.Size(774, 436);
      this.Controls.Add(this.btnInsert);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.instructionsPictureBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.passwordsDataGrid);
      this.Controls.Add(this.importButton);
      this.Controls.Add(this.exportButton);
      this.Controls.Add(this.changeMasterPasswordButton);
      this.Controls.Add(this.closeButton);
      this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DatabaseForm";
      this.ShowIcon = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FingerPass Database";
      this.TopMost = true;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DatabaseForm_FormClosed);
      this.Load += new System.EventHandler(this.DatabaseForm_Load);
      this.passwordMenuStrip.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.passwordsDataGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.instructionsPictureBox)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button changeMasterPasswordButton;
		private System.Windows.Forms.ContextMenuStrip passwordMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyPasswordToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem moveToTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem moveToBottomToolStripMenuItem;
		private System.Windows.Forms.Button exportButton;
		private System.Windows.Forms.Button importButton;
		private System.Windows.Forms.DataGridView passwordsDataGrid;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label programLabel;
		private System.Windows.Forms.Label windowLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label currentMatchLabel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox instructionsPictureBox;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnInsert;
  }
}