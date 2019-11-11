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
	public partial class CustomerInsertForm : Form
	{
		public CustomerInsertForm()
		{
			InitializeComponent();
		}
		public CustomerInsertForm(MainForm mainForm) : this()
		{
			this.MdiParent = mainForm;
		}

		private void Label5_Click(object sender, EventArgs e)
		{

		}

		private void CustomerDetailsgroupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
