using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class VentaRepository : IVentaRepository
    {
        private readonly SqlConnection _connection;
        public IList<Venta> Ventas;
        public IList<DetalleProducto> DetalleProductos;
        private SqlDataReader Reader;
        Venta venta;
        DetalleProducto detalleProducto;

        public VentaRepository(IConnectionManager connection)
        {
            _connection = connection.Connection;
            Ventas = new List<Venta>();
            venta = new Venta();
            DetalleProductos = new List<DetalleProducto>();
            detalleProducto = new DetalleProducto();
        }

        public Venta CrearVenta()
        {
            Venta venta = new Venta();
            return venta;
        }

        public void GuardarVenta(Venta venta)
        {
            using (var comand = _connection.CreateCommand())
            {
                comand.CommandText = "INSERT INTO Ventas (IdVenta,Total,FechaReg) values " +
                "(@IdVenta,@Total,@FechaReg)";
                comand.Parameters.AddWithValue("@IdVenta", venta.IdVenta);
                comand.Parameters.AddWithValue("@Total", venta.TotalVenta);
                comand.Parameters.AddWithValue("@FechaReg", venta.FechaVenta);

                comand.ExecuteNonQuery();
            }
            _connection.Close();
        }

        public IList<Venta> Consultar()
        {
            Ventas.Clear();
            using (var comando = _connection.CreateCommand())
            {
                comando.CommandText = "Select * From Ventas";
                Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    venta = Mapear(Reader);
                    Ventas.Add(venta);
                }
            }
            return Ventas;
        }

        private Venta Mapear(SqlDataReader reader)
        {
            Venta venta = CrearVenta();
            venta.IdVenta = (int)reader["IdVenta"];
            venta.FechaVenta = (DateTime)reader["FechaReg"];
            venta.TotalVenta = (decimal)reader["Total"];
         
            return venta;
        }
    }
}
