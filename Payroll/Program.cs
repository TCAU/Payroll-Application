using System;
using System.Windows.Forms;

namespace Payroll
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. Also etting 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Payroll_Application());
        }
    }
}
