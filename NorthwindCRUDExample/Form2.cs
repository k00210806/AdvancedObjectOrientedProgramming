using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindCRUDExample
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		private void MainMenu_Load(object sender, EventArgs e)
		{

		}

		private void AddCustToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form5 form5 = new Form5();
			form5.Show();
		}

		private void EditCustToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form6 form6 = new Form6();
			form6.Show();
		}

		private void DeleteByFindToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form7 form7 = new Form7();
			form7.Show();
		}
	}
}
