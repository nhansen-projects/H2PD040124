using System.Linq;
using Microsoft.Data.SqlClient;

// get company from ID
// get all companies
// Insert company
// update company
// delete company from ID

namespace CarAuction.ConnectionHandlers
{
    public static partial class Database
    {
        private static SqlConnectionStringBuilder _builder = new SqlConnectionStringBuilder
        {
            DataSource = "docker.data.techcollege.dk,20002",
            UserID = "sa",
            IntegratedSecurity = false,
            Password = "H2PD040124_Gruppe2"
        };

        public static string ConnectionString { get; set; } = _builder.ConnectionString;

        private static SqlConnection Connection => new SqlConnection(ConnectionString);

        public static void OpenConnection()
        {
            Connection.Open();
        }

        public static void CloseConnection()
        {
            Connection.Close();
        }

        public static void Insert(string table, string[] columns, string[] values)
        {
            string query = $"INSERT INTO {table} ({string.Join(", ", columns)}) VALUES ({string.Join(", ", values)});";
            SqlCommand command = new SqlCommand(query, Connection);
            command.ExecuteNonQuery();
        }

        public static void Update(string table, string[] columns, string[] values, string condition)
        {
            string query =
                $"UPDATE {table} SET {string.Join(", ", columns.Select((column, index) => $"{column} = {values[index]}"))} WHERE {condition};";
            SqlCommand command = new SqlCommand(query, Connection);
            command.ExecuteNonQuery();
        }

        public static void Delete(string table, string condition)
        {
            string query = $"DELETE FROM {table} WHERE {condition};";
            SqlCommand command = new SqlCommand(query, Connection);
            command.ExecuteNonQuery();
        }

        public static SqlDataReader Select(string table, string[] columns, string condition)
        {
            string query = $"SELECT {string.Join(", ", columns)} FROM {table} WHERE {condition};";
            SqlCommand command = new SqlCommand(query, Connection);
            return command.ExecuteReader();
        }

        public static SqlDataReader SelectAll(string table)
        {
            string query = $"SELECT * FROM {table};";
            SqlCommand command = new SqlCommand(query, Connection);
            return command.ExecuteReader();
        }
        
        public static void UserConnection(string username, string password)
        {
            string query =
                $"SELECT role from tbl_login WHERE Username = {username} and password = {password}";
            SqlCommand command = new SqlCommand(query, Connection);
            command.ExecuteReader();
            
        }
    }
    
    // 
}
