using System;
using System.Windows.Forms;
using Proyecto.Negocio;

namespace Proyecto.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        // Se crean los controles directamente desde el código
        private Label lblUsuario;
        private Label lblContrasena;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnLogin;

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Login - Sistema Multicapas";
            this.Width = 400;
            this.Height = 250;

            lblUsuario = new Label() { Text = "Usuario:", Left = 50, Top = 40, Width = 80 };
            lblContrasena = new Label() { Text = "Contraseña:", Left = 50, Top = 80, Width = 80 };
            txtUsuario = new TextBox() { Left = 150, Top = 40, Width = 150 };
            txtContrasena = new TextBox() { Left = 150, Top = 80, Width = 150, PasswordChar = '*' };
            btnLogin = new Button() { Text = "Iniciar Sesión", Left = 150, Top = 120, Width = 120 };

            btnLogin.Click += BtnLogin_Click;

            this.Controls.Add(lblUsuario);
            this.Controls.Add(lblContrasena);
            this.Controls.Add(txtUsuario);
            this.Controls.Add(txtContrasena);
            this.Controls.Add(btnLogin);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            bool acceso = usuarioNegocio.ValidarLogin(txtUsuario.Text, txtContrasena.Text);

            if (acceso)
            {
                MessageBox.Show("Bienvenido al sistema", "Acceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmListaEmpleados frm = new FrmListaEmpleados();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
