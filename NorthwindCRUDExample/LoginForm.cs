using System;
using System.Windows.Forms;

namespace NorthwindCRUDExample
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}
		private Boolean debug = true;
		private void OKbutton_Click(object sender, EventArgs e)
		{
			if (debug || PasswordtextBox.Text == Properties.Settings.Default.ApplicationPassword)
			{
				MainForm mainMenu = new MainForm();
				mainMenu.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Invalid Password");
				PasswordtextBox.Focus();
				PasswordtextBox.SelectAll();
			}
		}
	}
}