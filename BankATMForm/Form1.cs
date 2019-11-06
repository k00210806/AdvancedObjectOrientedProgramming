using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace BankATMForm
{
	public partial class Form1 : Form
	{
		private int amount;
		private int PIN;
		private double balance;
		private int AmountInOut;
		private double withdraw;
		private double lodgment;

		//
		//	Output Window
		//
		public string Receipt;
		public string CheckBook;
		public Form1()
		{
			InitializeComponent();
		}

		public int GetPin()
		{
			return Convert.ToInt32(pinTextBox.Text);
		}
		private void SouthWest_Click(object sender, EventArgs e)
		{


		}

		private void ProceedButton_Click(object sender, EventArgs e)
		{
			PIN = GetPin();

			//
			//	recepitRequest
			//
			HandleReceiptRequest();

			HandleChequeBookRequest();

			if (cashWithdrawalServiceRadioButton.Checked == true)
			{
				CashWithdrawal();
			}
			else if (lodgmentServiceRadioButton.Checked == true)
			{
				Lodgement();
			}
			else
			{
				Enquiry();
			}
		}

		private void HandleChequeBookRequest()
		{
			//
			//	chequeBookRequest
			//
			if (chequeBookRequestCheckBox.Checked == true)
			{
				CheckBook = "Cheque Book will be posted";
			}
			else
			{
				CheckBook = "";
			}
		}

		private void HandleReceiptRequest()
		{
			if (recepitRequestCheckBox.Checked == true)
			{
				Receipt = "Receipt will be Printed";
			}
			else
			{
				Receipt = "";
			}
		}

		private double getAmountToWithdraw()
		{
			String prompt = "Please enter amount to Withdraw:";
			String title = "amount to withdrawal";

			return Convert.ToDouble(Interaction.InputBox(prompt, title));
		}
		private void DisplayMessageToUser(double amount)
		{
			MessageBoxButtons buttons = MessageBoxButtons.OK;
			MessageBoxIcon icon = MessageBoxIcon.Information;
			string messageBoxCaption = "Amount to withdraw";
			String messageBoxText = "Amount to withdraw: " + String.Format("{0:€,0.00}", amount);


			MessageBox.Show(messageBoxText, messageBoxCaption, buttons, icon);
		}
		private void CashWithdrawal()
		{
			//
			//  "If a withdrawal is requested an input box is displayed and the amount of the withdrawal keyed in (Figure b)."
			//
			withdraw = getAmountToWithdraw();

			DisplayMessageToUser(withdraw);

			if (currentAccountTypeRadioButton.Checked)
			{
				HandleCurrentAccount(withdraw);
			}
			else if (cashsaverAccountTypeRadioButton.Checked == true || depositAccountTypeRadioButton.Checked == true)
			{
				HandleAccount(withdraw);
			}
			else
			{
				// Tell the user to pick an accunt type;
			}
		}

		private void HandleAccount(double amount)
		{
			if (amount < balance)
			{
				balance = balance - amount;
				detailsTextBox.Text = "PIN: " + PIN.ToString() + "\r\n" + "Withdrawal" +
					"\r\n" + "Balance: " + "\t" + string.Format("{0:€,0.00}", (balance.ToString())) + "\r\n" +
					Receipt + "\r\n" + CheckBook;
			}
			else
			{
				MessageBox.Show("Withdrawal Denied- Insufficient Funds Available ");
			}
		}

		private void HandleCurrentAccount(double amount)
		{
			if (amount < balance + 200)
			{
				balance = balance - amount;
				detailsTextBox.Text = "PIN: " + PIN.ToString() + "\r\n" +
					"withdrawal" + "\r\n" + "Balance:" + "\t" + String.Format("{0:€,0.00}", (balance.ToString())) +
					"\r\n" + Receipt + "\r\n" + CheckBook;
			}
			else
			{
				MessageBox.Show("Withdrawal Denied ");
			}
		}

		private void Lodgement()
		{
			string info = "Amount to Lodge";
			MessageBoxIcon icon;
			MessageBoxButtons buttons = MessageBoxButtons.OK;
			lodgment = Convert.ToDouble(Interaction.InputBox("Please enter amount to lodge:", "amount"));

			icon = MessageBoxIcon.Information;

			MessageBox.Show(Convert.ToString("Amount to Lodge:" +
				String.Format("{0:€,0.00}", amount)), info, buttons, icon);

			balance = balance - amount;
			detailsTextBox.Text = "PIN: " + PIN.ToString() + "\r\n" + "Lodgement" +
				"\r\n" + "Balance: " + "\t" + string.Format("{0:€,0.00}", (balance.ToString())) + "\r\n" +
				Receipt + "\r\n" + CheckBook;
		}
		private void Enquiry()
		{
			detailsTextBox.Text = "PIN: " + PIN.ToString() + "\r\n" + "Enquiry" +
				"\r\n" + "Balance: " + "\t" + string.Format("{0:€,0.00}", (balance.ToString())) + "\r\n" +
				Receipt + "\r\n" + CheckBook;

		}
		private void BtnEnd_Click(object sender, EventArgs e)
		{
			string text = "Are you sure you want to end this Program?";
			string caption = "End Dialogues";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult dialogResult = MessageBox.Show(text, caption, buttons);
			if (dialogResult == DialogResult.Yes)
			{
				Close();
				///Application.Exit();
			}
		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			ResetFormToDefault();
		}

		private void ResetFormToDefault()
		{
			pinTextBox.Text = String.Empty;
			cashWithdrawalServiceRadioButton.Checked = false;
			accountEnquiryServiceRadioButton.Checked = false;
			depositAccountTypeRadioButton.Checked = false;
			currentAccountTypeRadioButton.Checked = false;
			cashsaverAccountTypeRadioButton.Checked = false;
			recepitRequestCheckBox.Checked = false;
			chequeBookRequestCheckBox.Checked = false;
			lodgmentServiceRadioButton.Checked = false;
			detailsTextBox.Text = String.Empty;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void TxtPIN_TextChanged(object sender, EventArgs e)
		{

		}
	}

}