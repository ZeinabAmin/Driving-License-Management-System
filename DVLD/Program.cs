using System;
using DVLD.Login;
using System.Windows.Forms;


namespace DVLD
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
          // System.Windows.Forms.Application.Run(new frmMain());
           // System.Windows.Forms.Application.Run(new frmTest2());
           System.Windows.Forms.Application.Run(new frmLogin());
        }
    }
}
