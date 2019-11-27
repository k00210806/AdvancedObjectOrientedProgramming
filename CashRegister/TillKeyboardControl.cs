using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
	public partial class TillKeyboardControl : UserControl
	{
		public TillKeyboardControl()
		{
			InitializeComponent();
		}
		public CashRegisterForm cashRegisterForm;

		public int EuroAmmount { get; set; }
		public int CentAmmount { get; set; }
		public string EuroAmmountBuilder { get; set; }
		public string CentAmmountBuilder { get; set; }

		private void ClearCashButton_Click(object sender, EventArgs e)
		{
			ResetMoney();
		}

		private void ResetMoney()
		{
			this.cashRegisterForm.ResetTotalText();
		}

		private void N2Button_Click(object sender, EventArgs e)
		{
			this.AppendNumber("2");
		}

		private void AppendNumber(string text)
		{
			this.cashRegisterForm.AppendTotalText(text);

		}

		private void DotButton_Click(object sender, EventArgs e)
		{
			this.AppendNumber(".");
		}

		private void N50Button_Click(object sender, EventArgs e)
		{
			this.AppendNumber("50");
		}

		private void N20Button_Click(object sender, EventArgs e)
		{
			this.AppendNumber("20");
		}

		private void CashButton_Click(object sender, EventArgs e)
		{
			this.cashRegisterForm.CashOut();

		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			this.cashRegisterForm.NextCashOpperation();
		}
	}
}
