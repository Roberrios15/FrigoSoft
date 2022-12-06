using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    class Almacen
    {
        public int idProducto { get; set; }
        public double cantidadProducto { get; set; }
        public int loteProducto { get; set; }
        public DateTime fechaVencimiento{ get; set; }

        public Almacen(double cantidadProducto,int loteProducto, DateTime fechaVencimiento)
        {
            this.cantidadProducto = cantidadProducto;
            this.loteProducto= loteProducto;
            this.fechaVencimiento = fechaVencimiento;
        }

    }
}
