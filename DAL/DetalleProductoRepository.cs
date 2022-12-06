using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DetalleProductoRepository
    {
        private readonly SqlConnection _connection;
        public IList<DetalleProducto> DetalleProductos;
        ProductoRepository ProductoRepository;
        private SqlDataReader Reader;
        DetalleProducto detalleProducto;
        public DetalleProductoRepository(ConnectionManager connection)
        {
            _connection = connection.conexion;
            ProductoRepository = new ProductoRepository(connection);
            DetalleProductos = new List<DetalleProducto>();
            detalleProducto = new DetalleProducto();
        }

        public void ModificarExistencias(List<DetalleProducto> detalles)
        {
            using (var comando = _connection.CreateCommand())
            {
                _connection.Open();
                foreach (var item in detalles)
                {
                    comando.Parameters.Clear();
                    Producto producto = ProductoRepository.BuscarProducto(item.Producto.CodigoProducto.Trim());
                    decimal existenciasTotales = producto.Existencias - item.Cantidad;

                    comando.CommandText = "Update Productos set Existencias = @Existencias where CodigoProducto=@CodigoProducto";
                    comando.Parameters.AddWithValue("@CodigoProducto", item.Producto.CodigoProducto);
                    comando.Parameters.AddWithValue("@Existencias", existenciasTotales);
                    comando.ExecuteNonQuery();
                }

                _connection.Close();
            }

        }

        public void GuardarDetalles(List<DetalleProducto> detalleProductos)
        {
            using (var comand = _connection.CreateCommand())
            {
                foreach (var item in detalleProductos)
                {
                    comand.Parameters.Clear();

                    comand.CommandText = "INSERT INTO DetalleProductos (Producto,Libras,FechaReg,Categoria,Valor,IdVenta,CodigoProducto) values " +
                    "(@Producto,@Libras,@FechaReg,@Categoria,@Valor,@IdVenta,@CodigoProducto)";
                    comand.Parameters.AddWithValue("@Producto", item.Producto.Nombre);
                    comand.Parameters.AddWithValue("@Libras", item.Cantidad);
                    comand.Parameters.AddWithValue("@FechaReg", item.FechaReg);
                    comand.Parameters.AddWithValue("@Categoria", item.Producto.Categoria);
                    comand.Parameters.AddWithValue("@Valor", item.Total);
                    comand.Parameters.AddWithValue("@IdVenta", item.IdVenta);
                    comand.Parameters.AddWithValue("@CodigoProducto", item.Producto.CodigoProducto);

                    comand.ExecuteNonQuery();
                }
               
            }
            _connection.Close();
        }
    }
}
