using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Proyecto.Negocio;
using Proyecto.Entidades;

namespace Proyecto.Presentacion
{
    public partial class FrmListaProductos : Form
    {
        private NegocioProductos negocioProductos = new NegocioProductos();

        public FrmListaProductos()
        {
            InitializeComponent();
        }

        private void FrmListaProductos_Load(object sender, EventArgs e)
        {
            // Al cargar el formulario, mostramos los productos
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            List<Producto> productos = negocioProductos.ListarProductos();
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ActualizarLista();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto para editar.");
                return;
            }

            Producto productoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;

            FrmProductos frm = new FrmProductos(productoSeleccionado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ActualizarLista();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
                return;
            }

            Producto productoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;

            DialogResult result = MessageBox.Show($"¿Desea eliminar {productoSeleccionado.Nombre}?",
                                                  "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                negocioProductos.EliminarProducto(productoSeleccionado.Id);
                ActualizarLista();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataGridView dataGridView1;
        private DataGridView dgvProductos;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
    }
}