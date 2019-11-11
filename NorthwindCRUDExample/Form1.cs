using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindCRUDExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UsernametextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {
         
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void OKbutton_Click(object sender, EventArgs e)
		
			{
			
				if (PasswordtextBox.Text == "Moylish")
				{
					MainMenu mainMenu = new MainMenu();
					mainMenu.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Invalid Password");
					PasswordtextBox.Focus();
					PasswordtextBox.SelectAll();
				}
			}
		}
}

		
	

