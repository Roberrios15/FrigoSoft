using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class CompraRepository : ICompraRepository
    {
        private readonly SqlConnection _connection;
        public IList<Compra> Compras;
        private SqlDataReader Reader;
        Compra compra;

        public CompraRepository(IConnectionManager connection)
        {
            _connection = connection.Connection;
            Compras = new List<Compra>();
            compra = new Compra();
        }

        public CompraRepository()
        {
            Compras = new List<Compra>();
        }

        public Compra CrearCompra()
        {
            Compra compra = new Compra();
            return compra;
        }

        public void GuardarCompra(Compra compra)
        {
            using (var comand = _connection.CreateCommand())
            {
                comand.CommandText = "INSERT INTO Compras (NombreProveedor,NitProveedor,Categoria,Libras,Kilos,PrecioLibra,PrecioKilo,Lote,Producto,FechaReg,Total) values " +
                "(@NombreProveedor,@NitProveedor,@Categoria,@Libras,@Kilos,@PrecioLibra,@PrecioKilo,@Lote,@Producto,@FechaReg,@Total)";
                comand.Parameters.AddWithValue("@NombreProveedor", compra.NombreProveedor);
                comand.Parameters.AddWithValue("@NitProveedor", compra.NitProveedor);
                comand.Parameters.AddWithValue("@Categoria", compra.Categoria);
                comand.Parameters.AddWithValue("@Libras", compra.Libras);
                comand.Parameters.AddWithValue("@Kilos", compra.Kilos);
                comand.Parameters.AddWithValue("@PrecioLibra", compra.PrecioLibra);
                comand.Parameters.AddWithValue("@PrecioKilo", compra.PrecioKilo);
                comand.Parameters.AddWithValue("@Lote", compra.Lote);
                comand.Parameters.AddWithValue("@Producto", compra.Producto);
                comand.Parameters.AddWithValue("@FechaReg", compra.FechaReg);
                comand.Parameters.AddWithValue("@Total", compra.Total);
                comand.ExecuteNonQuery();
            }
            _connection.Close();
        }

        public Compra Mapear(SqlDataReader reader)
        {
            Compra compra = CrearCompra();
            compra.NombreProveedor = (string)reader["NombreProveedor"];
            compra.NitProveedor = (string)reader["NitProveedor"];
            compra.Categoria = (string)reader["Categoria"];
            compra.Libras = (decimal)reader["Libras"];
            compra.Kilos = (decimal)reader["Kilos"];
            compra.PrecioLibra = (decimal)reader["PrecioLibra"];
            compra.PrecioKilo = (decimal)reader["PrecioKilo"];
            compra.Lote = (string)reader["Categoria"];
            compra.Producto = (string)reader["Producto"];
            compra.FechaReg = (DateTime)reader["FechaReg"];
            compra.Total = (decimal)reader["Total"];

            return compra;
        }

        public IList<Compra> Consultar()
        {
            Compras.Clear();
            using (var comando = _connection.CreateCommand())
            {
                comando.CommandText = "Select * From Compras";
                Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    compra = Mapear(Reader);
                    Compras.Add(compra);
                }
            }
            return Compras;
        }
    }
}
