using System.Windows.Forms;
using System.Drawing;
namespace Pantallas_Sistema_facturación
{
    public partial class Frmlogin : Form
    {
        private Panel lineaUsuario;
        private Panel lineaContraseña;
        public Frmlogin()
        {
            InitializeComponent();
            CrearLineas();
        }
        private void CrearLineas()
        {
            // Línea para txtUsuario
            lineaUsuario = new Panel();
            lineaUsuario.Height = 2; // altura de la línea
            lineaUsuario.Width = txtUsuario.Width;
            lineaUsuario.BackColor = Color.LightGray;
            lineaUsuario.Top = txtUsuario.Bottom + 1; // justo debajo del TextBox
            lineaUsuario.Left = txtUsuario.Left;

            this.Controls.Add(lineaUsuario);

            // Línea para txtContraseña
            lineaContraseña = new Panel();
            lineaContraseña.Height = 2; // altura de la línea
            lineaContraseña.Width = txtContraseña.Width;
            lineaContraseña.BackColor = Color.LightGray;
            lineaContraseña.Top = txtContraseña.Bottom + 1; // justo debajo del TextBox
            lineaContraseña.Left = txtContraseña.Left;

            this.Controls.Add(lineaContraseña);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Ingrese usuario y contraseña");
                return;
            }

            LoginService loginService = new LoginService();

            if (loginService.ValidarUsuario(usuario, contraseña))
            {
                MessageBox.Show("¡Bienvenido!");
                // Por ahora no abrimos FrmPrincipal, solo mostramos mensaje
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}