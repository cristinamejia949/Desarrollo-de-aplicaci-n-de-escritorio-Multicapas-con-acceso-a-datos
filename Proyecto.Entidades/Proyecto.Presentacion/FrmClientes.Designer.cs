using System;
using System.Windows.Forms;
using Proyecto.Entidades;
using Proyecto.Negocio;

namespace Proyecto.Presentacion
{
    public partial class FrmClientes : Form
    {
        private Cliente cliente;
        private NegocioClientes negocioClientes = new NegocioClientes();

        public FrmClientes()
        {
            InitializeComponent();
            cliente = new Cliente();
        }

        public FrmClientes(Cliente clienteExistente)
        {
            InitializeComponent();
            cliente = clienteExistente;
            CargarDatos();
        }

        private void CargarDatos()
        {
            txtNombre.Text = cliente.Nombre;
            txtCorreo.Text = cliente.Correo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.Nombre = txtNombre.Text;
            cliente.Correo = txtCorreo.Text;

            if (string.IsNullOrWhiteSpace(cliente.Nombre) || string.IsNullOrWhiteSpace(cliente.Correo))
            {
                MessageBox.Show("Debe llenar todos los campos.");
                return;
            }

            negocioClientes.GuardarCliente(cliente);
            MessageBox.Show("Cliente guardado correctamente.");
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}