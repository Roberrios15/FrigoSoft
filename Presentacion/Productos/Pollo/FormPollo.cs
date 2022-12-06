using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Productos.Pollo
{
    public partial class FormPollo : Form
    {
        private Inicio formInicio;
        private FormProductos formProducto;

        public FormPollo(object inicio, object productos)
        {
            this.formInicio = (Inicio)inicio;
            this.formProducto = (FormProductos)productos;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            formInicio.AbrirFormPanel(this.formProducto);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
