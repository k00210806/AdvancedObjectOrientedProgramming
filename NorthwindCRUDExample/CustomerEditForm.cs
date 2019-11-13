namespace NorthwindCRUDExample
{
	using System;
	using System.Windows.Forms;
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
			try
			{
				SaveValuesAndUpdateCustomerToDatabase();
				MessageBox.Show("Update succesful");
			}
			catch (InvalidCastException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void SaveValuesAndUpdateCustomerToDatabase()
		{
			NorthwindDataSet.CustomersRow drChangeRow = northwindDataSet.Customers.FindByCustomerID(customerIDTextBox.Text);
			drChangeRow.BeginEdit();
			GetValues(drChangeRow);
			drChangeRow.EndEdit();

			this.Validate();
			this.customersBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.northwindDataSet);
		}

		private void GetValues(NorthwindDataSet.CustomersRow customersRow)
		{
			//customersRow.CustomerID = customerIDTextBox.Text;
			//customersRow.CompanyName = companyNameTextBox.Text;
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

		private void Deletebutton_Click(object sender, EventArgs e)
		{
			var confirmResult = MessageBox.Show("Are you sure to delete this item ?",  "Confirm Delete!", MessageBoxButtons.YesNo);
			if (confirmResult == DialogResult.Yes)
			{
				try
				{
					this.DeleteCustomer();
					MessageBox.Show("Delete succesful");
				}
				catch (InvalidCastException ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else
			{
				// If 'No', do something here.
			}
		}

		private void DeleteCustomer()
		{
			NorthwindDataSet.CustomersRow customersRow = northwindDataSet.Customers.FindByCustomerID(customerIDTextBox.Text);

			//if(hasOrders)
			//{
			//	MessageBox.Show("Cannot Delete Customer with pending orders");
			//	throw new Exception();
			//}
			customersRow.Delete();
			//
			//	Database
			//
			this.customersTableAdapter.Update(this.northwindDataSet);
		}
	}
}
