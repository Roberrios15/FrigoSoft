using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Presentacion.Productos;


namespace Presentacion.Productos.Res
{
    public partial class FormRes : Form
    {
        private Inicio formInicio;
        private FormProductos formProducto;

        public FormRes(object inicio, object productos)
        {
            this.formInicio = (Inicio)inicio;
            this.formProducto = (FormProductos)productos;
            InitializeComponent();
        }



        public FormRes()
        {
            InitializeComponent();
        }
        private void FormRes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            formInicio.AbrirFormPanel(this.formProducto);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void lblPagina2_Click(object sender, EventArgs e)
        {
            //formInicio.AbrirFormPanel(new FormRes2());
        }
    }
}
