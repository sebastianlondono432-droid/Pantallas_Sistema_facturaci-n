using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantallas_Sistema_Facturación
{
    public partial class FrmAcercaDe : Form
    {
        public FrmAcercaDe()
        {

            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Acerca De";
            this.BackColor = Color.FromArgb(55, 55, 60);
            Label lbl = new Label
            {
                Text = "Gestión de Acerca De",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(50, 50)
            };
            this.Controls.Add(lbl);
        }
    }
}
