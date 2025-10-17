using System;
using System.Windows.Forms;
using Proyecto.Entidades;
using Proyecto.Negocio;

namespace Proyecto.Presentacion
{
    public partial class FrmProductos : Form
    {
        private Producto producto;
        private NegocioProductos negocioProductos = new NegocioProductos();

        public FrmProductos()
        {
            InitializeComponent();
            producto = new Producto();
        }

        public FrmProductos(Producto productoExistente)
        {
            InitializeComponent();
            producto = productoExistente;
            CargarDatos();
        }

        private void CargarDatos()
        {
            txtNombre.Text = producto.Nombre;
            txtPrecio.Text = producto.Precio.ToString();
            txtStock.Text = producto.Stock.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            producto.Nombre = txtNombre.Text;

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.");
                return;
            }

            // Validación de números
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) ||
                !int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Precio o Stock no son válidos.");
                return;
            }

            producto.Precio = precio;
            producto.Stock = stock;

            negocioProductos.GuardarProducto(producto);
            MessageBox.Show("Producto guardado correctamente.");
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Label Nombre;
        private Label Precio;
        private Label Stock;
        private TextBox txtNombre;
        private TextBox textstock;
        private TextBox txtPrecio;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}