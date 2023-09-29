using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payrollManagementSystem_G4
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

            frmLogin loginStart = new frmLogin();
            loginStart.Show();

            Application.Run();

            //Application.Run(new ApplicationContext() { MainForm = loginStart });
        }

        

    }
}
