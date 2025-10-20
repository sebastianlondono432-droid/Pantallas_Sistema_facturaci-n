using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pantallas_Sistema_Facturación
{
    public partial class Frmlogin : Form
    {
        private Panel lineaUsuario = null!;
        private Panel lineaContrasena = null!;

        public Frmlogin()
        {
            InitializeComponent();
            // Asegúrate de que en el diseñador existan txtUsuario, txtContraseña y btnLogin
            // y que sus eventos Enter/Leave/Click estén asociados a los handlers de abajo.
            PrepararPlaceholders();
            CrearLineas();
            ConfigurarPasswordChar();
        }

        private void PrepararPlaceholders()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.UseSystemPasswordChar = false; // para ver el placeholder
            }
        }

        private void ConfigurarPasswordChar()
        {
            // si ya escribió algo real en contraseña, ocultar caracteres
            if (txtContraseña.Text != "Contraseña")
                txtContraseña.UseSystemPasswordChar = true;
        }

        private void CrearLineas()
        {
            // Línea para txtUsuario
            lineaUsuario = new Panel
            {
                Height = 2,
                Width = txtUsuario.Width,
                BackColor = Color.LightGray,
                Top = txtUsuario.Bottom + 1,
                Left = txtUsuario.Left
            };
            this.Controls.Add(lineaUsuario);

            // Línea para txtContraseña
            lineaContrasena = new Panel
            {
                Height = 2,
                Width = txtContraseña.Width,
                BackColor = Color.LightGray,
                Top = txtContraseña.Bottom + 1,
                Left = txtContraseña.Left
            };
            this.Controls.Add(lineaContrasena);

            // Si el formulario se redimensiona, ajustamos las líneas
            this.Resize += (s, e) =>
            {
                lineaUsuario.Width = txtUsuario.Width;
                lineaUsuario.Top = txtUsuario.Bottom + 1;
                lineaUsuario.Left = txtUsuario.Left;

                lineaContrasena.Width = txtContraseña.Width;
                lineaContrasena.Top = txtContraseña.Bottom + 1;
                lineaContrasena.Left = txtContraseña.Left;
            };
        }

        // ====== EVENTOS ======

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                txtContraseña.UseSystemPasswordChar = false;
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Gray;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = (txtUsuario.Text == "Usuario") ? "" : txtUsuario.Text;
            string contraseña = (txtContraseña.Text == "Contraseña") ? "" : txtContraseña.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Ingrese usuario y contraseña");
                return;
            }

            // Si tu LoginService está desconectado, usa la validación directa
            if (usuario == "admin" && contraseña == "1234")
            {
                MessageBox.Show("¡Bienvenido!");
                this.DialogResult = DialogResult.OK; // <- Esto es CLAVE
                this.Close(); // Cierra el login y activa Program.cs
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
