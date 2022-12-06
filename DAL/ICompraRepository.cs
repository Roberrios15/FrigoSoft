using System.Collections.Generic;
using Entity;

namespace DAL
{
    public interface ICompraRepository
    {
        void GuardarCompra(Compra compra);
        IList<Compra> Consultar();
    }
}