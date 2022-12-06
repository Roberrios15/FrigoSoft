using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public decimal TotalVenta{ get; set; }
        public DateTime FechaVenta{ get; set; }

        public List<DetalleProducto> detalleProductos = new List<DetalleProducto>();
        public void AgregarCarrito(decimal cantidad, Producto producto)
        {
            DetalleProducto detalleProducto = new DetalleProducto(cantidad, producto);
            detalleProductos.Add(detalleProducto);
        }
        public void QuitarDetalles(string codigo)
        {
            DetalleProducto detalle = detalleProductos.Find(d => d.Producto.CodigoProducto.Trim() == codigo.Trim());
            detalleProductos.Remove(detalle);

        }
        public void CalcularVenta()
        {
            TotalVenta = detalleProductos.Sum(s => s.Total);

        }
    }
}
