namespace NorthwindCRUDExample
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.customerGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.custMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addCustToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editCustToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteByFindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerGridToolStripMenuItem,
            this.customerDetailsToolStripMenuItem,
            this.custMaintenanceToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// customerGridToolStripMenuItem
			// 
			this.customerGridToolStripMenuItem.Name = "customerGridToolStripMenuItem";
			this.customerGridToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
			this.customerGridToolStripMenuItem.Text = "Customer Grid";
			this.customerGridToolStripMenuItem.Click += new System.EventHandler(this.CustomerGridToolStripMenuItem_Click);
			// 
			// customerDetailsToolStripMenuItem
			// 
			this.customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
			this.customerDetailsToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
			this.customerDetailsToolStripMenuItem.Text = "Customer Details ";
			// 
			// custMaintenanceToolStripMenuItem
			// 
			this.custMaintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustToolStripMenuItem,
            this.editCustToolStripMenuItem,
            this.deleteByFindToolStripMenuItem});
			this.custMaintenanceToolStripMenuItem.Name = "custMaintenanceToolStripMenuItem";
			this.custMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
			this.custMaintenanceToolStripMenuItem.Text = "Cust Maintenance";
			// 
			// addCustToolStripMenuItem
			// 
			this.addCustToolStripMenuItem.Name = "addCustToolStripMenuItem";
			this.addCustToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.addCustToolStripMenuItem.Text = "Add Cust";
			this.addCustToolStripMenuItem.Click += new System.EventHandler(this.AddCustToolStripMenuItem_Click);
			// 
			// editCustToolStripMenuItem
			// 
			this.editCustToolStripMenuItem.Name = "editCustToolStripMenuItem";
			this.editCustToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.editCustToolStripMenuItem.Text = "Edit Cust";
			this.editCustToolStripMenuItem.Click += new System.EventHandler(this.EditCustToolStripMenuItem_Click);
			// 
			// deleteByFindToolStripMenuItem
			// 
			this.deleteByFindToolStripMenuItem.Name = "deleteByFindToolStripMenuItem";
			this.deleteByFindToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.deleteByFindToolStripMenuItem.Text = "Delete By Find";
			this.deleteByFindToolStripMenuItem.Click += new System.EventHandler(this.DeleteByFindToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Customer Main";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem customerGridToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customerDetailsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem custMaintenanceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addCustToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editCustToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteByFindToolStripMenuItem;
	}
}