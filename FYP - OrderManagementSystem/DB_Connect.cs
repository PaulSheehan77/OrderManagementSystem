using System.Data.SqlClient;

namespace FYP___OrderManagementSystem
{
    class DB_Connect
    {
        public static SqlConnection connect()
        {
            SqlConnection c = new SqlConnection(Constants.db_connection);
            return c;
        }
    }
}
