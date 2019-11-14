namespace NorthwindCRUDExample
{
	partial class CustomerOrdersForm
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
			System.Windows.Forms.Label countryLabel;
			this.customersTableAdapter1 = new NorthwindCRUDExample.NorthwindDataSetTableAdapters.CustomersTableAdapter();
			this.Customer = new System.Windows.Forms.GroupBox();
			this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.northwindDataSet = new NorthwindCRUDExample.NorthwindDataSet();
			this.tableAdapterManager = new NorthwindCRUDExample.NorthwindDataSetTableAdapters.TableAdapterManager();
			this.customerIDComboBox = new System.Windows.Forms.ComboBox();
			this.companyNameTextBox = new System.Windows.Forms.TextBox();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.countryTextBox = new System.Windows.Forms.TextBox();
			customerIDLabel = new System.Windows.Forms.Label();
			companyNameLabel = new System.Windows.Forms.Label();
			addressLabel = new System.Windows.Forms.Label();
			cityLabel = new System.Windows.Forms.Label();
			countryLabel = new System.Windows.Forms.Label();
			this.Customer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// customersTableAdapter1
			// 
			this.customersTableAdapter1.ClearBeforeFill = true;
			// 
			// Customer
			// 
			this.Customer.Controls.Add(countryLabel);
			this.Customer.Controls.Add(this.countryTextBox);
			this.Customer.Controls.Add(cityLabel);
			this.Customer.Controls.Add(this.cityTextBox);
			this.Customer.Controls.Add(addressLabel);
			this.Customer.Controls.Add(this.addressTextBox);
			this.Customer.Controls.Add(companyNameLabel);
			this.Customer.Controls.Add(this.companyNameTextBox);
			this.Customer.Controls.Add(customerIDLabel);
			this.Customer.Controls.Add(this.customerIDComboBox);
			this.Customer.Location = new System.Drawing.Point(12, 12);
			this.Customer.Name = "Customer";
			this.Customer.Size = new System.Drawing.Size(569, 174);
			this.Customer.TabIndex = 0;
			this.Customer.TabStop = false;
			this.Customer.Text = "groupBox1";
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
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter1;
			this.tableAdapterManager.SalesOrderDetailsTableAdapter = null;
			this.tableAdapterManager.SalesOrdersTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = NorthwindCRUDExample.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// customerIDLabel
			// 
			customerIDLabel.AutoSize = true;
			customerIDLabel.Location = new System.Drawing.Point(61, 34);
			customerIDLabel.Name = "customerIDLabel";
			customerIDLabel.Size = new System.Drawing.Size(68, 13);
			customerIDLabel.TabIndex = 0;
			customerIDLabel.Text = "Customer ID:";
			// 
			// customerIDComboBox
			// 
			this.customerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
			this.customerIDComboBox.DataSource = this.customersBindingSource;
			this.customerIDComboBox.DisplayMember = "CustomerID";
			this.customerIDComboBox.FormattingEnabled = true;
			this.customerIDComboBox.Location = new System.Drawing.Point(135, 31);
			this.customerIDComboBox.Name = "customerIDComboBox";
			this.customerIDComboBox.Size = new System.Drawing.Size(121, 21);
			this.customerIDComboBox.TabIndex = 1;
			// 
			// companyNameLabel
			// 
			companyNameLabel.AutoSize = true;
			companyNameLabel.Location = new System.Drawing.Point(358, 39);
			companyNameLabel.Name = "companyNameLabel";
			companyNameLabel.Size = new System.Drawing.Size(85, 13);
			companyNameLabel.TabIndex = 2;
			companyNameLabel.Text = "Company Name:";
			// 
			// companyNameTextBox
			// 
			this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CompanyName", true));
			this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.customersBindingSource, "CompanyName", true));
			this.companyNameTextBox.Location = new System.Drawing.Point(449, 36);
			this.companyNameTextBox.Name = "companyNameTextBox";
			this.companyNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.companyNameTextBox.TabIndex = 3;
			// 
			// addressLabel
			// 
			addressLabel.AutoSize = true;
			addressLabel.Location = new System.Drawing.Point(362, 77);
			addressLabel.Name = "addressLabel";
			addressLabel.Size = new System.Drawing.Size(48, 13);
			addressLabel.TabIndex = 4;
			addressLabel.Text = "Address:";
			// 
			// addressTextBox
			// 
			this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
			this.addressTextBox.Location = new System.Drawing.Point(416, 74);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(100, 20);
			this.addressTextBox.TabIndex = 5;
			// 
			// cityLabel
			// 
			cityLabel.AutoSize = true;
			cityLabel.Location = new System.Drawing.Point(382, 109);
			cityLabel.Name = "cityLabel";
			cityLabel.Size = new System.Drawing.Size(27, 13);
			cityLabel.TabIndex = 6;
			cityLabel.Text = "City:";
			// 
			// cityTextBox
			// 
			this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
			this.cityTextBox.Location = new System.Drawing.Point(415, 106);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(100, 20);
			this.cityTextBox.TabIndex = 7;
			// 
			// countryLabel
			// 
			countryLabel.AutoSize = true;
			countryLabel.Location = new System.Drawing.Point(383, 137);
			countryLabel.Name = "countryLabel";
			countryLabel.Size = new System.Drawing.Size(46, 13);
			countryLabel.TabIndex = 8;
			countryLabel.Text = "Country:";
			// 
			// countryTextBox
			// 
			this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Country", true));
			this.countryTextBox.Location = new System.Drawing.Point(435, 134);
			this.countryTextBox.Name = "countryTextBox";
			this.countryTextBox.Size = new System.Drawing.Size(100, 20);
			this.countryTextBox.TabIndex = 9;
			// 
			// CustomerOrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Customer);
			this.Name = "CustomerOrdersForm";
			this.Text = "CustomerOrdersForm";
			this.Customer.ResumeLayout(false);
			this.Customer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
		private System.Windows.Forms.GroupBox Customer;
		private System.Windows.Forms.BindingSource customersBindingSource;
		private NorthwindDataSet northwindDataSet;
		private System.Windows.Forms.TextBox countryTextBox;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.TextBox companyNameTextBox;
		private System.Windows.Forms.ComboBox customerIDComboBox;
		private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
	}
}