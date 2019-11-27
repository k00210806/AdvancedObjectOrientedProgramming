using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
	public partial class CashRegisterForm : Form
	{
		public CashRegisterForm()
		{
			InitializeComponent();
			this.tillKeyboardControl1.cashRegisterForm = this;
		}

		public void AppendTotalText(String text)
		{
			this.cashTextBox.Text += text;
		}

		private void CashRegisterForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
			this.productsTableAdapter.Fill(this.northwindDataSet.Products);

		}

		internal void ResetTotalText()
		{
			this.cashTextBox.Text = string.Empty;
		}

		internal void NextCashOpperation()
		{
			throw new NotImplementedException();
		}

		internal void CashOut()
		{
			double cash = 0, cost = 0, change = 0;
			cost =Convert.ToDouble( totalDueTextBox.Text);
			cash = Convert.ToDouble(cashTextBox.Text);

			
			change = cash - cost;
			this.chanageTextBox.Text = change.ToString();
		}

		private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
