using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly SqlConnection _connection;
        public IList<Proveedor> Proveedores;
        private SqlDataReader Reader;
        Proveedor proveedor;

        public ProveedorRepository(IConnectionManager connection)
        {
            _connection = connection.Connection;
            Proveedores = new List<Proveedor>();
            proveedor = new Proveedor();
        }

        public Proveedor CrearProveedor()
        {
            Proveedor proveedor = new Proveedor();
            return proveedor;
        }

        public void GuardarProveedor(Proveedor proveedor)
        {
            using (var comand = _connection.CreateCommand())
            {
                comand.CommandText = "INSERT INTO Proveedores (Nit,Nombre,Telefono,Direccion,Categoria,FechaReg) values " +
                "(@Nit,@Nombre,@Telefono,@Direccion,@Categoria,@FechaReg)";
                comand.Parameters.AddWithValue("@Nit", proveedor.Nit);
                comand.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                comand.Parameters.AddWithValue("@Telefono", proveedor.Contacto);
                comand.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                comand.Parameters.AddWithValue("@Categoria", proveedor.Categoria);
                comand.Parameters.AddWithValue("@FechaReg", proveedor.FechaReg);               
                comand.ExecuteNonQuery();
            }
            _connection.Close();
        }
        public Proveedor BuscarProveedor(string nit)
        {
            Proveedor proveedor = CrearProveedor();
            using (var comando = _connection.CreateCommand())
            {
                comando.CommandText = "Select * from Proveedores where Nit=@nit";
                comando.Parameters.AddWithValue("@nit", nit);
                Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    proveedor = Mapear(Reader);
                }
            }

            return proveedor;
        }
        public Proveedor BuscarProveedorByNombre(string nombre)
        {
            Proveedor proveedor = CrearProveedor();
            using (var comando = _connection.CreateCommand())
            {
                comando.CommandText = "Select * from Proveedores where Nombre=@nombre";
                comando.Parameters.AddWithValue("@nombre", nombre);
                Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    proveedor = Mapear(Reader);
                }
            }

            return proveedor;
        }
        public Proveedor Mapear(SqlDataReader reader)
        {
            Proveedor proveedor = CrearProveedor();
            proveedor.Nit = (string)reader["Nit"];
            proveedor.Nombre = (string)reader["Nombre"];
            proveedor.Contacto = (string)reader["Telefono"];
            proveedor.Categoria = (string)reader["Categoria"];
            proveedor.Direccion = (string)reader["Direccion"];
            proveedor.FechaReg = (DateTime)reader["FechaReg"];
            

            return proveedor;
        }

        public IList<Proveedor> Consultar()
        {
            Proveedores.Clear();
            using (var comando = _connection.CreateCommand())
            {
                comando.CommandText = "Select * From Proveedores";
                Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    proveedor = Mapear(Reader);
                    Proveedores.Add(proveedor);
                }
            }
            return Proveedores;
        }
    }
}
