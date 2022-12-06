using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Producto
    {
        public string CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Existencias { get; set; }
        public decimal Libras { get; set; }
        public DateTime FechaReg { get; set; }
        public decimal PrecioCompra { get; set; }
    }
}
