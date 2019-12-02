namespace OrderProcessing
{
	using System;
	using System.Data;
	using System.Windows.Forms;
	public partial class ModifyOrderForm : Form
	{
		NorthwindDataSet.ProductsRow ProductFoundRow; DataRow drNewOrderRow;
		NorthwindDataSet.SalesOrderDetailsRow drNewDetailsRow;
		NorthwindDataSet.ProductsRow RowProduct;
		Int32 NumToUse;
		DataView dvproduct;
		DataView dvOrderDetails;
		DataView dvItems;
		Boolean ProductSelected;
		Int32 cntItems;
		Double Total;
		Int32 productid;


		public ModifyOrderForm()
		{
			InitializeComponent();
		}

		private void ModifyOrderForm_Load(object sender, EventArgs e)
		{
			this.salesOrdersTableAdapter.Fill(this.northwindDataSet.SalesOrderDetails);



			// TODO: This line of code loads data into the 'northwindDataSet.SalesOrderDetails' table. You can move, or remove it, as needed.
			this.salesOrderDetailsTableAdapter.Fill(this.northwindDataSet.SalesOrderDetails);
			// TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
			this.productsTableAdapter.Fill(this.northwindDataSet.Products);
			// TODO: This line of code loads data into the 'northwindDataSet.SalesOrders' table. You can move, or remove it, as needed.
			this.salesOrdersTableAdapter.Fill(this.northwindDataSet.SalesOrders);
			// TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
			this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

			customerldComboBox.Text = "Select Customer ID";
			companyNameTextBox.Text = "";
			addressTextBox.Text = "";
			cityTextBox.Text = "";
		}

		private void CustomerIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ordersGroupBox.Visible = true;
		}

		private void OrderIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (OrderIdComboBox.Text != "")
			{

				lvProducts.Items.Clear();
				orderDeatilsGroupBox.Visible = true;
				editButton.Visible = true;
				productsIDComboBox.Text = "Select Product";
				productsComboBox.Text = "Select Product Description";
				okayButton.Enabled = true;
				nextButton.Enabled = true;
				GetOrderDetails();
			}
		}

		private void GetOrderDetails()
		{
			Total = 0;

			dvOrderDetails = new DataView(this.northwindDataSet.SalesOrders);
			dvOrderDetails.RowFilter = "Orderld = " + OrderIdComboBox.Text;
			if (dvOrderDetails.Count == 0)
			{
				MessageBox.Show("There are no items for this order");
			}
			else
			{
				Int32 itemcount = dvOrderDetails.Count - 1;
				for (cntItems = 0; cntItems <= itemcount; cntItems++)
				{
					Total += AddToListViewFromDatBase(dvOrderDetails, cntItems);
					totalTextBox.Text = String.Format(" {0:€,0.00}", Total);
				}

			}
		}

		private double AddToListViewFromDatBase(DataView dvOrderDetails, int cntltems)
		{
			Double cost = Convert.ToDouble(dvOrderDetails[cntltems]["UnitPrice"]) * Convert.ToDouble(dvOrderDetails[cntltems]["Quantity"]);
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
			listViewItem.SubItems.Add(String.Format("{0:€,0.00}", cost));
			lvProducts.Items.AddRange(new ListViewItem[] { listViewItem });
			return cost;

		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{

			int productid = Convert.ToInt32(lvProducts.FocusedItem.SubItems[0].Text);
			DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Yes or No",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if (result == DialogResult.Yes)
			{
				FindOrderDetails();
				if (dvproduct.Count > 0)
				{
					dvproduct.Delete(0);
					try
					{

						this.salesOrderDetailsTableAdapter.Update(this.northwindDataSet.SalesOrderDetails);
						MessageBox.Show(" Deleted");
						DeleteFromListView();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
		}
		private void FindOrderDetails()
		{
			dvproduct = new DataView(northwindDataSet.SalesOrderDetails);
			dvproduct.RowFilter = "Orderld=" + OrderIdComboBox.Text + "ANDProductId=" +
			lvProducts.FocusedItem.SubItems[0].Text;
			if (dvproduct.Count == 0)
			{
				MessageBox.Show("ltem not found");
			}
		}



		private void DeleteFromListView()
		{
			Double AmountToSubtract;
			string CostNoCurr = lvProducts.FocusedItem.SubItems[4].Text;
			CostNoCurr = CostNoCurr.Replace("€", " ");
			AmountToSubtract = Convert.ToDouble(CostNoCurr);
			Total -= AmountToSubtract;
			lvProducts.Items.Remove(lvProducts.FocusedItem);
			totalTextBox.Text = Convert.ToString(Total);
			deleteButton.Enabled = false;
			editButton.Enabled = false;
		}
		private void EditButton_Click(object sender, EventArgs e)
		{
			groupBox1.Visible = true;
			FindOrderDetails();
			if (dvproduct.Count > 0)
			{
				txtProductNumer.Text = lvProducts.FocusedItem.SubItems[0].Text;
				txtDescription.Text = lvProducts.FocusedItem.SubItems[1].Text;
				txtUnitPrice.Text = lvProducts.FocusedItem.SubItems[2].Text;
				txtQuantity.Text = lvProducts.FocusedItem.SubItems[3].Text;
				txtCost.Text = lvProducts.FocusedItem.SubItems[4].Text;
				DeleteFromListView();
				editButton.Enabled = false;
				deleteButton.Enabled = false;
				updateButton.Visible = true;
				txtQuantity.Focus();
			}
		}
		private void UpdateButton_Click(object sender, EventArgs e)
		{
			Double Cost;
			dvproduct[0]["Quantity"] = Convert.ToDouble(txtQuantity.Text);
			try
			{
				this.salesOrderDetailsTableAdapter.Update(this.northwindDataSet.SalesOrderDetails);
				MessageBox.Show("changes");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			string PriceNoCurr;
			PriceNoCurr = txtUnitPrice.Text.Replace("€", " ");

			Cost = Convert.ToDouble(PriceNoCurr) * Convert.ToDouble(txtQuantity.Text);
			String newItem;
			newItem = txtProductNumer.Text;
			ListViewItem Iteml = new ListViewItem(newItem);
			Iteml.SubItems.Add(txtDescription.Text);
			Iteml.SubItems.Add(txtUnitPrice.Text);
			Iteml.SubItems.Add(txtQuantity.Text);
			Iteml.SubItems.Add(String.Format("{0:€,0.00}", Cost));
			lvProducts.Items.AddRange(new ListViewItem[] { Iteml });
			Total += Cost;
			this.totalTextBox.Text = String.Format("{0:€,0.00}", Total);
			this.groupBox1.Visible = false;
			updateButton.Visible = false;

		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			Clearitems();
		}
		private void Clearitems()
		{
			customerldComboBox.Text = "Select Custom r";
			productsIDComboBox.Text = "Select ProductId ";
			productsComboBox.Text = "Select Product Description";
			companyNameTextBox.Text = "";
			addressTextBox.Text = ""; cityTextBox.Text = "";
			custOrderRefTextBox.Text = " ";
			lvProducts.Items.Clear();

			Total = 0;

			nextButton.Enabled = false;
			ordersGroupBox.Visible = false;
			orderDeatilsGroupBox.Visible = false;
			groupBox1.Visible = false;
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void ProductslDComboBox_SelectedlndexChanged(object sender, EventArgs e)
		{

			ProductSelected = true;
		}
		private void productsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			deleteButton.Enabled = true;
			editButton.Enabled = true;
		}

		private void ProductsListBox_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}