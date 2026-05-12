using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Carver.Database
{
    internal class DBConnection
    {
        private static string _connectionString = "Data Source=HPPAV\\SQLEXPRESS;Initial Catalog=CarverDB;Integrated Security=True;Encrypt=False";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
