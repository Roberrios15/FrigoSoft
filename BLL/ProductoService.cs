using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class ProductoService
    {
        private IConnectionManager connectionManager;
        private IProductoRepository productoRepository;
        IList<Producto> productos;

        public ProductoService(string stringConnection)
        {
            connectionManager = new ConnectionManager(stringConnection);
            productoRepository = new ProductoRepository(connectionManager);
            productos = new List<Producto>();
        }
        
        public ProductoService(IProductoRepository repository, IConnectionManager connectionManager)
        {
            productoRepository = repository;
            this.connectionManager = connectionManager;
            
            productos = new List<Producto>();
        }

        public String GuardarProducto(Producto producto)
        {
            try
            {
                connectionManager.Open();
                Producto productoBuscado = productoRepository.BuscarProducto(producto.CodigoProducto);
                if (productoBuscado.CodigoProducto == null)
                {
                    productoRepository.GuardarProducto(producto);
                    connectionManager.Close();
                    return $"El producto {producto.Nombre} se ha guardado satisfactoriamente. ";
                }
                else
                {
                    productoRepository.ModificarExistencias(producto);
                    connectionManager.Close();
                    return $"Registradas las nuevas cantidades del producto {producto.Nombre} ";
                }


            }
            catch (Exception e)
            {
                return $"Error al guardar el producto, error  {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public Producto CrearProducto()
        {
            Producto producto = new Producto();
            return producto;
        }

        public Producto BuscarProducto(string codigo)
        {
            Producto producto = CrearProducto();
            try
            {
                connectionManager.Open();
                producto = productoRepository.BuscarProducto(codigo);
                connectionManager.Close();
            }
            catch (Exception )
            {
                connectionManager.Close();
            }
            finally
            {
                connectionManager.Close();
            }

            return producto;
        }
    }
}
