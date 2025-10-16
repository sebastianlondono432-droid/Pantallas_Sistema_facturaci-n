namespace Pantallas_Sistema_facturación
{
    partial class Frmlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlogin));
            buttonlogin = new Button();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            labelLogin = new Label();
            linkLabel1 = new LinkLabel();
            btncerrar = new PictureBox();
            btnminimizar = new PictureBox();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            SuspendLayout();
            // 
            // buttonlogin
            // 
            buttonlogin.BackColor = SystemColors.WindowFrame;
            buttonlogin.FlatStyle = FlatStyle.Flat;
            buttonlogin.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonlogin.ForeColor = SystemColors.ActiveCaptionText;
            buttonlogin.Location = new Point(356, 264);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Size = new Size(418, 42);
            buttonlogin.TabIndex = 1;
            buttonlogin.Text = "Acceder";
            buttonlogin.UseVisualStyleBackColor = false;
            buttonlogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.login_logo_user_users_group_customer_education_button_typeface_credential_png_clipart_removebg_preview;
            pictureBox1.Location = new Point(3, 343);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 0);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DodgerBlue;
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(242, 391);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(238, 334);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // labelLogin
            // 
            labelLogin.FlatStyle = FlatStyle.Flat;
            labelLogin.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLogin.Location = new Point(356, 9);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(418, 50);
            labelLogin.TabIndex = 3;
            labelLogin.Text = "Login";
            labelLogin.TextAlign = ContentAlignment.TopCenter;
            labelLogin.Click += label2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = SystemColors.ActiveCaptionText;
            linkLabel1.LinkColor = SystemColors.ActiveCaptionText;
            linkLabel1.Location = new Point(458, 323);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(216, 30);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Olvidaste tu contraseña ?";
            // 
            // btncerrar
            // 
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(748, 0);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(52, 28);
            btncerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btncerrar.TabIndex = 6;
            btncerrar.TabStop = false;
            // 
            // btnminimizar
            // 
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(703, -13);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(49, 54);
            btnminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizar.TabIndex = 7;
            btnminimizar.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.WindowFrame;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(356, 109);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(296, 27);
            txtUsuario.TabIndex = 8;
            txtUsuario.Text = "Usuario";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.WindowFrame;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(356, 169);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(296, 27);
            txtContraseña.TabIndex = 10;
            txtContraseña.Text = "Contraseña";
            // 
            // Frmlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 391);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(btnminimizar);
            Controls.Add(btncerrar);
            Controls.Add(linkLabel1);
            Controls.Add(buttonlogin);
            Controls.Add(labelLogin);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frmlogin";
            Opacity = 0.85D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonlogin;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox2;
        private Label labelLogin;
        private LinkLabel linkLabel1;
        private PictureBox btncerrar;
        private PictureBox btnminimizar;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
    }
}
