using System.Collections.Generic;
using Entity;

namespace DAL
{
    public interface IProveedorRepository
    {
        void GuardarProveedor(Proveedor proveedor);
        Proveedor BuscarProveedor(string nit);
        Proveedor BuscarProveedorByNombre(string nombre);
        IList<Proveedor> Consultar();
    }
}