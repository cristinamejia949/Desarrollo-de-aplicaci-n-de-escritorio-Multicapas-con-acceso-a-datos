using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Proyecto.Negocio;
using Proyecto.Entidades;

namespace Proyecto.Presentacion
{
    public partial class FrmListaClientes : Form
    {
        private NegocioClientes negocioClientes = new NegocioClientes();

        public FrmListaClientes()
        {
            InitializeComponent();
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            // Cuando el formulario carga, se muestran los clientes
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            List<Cliente> clientes = negocioClientes.ListarClientes();
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientes;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ActualizarLista();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para editar.");
                return;
            }

            Cliente clienteSeleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

            FrmClientes frm = new FrmClientes(clienteSeleccionado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ActualizarLista();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
                return;
            }

            Cliente clienteSeleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

            DialogResult result = MessageBox.Show($"¿Desea eliminar a {clienteSeleccionado.Nombre}?",
                                                  "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                negocioClientes.EliminarCliente(clienteSeleccionado.Id);
                ActualizarLista();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataGridView dgvClientes;
        private DataGridView dataGridView2;
        private Button btnNuevo;
        private Button Editar;
        private Button btnEliminar;
        private Button btnSalir;
    }
}