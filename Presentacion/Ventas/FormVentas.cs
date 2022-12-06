using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Entity;
using Microsoft.VisualBasic;

namespace Presentacion.Ventas
{
    public partial class FormVentas : Form
    {
        Producto producto;
        ProductoService ProductoService;
        VentaService VentaService;
        DetalleProductoService DetalleProductoService;
        Venta venta;
        const decimal f = 0m;
        DetalleProducto detalleProducto;
        public FormVentas()
        {
            ProductoService = new ProductoService(ConfigConnection.connectionString);
            VentaService = new VentaService(ConfigConnection.connectionString);
            DetalleProductoService = new DetalleProductoService(ConfigConnection.connectionString);
            InitializeComponent();
            producto = new Producto();
            venta = new Venta();
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtLibras.Enabled = false;
            btnAddCart.Enabled = false;
        }
        private void txtBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
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
        private void btnVender_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBosEfectivo.Text))
            {
                string efectivoS = txtBosEfectivo.Text.Replace("$", "").Replace(",", "");
                decimal efectivo = string.IsNullOrEmpty(efectivoS) ? 0 : Convert.ToDecimal(efectivoS);
                string devolucionS = labelDevolucion.Text.Replace("$", "").Replace(",", "");
                decimal devolucion = string.IsNullOrEmpty(devolucionS) ? 0 : Convert.ToDecimal(devolucionS);
                if (devolucion >= 0)
                {
                    Venta ventaP = MapearVenta();
                    List<DetalleProducto> detalles = MapearDetalles(ventaP);
                    string mensaje = DetalleProductoService.GuardarDetalleProducto(detalles);
                    if (mensaje.Trim() == "Se han registrado los detalles con exito")
                    {
                        string mensaje2 = VentaService.GuardarVenta(ventaP);
                        MessageBox.Show(mensaje2, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTodo();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Efectivo insuficiente para realizar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay efectivo para realizar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoPro.Text))
            {
                MessageBox.Show("Digite un codigo de producto a buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                producto = ProductoService.BuscarProducto(txtCodigoPro.Text.Trim());
                if (producto.CodigoProducto == null)
                {
                    MessageBox.Show("Codigo de producto no se encontro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigoPro.Text = "";
                    txtProducto.Text = "";
                    txtPrecioLibra.Text = "";
                    txtExistencias.Text = "";
                }
                else
                {
                    txtProducto.Text = producto.Nombre.Trim();
                    txtPrecioLibra.Text = producto.PrecioVenta.ToString("C0", CultureInfo.GetCultureInfo("en-US"));
                    txtExistencias.Text = producto.Existencias.ToString();
                    txtLibras.Enabled = true;
                }
            }
        }
        private void txtLibras_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtExistencias.Text))
            {
                var a = txtLibras.Text.Contains(".") ? txtLibras.Text.Replace(".", ",") : txtLibras.Text;
                decimal libras = string.IsNullOrEmpty(a) ? 0 : Convert.ToDecimal(a);
                decimal existencias = Convert.ToDecimal(txtExistencias.Text);

                if (string.IsNullOrEmpty(txtLibras.Text))
                {
                    txtExistencias.BackColor = Color.White;
                }
                else
                {
                    if (libras > existencias)
                    {
                        txtExistencias.BackColor = Color.FromArgb(200, 6, 7);
                        txtExistencias.ForeColor = Color.White;
                        btnAddCart.Enabled = false;
                    }
                    else
                    {
                        txtExistencias.BackColor = Color.White;
                        btnAddCart.Enabled = true;
                        var c = libras * Convert.ToDecimal(producto.PrecioVenta);
                        txtValor.Text = string.Format(new CultureInfo("en-US"), "{0:C0}", c);
                        btnAddCart.Enabled = true;
                    }
                }
            }
            
        }
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            var a = txtLibras.Text.Contains(".") ? txtLibras.Text.Replace(".", ",") : txtLibras.Text;
            decimal cantidad = string.IsNullOrEmpty(a) ? 0 : Convert.ToDecimal(a);
            detalleProducto = new DetalleProducto(cantidad, producto);
            if (venta.detalleProductos.Any(c => c.Producto.CodigoProducto == detalleProducto.Producto.CodigoProducto))
            {
                MessageBox.Show("Producto ya agregado al carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                venta.AgregarCarrito(cantidad, producto);
            }
            gridDetalles.DataSource = PintarDetalles(venta.detalleProductos);
            labelTotal.Text = venta.detalleProductos.Sum(c => c.Total).ToString("C0", CultureInfo.GetCultureInfo("en-US"));
            Limpiar();
        }
        public DataTable PintarDetalles(List<DetalleProducto> detalleProductos)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Codigo");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Categoria");
            tabla.Columns.Add("Cantidad");
            tabla.Columns.Add("Total");

            foreach (var item in detalleProductos)
            {

                DataRow fila = tabla.NewRow();
                fila["Codigo"] = item.Producto.CodigoProducto;
                fila["Nombre"] = item.Producto.Nombre;
                fila["Categoria"] = item.Producto.Categoria;
                fila["Cantidad"] = item.Cantidad;
                fila["Total"] = string.Format(new CultureInfo("en-US"), "{0:C0}", item.Total);
                tabla.Rows.Add(fila);
            }

            return tabla;
        }
        private void btnRemoveCart_Click(object sender, EventArgs e)
        {
            DetalleProducto detalle = new DetalleProducto();
            string mensaje, titulo, defecto;
            object valor;
            mensaje = "Digite el codigo del producto a quitar del carrito";
            titulo = "Eliminar Del Carrito";
            defecto = "Ingrese aqui el Codigo del producto";
            valor = Interaction.InputBox(mensaje, titulo, defecto);

            if ((string)valor != "")
            {
                detalle = venta.detalleProductos.Where(c => c.Producto.CodigoProducto.Trim() == (string)valor).FirstOrDefault();
                if (detalle == null)
                {
                    MessageBox.Show("Producto no encontrado en el carrito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    venta.QuitarDetalles(valor.ToString());
                    gridDetalles.DataSource = PintarDetalles(venta.detalleProductos);
                    labelTotal.Text = venta.detalleProductos.Sum(c => c.Total).ToString("C0", CultureInfo.GetCultureInfo("en-US"));
                    MessageBox.Show("Producto removido del carrito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        public void Limpiar()
        {
            txtCodigoPro.Text = string.Empty;
            txtExistencias.Text = string.Empty;
            txtLibras.Text = string.Empty;
            txtPrecioLibra.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtLibras.Enabled = false;
            btnAddCart.Enabled = false;
        }
        public void LimpiarTodo()
        {
            txtCodigoPro.Text = string.Empty;
            txtExistencias.Text = string.Empty;
            txtLibras.Text = string.Empty;
            txtPrecioLibra.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtLibras.Enabled = false;
            btnAddCart.Enabled = false;
            labelDevolucion.Text = string.Empty;
            labelTotal.Text = string.Empty;
            gridDetalles.DataSource = 0;
            txtBosEfectivo.Text = string.Empty;
        }
        private void txtBosEfectivo_TextChanged(object sender, EventArgs e)
        {
            var usCulture = CultureInfo.CreateSpecificCulture("en-US");
            var clonedNumbers = (NumberFormatInfo)usCulture.NumberFormat.Clone();
            clonedNumbers.CurrencyNegativePattern = 2;
            string formatted = string.Format(clonedNumbers, "{0:C2}", -1234);
            string efectivoS = txtBosEfectivo.Text.Replace("$", "").Replace(",", "");
            decimal efectivo = string.IsNullOrEmpty(efectivoS) ? 0 : Convert.ToDecimal(efectivoS);
            string totalS = labelTotal.Text.Replace("$", "").Replace(",","");
            decimal total = string.IsNullOrEmpty(totalS) ? 0 : Convert.ToDecimal(totalS);

            decimal devueltas = efectivo - total;
            

            labelDevolucion.Text = string.Format(clonedNumbers,"{0:C0}",devueltas);

            txtBosEfectivo.Text = efectivo.ToString("C0", CultureInfo.GetCultureInfo("en-US"));
            txtBosEfectivo.SelectionStart = txtBosEfectivo.Text.Length;
        }
        public Venta MapearVenta()
        {
            string totalS = labelTotal.Text.Replace("$", "").Replace(",", "");
            decimal total = string.IsNullOrEmpty(totalS) ? 0 : Convert.ToDecimal(totalS);
            Venta ventaM = VentaService.CrearVenta();
            ventaM.FechaVenta = DateTime.Now;
            ventaM.TotalVenta = total;
            ventaM.IdVenta = Convert.ToInt32(DateTime.Now.Year + "" + ventaM.TotalVenta);
            ventaM.detalleProductos = venta.detalleProductos;

            return ventaM;
        }

        public List<DetalleProducto> MapearDetalles(Venta venta)
        {
            List<DetalleProducto> detalles = new List<DetalleProducto>();
            
            foreach (var item in venta.detalleProductos)
            {
                DetalleProducto detalleProducto = DetalleProductoService.CrearDetalleProducto();
                detalleProducto.Producto = ProductoService.CrearProducto();
                detalleProducto.IdVenta = venta.IdVenta;
                detalleProducto.Cantidad = item.Cantidad;
                detalleProducto.Total = item.Total;
                detalleProducto.Producto.Categoria = item.Producto.Categoria;
                detalleProducto.Producto.Nombre = item.Producto.Nombre;
                detalleProducto.Producto.CodigoProducto = item.Producto.CodigoProducto;
                detalleProducto.FechaReg = DateTime.Now;

                detalles.Add(detalleProducto);
            }

            return detalles;
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
