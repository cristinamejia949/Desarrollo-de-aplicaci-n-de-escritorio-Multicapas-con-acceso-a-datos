using System;
using System.Windows.Forms;

namespace Proyecto.Presentacion
{
    public partial class FrmSeguridad : Form
    {
        public FrmSeguridad()
        {
            InitializeComponent();
        }

        private void FrmSeguridad_Load(object sender, EventArgs e)
        {
            this.Text = "Gestión de Seguridad";
            this.Width = 400;
            this.Height = 200;

            Label lbl = new Label()
            {
                Text = "Módulo de seguridad (en desarrollo)",
                AutoSize = true,
                Left = 50,
                Top = 80
            };

            this.Controls.Add(lbl);
        }
    }
}
