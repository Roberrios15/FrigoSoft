using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CompraService
    {
        private IConnectionManager connectionManager;
        private ICompraRepository compraRepository;
        IList<Compra> compras;

        public CompraService(string stringConnection)
        {
            connectionManager = new ConnectionManager(stringConnection);
            compraRepository = new CompraRepository(connectionManager);
            compras = new List<Compra>();
        }

        public CompraService(ICompraRepository repository, IConnectionManager connectionManager)
        {
            compraRepository = repository;
            this.connectionManager = connectionManager;
            
            compras = new List<Compra>();
        }

        public String GuardarCompra(Compra compra)
        {
            try
            {
                connectionManager.Open();
                compraRepository.GuardarCompra(compra);
                connectionManager.Close();
                return $"Se ha registrado la compra al proveedor {compra.NombreProveedor} con exito ";
            }
            catch (Exception e)
            {
                return $"Error al guardar los datos de la compra, error  {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public Compra CrearCompra()
        {
            Compra compra = new Compra();
            return compra;
        }

        public IList<Compra> Consultar()
        {
            try
            {
                connectionManager.Open();
                compras = compraRepository.Consultar();
                connectionManager.Close();
                return compras;
            }
            catch (Exception)
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
