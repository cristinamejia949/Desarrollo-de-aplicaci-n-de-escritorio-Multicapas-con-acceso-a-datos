using System;
using System.Windows.Forms;
using Proyecto.Negocio;
using Proyecto.Entidades;

namespace Proyecto.Presentacion
{
    public partial class FrmListaEmpleados : Form
    {
        private EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
        private DataGridView dgvEmpleados;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;

        public FrmListaEmpleados()
        {
            InitializeComponent();
        }

        private void FrmListaEmpleados_Load(object sender, EventArgs e)
        {
            this.Text = "Lista de Empleados";
            this.Width = 600;
            this.Height = 400;

            dgvEmpleados = new DataGridView() { Left = 20, Top = 20, Width = 540, Height = 250 };
            btnAgregar = new Button() { Text = "Agregar", Left = 20, Top = 300 };
            btnActualizar = new Button() { Text = "Actualizar", Left = 120, Top = 300 };
            btnEliminar = new Button() { Text = "Eliminar", Left = 240, Top = 300 };

            btnAgregar.Click += BtnAgregar_Click;
            btnActualizar.Click += BtnActualizar_Click;
            btnEliminar.Click += BtnEliminar_Click;

            this.Controls.Add(dgvEmpleados);
            this.Controls.Add(btnAgregar);
            this.Controls.Add(btnActualizar);
            this.Controls.Add(btnEliminar);

            RefrescarLista();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmEmpleados frm = new FrmEmpleados(empleadoNegocio);
            frm.ShowDialog();
            RefrescarLista();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            RefrescarLista();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow != null)
            {
                int id = (int)dgvEmpleados.CurrentRow.Cells["Id"].Value;
                MessageBox.Show(empleadoNegocio.EliminarEmpleado(id));
                RefrescarLista();
            }
        }

        private void RefrescarLista()
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = empleadoNegocio.ObtenerEmpleados();
        }
    }
}
