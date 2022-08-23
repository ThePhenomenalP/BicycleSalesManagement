using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleSalesManagement
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
            frmLogin frmLog = new frmLogin();            
            frmLog.ShowDialog();
            if (frmLog.access == true)
            {
                Application.Run(new FrmMain2());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
