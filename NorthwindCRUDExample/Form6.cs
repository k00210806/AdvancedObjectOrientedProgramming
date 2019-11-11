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
	public partial class Form6 : Form
	{ 
		NorthwindDataSet.CustomersRow drChangeRow;
	
		public Form6()
		{
			InitializeComponent();
		}

		private void Form6_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
			this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

		}

		private void RegionLabel_Click(object sender, EventArgs e)
		{

		}

		private void Returnbutton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Editbutton_Click(object sender, EventArgs e)
		{
			drChangeRow = northwindDataSet.Customers.FindByCustomerID(customerIDTextBox.Text);
			drChangeRow.BeginEdit();
			GetValues();
			drChangeRow.EndEdit();
			try
			{
				MessageBox.Show("Update succesful");
			}
			catch (InvalidCastException ex)
			{
				MessageBox.Show(ex.Message);


			}

		}
		private void GetValues()
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
