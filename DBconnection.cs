using System.Data.SqlClient;

namespace firstproject
{
    public static class DBConnection
    {
        private static readonly string connectionString = "Data Source=localhost;Initial Catalog=library;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
