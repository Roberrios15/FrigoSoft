using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class DetalleFactura
    {
        public int idProducto { get; set; }
        public int idFactura{ get; set; }
        public double cantidad { get; set; }
        public double valorUnitario { get; set; }
        public double valorTotal { get; set; }

        public DetalleFactura(int idProducto, int idFactura, double cantidad, double valorUnitario, double valorTotal)
        {
            this.idProducto = idProducto;
            this.idFactura = idFactura;
            this.cantidad = cantidad;
            this.valorUnitario = valorUnitario;
            this.valorTotal = valorTotal;
        }
    }
}
