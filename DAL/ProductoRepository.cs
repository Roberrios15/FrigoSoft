using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly SqlConnection _connection;
        public IList<Producto> Productos;
        private SqlDataReader Reader;
        Producto producto;

        public ProductoRepository(IConnectionManager connection)
        {
            _connection = connection.Connection;
            Productos = new List<Producto>();
            producto = new Producto();
        }

        public Producto CrearProducto()
        {
            Producto producto = new Producto();
            return producto;
        }

        public void GuardarProducto(Producto producto)
        {
            using (var comand = _connection.CreateCommand())
            {
                comand.CommandText = "INSERT INTO Productos (CodigoProducto,Nombre,Categoria,PrecioVenta,Existencias,Libras,FechaReg,PrecioCompra) values " +
                "(@CodigoProducto,@Nombre,@Categoria,@PrecioVenta,@Existencias,@Libras,@FechaReg,@PrecioCompra)";
                comand.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                comand.Parameters.AddWithValue("@Nombre", producto.Nombre);
                comand.Parameters.AddWithValue("@Categoria", producto.Categoria);
                comand.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                comand.Parameters.AddWithValue("@Existencias", producto.Existencias);
                comand.Parameters.AddWithValue("@Libras", producto.Libras);
                comand.Parameters.AddWithValue("@FechaReg", producto.FechaReg);
                comand.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
                comand.ExecuteNonQuery();
            }
            _connection.Close();
        }

        public void ModificarExistencias(Producto producto)
        {
            using (var comando = _connection.CreateCommand())
            {
                Producto productoBuscado = BuscarProducto(producto.CodigoProducto.Trim());
                decimal existenciasTotales = producto.Existencias + productoBuscado.Existencias; ;
                comando.CommandText = "Update Productos set Existencias=@Existencias where CodigoProducto=@CodigoProducto";
                comando.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                comando.Parameters.AddWithValue("@Existencias", existenciasTotales);
                comando.ExecuteNonQuery();
            }
            _connection.Close();
        }

        public Producto BuscarProducto(string codigoProducto)
        {
            Producto producto = CrearProducto();
            using (var comando = _connection.CreateCommand())
            {
                comando.CommandText = "Select * from Productos where CodigoProducto=@codigoProducto";
                comando.Parameters.AddWithValue("@codigoProducto", codigoProducto);
                Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    producto = Mapear(Reader);
                }
            }

            return producto;
        }

        private Producto Mapear(SqlDataReader reader)
        {
            Producto producto = CrearProducto();
            producto.CodigoProducto = (string)reader["CodigoProducto"];
            producto.Nombre = (string)reader["Nombre"];
            producto.Categoria = (string)reader["Categoria"];
            producto.PrecioCompra = (decimal)reader["PrecioCompra"];
            producto.PrecioVenta = (decimal)reader["PrecioVenta"];
            producto.Existencias = (decimal)reader["Existencias"];
            producto.Libras = (decimal)reader["Libras"];
            producto.FechaReg = (DateTime)reader["FechaReg"];
       
            return producto;
        }
    }
}
