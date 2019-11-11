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

		private void MainMenu_Load(object sender, EventArgs e)
		{

		}

		private void AddCustToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddCustomers form5 = new AddCustomers();
			form5.Show();
		}

		private void EditCustToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CustomerEditForm form6 = new CustomerEditForm();
			form6.Show();
		}

		private void DeleteByFindToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CustomerDeleteForm form7 = new CustomerDeleteForm();
			form7.Show();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
