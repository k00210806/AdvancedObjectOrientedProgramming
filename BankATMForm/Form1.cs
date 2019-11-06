using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace BankATMForm
{
    public partial class Form1 : Form
    {
        public int amount;
        public int PIN;
        public int balance;
        public int AmountInOut;
        public string Receipt;
        public string CheckBook;
        public double withdraw;
        public double lodgment;
        public Form1()
        {
            InitializeComponent();
        }

        public int GetPin()
        {
            return Convert.ToInt32(txtPIN.Text);
        }
        private void SouthWest_Click(object sender, EventArgs e)
        {


        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            PIN = GetPin();

            if (checkBoxRecepit.Checked == true)
            {
                Receipt = "Receipt will be Printed";
            }
            else
            {
                Receipt = "";
            }
            if (checkBoxChequeBook.Checked == true)
            {
                CheckBook = "Cheque Book will be posted";
            }
            else
            {
                CheckBook = "";
            }
            if (radCash.Checked == true)
            {
                Cash();
            }
            else if (radLodgment.Checked == true)
            {
                Lodgement();
            }
            else
            {
                Enquiry();
            }
        }

        private int getAmountToWithdraw()
        {
            withdraw = Convert.ToDouble(Interaction.InputBox("Please enter amount to Withdraw: ", "amount to withdrawal"));
            return Convert.ToInt32(MessageBox.Show("Please enter amount to Withdrawal:",
               "Amount to withdrawal"));

        }
        private void DisplayMessageToUser(int amount)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            string messageBoxCaption = "Amount to withdrawal";
            String messageBoxText = "Amount to withdrawal: " + String.Format("{0:€,0.00}", amount);


            MessageBox.Show(messageBoxText, messageBoxCaption, buttons, icon);
        }
        private void Cash()
        {
            int amount = getAmountToWithdraw();

            DisplayMessageToUser(amount);


            if (currentAccountRadioButton.Checked == true)
            {
                HandleCurrentAccount(amount);
            }
            else if (cashSaveRadioButton.Checked == true)
            {
                HandleSavingsAccount(amount);
            }
            else
            {
                HandleDepositAccount(amount);
            }
        }

        private void HandleDepositAccount(int amount)
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

        private void HandleSavingsAccount(int amount)
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

        private void HandleCurrentAccount(int amount)
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
            txtPIN.Text = String.Empty;
            radCash.Checked = false;
            radEnquiry.Checked = false;
            radDepositAmount.Checked = false;
            currentAccountRadioButton.Checked = false;
            cashSaveRadioButton.Checked = false;
            checkBoxRecepit.Checked = false;
            checkBoxChequeBook.Checked = false;
            radLodgment.Checked = false;
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