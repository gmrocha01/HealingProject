using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Healing.Database
{
    public static class MySqlConexao
    {
        private static MySqlConnection _conn;

        public static MySqlConnection GetConnection()
        {
            if (_conn == null)
            {
                var cs = ConfigurationManager.ConnectionStrings["HealingDb"].ConnectionString;
                _conn = new MySqlConnection(cs);
            }
            if (_conn.State != System.Data.ConnectionState.Open)
                _conn.Open();
            return _conn;
        }

        public static void Close()
        {
            if (_conn != null && _conn.State != System.Data.ConnectionState.Closed)
                _conn.Close();
        }
    }
}
