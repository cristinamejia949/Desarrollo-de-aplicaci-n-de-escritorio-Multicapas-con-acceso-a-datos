using System;
using System.Windows.Forms;
using Proyecto.Negocio;
using Proyecto.Entidades;

namespace Proyecto.Presentacion
{
    public partial class FrmEmpleados : Form
    {
        private EmpleadoNegocio _empleadoNegocio;

        private Label lblId;
        private Label lblNombre;
        private Label lblCargo;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtCargo;
        private Button btnGuardar;

        public FrmEmpleados(EmpleadoNegocio empleadoNegocio)
        {
            InitializeComponent();
            _empleadoNegocio = empleadoNegocio;
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            this.Text = "Agregar Empleado";
            this.Width = 400;
            this.Height = 300;

            lblId = new Label() { Text = "ID:", Left = 50, Top = 40 };
            lblNombre = new Label() { Text = "Nombre:", Left = 50, Top = 80 };
            lblCargo = new Label() { Text = "Cargo:", Left = 50, Top = 120 };

            txtId = new TextBox() { Left = 150, Top = 40, Width = 150 };
            txtNombre = new TextBox() { Left = 150, Top = 80, Width = 150 };
            txtCargo = new TextBox() { Left = 150, Top = 120, Width = 150 };

            btnGuardar = new Button() { Text = "Guardar", Left = 150, Top = 170, Width = 100 };
            btnGuardar.Click += BtnGuardar_Click;

            this.Controls.Add(lblId);
            this.Controls.Add(lblNombre);
            this.Controls.Add(lblCargo);
            this.Controls.Add(txtId);
            this.Controls.Add(txtNombre);
            this.Controls.Add(txtCargo);
            this.Controls.Add(btnGuardar);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Empleado nuevo = new Empleado()
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Cargo = txtCargo.Text
            };

            MessageBox.Show(_empleadoNegocio.AgregarEmpleado(nuevo));
            this.Close();
        }
    }
}