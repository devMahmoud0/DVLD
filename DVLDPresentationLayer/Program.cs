using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //while (true)
            //{
            //    using (frmLogin login = new frmLogin())
            //    {
            //        if (login.ShowDialog() != DialogResult.OK)
            //            break;
            //    }

            //    frmMain main = new frmMain();
            //    Application.Run(main);

            //    if (!main.IsLogout)
            //        break;
            //}
            //Application.Run(new frmLogin());
            //Application.Run(new frmMain());

            Application.Run(new frmMain());

            //Application.Run(new frmTest());
        }
    }
}
