using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Productos.Cerdo
{
    public partial class FormCerdo : Form
    {
        private Inicio formInicio;
        private FormProductos formProducto;
        public FormCerdo(object inicio, object productos)
        {
            this.formInicio = (Inicio)inicio;
            this.formProducto = (FormProductos)productos;
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            formInicio.AbrirFormPanel(this.formProducto);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnRetroceso_Click(object sender, EventArgs e)
        {
            formInicio.AbrirFormPanel(this.formProducto);

        }
    }
}
