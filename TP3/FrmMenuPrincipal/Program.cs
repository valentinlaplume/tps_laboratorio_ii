using Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMenuPrincipal
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmMenuPrincipal frmMenuPrincipalnew = new FrmMenuPrincipal();
            frmMenuPrincipalnew.Text = "Menu Principal - VL MOTORS" + " - " + DateTime.Now.ToString("d");
            //Application.Run(new FrmOpenFileDialog());
            Application.Run(frmMenuPrincipalnew);
        }
    }
}
