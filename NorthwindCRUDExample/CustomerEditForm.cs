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
	public partial class CustomerEditForm : Form
	{ 
		
	
		public CustomerEditForm()
		{
			InitializeComponent();
		}
		public CustomerEditForm(MainForm mainForm) : this()
		{
			this.MdiParent = mainForm;
		}

		private void CustomerEditForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
			this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

		}

		private void Returnbutton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Editbutton_Click(object sender, EventArgs e)
		{
			NorthwindDataSet.CustomersRow drChangeRow = northwindDataSet.Customers.FindByCustomerID(customerIDTextBox.Text);
			drChangeRow.BeginEdit();
			GetValues(drChangeRow);
			drChangeRow.EndEdit();

			this.Validate();
			this.customersBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.northwindDataSet);
			try
			{
				MessageBox.Show("Update succesful");
			}
			catch (InvalidCastException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void GetValues(NorthwindDataSet.CustomersRow drChangeRow)
		{
			drChangeRow.ContactName = contactNameTextBox.Text;
			drChangeRow.ContactTitle = contactTitleTextBox.Text;
			drChangeRow.Address = addressTextBox.Text;
			drChangeRow.City = cityTextBox.Text;
			drChangeRow.Region = regionTextBox.Text;
			drChangeRow.PostalCode = postalCodeTextBox.Text;
			drChangeRow.Country = countryTextBox.Text;
			drChangeRow.Phone = phoneTextBox.Text;
			drChangeRow.Fax = faxTextBox.Text;
		}
	}
}
