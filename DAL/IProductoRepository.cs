using Entity;

namespace DAL
{
    public interface IProductoRepository
    {
        void GuardarProducto(Producto producto);
        Producto BuscarProducto(string codigoProducto);

        void ModificarExistencias(Producto producto);
    }
}