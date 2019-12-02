using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderProcessing
{
    class Class1
    {
        public void blah()

        {


        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            productid = Convert.ToInt32(lvProducts.FocusedItem.subltems[0].Text);
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
                           lvProducts.FocusedItem.Subltems[0].Text;
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
            AmountToSubtract = Convert.To Double(CostNoCurr);
            Total -= AmountToSubtract;
            lvProducts.Items.Remove(lvProducts.FocusedItem);
            txtTotalDue.Text = Convert.ToString(Total);
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }
    }


    private void editButton_Click(object sender, EventArgs e)
    {
        grpEdit.Visible = true;
        FindOrderDetails();
        if (dvproduct.Count > 0)
        {
            txtProductNumber.Text = lvProducts.FocusedItem.SubItems[0].Text;
            txtDescription.Text = lvProducts.FocuseItem.Subltems[1].Text;
            txtUnitPrice.Text = lvProducts.FocusedItem.SubItems[2].Text;
            txtQuantity.Text = lvProducts.Focused Item.SubItems[3].Text;
            txtCost.Text = lvProducts.FocusedItem.SubItems[4].Text;
            DeleteFromListView();

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Visible = true;
            txtQuantity.Focus();
        }
    }
    private void btnUpdate_Click(object sender, EventArgs e)
    {
        Double Cost;
        dvproduct[0]["Quantity"] = Convert.ToDouble(txtQuantity.Text);
        try
        {
            this.salesOrderDetailsTableAdapter.Update(this.northwindDataSet.SalesOrderDetails);
            MessageBox.show("changes");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        string PriceNoCurr;
        PriceNoCurr = txtUnitPrice.Text.Replace("€", " ");
        Cost = Convert.ToDouble(PriceNoCurr) * Convert.ToDouble(txtQuantity.Text);
        String Newltem;
        Newltem = txtProductNumber.Text;
        ListViewItem Iteml = new ListViewItem(NewItem);
        Item1.SubItems.Add(txtDescription.Text);
        Item 1.SubItems.Add(txtUnitPrice.Text);
        Item1.SubItems.Add(txtQuantity.Text);
        Item1.SubItems.Add(String.Format("{0:€,0.00}", Cost));
        lvProducts.Items.AddRange(new ListViewltem[] { Item 1 });
        Total += Cost;
        txtTotalDue.Text = String.Format("{0:€,0.00}", Total);
        grpEdit.Visible = false;
        updateButton.Visible = false;


    }


    private void btnNext_Click(object sender, EventArgs e)
    {
        ClearItems();
    }
    private void Clearitems()
    {
        CustomerldComboBox.Text = "Select Custom r";
        ProductsIDComboBox.Text = "Select ProductId ";
        ProductsComboBox.Text = "Select Product Description";
        CompanyNameTextBox.Text = "";
        AddressTextBox.Text = ""; CityTextBox.Text = "";
        custOrderRefTextBox.Text = " ";
        lvProducts.Items.Clear();

        Total = 0;

        btnNext.Enabled = false;
        grpOrders.Visible = false;
        grpOrderDetails.Visible = false;
        grpEdit.Visible = false;
    }
    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }
    private void ProductslDComboBox_SelectedlndexChanged(object sender, EventArgs e)
    {
        { ProductSelected = true; 
    }
    private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnDelete.Enabled = true;
        btnEdit.Enabled = true;
    }
}

