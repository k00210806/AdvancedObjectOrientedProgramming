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
	public partial class CustomerOrdersForm : Form
	{
		public CustomerOrdersForm()
		{
			InitializeComponent();
		}
		public CustomerOrdersForm(MainForm mainForm) : this()
		{
			this.MdiParent = mainForm;
		}

	}
}
