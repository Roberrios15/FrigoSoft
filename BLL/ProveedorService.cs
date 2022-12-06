using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProveedorService
    {
        private IConnectionManager connectionManager;
        private IProveedorRepository proveedorRepository;
        IList<Proveedor> proveedores;

        public ProveedorService(string stringConnection)
        {
            connectionManager = new ConnectionManager(stringConnection);
            proveedorRepository = new ProveedorRepository(connectionManager);
            proveedores = new List<Proveedor>();
        }

        public ProveedorService(IProveedorRepository repository, IConnectionManager connectionManager)
        {
            this.connectionManager = connectionManager;
            proveedorRepository = repository;
            proveedores = new List<Proveedor>();
        }

        public String GuardarProveedor(Proveedor proveedor)
        {
            try
            {
                connectionManager.Open();
                Proveedor proveedorBuscado = proveedorRepository.BuscarProveedor(proveedor.Nit.Trim());
                if (proveedorBuscado.Nit == null)
                {
                    proveedorRepository.GuardarProveedor(proveedor);
                    connectionManager.Close();
                    return $"Los Datos del proveedor {proveedor.Nombre} se han guardado satisfactoriamente ";
                }
                else
                {
                    return $"El proveedor {proveedor.Nombre} ya esta registrado ";
                }
            }
            catch (Exception e)
            {
                return $"Error al guardar el proveedor, error  {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public Proveedor CrearProveedor()
        {
            Proveedor proveedor = new Proveedor();
            return proveedor;
        }

        public IList<Proveedor> Consultar()
        {
            try
            {
                connectionManager.Open();
                proveedores = proveedorRepository.Consultar();
                connectionManager.Close();
                return proveedores;
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

        public Proveedor BuscarVendedorByNombre(string nombre)
        {
            Proveedor proveedor = CrearProveedor();
            try
            {
                connectionManager.Open();
                proveedor = proveedorRepository.BuscarProveedorByNombre(nombre);                
                connectionManager.Close();
            }
            catch (Exception)
            {
                connectionManager.Close();
            }
            finally
            {
                connectionManager.Close();
            }

            return proveedor;
        }
    }
}
