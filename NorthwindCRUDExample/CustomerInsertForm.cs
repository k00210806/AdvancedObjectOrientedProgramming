using System;
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

		private void GetValues(NorthwindDataSet.CustomersRow customersRow)
		{
			customersRow.CustomerID = customerIDTextBox.Text;
			customersRow.CompanyName = companyNameTextBox.Text;
			customersRow.ContactName = contactNameTextBox.Text;

			customersRow.ContactTitle = contactTitleTextBox.Text;
			customersRow.Address = addressTextBox.Text;
			customersRow.City = cityTextBox.Text;
			customersRow.Region = regionTextBox.Text;
			customersRow.PostalCode = postalCodeTextBox.Text;
			customersRow.Country = countryTextBox.Text;
			customersRow.Phone = phoneTextBox.Text;
			customersRow.Fax = faxTextBox.Text;
		}

		private void AddCustbutton_Click(object sender, System.EventArgs e)
		{
			try
			{
				SaveValuesAndInsertCustomer();
				MessageBox.Show("Insert succesful");
			}
			catch (InvalidCastException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void SaveValuesAndInsertCustomer()
		{
			NorthwindDataSet.CustomersRow newCustomersRow = northwindDataSet.Customers.NewCustomersRow();

			newCustomersRow.BeginEdit();
			GetValues(newCustomersRow);
			newCustomersRow.EndEdit();

			this.Validate();

			northwindDataSet.Customers.AddCustomersRow(newCustomersRow);
			this.customersTableAdapter.Update(this.northwindDataSet);
		}
	}
}