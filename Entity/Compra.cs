using System;

namespace Entity
{
    public class Compra
    {
        public int Id { get; set; }
        public string NombreProveedor { get; set; }
        public string NitProveedor{ get; set; }
        public string Categoria { get; set; }
        public decimal Libras { get; set; }
        public decimal Kilos { get; set; }
        public decimal PrecioLibra { get; set; }
        public decimal PrecioKilo { get; set; }
        public string Lote { get; set; }
        public string Producto { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaReg { get; set; }

    }
}
