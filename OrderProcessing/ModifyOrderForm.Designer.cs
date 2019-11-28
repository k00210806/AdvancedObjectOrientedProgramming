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
			this.northwindDataSet = new OrderProcessing.NorthwindDataSet();
			this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.customersTableAdapter = new OrderProcessing.NorthwindDataSetTableAdapters.CustomersTableAdapter();
			this.tableAdapterManager = new OrderProcessing.NorthwindDataSetTableAdapters.TableAdapterManager();
			this.customerIDComboBox = new System.Windows.Forms.ComboBox();
			this.companyNameTextBox = new System.Windows.Forms.TextBox();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.ordersGroupBox = new System.Windows.Forms.GroupBox();
			this.salesOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.salesOrdersTableAdapter = new OrderProcessing.NorthwindDataSetTableAdapters.SalesOrdersTableAdapter();
			this.orderIDComboBox = new System.Windows.Forms.ComboBox();
			this.custOrderRefTextBox = new System.Windows.Forms.TextBox();
			this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.requiredDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.orderDeatilsGroupBox = new System.Windows.Forms.GroupBox();
			this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productsTableAdapter = new OrderProcessing.NorthwindDataSetTableAdapters.ProductsTableAdapter();
			this.productIDComboBox = new System.Windows.Forms.ComboBox();
			this.productNameComboBox = new System.Windows.Forms.ComboBox();
			this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.productsListBox = new System.Windows.Forms.ListBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.okayButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.totalTextBox = new System.Windows.Forms.TextBox();
			this.nextButton = new System.Windows.Forms.Button();
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
			((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
			this.ordersGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.salesOrdersBindingSource)).BeginInit();
			this.orderDeatilsGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
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
			this.groupBox1.Controls.Add(this.customerIDComboBox);
			this.groupBox1.Location = new System.Drawing.Point(55, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(500, 114);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Customers";
			// 
			// northwindDataSet
			// 
			this.northwindDataSet.DataSetName = "NorthwindDataSet";
			this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// customersBindingSource
			// 
			this.customersBindingSource.DataMember = "Customers";
			this.customersBindingSource.DataSource = this.northwindDataSet;
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
			// customerIDLabel
			// 
			customerIDLabel.AutoSize = true;
			customerIDLabel.Location = new System.Drawing.Point(6, 27);
			customerIDLabel.Name = "customerIDLabel";
			customerIDLabel.Size = new System.Drawing.Size(68, 13);
			customerIDLabel.TabIndex = 0;
			customerIDLabel.Text = "Customer ID:";
			// 
			// customerIDComboBox
			// 
			this.customerIDComboBox.DataSource = this.customersBindingSource;
			this.customerIDComboBox.DisplayMember = "CustomerID";
			this.customerIDComboBox.FormattingEnabled = true;
			this.customerIDComboBox.Location = new System.Drawing.Point(80, 24);
			this.customerIDComboBox.Name = "customerIDComboBox";
			this.customerIDComboBox.Size = new System.Drawing.Size(121, 21);
			this.customerIDComboBox.TabIndex = 1;
			this.customerIDComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerIDComboBox_SelectedIndexChanged);
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
			// companyNameTextBox
			// 
			this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CompanyName", true));
			this.companyNameTextBox.Location = new System.Drawing.Point(367, 21);
			this.companyNameTextBox.Name = "companyNameTextBox";
			this.companyNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.companyNameTextBox.TabIndex = 3;
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
			// addressTextBox
			// 
			this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
			this.addressTextBox.Location = new System.Drawing.Point(367, 49);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(100, 20);
			this.addressTextBox.TabIndex = 5;
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
			// cityTextBox
			// 
			this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
			this.cityTextBox.Location = new System.Drawing.Point(367, 76);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(100, 20);
			this.cityTextBox.TabIndex = 7;
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
			this.ordersGroupBox.Controls.Add(this.orderIDComboBox);
			this.ordersGroupBox.Location = new System.Drawing.Point(55, 159);
			this.ordersGroupBox.Name = "ordersGroupBox";
			this.ordersGroupBox.Size = new System.Drawing.Size(604, 115);
			this.ordersGroupBox.TabIndex = 1;
			this.ordersGroupBox.TabStop = false;
			this.ordersGroupBox.Text = "Orders";
			this.ordersGroupBox.Visible = false;
			// 
			// salesOrdersBindingSource
			// 
			this.salesOrdersBindingSource.DataMember = "SalesOrders";
			this.salesOrdersBindingSource.DataSource = this.northwindDataSet;
			// 
			// salesOrdersTableAdapter
			// 
			this.salesOrdersTableAdapter.ClearBeforeFill = true;
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
			// orderIDComboBox
			// 
			this.orderIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrdersBindingSource, "OrderID", true));
			this.orderIDComboBox.FormattingEnabled = true;
			this.orderIDComboBox.Location = new System.Drawing.Point(71, 17);
			this.orderIDComboBox.Name = "orderIDComboBox";
			this.orderIDComboBox.Size = new System.Drawing.Size(121, 21);
			this.orderIDComboBox.TabIndex = 1;
			this.orderIDComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderIDComboBox_SelectedIndexChanged);
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
			// custOrderRefTextBox
			// 
			this.custOrderRefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrdersBindingSource, "CustOrderRef", true));
			this.custOrderRefTextBox.Location = new System.Drawing.Point(384, 16);
			this.custOrderRefTextBox.Name = "custOrderRefTextBox";
			this.custOrderRefTextBox.Size = new System.Drawing.Size(200, 20);
			this.custOrderRefTextBox.TabIndex = 3;
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
			// orderDateDateTimePicker
			// 
			this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salesOrdersBindingSource, "OrderDate", true));
			this.orderDateDateTimePicker.Location = new System.Drawing.Point(384, 46);
			this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
			this.orderDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.orderDateDateTimePicker.TabIndex = 5;
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
			// requiredDateDateTimePicker
			// 
			this.requiredDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salesOrdersBindingSource, "RequiredDate", true));
			this.requiredDateDateTimePicker.Location = new System.Drawing.Point(384, 72);
			this.requiredDateDateTimePicker.Name = "requiredDateDateTimePicker";
			this.requiredDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.requiredDateDateTimePicker.TabIndex = 7;
			// 
			// orderDeatilsGroupBox
			// 
			this.orderDeatilsGroupBox.Controls.Add(this.totalTextBox);
			this.orderDeatilsGroupBox.Controls.Add(this.label1);
			this.orderDeatilsGroupBox.Controls.Add(this.editButton);
			this.orderDeatilsGroupBox.Controls.Add(this.deleteButton);
			this.orderDeatilsGroupBox.Controls.Add(this.okayButton);
			this.orderDeatilsGroupBox.Controls.Add(this.numericUpDown1);
			this.orderDeatilsGroupBox.Controls.Add(this.productsListBox);
			this.orderDeatilsGroupBox.Controls.Add(productNameLabel);
			this.orderDeatilsGroupBox.Controls.Add(this.productNameComboBox);
			this.orderDeatilsGroupBox.Controls.Add(productIDLabel);
			this.orderDeatilsGroupBox.Controls.Add(this.productIDComboBox);
			this.orderDeatilsGroupBox.Location = new System.Drawing.Point(55, 291);
			this.orderDeatilsGroupBox.Name = "orderDeatilsGroupBox";
			this.orderDeatilsGroupBox.Size = new System.Drawing.Size(700, 257);
			this.orderDeatilsGroupBox.TabIndex = 2;
			this.orderDeatilsGroupBox.TabStop = false;
			this.orderDeatilsGroupBox.Text = "Order Details";
			this.orderDeatilsGroupBox.Visible = false;
			// 
			// productsBindingSource
			// 
			this.productsBindingSource.DataMember = "Products";
			this.productsBindingSource.DataSource = this.northwindDataSet;
			// 
			// productsTableAdapter
			// 
			this.productsTableAdapter.ClearBeforeFill = true;
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
			// productIDComboBox
			// 
			this.productIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductID", true));
			this.productIDComboBox.FormattingEnabled = true;
			this.productIDComboBox.Location = new System.Drawing.Point(96, 18);
			this.productIDComboBox.Name = "productIDComboBox";
			this.productIDComboBox.Size = new System.Drawing.Size(121, 21);
			this.productIDComboBox.TabIndex = 1;
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
			// productNameComboBox
			// 
			this.productNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductName", true));
			this.productNameComboBox.FormattingEnabled = true;
			this.productNameComboBox.Location = new System.Drawing.Point(326, 18);
			this.productNameComboBox.Name = "productNameComboBox";
			this.productNameComboBox.Size = new System.Drawing.Size(121, 21);
			this.productNameComboBox.TabIndex = 3;
			// 
			// productsBindingSource1
			// 
			this.productsBindingSource1.DataMember = "Products";
			this.productsBindingSource1.DataSource = this.northwindDataSet;
			// 
			// productsListBox
			// 
			this.productsListBox.DataSource = this.productsBindingSource1;
			this.productsListBox.DisplayMember = "ProductName";
			this.productsListBox.FormattingEnabled = true;
			this.productsListBox.Location = new System.Drawing.Point(18, 59);
			this.productsListBox.Name = "productsListBox";
			this.productsListBox.Size = new System.Drawing.Size(654, 134);
			this.productsListBox.TabIndex = 4;
			this.productsListBox.ValueMember = "ProductID";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(474, 21);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(66, 20);
			this.numericUpDown1.TabIndex = 5;
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
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(125, 200);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 7;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(235, 199);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(75, 23);
			this.editButton.TabIndex = 8;
			this.editButton.Text = "Edit";
			this.editButton.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(464, 209);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "label1";
			// 
			// totalTextBox
			// 
			this.totalTextBox.Location = new System.Drawing.Point(528, 206);
			this.totalTextBox.Name = "totalTextBox";
			this.totalTextBox.Size = new System.Drawing.Size(100, 20);
			this.totalTextBox.TabIndex = 10;
			// 
			// nextButton
			// 
			this.nextButton.Location = new System.Drawing.Point(566, 555);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(75, 23);
			this.nextButton.TabIndex = 3;
			this.nextButton.Text = "Next";
			this.nextButton.UseVisualStyleBackColor = true;
			// 
			// ModifyOrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 582);
			this.Controls.Add(this.nextButton);
			this.Controls.Add(this.orderDeatilsGroupBox);
			this.Controls.Add(this.ordersGroupBox);
			this.Controls.Add(this.groupBox1);
			this.Name = "ModifyOrderForm";
			this.Text = "ModifyOrderForm";
			this.Load += new System.EventHandler(this.ModifyOrderForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
			this.ordersGroupBox.ResumeLayout(false);
			this.ordersGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.salesOrdersBindingSource)).EndInit();
			this.orderDeatilsGroupBox.ResumeLayout(false);
			this.orderDeatilsGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
		private System.Windows.Forms.ComboBox customerIDComboBox;
		private NorthwindDataSetTableAdapters.SalesOrdersTableAdapter salesOrdersTableAdapter;
		private System.Windows.Forms.GroupBox ordersGroupBox;
		private System.Windows.Forms.BindingSource salesOrdersBindingSource;
		private System.Windows.Forms.DateTimePicker requiredDateDateTimePicker;
		private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
		private System.Windows.Forms.TextBox custOrderRefTextBox;
		private System.Windows.Forms.ComboBox orderIDComboBox;
		private NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
		private System.Windows.Forms.GroupBox orderDeatilsGroupBox;
		private System.Windows.Forms.BindingSource productsBindingSource;
		private System.Windows.Forms.ComboBox productNameComboBox;
		private System.Windows.Forms.ComboBox productIDComboBox;
		private System.Windows.Forms.TextBox totalTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button okayButton;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.ListBox productsListBox;
		private System.Windows.Forms.BindingSource productsBindingSource1;
		private System.Windows.Forms.Button nextButton;
	}
}