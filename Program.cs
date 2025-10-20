using Microsoft.VisualBasic.Logging;
using Pantallas_Sistema_Facturación;
using System;
using System.Windows.Forms;

namespace Pantallas_Sistema_Facturación
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar login primero
            Frmlogin login = new Frmlogin();

            // Si el login se cierra con resultado correcto, abrir principal
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmPrincipal());
            }
        }
    }
}
