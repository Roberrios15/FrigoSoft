using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using Entity;
using Microsoft.VisualBasic;

namespace Presentacion
{
    public partial class FormProveedores : Form
    {
        ProveedorService proveedorService;
        public FormProveedores()
        {
            proveedorService = new ProveedorService(ConfigConnection.connectionString);
            InitializeComponent();
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string cerdo = chCerdo.Checked == true ? "Cerdo-" : "";
            string pollo = chPollo.Checked == true ? "Pollo-" : "";
            string res = chRes.Checked == true ? "Res-" : "";
            string embutido = chEmbutidos.Checked == true ? "Embutidos" : "";
            string categoria = cerdo + pollo + res  + embutido;

            Proveedor proveedorMapeado = MapearProveedor(categoria);
            string mensaje = proveedorService.GuardarProveedor(proveedorMapeado);
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cargar();
            Limpiar();
        }

        private void txtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public Proveedor MapearProveedor(string categoria)
        {
            Proveedor proveedor = proveedorService.CrearProveedor();
            proveedor.Nit = txtNit.Text;
            proveedor.Nombre = txtNombre.Text;
            proveedor.Contacto = txtContacto.Text;
            proveedor.Direccion = txtDireccion.Text;
            proveedor.Categoria = categoria;
            proveedor.FechaReg = DateTime.Now;

            return proveedor;
        }

        public void Cargar()
        {
            dtgvProveedores.DataSource = PintarProveedor(proveedorService.Consultar());
        }

        public DataTable PintarProveedor(IList<Proveedor> proveedores)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Nit");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Contacto");
            tabla.Columns.Add("Categoria");
            tabla.Columns.Add("Direccion");

            foreach (var item in proveedores)
            {
                DataRow fila = tabla.NewRow();
                fila["Nit"] = item.Nit;
                fila["Nombre"] = item.Nombre;
                fila["Contacto"] = item.Contacto;
                fila["Categoria"] = item.Categoria;
                fila["Direccion"] = item.Direccion;

                tabla.Rows.Add(fila);
            }

            return tabla;
        }

        public void Limpiar()
        {
            txtNit.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtContacto.Text = "";
            chCerdo.Checked = false;
            chPollo.Checked = false;
            chEmbutidos.Checked = false;
            chRes.Checked = false;
        }
    }
}
