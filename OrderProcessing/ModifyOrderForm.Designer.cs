namespace OrderProcessing
{
	partial class ModifyOrderForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label custOrderRefLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label requiredDateLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new OrderProcessing.NorthwindDataSet();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.customerldComboBox = new System.Windows.Forms.ComboBox();
            this.customersTableAdapter = new OrderProcessing.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new OrderProcessing.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.productsTableAdapter = new OrderProcessing.NorthwindDataSetTableAdapters.ProductsTableAdapter();
            this.salesOrdersTableAdapter = new OrderProcessing.NorthwindDataSetTableAdapters.SalesOrdersTableAdapter();
            this.ordersGroupBox = new System.Windows.Forms.GroupBox();
            this.requiredDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salesOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.custOrderRefTextBox = new System.Windows.Forms.TextBox();
            this.OrderIdComboBox = new System.Windows.Forms.ComboBox();
            this.orderDeatilsGroupBox = new System.Windows.Forms.GroupBox();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.txtProductNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtUnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.okayButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.productsComboBox = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsIDComboBox = new System.Windows.Forms.ComboBox();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nextButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            customerIDLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            custOrderRefLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            requiredDateLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            this.ordersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersBindingSource)).BeginInit();
            this.orderDeatilsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(6, 27);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 0;
            customerIDLabel.Text = "Customer ID:";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(276, 24);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(85, 13);
            companyNameLabel.TabIndex = 2;
            companyNameLabel.Text = "Company Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(313, 52);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(334, 79);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 6;
            cityLabel.Text = "City:";
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(15, 20);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(50, 13);
            orderIDLabel.TabIndex = 0;
            orderIDLabel.Text = "Order ID:";
            // 
            // custOrderRefLabel
            // 
            custOrderRefLabel.AutoSize = true;
            custOrderRefLabel.Location = new System.Drawing.Point(281, 19);
            custOrderRefLabel.Name = "custOrderRefLabel";
            custOrderRefLabel.Size = new System.Drawing.Size(80, 13);
            custOrderRefLabel.TabIndex = 2;
            custOrderRefLabel.Text = "Cust Order Ref:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(299, 46);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(62, 13);
            orderDateLabel.TabIndex = 4;
            orderDateLabel.Text = "Order Date:";
            // 
            // requiredDateLabel
            // 
            requiredDateLabel.AutoSize = true;
            requiredDateLabel.Location = new System.Drawing.Point(282, 78);
            requiredDateLabel.Name = "requiredDateLabel";
            requiredDateLabel.Size = new System.Drawing.Size(79, 13);
            requiredDateLabel.TabIndex = 6;
            requiredDateLabel.Text = "Required Date:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(29, 21);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(61, 13);
            productIDLabel.TabIndex = 0;
            productIDLabel.Text = "Product ID:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(242, 21);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(78, 13);
            productNameLabel.TabIndex = 2;
            productNameLabel.Text = "Product Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(cityLabel);
            this.groupBox1.Controls.Add(this.cityTextBox);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(companyNameLabel);
            this.groupBox1.Controls.Add(this.companyNameTextBox);
            this.groupBox1.Controls.Add(customerIDLabel);
            this.groupBox1.Controls.Add(this.customerldComboBox);
            this.groupBox1.Location = new System.Drawing.Point(55, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(367, 76);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 7;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(367, 49);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 5;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(367, 21);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyNameTextBox.TabIndex = 3;
            // 
            // customerldComboBox
            // 
            this.customerldComboBox.DataSource = this.customersBindingSource;
            this.customerldComboBox.DisplayMember = "CustomerID";
            this.customerldComboBox.FormattingEnabled = true;
            this.customerldComboBox.Location = new System.Drawing.Point(80, 24);
            this.customerldComboBox.Name = "customerldComboBox";
            this.customerldComboBox.Size = new System.Drawing.Size(121, 21);
            this.customerldComboBox.TabIndex = 1;
            this.customerldComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerIDComboBox_SelectedIndexChanged);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.OrderNumbersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.SalesOrderDetailsTableAdapter = null;
            this.tableAdapterManager.SalesOrdersTableAdapter = this.salesOrdersTableAdapter;
            this.tableAdapterManager.UpdateOrder = OrderProcessing.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // salesOrdersTableAdapter
            // 
            this.salesOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersGroupBox
            // 
            this.ordersGroupBox.Controls.Add(requiredDateLabel);
            this.ordersGroupBox.Controls.Add(this.requiredDateDateTimePicker);
            this.ordersGroupBox.Controls.Add(orderDateLabel);
            this.ordersGroupBox.Controls.Add(this.orderDateDateTimePicker);
            this.ordersGroupBox.Controls.Add(custOrderRefLabel);
            this.ordersGroupBox.Controls.Add(this.custOrderRefTextBox);
            this.ordersGroupBox.Controls.Add(orderIDLabel);
            this.ordersGroupBox.Controls.Add(this.OrderIdComboBox);
            this.ordersGroupBox.Location = new System.Drawing.Point(55, 159);
            this.ordersGroupBox.Name = "ordersGroupBox";
            this.ordersGroupBox.Size = new System.Drawing.Size(604, 115);
            this.ordersGroupBox.TabIndex = 1;
            this.ordersGroupBox.TabStop = false;
            this.ordersGroupBox.Text = "Orders";
            this.ordersGroupBox.Visible = false;
            // 
            // requiredDateDateTimePicker
            // 
            this.requiredDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salesOrdersBindingSource, "RequiredDate", true));
            this.requiredDateDateTimePicker.Location = new System.Drawing.Point(384, 72);
            this.requiredDateDateTimePicker.Name = "requiredDateDateTimePicker";
            this.requiredDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.requiredDateDateTimePicker.TabIndex = 7;
            // 
            // salesOrdersBindingSource
            // 
            this.salesOrdersBindingSource.DataMember = "SalesOrders";
            this.salesOrdersBindingSource.DataSource = this.northwindDataSet;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salesOrdersBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(384, 46);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.orderDateDateTimePicker.TabIndex = 5;
            // 
            // custOrderRefTextBox
            // 
            this.custOrderRefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrdersBindingSource, "CustOrderRef", true));
            this.custOrderRefTextBox.Location = new System.Drawing.Point(384, 16);
            this.custOrderRefTextBox.Name = "custOrderRefTextBox";
            this.custOrderRefTextBox.Size = new System.Drawing.Size(200, 20);
            this.custOrderRefTextBox.TabIndex = 3;
            // 
            // OrderIdComboBox
            // 
            this.OrderIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrdersBindingSource, "OrderID", true));
            this.OrderIdComboBox.FormattingEnabled = true;
            this.OrderIdComboBox.Location = new System.Drawing.Point(71, 17);
            this.OrderIdComboBox.Name = "OrderIdComboBox";
            this.OrderIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.OrderIdComboBox.TabIndex = 1;
            this.OrderIdComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderIDComboBox_SelectedIndexChanged);
            // 
            // orderDeatilsGroupBox
            // 
            this.orderDeatilsGroupBox.Controls.Add(this.lvProducts);
            this.orderDeatilsGroupBox.Controls.Add(this.totalTextBox);
            this.orderDeatilsGroupBox.Controls.Add(this.TotalLabel);
            this.orderDeatilsGroupBox.Controls.Add(this.editButton);
            this.orderDeatilsGroupBox.Controls.Add(this.deleteButton);
            this.orderDeatilsGroupBox.Controls.Add(this.okayButton);
            this.orderDeatilsGroupBox.Controls.Add(this.numericUpDown1);
            this.orderDeatilsGroupBox.Controls.Add(productNameLabel);
            this.orderDeatilsGroupBox.Controls.Add(this.productsComboBox);
            this.orderDeatilsGroupBox.Controls.Add(productIDLabel);
            this.orderDeatilsGroupBox.Controls.Add(this.productsIDComboBox);
            this.orderDeatilsGroupBox.Location = new System.Drawing.Point(55, 291);
            this.orderDeatilsGroupBox.Name = "orderDeatilsGroupBox";
            this.orderDeatilsGroupBox.Size = new System.Drawing.Size(700, 257);
            this.orderDeatilsGroupBox.TabIndex = 2;
            this.orderDeatilsGroupBox.TabStop = false;
            this.orderDeatilsGroupBox.Text = "Order Details";
            this.orderDeatilsGroupBox.Visible = false;
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.txtProductNumber,
            this.txtDescription,
            this.txtUnitPrice,
            this.txtQuantity,
            this.txtCost});
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(32, 63);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(443, 80);
            this.lvProducts.TabIndex = 11;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            this.lvProducts.SelectedIndexChanged += new System.EventHandler(this.ProductsListBox_SelectedIndexChanged_1);
            // 
            // txtProductNumber
            // 
            this.txtProductNumber.Text = "Product ID";
            this.txtProductNumber.Width = 110;
            // 
            // txtDescription
            // 
            this.txtDescription.Text = "Description";
            this.txtDescription.Width = 90;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Text = "Unit Price";
            this.txtUnitPrice.Width = 81;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Text = "Quantity";
            // 
            // txtCost
            // 
            this.txtCost.Text = "Cost";
            this.txtCost.Width = 76;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(400, 152);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(75, 20);
            this.totalTextBox.TabIndex = 10;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(345, 155);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalLabel.Size = new System.Drawing.Size(31, 13);
            this.TotalLabel.TabIndex = 9;
            this.TotalLabel.Text = "Total";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(130, 149);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(49, 149);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // okayButton
            // 
            this.okayButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.okayButton.Location = new System.Drawing.Point(565, 21);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 6;
            this.okayButton.Text = "OK";
            this.okayButton.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(474, 21);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // productsComboBox
            // 
            this.productsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductName", true));
            this.productsComboBox.FormattingEnabled = true;
            this.productsComboBox.Location = new System.Drawing.Point(326, 18);
            this.productsComboBox.Name = "productsComboBox";
            this.productsComboBox.Size = new System.Drawing.Size(121, 21);
            this.productsComboBox.TabIndex = 3;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.northwindDataSet;
            // 
            // productsIDComboBox
            // 
            this.productsIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductID", true));
            this.productsIDComboBox.FormattingEnabled = true;
            this.productsIDComboBox.Location = new System.Drawing.Point(96, 18);
            this.productsIDComboBox.Name = "productsIDComboBox";
            this.productsIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.productsIDComboBox.TabIndex = 1;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.northwindDataSet;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(447, 554);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(534, 554);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(61, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ModifyOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.orderDeatilsGroupBox);
            this.Controls.Add(this.ordersGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModifyOrderForm";
            this.Text = "ModifyOrderForm";
            this.Load += new System.EventHandler(this.ModifyOrderForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            this.ordersGroupBox.ResumeLayout(false);
            this.ordersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersBindingSource)).EndInit();
            this.orderDeatilsGroupBox.ResumeLayout(false);
            this.orderDeatilsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private NorthwindDataSet northwindDataSet;
		private System.Windows.Forms.BindingSource customersBindingSource;
		private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
		private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.TextBox companyNameTextBox;
		private System.Windows.Forms.ComboBox customerldComboBox;
		private NorthwindDataSetTableAdapters.SalesOrdersTableAdapter salesOrdersTableAdapter;
		private System.Windows.Forms.GroupBox ordersGroupBox;
		private System.Windows.Forms.BindingSource salesOrdersBindingSource;
		private System.Windows.Forms.DateTimePicker requiredDateDateTimePicker;
		private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
		private System.Windows.Forms.TextBox custOrderRefTextBox;
		private System.Windows.Forms.ComboBox OrderIdComboBox;
		private NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
		private System.Windows.Forms.GroupBox orderDeatilsGroupBox;
		private System.Windows.Forms.BindingSource productsBindingSource;
		private System.Windows.Forms.ComboBox productsComboBox;
		private System.Windows.Forms.ComboBox productsIDComboBox;
		private System.Windows.Forms.TextBox totalTextBox;
		private System.Windows.Forms.Label TotalLabel;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button okayButton;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.BindingSource productsBindingSource1;
		private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader txtProductNumber;
        private System.Windows.Forms.ColumnHeader txtDescription;
        private System.Windows.Forms.ColumnHeader txtUnitPrice;
        private System.Windows.Forms.ColumnHeader txtQuantity;
        private System.Windows.Forms.ColumnHeader txtCost;
        private System.Windows.Forms.Button CloseButton;
    }
}