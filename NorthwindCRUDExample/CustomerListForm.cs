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
	public partial class CustomerListForm : Form
	{
		public CustomerListForm()
		{
			InitializeComponent();
		}
		public CustomerListForm(MainForm mainForm) : this()
		{
			this.MdiParent = mainForm;
		}
		private void CustomersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.customersBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.northwindDataSet);

		}

		private void Form3_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
			this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

		}
	}
}