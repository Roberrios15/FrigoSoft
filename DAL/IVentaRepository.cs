using System.Collections.Generic;
using Entity;

namespace DAL
{
    public interface IVentaRepository
    {
        void GuardarVenta(Venta venta);
        IList<Venta> Consultar();
    }
}