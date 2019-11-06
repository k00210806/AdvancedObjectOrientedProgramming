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
			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			
			
			//Form1 form1 = new Form1();
			var form1 = new Form1();

            Application.Run(form1);
        }
    }
}
