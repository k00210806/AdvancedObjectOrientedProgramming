using System;
using System.Windows.Forms;

namespace NorthwindCRUDExample
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}


		private void AddCustToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CustomerInsertForm customerInsertForm = new CustomerInsertForm(this);
			customerInsertForm.Show();
		}

		private void EditCustToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CustomerEditForm customerEditForm = new CustomerEditForm(this);
			customerEditForm.Show();
		}

		private void DeleteByFindToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CustomerDeleteForm customerDeleteForm = new CustomerDeleteForm(this);
			customerDeleteForm.Show();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void CustomerGridToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var customerListForm = new CustomerListForm(this);
			customerListForm.Show();
		}
	}
}
