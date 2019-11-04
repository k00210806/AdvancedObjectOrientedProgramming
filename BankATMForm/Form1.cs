using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankATMForm
{
    public partial class Form1 : Form
    {
        public int Amount;
        public int PIN;
        public int Balance = 650;
        public int AmountInOut;
        public string Receipt;
        public string CheckBook;
        private DialogResult returnValue;

        public object Interaction { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void SouthWest_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PIN = Convert.ToInt32(txtPIN.Text);
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
                CheckBook = "checkBook will be posted";
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
        private void Cash()
        {
            string info = "Amount to withdrawal";
            MessageBoxIcon icon;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
           Amount = Convert.ToInt32(Interaction.InputBox("Please enter amount to Withdrawal:",
              "Amount to withdrawal"));
            icon = MessageBoxIcon.Information;
            MessageBox.Show(Convert.ToString("Amount to withdrawal: " +
                String.Format("{0:€,0.00}", Amount)), info, buttons, icon);
            if (radCurrentAccount.Checked==true)
            {
                if (Amount < Balance + 200)
                {
                    Balance = Balance - Amount;
                    txtDetails.Text = "PIN: " + PIN.ToString() + "\r\n" +
                        "withdrawal" + "\r\n" + "Balance:" + "\t" + String.Format("{0:€,0.00}", (Balance.ToString())) +
                        "\r\n" + Receipt + "\r\n" + CheckBook;
                }
                else
                {
                    MessageBox.Show("Withdrawal Denied ");
                }
                }
            else if (radCashsave.Checked== true)
            {
                if (Amount < Balance)
                {
                    Balance = Balance - Amount;
                    txtDetails.Text = "PIN: " + PIN.ToString() + "\r\n" + "Withdrawal" +
                        "\r\n" + "Balance: " + "\t" + string.Format("{0:€,0.00}", (Balance.ToString())) + "\r\n" +
                        Receipt + "\r\n" + CheckBook;
                }
                else
                {
                    MessageBox.Show("Withdrawal Denied- Insufficient Funds Available ");
                }
                }
            else
            {
                if (Amount < Balance)
                {
                    Balance = Balance - Amount;
                    txtDetails.Text = "PIN: " + PIN.ToString() + "\r\n" + "Withdrawal" +
                        "\r\n" + "Balance: " + "\t" + string.Format("{0:€,0.00}", (Balance.ToString())) + "\r\n" +
                        Receipt + "\r\n" + CheckBook;
                }
                else
                {
                    MessageBox.Show("Withdrawal Denied- Insufficient Funds Available ");

                }

                }
            }
        private void Lodgement()
        {
            string info = "Amount to Lodge";
            MessageBoxIcon icon;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            Amount = Convert.ToInt32(Interaction.InputBox("Please enter amount to Lodge:", "Amount to lodge"));
            icon = MessageBoxIcon.Information;
            MessageBox.Show(Convert.ToString("Amount to Lodge:" +
                String.Format("{0:€,0.00}", Amount)), info, buttons, icon);
            Balance = Balance - Amount;
            txtDetails.Text = "PIN: " + PIN.ToString() + "\r\n" + "Lodgement" +
                "\r\n" + "Balance: " + "\t" + string.Format("{0:€,0.00}", (Balance.ToString())) + "\r\n" +
                Receipt + "\r\n" + CheckBook;
        }
        private void Enquiry()
        {
            txtDetails.Text = "PIN: " + PIN.ToString() + "\r\n" + "Enquiry"+
                "\r\n" + "Balance: " + "\t" + string.Format("{0:€,0.00}", (Balance.ToString())) + "\r\n" +
                Receipt + "\r\n" + CheckBook;
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            string text = "Are you sure you wnat to end this Program?";
            string caption = "End Dialogues";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult = MessageBox.Show(text, caption, buttons);
            if (returnValue == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            txtPIN.Text = "";
            radCash.Checked = false;
            radLodgment.Checked = false;
            radEnquiry.Checked = false;
            radDepositAmount.Checked = false;
            radCurrentAccount.Checked = false;
            radCashsave.Checked = false;
            checkBoxRecepit.Checked = false;
            checkBoxChequeBook.Checked = false;
            txtDetails.Text = "";
        }
    }

                }
           

        
        

      





