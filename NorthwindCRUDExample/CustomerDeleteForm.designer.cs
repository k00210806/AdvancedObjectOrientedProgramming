namespace NorthwindCRUDExample
{
	partial class CustomerDeleteForm
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.northwindDataSet = new NorthwindCRUDExample.NorthwindDataSet();
			this.customersTableAdapter = new NorthwindCRUDExample.NorthwindDataSetTableAdapters.CustomersTableAdapter();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.faxTextBox = new System.Windows.Forms.TextBox();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.countryTextBox = new System.Windows.Forms.TextBox();
			this.postalCodeTextBox = new System.Windows.Forms.TextBox();
			this.regionTextBox = new System.Windows.Forms.TextBox();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.contactTitleTextBox = new System.Windows.Forms.TextBox();
			this.contactNameTextBox = new System.Windows.Forms.TextBox();
			this.companyNameTextBox = new System.Windows.Forms.TextBox();
			this.customerIDTextBox = new System.Windows.Forms.TextBox();
			this.Deletebutton = new System.Windows.Forms.Button();
			this.Returnbutton = new System.Windows.Forms.Button();
			this.tableAdapterManager = new NorthwindCRUDExample.NorthwindDataSetTableAdapters.TableAdapterManager();
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
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// customerIDLabel
			// 
			customerIDLabel.AutoSize = true;
			customerIDLabel.Location = new System.Drawing.Point(-1, 27);
			customerIDLabel.Name = "customerIDLabel";
			customerIDLabel.Size = new System.Drawing.Size(68, 13);
			customerIDLabel.TabIndex = 0;
			customerIDLabel.Text = "Customer ID:";
			// 
			// companyNameLabel
			// 
			companyNameLabel.AutoSize = true;
			companyNameLabel.Location = new System.Drawing.Point(-3, 53);
			companyNameLabel.Name = "companyNameLabel";
			companyNameLabel.Size = new System.Drawing.Size(85, 13);
			companyNameLabel.TabIndex = 2;
			companyNameLabel.Text = "Company Name:";
			// 
			// contactNameLabel
			// 
			contactNameLabel.AutoSize = true;
			contactNameLabel.Location = new System.Drawing.Point(-1, 79);
			contactNameLabel.Name = "contactNameLabel";
			contactNameLabel.Size = new System.Drawing.Size(78, 13);
			contactNameLabel.TabIndex = 4;
			contactNameLabel.Text = "Contact Name:";
			// 
			// contactTitleLabel
			// 
			contactTitleLabel.AutoSize = true;
			contactTitleLabel.Location = new System.Drawing.Point(-3, 105);
			contactTitleLabel.Name = "contactTitleLabel";
			contactTitleLabel.Size = new System.Drawing.Size(70, 13);
			contactTitleLabel.TabIndex = 6;
			contactTitleLabel.Text = "Contact Title:";
			// 
			// addressLabel
			// 
			addressLabel.AutoSize = true;
			addressLabel.Location = new System.Drawing.Point(249, 25);
			addressLabel.Name = "addressLabel";
			addressLabel.Size = new System.Drawing.Size(48, 13);
			addressLabel.TabIndex = 8;
			addressLabel.Text = "Address:";
			addressLabel.Click += new System.EventHandler(this.AddressLabel_Click);
			// 
			// cityLabel
			// 
			cityLabel.AutoSize = true;
			cityLabel.Location = new System.Drawing.Point(249, 49);
			cityLabel.Name = "cityLabel";
			cityLabel.Size = new System.Drawing.Size(27, 13);
			cityLabel.TabIndex = 10;
			cityLabel.Text = "City:";
			// 
			// regionLabel
			// 
			regionLabel.AutoSize = true;
			regionLabel.Location = new System.Drawing.Point(249, 75);
			regionLabel.Name = "regionLabel";
			regionLabel.Size = new System.Drawing.Size(44, 13);
			regionLabel.TabIndex = 12;
			regionLabel.Text = "Region:";
			// 
			// postalCodeLabel
			// 
			postalCodeLabel.AutoSize = true;
			postalCodeLabel.Location = new System.Drawing.Point(249, 101);
			postalCodeLabel.Name = "postalCodeLabel";
			postalCodeLabel.Size = new System.Drawing.Size(67, 13);
			postalCodeLabel.TabIndex = 14;
			postalCodeLabel.Text = "Postal Code:";
			// 
			// countryLabel
			// 
			countryLabel.AutoSize = true;
			countryLabel.Location = new System.Drawing.Point(251, 127);
			countryLabel.Name = "countryLabel";
			countryLabel.Size = new System.Drawing.Size(46, 13);
			countryLabel.TabIndex = 16;
			countryLabel.Text = "Country:";
			// 
			// phoneLabel
			// 
			phoneLabel.AutoSize = true;
			phoneLabel.Location = new System.Drawing.Point(249, 153);
			phoneLabel.Name = "phoneLabel";
			phoneLabel.Size = new System.Drawing.Size(41, 13);
			phoneLabel.TabIndex = 18;
			phoneLabel.Text = "Phone:";
			phoneLabel.Click += new System.EventHandler(this.PhoneLabel_Click);
			// 
			// faxLabel
			// 
			faxLabel.AutoSize = true;
			faxLabel.Location = new System.Drawing.Point(251, 179);
			faxLabel.Name = "faxLabel";
			faxLabel.Size = new System.Drawing.Size(27, 13);
			faxLabel.TabIndex = 20;
			faxLabel.Text = "Fax:";
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.customersBindingSource;
			this.comboBox1.DisplayMember = "CustomerID";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(29, 26);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(133, 21);
			this.comboBox1.TabIndex = 0;
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
			// customersTableAdapter
			// 
			this.customersTableAdapter.ClearBeforeFill = true;
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
			this.groupBox1.Location = new System.Drawing.Point(29, 83);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(426, 213);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Customer Details";
			this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
			// 
			// faxTextBox
			// 
			this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Fax", true));
			this.faxTextBox.Location = new System.Drawing.Point(320, 176);
			this.faxTextBox.Name = "faxTextBox";
			this.faxTextBox.Size = new System.Drawing.Size(100, 20);
			this.faxTextBox.TabIndex = 21;
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
			this.phoneTextBox.Location = new System.Drawing.Point(320, 150);
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
			this.phoneTextBox.TabIndex = 19;
			// 
			// countryTextBox
			// 
			this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Country", true));
			this.countryTextBox.Location = new System.Drawing.Point(320, 124);
			this.countryTextBox.Name = "countryTextBox";
			this.countryTextBox.Size = new System.Drawing.Size(100, 20);
			this.countryTextBox.TabIndex = 17;
			// 
			// postalCodeTextBox
			// 
			this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PostalCode", true));
			this.postalCodeTextBox.Location = new System.Drawing.Point(320, 98);
			this.postalCodeTextBox.Name = "postalCodeTextBox";
			this.postalCodeTextBox.Size = new System.Drawing.Size(100, 20);
			this.postalCodeTextBox.TabIndex = 15;
			// 
			// regionTextBox
			// 
			this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Region", true));
			this.regionTextBox.Location = new System.Drawing.Point(320, 72);
			this.regionTextBox.Name = "regionTextBox";
			this.regionTextBox.Size = new System.Drawing.Size(100, 20);
			this.regionTextBox.TabIndex = 13;
			// 
			// cityTextBox
			// 
			this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
			this.cityTextBox.Location = new System.Drawing.Point(320, 46);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(100, 20);
			this.cityTextBox.TabIndex = 11;
			// 
			// addressTextBox
			// 
			this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
			this.addressTextBox.Location = new System.Drawing.Point(320, 19);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(100, 20);
			this.addressTextBox.TabIndex = 9;
			// 
			// contactTitleTextBox
			// 
			this.contactTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ContactTitle", true));
			this.contactTitleTextBox.Location = new System.Drawing.Point(88, 102);
			this.contactTitleTextBox.Name = "contactTitleTextBox";
			this.contactTitleTextBox.Size = new System.Drawing.Size(100, 20);
			this.contactTitleTextBox.TabIndex = 7;
			// 
			// contactNameTextBox
			// 
			this.contactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ContactName", true));
			this.contactNameTextBox.Location = new System.Drawing.Point(88, 76);
			this.contactNameTextBox.Name = "contactNameTextBox";
			this.contactNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.contactNameTextBox.TabIndex = 5;
			// 
			// companyNameTextBox
			// 
			this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CompanyName", true));
			this.companyNameTextBox.Location = new System.Drawing.Point(88, 50);
			this.companyNameTextBox.Name = "companyNameTextBox";
			this.companyNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.companyNameTextBox.TabIndex = 3;
			// 
			// customerIDTextBox
			// 
			this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
			this.customerIDTextBox.Location = new System.Drawing.Point(88, 24);
			this.customerIDTextBox.Name = "customerIDTextBox";
			this.customerIDTextBox.Size = new System.Drawing.Size(100, 20);
			this.customerIDTextBox.TabIndex = 1;
			// 
			// Deletebutton
			// 
			this.Deletebutton.Location = new System.Drawing.Point(277, 302);
			this.Deletebutton.Name = "Deletebutton";
			this.Deletebutton.Size = new System.Drawing.Size(77, 23);
			this.Deletebutton.TabIndex = 2;
			this.Deletebutton.Text = "Delete";
			this.Deletebutton.UseVisualStyleBackColor = true;
			this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
			// 
			// Returnbutton
			// 
			this.Returnbutton.Location = new System.Drawing.Point(385, 302);
			this.Returnbutton.Name = "Returnbutton";
			this.Returnbutton.Size = new System.Drawing.Size(70, 23);
			this.Returnbutton.TabIndex = 3;
			this.Returnbutton.Text = "Return";
			this.Returnbutton.UseVisualStyleBackColor = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
			this.tableAdapterManager.UpdateOrder = NorthwindCRUDExample.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// Form7
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Returnbutton);
			this.Controls.Add(this.Deletebutton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.comboBox1);
			this.Name = "Form7";
			this.Text = "DeleteCustomers ";
			this.Load += new System.EventHandler(this.Form7_Load);
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private NorthwindDataSet northwindDataSet;
		private System.Windows.Forms.BindingSource customersBindingSource;
		private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox faxTextBox;
		private System.Windows.Forms.TextBox phoneTextBox;
		private System.Windows.Forms.TextBox countryTextBox;
		private System.Windows.Forms.TextBox postalCodeTextBox;
		private System.Windows.Forms.TextBox regionTextBox;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.TextBox contactTitleTextBox;
		private System.Windows.Forms.TextBox contactNameTextBox;
		private System.Windows.Forms.TextBox companyNameTextBox;
		private System.Windows.Forms.TextBox customerIDTextBox;
		private System.Windows.Forms.Button Deletebutton;
		private System.Windows.Forms.Button Returnbutton;
		private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
	}
}