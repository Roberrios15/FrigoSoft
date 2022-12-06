using Presentacion.Almacen.Lotes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Almacen
{
    public partial class FormAlmacen : Form
    {
        private Inicio formInicio;
        public FormAlmacen(object inicio)
        {
            this.formInicio = (Inicio)inicio;
            InitializeComponent();
        }

        public FormAlmacen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLote1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
