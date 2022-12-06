using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Presentacion.Productos.Res;
using Presentacion.Compras;
using Presentacion.Ventas;
using Presentacion.Almacen;
using Presentacion.Reportes;
using System.Drawing.Text;

namespace Presentacion
{
    public partial class Inicio : Form
    {
        private PictureBox picturePanelPrincipal;
        public Inicio()
        {
            InitializeComponent();
            this.picturePanelPrincipal = (PictureBox)this.panelPrincipal;
            this.UseWaitCursor = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsg, int wparam, int lparam);


        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 72;
                picturePanelPrincipal.Width = 1299;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestaurar.Visible = true;
            iconMaximizar.Visible = false;
        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestaurar.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormProveedores());
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {
        }
        public void AbrirFormPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;

            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        public void CleanFormPanel()
        {
            if (this.panelContenedor.Controls.Count > 0) {
                this.panelContenedor.Controls.RemoveAt(0);
                this.panelContenedor.Controls.Add(this.picturePanelPrincipal);
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormProductos(this));
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (subMenuReportes.Visible == false)
            {
                subMenuReportes.Visible = true;
            }
            else
            {
                subMenuReportes.Visible = false;
            }
        }

        private void btnReporteCompras_Click(object sender, EventArgs e)
        {
            subMenuReportes.Visible = false;
            AbrirFormPanel(new FormReporteCompras());
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            subMenuReportes.Visible = false;
            AbrirFormPanel(new FormReporteVentas());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormCompras());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormVentas());
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormAlmacen());
        }

        public void mensaje()
        {
            MessageBox.Show("Aqui");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CleanFormPanel();
        }
    }
}
