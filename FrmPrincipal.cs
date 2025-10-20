using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pantallas_Sistema_Facturación
{
    public partial class FrmPrincipal : Form
    {
        private Panel panelTop, panelLeft, panelContenedor;
        private Label lblTitulo;
        private Button btnPrincipal, btnClientes, btnProductos, btnFacturas, btnEmpleados,
                       btnSeguridad, btnInformes, btnAyuda, btnAcercaDe, btnSalir;

        public FrmPrincipal()
        {
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            // Configuración general
            this.Text = "Sistema de Facturación - COD ADVANCE";
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(45, 45, 48);
            this.FormBorderStyle = FormBorderStyle.None;

            // Panel superior
            panelTop = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50,
                BackColor = Color.FromArgb(28, 28, 28)
            };
            lblTitulo = new Label
            {
                Text = "SISTEMA DE FACTURACIÓN",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 15)
            };
            panelTop.Controls.Add(lblTitulo);
            this.Controls.Add(panelTop);

            // Panel lateral
            panelLeft = new Panel
            {
                Dock = DockStyle.Left,
                Width = 200,
                BackColor = Color.FromArgb(31, 31, 31)
            };
            this.Controls.Add(panelLeft);

            // Panel contenedor
            panelContenedor = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(55, 55, 60)
            };
            this.Controls.Add(panelContenedor);

            // Botones de menú
            btnPrincipal = CrearBoton("Principal");
            btnClientes = CrearBoton("Clientes");
            btnProductos = CrearBoton("Productos");
            btnFacturas = CrearBoton("Facturas");
            btnEmpleados = CrearBoton("Empleados");
            btnSeguridad = CrearBoton("Seguridad");
            btnInformes = CrearBoton("Informes");
            btnAyuda = CrearBoton("Ayuda");
            btnAcercaDe = CrearBoton("Acerca de");
            btnSalir = CrearBoton("Salir");

            // Agregar botones al panel lateral
            int y = 100;
            foreach (Button b in new Button[] {
                btnPrincipal, btnClientes, btnProductos, btnFacturas, btnEmpleados,
                btnSeguridad, btnInformes, btnAyuda, btnAcercaDe, btnSalir
            })
            {
                b.Location = new Point(20, y);
                panelLeft.Controls.Add(b);
                y += 45;
            }

            // Eventos
            btnSalir.Click += (s, e) => Application.Exit();
            btnClientes.Click += (s, e) => AbrirFormulario(new FrmClientes());
            btnProductos.Click += (s, e) => AbrirFormulario(new FrmProductos());
            btnFacturas.Click += (s, e) => AbrirFormulario(new FrmFacturas());
            btnEmpleados.Click += (s, e) => AbrirFormulario(new FrmEmpleados());
            btnSeguridad.Click += (s, e) => AbrirFormulario(new FrmSeguridad());
            btnInformes.Click += (s, e) => AbrirFormulario(new FrmInformes());
            btnAyuda.Click += (s, e) => AbrirFormulario(new FrmAyuda());
            btnAcercaDe.Click += (s, e) => AbrirFormulario(new FrmAcercaDe());
        }

        private Button CrearBoton(string texto)
        {
            Button btn = new Button
            {
                Text = texto,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Width = 160,
                Height = 35,
                TextAlign = ContentAlignment.MiddleLeft,
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            return btn;
        }

        private void AbrirFormulario(Form formHijo)
        {
            // Limpiar cualquier control previo
            panelContenedor.Controls.Clear();

            // Configurar el nuevo formulario hijo
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            // Agregar el formulario al contenedor
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;

            // Mostrar el formulario y traerlo al frente
            formHijo.BringToFront();
            formHijo.Show();
        }
       
        }
}

