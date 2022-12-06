using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class DetalleProductoService
    {
        private ConnectionManager connectionManager;
        private DetalleProductoRepository detalleProductoRepository;
        IList<DetalleProducto> detalleProductos;

        public DetalleProductoService(string stringConnection)
        {
            connectionManager = new ConnectionManager(stringConnection);
            detalleProductoRepository = new DetalleProductoRepository(connectionManager);
            detalleProductos = new List<DetalleProducto>();
        }

        public String GuardarDetalleProducto(List<DetalleProducto> detalles)
        {
            try
            {
                connectionManager.Open();
                detalleProductoRepository.GuardarDetalles(detalles);
                detalleProductoRepository.ModificarExistencias(detalles);
                connectionManager.Close();
                return $"Se han registrado los detalles con exito";
            }
            catch (Exception e)
            {
                return $"Error al guardar los detalles, error  {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public DetalleProducto CrearDetalleProducto()
        {
            DetalleProducto detalle = new DetalleProducto();
            return detalle;
        }
    }
}
