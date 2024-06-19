using System;
using System.Linq;
using CarAuction.Models;
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
            Password = "H2PD040124_Gruppe2",
            TrustServerCertificate = true,
            InitialCatalog = "AuctionDB"
        };

        public static string ConnectionString { get; set; } = _builder.ConnectionString;

        private static SqlConnection Connection; // => new SqlConnection(ConnectionString);

        public static void OpenConnection()
        {
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }

        public static void CloseConnection()
        {
            Connection.Close();
        }
        public static int GetScopeIdentity(string table)
        {
            string query = $"SELECT SCOPE_IDENTITY() From [{table}];";
            SqlCommand command = new SqlCommand(query, Connection);
            int result = Convert.ToInt32(command.ExecuteScalar());
            return result;
        }

        public static void Insert(string table, string[] columns, string[] values)
        {//Problemet er at alt de smider ind i values ikke kommer i quotation marks
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
            string query = $"DELETE FROM [{table}] WHERE {condition};";
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

        public static void NewVehicle(Vehicle vehicle)
        {
            OpenConnection();
            string[] columns = new string[] { "Name", "Km", "Regnr", "Year", "TowingHook", "DriverLicenseType", "EngineSize", "KmPerLiter", "FuelType", "EnergyClass" };

            string query = $"INSERT INTO [Vehicle] ({string.Join(", ", columns)}) VALUES (@Name, @Km, @Regnr, @Year, @TowingHook, @DriverLicenseType, @EngineSize, @KmPerLiter, @FuelType, @EnergyClass);";
            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@Name", vehicle.Name);
            command.Parameters.AddWithValue("@Km", vehicle.Km);
            command.Parameters.AddWithValue("@Regnr", vehicle.Regnr);
            command.Parameters.AddWithValue("@Year", vehicle.Year);
            command.Parameters.AddWithValue("@TowingHook", vehicle.TowingHook);
            command.Parameters.AddWithValue("@DriverLicenseType", vehicle.DriversLicenseType);
            command.Parameters.AddWithValue("@EngineSize", vehicle.EngineSize);
            command.Parameters.AddWithValue("@KmPerLiter", vehicle.KmPerLiter);
            command.Parameters.AddWithValue("@FuelType", vehicle.FuelType);
            command.Parameters.AddWithValue("@EnergyClass", vehicle.GetEnergyClass());
            command.ExecuteNonQuery();
            CloseConnection();
        }
        public static void NewUser(User user)
        {
            OpenConnection();
            string[] columns = new string[] { "Username", "Password", "PostalCode" };

            string query = $"INSERT INTO [User] ({string.Join(", ", columns)}) VALUES (@Username, @Password, @PostalCode); Select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@Username", user.Username);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@PostalCode", user.PostalCode);

            user.Id = Convert.ToInt32(command.ExecuteScalar());
            //user.Id = GetScopeIdentity("User");

            CloseConnection();
        }
        public static bool Login(string username, string password)
        {
            OpenConnection();
            string query = $"SELECT * FROM [User] WHERE Username = @Username AND Password = @Password;";
            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            SqlDataReader reader = command.ExecuteReader();
            bool result = reader.HasRows;
            CloseConnection();
            return result;
        }
    }

}
