#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.EF.Connection.cs
// By            ::    Arjan Crielaard

#endregion

namespace MostDev.DataLayer.EF
{
    public static class Connection
    {
        public static string GetMySqlConnection()
        {
            var dbname = "mostdev";

            if (string.IsNullOrEmpty(dbname)) return null;

            var username = "root";
            var password = "5j@G!m4(u[([~e-9yeL2k*(g";
            var server = "localhost";
            var port = "3306";

            //CloudConnection
            //return $"Server={server}:{port}; Database={dbname};Uid={username};Pwd={password};";

            //local connection
            return $"Server={server}; Database={dbname};Uid={username};Pwd={password};";
        }
    }
}