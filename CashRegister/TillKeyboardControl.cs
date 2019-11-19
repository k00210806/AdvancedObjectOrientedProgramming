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
			this.EuroAmmount = 0;
			this.CentAmmount = 0;
		}
	}
}
