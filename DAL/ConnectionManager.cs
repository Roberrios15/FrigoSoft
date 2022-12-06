using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnectionManager : IConnectionManager
    {
        public string ConnectionString;
        internal SqlConnection conexion;

        public ConnectionManager(string connectionString)
        {
            ConnectionString = connectionString;
            conexion = new SqlConnection(connectionString);
        }
        
        public ConnectionManager(SqlConnection connection)
        {
            conexion = connection;
        }

        public ConnectionManager()
        {
            
        }

        public void Open()
        {
            conexion.Open();
        }
        public void Close()
        {
            conexion.Close();
        }

        public SqlConnection Connection => conexion;
    }
}
