using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class VentaService
    {
        private IConnectionManager connectionManager;
        private IVentaRepository ventaRepository;
        IList<Venta> ventas;

        public VentaService(string stringConnection)
        {
            connectionManager = new ConnectionManager(stringConnection);
            ventaRepository = new VentaRepository(connectionManager);
            ventas = new List<Venta>();
        }

        public VentaService(IVentaRepository repo, IConnectionManager conn)
        {
            ventaRepository = repo;
            connectionManager = conn;
        }

        public String GuardarVenta(Venta venta)
        {
            try
            {
                connectionManager.Open();
                ventaRepository.GuardarVenta(venta);
                connectionManager.Close();
                return $"Se ha registrado la venta con exito ";
            }
            catch (Exception e)
            {
                return $"Error al guardar los datos de la venta, error  {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public Venta CrearVenta()
        {
            Venta venta = new Venta();
            return venta;
        }

        public IList<Venta> Consultar()
        {
            try
            {
                connectionManager.Open();
                ventas = ventaRepository.Consultar();
                connectionManager.Close();
                return ventas;
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                connectionManager.Close();
            }
        }

    }
}
