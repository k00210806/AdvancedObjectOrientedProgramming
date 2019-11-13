namespace NorthwindCRUDExample
{
	partial class CustomerEditForm
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
			System.Windows.Forms.Label contactNameLabel;
			System.Windows.Forms.Label contactTitleLabel;
			System.Windows.Forms.Label addressLabel;
			System.Windows.Forms.Label cityLabel;
			System.Windows.Forms.Label regionLabel;
			System.Windows.Forms.Label postalCodeLabel;
			System.Windows.Forms.Label countryLabel;
			System.Windows.Forms.Label phoneLabel;
			System.Windows.Forms.Label faxLabel;
			this.CustomerIDcomboBox = new System.Windows.Forms.ComboBox();
			this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.northwindDataSet = new NorthwindCRUDExample.NorthwindDataSet();
			this.northwindDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.customersTableAdapter = new NorthwindCRUDExample.NorthwindDataSetTableAdapters.CustomersTableAdapter();
			this.CompanyNamecomboBox = new System.Windows.Forms.ComboBox();
			this.tableAdapterManager = new NorthwindCRUDExample.NorthwindDataSetTableAdapters.TableAdapterManager();
			this.Editbutton = new System.Windows.Forms.Button();
			this.Returnbutton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.customerIDTextBox = new System.Windows.Forms.TextBox();
			this.companyNameTextBox = new System.Windows.Forms.TextBox();
			this.contactNameTextBox = new System.Windows.Forms.TextBox();
			this.contactTitleTextBox = new System.Windows.Forms.TextBox();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.regionTextBox = new System.Windows.Forms.TextBox();
			this.postalCodeTextBox = new System.Windows.Forms.TextBox();
			this.countryTextBox = new System.Windows.Forms.TextBox();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.faxTextBox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Deletebutton = new System.Windows.Forms.Button();
			customerIDLabel = new System.Windows.Forms.Label();
			companyNameLabel = new System.Windows.Forms.Label();
			contactNameLabel = new System.Windows.Forms.Label();
			contactTitleLabel = new System.Windows.Forms.Label();
			addressLabel = new System.Windows.Forms.Label();
			cityLabel = new System.Windows.Forms.Label();
			regionLabel = new System.Windows.Forms.Label();
			postalCodeLabel = new System.Windows.Forms.Label();
			countryLabel = new System.Windows.Forms.Label();
			phoneLabel = new System.Windows.Forms.Label();
			faxLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.northwindDataSetBindingSource)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// customerIDLabel
			// 
			customerIDLabel.AutoSize = true;
			customerIDLabel.Location = new System.Drawing.Point(6, 31);
			customerIDLabel.Name = "customerIDLabel";
			customerIDLabel.Size = new System.Drawing.Size(68, 13);
			customerIDLabel.TabIndex = 0;
			customerIDLabel.Text = "Customer ID:";
			// 
			// companyNameLabel
			// 
			companyNameLabel.AutoSize = true;
			companyNameLabel.Location = new System.Drawing.Point(6, 58);
			companyNameLabel.Name = "companyNameLabel";
			companyNameLabel.Size = new System.Drawing.Size(85, 13);
			companyNameLabel.TabIndex = 2;
			companyNameLabel.Text = "Company Name:";
			// 
			// contactNameLabel
			// 
			contactNameLabel.AutoSize = true;
			contactNameLabel.Location = new System.Drawing.Point(6, 87);
			contactNameLabel.Name = "contactNameLabel";
			contactNameLabel.Size = new System.Drawing.Size(78, 13);
			contactNameLabel.TabIndex = 4;
			contactNameLabel.Text = "Contact Name:";
			// 
			// contactTitleLabel
			// 
			contactTitleLabel.AutoSize = true;
			contactTitleLabel.Location = new System.Drawing.Point(6, 114);
			contactTitleLabel.Name = "contactTitleLabel";
			contactTitleLabel.Size = new System.Drawing.Size(70, 13);
			contactTitleLabel.TabIndex = 6;
			contactTitleLabel.Text = "Contact Title:";
			// 
			// addressLabel
			// 
			addressLabel.AutoSize = true;
			addressLabel.Location = new System.Drawing.Point(260, 31);
			addressLabel.Name = "addressLabel";
			addressLabel.Size = new System.Drawing.Size(48, 13);
			addressLabel.TabIndex = 8;
			addressLabel.Text = "Address:";
			// 
			// cityLabel
			// 
			cityLabel.AutoSize = true;
			cityLabel.Location = new System.Drawing.Point(260, 56);
			cityLabel.Name = "cityLabel";
			cityLabel.Size = new System.Drawing.Size(27, 13);
			cityLabel.TabIndex = 10;
			cityLabel.Text = "City:";
			// 
			// regionLabel
			// 
			regionLabel.AutoSize = true;
			regionLabel.Location = new System.Drawing.Point(260, 81);
			regionLabel.Name = "regionLabel";
			regionLabel.Size = new System.Drawing.Size(44, 13);
			regionLabel.TabIndex = 12;
			regionLabel.Text = "Region:";
			// 
			// postalCodeLabel
			// 
			postalCodeLabel.AutoSize = true;
			postalCodeLabel.Location = new System.Drawing.Point(260, 106);
			postalCodeLabel.Name = "postalCodeLabel";
			postalCodeLabel.Size = new System.Drawing.Size(67, 13);
			postalCodeLabel.TabIndex = 14;
			postalCodeLabel.Text = "Postal Code:";
			// 
			// countryLabel
			// 
			countryLabel.AutoSize = true;
			countryLabel.Location = new System.Drawing.Point(260, 131);
			countryLabel.Name = "countryLabel";
			countryLabel.Size = new System.Drawing.Size(46, 13);
			countryLabel.TabIndex = 16;
			countryLabel.Text = "Country:";
			// 
			// phoneLabel
			// 
			phoneLabel.AutoSize = true;
			phoneLabel.Location = new System.Drawing.Point(260, 156);
			phoneLabel.Name = "phoneLabel";
			phoneLabel.Size = new System.Drawing.Size(41, 13);
			phoneLabel.TabIndex = 18;
			phoneLabel.Text = "Phone:";
			// 
			// faxLabel
			// 
			faxLabel.AutoSize = true;
			faxLabel.Location = new System.Drawing.Point(260, 181);
			faxLabel.Name = "faxLabel";
			faxLabel.Size = new System.Drawing.Size(27, 13);
			faxLabel.TabIndex = 20;
			faxLabel.Text = "Fax:";
			// 
			// CustomerIDcomboBox
			// 
			this.CustomerIDcomboBox.DataSource = this.customersBindingSource;
			this.CustomerIDcomboBox.DisplayMember = "CustomerID";
			this.CustomerIDcomboBox.FormattingEnabled = true;
			this.CustomerIDcomboBox.Location = new System.Drawing.Point(15, 25);
			this.CustomerIDcomboBox.Name = "CustomerIDcomboBox";
			this.CustomerIDcomboBox.Size = new System.Drawing.Size(230, 21);
			this.CustomerIDcomboBox.TabIndex = 0;
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
			// northwindDataSetBindingSource
			// 
			this.northwindDataSetBindingSource.DataSource = this.northwindDataSet;
			this.northwindDataSetBindingSource.Position = 0;
			// 
			// customersTableAdapter
			// 
			this.customersTableAdapter.ClearBeforeFill = true;
			// 
			// CompanyNamecomboBox
			// 
			this.CompanyNamecomboBox.DataSource = this.customersBindingSource;
			this.CompanyNamecomboBox.DisplayMember = "CompanyName";
			this.CompanyNamecomboBox.FormattingEnabled = true;
			this.CompanyNamecomboBox.Location = new System.Drawing.Point(262, 25);
			this.CompanyNamecomboBox.Name = "CompanyNamecomboBox";
			this.CompanyNamecomboBox.Size = new System.Drawing.Size(189, 21);
			this.CompanyNamecomboBox.TabIndex = 1;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
			this.tableAdapterManager.UpdateOrder = NorthwindCRUDExample.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// Editbutton
			// 
			this.Editbutton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.Editbutton.Location = new System.Drawing.Point(310, 308);
			this.Editbutton.Name = "Editbutton";
			this.Editbutton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Editbutton.Size = new System.Drawing.Size(77, 24);
			this.Editbutton.TabIndex = 3;
			this.Editbutton.Text = "Edit";
			this.Editbutton.UseVisualStyleBackColor = true;
			this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
			// 
			// Returnbutton
			// 
			this.Returnbutton.Location = new System.Drawing.Point(393, 308);
			this.Returnbutton.Name = "Returnbutton";
			this.Returnbutton.Size = new System.Drawing.Size(84, 24);
			this.Returnbutton.TabIndex = 4;
			this.Returnbutton.Text = "Close";
			this.Returnbutton.UseVisualStyleBackColor = true;
			this.Returnbutton.Click += new System.EventHandler(this.Returnbutton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Northwind Customers";
			// 
			// customerIDTextBox
			// 
			this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
			this.customerIDTextBox.Location = new System.Drawing.Point(97, 24);
			this.customerIDTextBox.Name = "customerIDTextBox";
			this.customerIDTextBox.ReadOnly = true;
			this.customerIDTextBox.Size = new System.Drawing.Size(100, 20);
			this.customerIDTextBox.TabIndex = 1;
			// 
			// companyNameTextBox
			// 
			this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CompanyName", true));
			this.companyNameTextBox.Location = new System.Drawing.Point(97, 51);
			this.companyNameTextBox.Name = "companyNameTextBox";
			this.companyNameTextBox.ReadOnly = true;
			this.companyNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.companyNameTextBox.TabIndex = 3;
			// 
			// contactNameTextBox
			// 
			this.contactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ContactName", true));
			this.contactNameTextBox.Location = new System.Drawing.Point(97, 80);
			this.contactNameTextBox.Name = "contactNameTextBox";
			this.contactNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.contactNameTextBox.TabIndex = 5;
			// 
			// contactTitleTextBox
			// 
			this.contactTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ContactTitle", true));
			this.contactTitleTextBox.Location = new System.Drawing.Point(97, 107);
			this.contactTitleTextBox.Name = "contactTitleTextBox";
			this.contactTitleTextBox.Size = new System.Drawing.Size(100, 20);
			this.contactTitleTextBox.TabIndex = 7;
			// 
			// addressTextBox
			// 
			this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
			this.addressTextBox.Location = new System.Drawing.Point(333, 27);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(100, 20);
			this.addressTextBox.TabIndex = 9;
			// 
			// cityTextBox
			// 
			this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
			this.cityTextBox.Location = new System.Drawing.Point(333, 50);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(100, 20);
			this.cityTextBox.TabIndex = 11;
			// 
			// regionTextBox
			// 
			this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Region", true));
			this.regionTextBox.Location = new System.Drawing.Point(333, 77);
			this.regionTextBox.Name = "regionTextBox";
			this.regionTextBox.Size = new System.Drawing.Size(100, 20);
			this.regionTextBox.TabIndex = 13;
			// 
			// postalCodeTextBox
			// 
			this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PostalCode", true));
			this.postalCodeTextBox.Location = new System.Drawing.Point(333, 103);
			this.postalCodeTextBox.Name = "postalCodeTextBox";
			this.postalCodeTextBox.Size = new System.Drawing.Size(100, 20);
			this.postalCodeTextBox.TabIndex = 15;
			// 
			// countryTextBox
			// 
			this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Country", true));
			this.countryTextBox.Location = new System.Drawing.Point(333, 129);
			this.countryTextBox.Name = "countryTextBox";
			this.countryTextBox.Size = new System.Drawing.Size(100, 20);
			this.countryTextBox.TabIndex = 17;
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
			this.phoneTextBox.Location = new System.Drawing.Point(333, 155);
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
			this.phoneTextBox.TabIndex = 19;
			// 
			// faxTextBox
			// 
			this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Fax", true));
			this.faxTextBox.Location = new System.Drawing.Point(333, 181);
			this.faxTextBox.Name = "faxTextBox";
			this.faxTextBox.Size = new System.Drawing.Size(100, 20);
			this.faxTextBox.TabIndex = 21;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(faxLabel);
			this.groupBox1.Controls.Add(this.faxTextBox);
			this.groupBox1.Controls.Add(phoneLabel);
			this.groupBox1.Controls.Add(this.phoneTextBox);
			this.groupBox1.Controls.Add(countryLabel);
			this.groupBox1.Controls.Add(this.countryTextBox);
			this.groupBox1.Controls.Add(postalCodeLabel);
			this.groupBox1.Controls.Add(this.postalCodeTextBox);
			this.groupBox1.Controls.Add(regionLabel);
			this.groupBox1.Controls.Add(this.regionTextBox);
			this.groupBox1.Controls.Add(cityLabel);
			this.groupBox1.Controls.Add(this.cityTextBox);
			this.groupBox1.Controls.Add(addressLabel);
			this.groupBox1.Controls.Add(this.addressTextBox);
			this.groupBox1.Controls.Add(contactTitleLabel);
			this.groupBox1.Controls.Add(this.contactTitleTextBox);
			this.groupBox1.Controls.Add(contactNameLabel);
			this.groupBox1.Controls.Add(this.contactNameTextBox);
			this.groupBox1.Controls.Add(companyNameLabel);
			this.groupBox1.Controls.Add(this.companyNameTextBox);
			this.groupBox1.Controls.Add(customerIDLabel);
			this.groupBox1.Controls.Add(this.customerIDTextBox);
			this.groupBox1.Location = new System.Drawing.Point(15, 72);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(462, 220);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Customer Details";
			// 
			// Deletebutton
			// 
			this.Deletebutton.Location = new System.Drawing.Point(225, 309);
			this.Deletebutton.Name = "Deletebutton";
			this.Deletebutton.Size = new System.Drawing.Size(77, 23);
			this.Deletebutton.TabIndex = 6;
			this.Deletebutton.Text = "Delete";
			this.Deletebutton.UseVisualStyleBackColor = true;
			this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
			// 
			// CustomerEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 346);
			this.Controls.Add(this.Deletebutton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Returnbutton);
			this.Controls.Add(this.Editbutton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.CompanyNamecomboBox);
			this.Controls.Add(this.CustomerIDcomboBox);
			this.Name = "CustomerEditForm";
			this.Text = "EditCustomers";
			this.Load += new System.EventHandler(this.CustomerEditForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.northwindDataSetBindingSource)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox CustomerIDcomboBox;
		private System.Windows.Forms.BindingSource northwindDataSetBindingSource;
		private NorthwindDataSet northwindDataSet;
		private System.Windows.Forms.BindingSource customersBindingSource;
		private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
		private System.Windows.Forms.ComboBox CompanyNamecomboBox;
		private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Button Editbutton;
		private System.Windows.Forms.Button Returnbutton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox customerIDTextBox;
		private System.Windows.Forms.TextBox companyNameTextBox;
		private System.Windows.Forms.TextBox contactNameTextBox;
		private System.Windows.Forms.TextBox contactTitleTextBox;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.TextBox regionTextBox;
		private System.Windows.Forms.TextBox postalCodeTextBox;
		private System.Windows.Forms.TextBox countryTextBox;
		private System.Windows.Forms.TextBox phoneTextBox;
		private System.Windows.Forms.TextBox faxTextBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button Deletebutton;
	}
}