using System;
using System.Windows.Forms;

namespace BankATMForm
{
	static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			//Form1 form1 = new Form1();
			var form1 = new Form1();

			form1.balance = 3456;
			form1.amount = 3456;

			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form1);
        }
    }
}
