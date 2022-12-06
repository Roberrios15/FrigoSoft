using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Presentacion.Compras
{
    public partial class FormCompras : Form
    {
        ProveedorService proveedorService;
        ProductoService productoService;
        CompraService compraService;
        string nit = "";
        IList<Proveedor> listProveedores;
        public FormCompras()
        {
            proveedorService = new ProveedorService(ConfigConnection.connectionString);
            compraService = new CompraService(ConfigConnection.connectionString);
            productoService = new ProductoService(ConfigConnection.connectionString);
            listProveedores = new List<Proveedor>();
            InitializeComponent();
            CargarProveedores();
            Cargar();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        public void CargarProveedores()
        {
            listProveedores = proveedorService.Consultar();
            foreach (var item in listProveedores)
            {
                cmbProveedores.Items.Add(item.Nombre);
            }
        }
        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            var proveedor = cmbProveedores.Text;
            Proveedor proveedorBuscado = proveedorService.CrearProveedor();
            proveedorBuscado = proveedorService.BuscarVendedorByNombre(proveedor);
            nit = proveedorBuscado.Nit.Trim();
            cmbCategoria.Items.Clear();
            string[] categorias = proveedorBuscado.Categoria.Split('-');
            foreach (var item in categorias)
            {
                cmbCategoria.Items.Add(item);
            }
        }
        private void txtPrecioLibra_TextChanged(object sender, EventArgs e)
        {
            int libras = string.IsNullOrEmpty(txtLibras.Text) ? 0 : Convert.ToInt32(txtLibras.Text);
            int precio = string.IsNullOrEmpty(txtPrecioLibra.Text) ? 0 : Convert.ToInt32(txtPrecioLibra.Text);
            decimal total = libras * precio;
            txtTotal.Text = total.ToString("C0",CultureInfo.GetCultureInfo("en-US"));
        }

        public Compra MapearCompra()
        {
            Compra compra = compraService.CrearCompra();
            compra.NitProveedor = nit;
            compra.NombreProveedor = cmbProveedores.Text;
            compra.Categoria = cmbCategoria.Text;
            compra.Lote = cmbLote.Text;
            compra.Producto = txtProducto.Text;
            compra.FechaReg = DateTime.Now;
            compra.Libras = Convert.ToInt32(txtLibras.Text);
            compra.Kilos = compra.Libras/2;
            compra.PrecioLibra = Convert.ToInt32(txtPrecioLibra.Text);
            compra.PrecioKilo = compra.PrecioLibra * 2;
            compra.Total = compra.Libras * compra.PrecioLibra;

            return compra;
        }

        public Producto MapearProducto(Compra compra)
        {
            Producto producto = productoService.CrearProducto();

            producto.Categoria = compra.Categoria;
            producto.CodigoProducto = txtCodigoPro.Text;
            producto.Nombre = compra.Producto;
            producto.FechaReg = DateTime.Now;
            producto.Libras = compra.Libras;
            producto.PrecioCompra = compra.PrecioLibra;
            producto.PrecioVenta = compra.PrecioLibra * 0.19m + 100 + compra.PrecioLibra;
            producto.Existencias = compra.Libras;
            return producto;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Compra compra = MapearCompra();
            string mensaje = compraService.GuardarCompra(compra);
            Producto producto = MapearProducto(compra);
            string mensaje1 = productoService.GuardarProducto(producto); 
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cargar();
            Limpiar();
        }

        public DataTable PintarCompra(IList<Compra> compras)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Nit");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Categoria");
            tabla.Columns.Add("Producto");
            tabla.Columns.Add("Libras");
            tabla.Columns.Add("Precio Libra");
            tabla.Columns.Add("Kilos");
            tabla.Columns.Add("Precio Kilo");
            tabla.Columns.Add("Total Compra");

            foreach (var item in compras)
            {
                DataRow fila = tabla.NewRow();
                fila["Nit"] = item.NitProveedor;
                fila["Nombre"] = item.NombreProveedor;
                fila["Categoria"] = item.Categoria;
                fila["Producto"] = item.Producto;
                fila["Libras"] = item.Libras;
                fila["Precio Libra"] = item.PrecioLibra.ToString("C0", CultureInfo.GetCultureInfo("en-US"));
                fila["Kilos"] = item.Kilos;
                fila["Precio Kilo"] = item.PrecioKilo.ToString("C0", CultureInfo.GetCultureInfo("en-US"));
                fila["Total Compra"] = item.Total.ToString("C0", CultureInfo.GetCultureInfo("en-US"));

                tabla.Rows.Add(fila);
            }

            return tabla;
        }

        public void Cargar()
        {
            gridCompras.DataSource = PintarCompra(compraService.Consultar());
        }
        public void Limpiar()
        {
            txtPrecioLibra.Text = "";
            txtLibras.Text = "";
            txtProducto.Text = "";
            txtTotal.Text = "";
            cmbCategoria.Text = "";
            cmbLote.Text = "";
            cmbProveedores.Text = "";
            txtCodigoPro.Text = "";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {

        }
    }
}
