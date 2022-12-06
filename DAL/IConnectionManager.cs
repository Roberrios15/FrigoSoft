using System.Data.SqlClient;

namespace DAL
{
    public interface IConnectionManager
    {
        void Open();
        void Close();
        
        SqlConnection Connection { get; }
    }
}