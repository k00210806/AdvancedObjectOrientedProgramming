using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderProcessing
{
	public partial class ModifyOrderForm : Form
	{
		public ModifyOrderForm()
		{
			InitializeComponent();
		}

		private void CustomersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.customersBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.northwindDataSet);

		}

		private void ModifyOrderForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
			this.productsTableAdapter.Fill(this.northwindDataSet.Products);
			// TODO: This line of code loads data into the 'northwindDataSet.SalesOrders' table. You can move, or remove it, as needed.
			this.salesOrdersTableAdapter.Fill(this.northwindDataSet.SalesOrders);
			// TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
			this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
			emptySelect();
		}

		private void emptySelect()
		{
			customerIDComboBox.Text = "Select Customr ld";
			companyNameTextBox.Text = string.Empty;
			addressTextBox.Text = string.Empty;
			cityTextBox.Text = string.Empty;
		}

		private void CustomerIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ordersGroupBox.Visible = true;
		}

		private void OrderIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(orderIDComboBox.Text))
			{
				productsListBox.Items.Clear();
				orderDeatilsGroupBox.Visible = true;
				editButton.Visible = true;
				productIDComboBox.Text = "Select Product";
				productNameComboBox.Text = "Select Product Description";
				okayButton.Enabled = true;
				nextButton.Enabled = true;
				GetOrderDetails();
			}
		}

		double total = 0;

		private void GetOrderDetails()
		{
			int total = 0;
			DataView dvOrderDetails = new DataView(this.northwindDataSet.SalesOrders);
			dvOrderDetails.RowFilter = "Orderld = " + orderIDComboBox.Text;
			if (dvOrderDetails.Count == 0)
			{
				MessageBox.Show("There are no items for this order");
			}
			else
			{
				int itemcount = dvOrderDetails.Count - 1;
				for (int cntltems = 0; cntltems <= itemcount; cntltems++)
				{
					AddToListViewFromDatBase(dvOrderDetails, cntltems);
				}
			}
		}

		private void AddToListViewFromDatBase(DataView dvOrderDetails, int cntltems)
		{
			Double Cost;

			Cost = Convert.ToDouble(dvOrderDetails[cntltems]["UnitPrice"]) *
	Convert.ToDouble(dvOrderDetails[cntltems]["Quantity"]);
			String Newltem;
			NorthwindDataSet.ProductsRow productFoundRow = northwindDataSet.Products.FindByProductID(Convert.ToInt32(dvOrderDetails[cntltems]["ProductId"]));
			Newltem = Convert.ToString(dvOrderDetails[cntltems]["Productld"]);
			ListViewItem listViewItem = new ListViewItem(Newltem);
			if (productFoundRow != null)
			{
				listViewItem.SubItems.Add(productFoundRow.ProductName);
			}
			else
			{
				listViewItem.SubItems.Add(" ");
			}
			listViewItem.SubItems.Add(String.Format("{0:€,0.00}", dvOrderDetails[cntltems]["UnitPrice"]));//
			listViewItem.SubItems.Add(Convert.ToString(dvOrderDetails[cntltems]["Quantity"]));
			listViewItem.SubItems.Add(String.Format("{0:€,0.00}", Cost));
			productsListBox.Items.AddRange(new ListViewItem[] { listViewItem });
			total += Cost;
			totalTextBox.Text = String.Format(" {0:€,0.00}", total);
		}
	}
}