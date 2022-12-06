using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleProducto
    {
        public Producto Producto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaReg { get; set; }
        public int IdVenta { get; set; }
        public DetalleProducto(decimal cantidad, Producto producto)
        {
            Cantidad = cantidad;
            Producto = producto;
            CalcularTotal();
        }
        public DetalleProducto()
        {

        }

        public void CalcularTotal()
        {
            Total = Producto.PrecioVenta * Cantidad;
        }
    }
}
