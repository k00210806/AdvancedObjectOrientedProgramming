namespace CashRegister
{
	partial class CashRegisterForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.QuantityLabel = new System.Windows.Forms.Label();
			this.OKButton = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.northwindDataSet = new CashRegister.NorthwindDataSet();
			this.ProductLabel = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.productsTableAdapter = new CashRegister.NorthwindDataSetTableAdapters.ProductsTableAdapter();
			this.listView1 = new System.Windows.Forms.ListView();
			this.ProductNumbercolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DescriptioncolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.UnitPricecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.QtycolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CostcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DeleteItemLabel = new System.Windows.Forms.Label();
			this.TotalDueLabel = new System.Windows.Forms.Label();
			this.CashLabel = new System.Windows.Forms.Label();
			this.ChangeDueLabel = new System.Windows.Forms.Label();
			this.totalDueTextBox = new System.Windows.Forms.TextBox();
			this.cashTextBox = new System.Windows.Forms.TextBox();
			this.chanageTextBox = new System.Windows.Forms.TextBox();
			this.tillKeyboardControl1 = new CashRegister.TillKeyboardControl();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.QuantityLabel);
			this.panel1.Controls.Add(this.OKButton);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.ProductLabel);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Location = new System.Drawing.Point(52, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(439, 34);
			this.panel1.TabIndex = 0;
			// 
			// QuantityLabel
			// 
			this.QuantityLabel.AutoSize = true;
			this.QuantityLabel.Location = new System.Drawing.Point(274, 3);
			this.QuantityLabel.Name = "QuantityLabel";
			this.QuantityLabel.Size = new System.Drawing.Size(46, 13);
			this.QuantityLabel.TabIndex = 5;
			this.QuantityLabel.Text = "Quantity";
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(397, 4);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(39, 24);
			this.OKButton.TabIndex = 4;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(335, 4);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.DataSource = this.productsBindingSource;
			this.comboBox2.DisplayMember = "ProductName";
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(161, 3);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(97, 21);
			this.comboBox2.TabIndex = 2;
			// 
			// productsBindingSource
			// 
			this.productsBindingSource.DataMember = "Products";
			this.productsBindingSource.DataSource = this.northwindDataSet;
			// 
			// northwindDataSet
			// 
			this.northwindDataSet.DataSetName = "NorthwindDataSet";
			this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ProductLabel
			// 
			this.ProductLabel.AutoSize = true;
			this.ProductLabel.Location = new System.Drawing.Point(3, 3);
			this.ProductLabel.Name = "ProductLabel";
			this.ProductLabel.Size = new System.Drawing.Size(44, 13);
			this.ProductLabel.TabIndex = 1;
			this.ProductLabel.Text = "Product";
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.productsBindingSource;
			this.comboBox1.DisplayMember = "ProductID";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(53, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(93, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// productsTableAdapter
			// 
			this.productsTableAdapter.ClearBeforeFill = true;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductNumbercolumnHeader,
            this.DescriptioncolumnHeader,
            this.UnitPricecolumnHeader,
            this.QtycolumnHeader,
            this.CostcolumnHeader});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(52, 93);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(439, 116);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// ProductNumbercolumnHeader
			// 
			this.ProductNumbercolumnHeader.Text = "Product Number";
			// 
			// DescriptioncolumnHeader
			// 
			this.DescriptioncolumnHeader.Text = "Description";
			// 
			// UnitPricecolumnHeader
			// 
			this.UnitPricecolumnHeader.Text = "Unit Price";
			// 
			// QtycolumnHeader
			// 
			this.QtycolumnHeader.Text = "Qty";
			// 
			// CostcolumnHeader
			// 
			this.CostcolumnHeader.Text = "Cost";
			// 
			// DeleteItemLabel
			// 
			this.DeleteItemLabel.AutoSize = true;
			this.DeleteItemLabel.Location = new System.Drawing.Point(102, 232);
			this.DeleteItemLabel.Name = "DeleteItemLabel";
			this.DeleteItemLabel.Size = new System.Drawing.Size(61, 13);
			this.DeleteItemLabel.TabIndex = 2;
			this.DeleteItemLabel.Text = "Delete Item";
			// 
			// TotalDueLabel
			// 
			this.TotalDueLabel.AutoSize = true;
			this.TotalDueLabel.Location = new System.Drawing.Point(305, 232);
			this.TotalDueLabel.Name = "TotalDueLabel";
			this.TotalDueLabel.Size = new System.Drawing.Size(54, 13);
			this.TotalDueLabel.TabIndex = 3;
			this.TotalDueLabel.Text = "Total Due";
			// 
			// CashLabel
			// 
			this.CashLabel.AutoSize = true;
			this.CashLabel.Location = new System.Drawing.Point(305, 261);
			this.CashLabel.Name = "CashLabel";
			this.CashLabel.Size = new System.Drawing.Size(31, 13);
			this.CashLabel.TabIndex = 4;
			this.CashLabel.Text = "Cash";
			// 
			// ChangeDueLabel
			// 
			this.ChangeDueLabel.AutoSize = true;
			this.ChangeDueLabel.Location = new System.Drawing.Point(305, 290);
			this.ChangeDueLabel.Name = "ChangeDueLabel";
			this.ChangeDueLabel.Size = new System.Drawing.Size(67, 13);
			this.ChangeDueLabel.TabIndex = 5;
			this.ChangeDueLabel.Text = "Change Due";
			// 
			// totalDueTextBox
			// 
			this.totalDueTextBox.Location = new System.Drawing.Point(388, 232);
			this.totalDueTextBox.Name = "totalDueTextBox";
			this.totalDueTextBox.Size = new System.Drawing.Size(103, 20);
			this.totalDueTextBox.TabIndex = 6;
			this.totalDueTextBox.Text = "0";
			// 
			// cashTextBox
			// 
			this.cashTextBox.Location = new System.Drawing.Point(387, 261);
			this.cashTextBox.Name = "cashTextBox";
			this.cashTextBox.Size = new System.Drawing.Size(104, 20);
			this.cashTextBox.TabIndex = 7;
			// 
			// chanageTextBox
			// 
			this.chanageTextBox.Location = new System.Drawing.Point(387, 290);
			this.chanageTextBox.Name = "chanageTextBox";
			this.chanageTextBox.Size = new System.Drawing.Size(104, 20);
			this.chanageTextBox.TabIndex = 8;
			// 
			// tillKeyboardControl1
			// 
			this.tillKeyboardControl1.CentAmmount = 0;
			this.tillKeyboardControl1.CentAmmountBuilder = null;
			this.tillKeyboardControl1.EuroAmmount = 0;
			this.tillKeyboardControl1.EuroAmmountBuilder = null;
			this.tillKeyboardControl1.Location = new System.Drawing.Point(518, 24);
			this.tillKeyboardControl1.Name = "tillKeyboardControl1";
			this.tillKeyboardControl1.Size = new System.Drawing.Size(410, 414);
			this.tillKeyboardControl1.TabIndex = 9;
			// 
			// CashRegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(954, 450);
			this.Controls.Add(this.tillKeyboardControl1);
			this.Controls.Add(this.chanageTextBox);
			this.Controls.Add(this.cashTextBox);
			this.Controls.Add(this.totalDueTextBox);
			this.Controls.Add(this.ChangeDueLabel);
			this.Controls.Add(this.CashLabel);
			this.Controls.Add(this.TotalDueLabel);
			this.Controls.Add(this.DeleteItemLabel);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.panel1);
			this.Name = "CashRegisterForm";
			this.Text = "Cash Register";
			this.Load += new System.EventHandler(this.CashRegisterForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label QuantityLabel;
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label ProductLabel;
		private System.Windows.Forms.ComboBox comboBox1;
		private NorthwindDataSet northwindDataSet;
		private System.Windows.Forms.BindingSource productsBindingSource;
		private NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader ProductNumbercolumnHeader;
		private System.Windows.Forms.ColumnHeader DescriptioncolumnHeader;
		private System.Windows.Forms.ColumnHeader UnitPricecolumnHeader;
		private System.Windows.Forms.ColumnHeader QtycolumnHeader;
		private System.Windows.Forms.ColumnHeader CostcolumnHeader;
		private System.Windows.Forms.Label DeleteItemLabel;
		private System.Windows.Forms.Label TotalDueLabel;
		private System.Windows.Forms.Label CashLabel;
		private System.Windows.Forms.Label ChangeDueLabel;
		private System.Windows.Forms.TextBox totalDueTextBox;
		private System.Windows.Forms.TextBox cashTextBox;
		private System.Windows.Forms.TextBox chanageTextBox;
		private TillKeyboardControl tillKeyboardControl1;
	}
}

