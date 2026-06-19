using Microsoft.Data.SqlClient;

namespace Carver.Database
{
    internal class DBConnection
    {
        private static string? _instanceName = null;

        private static readonly string[] CandidateInstances = new[]
        {
            @".\SQLEXPRESS",
            @".\MSSQLSERVER",
            @"(localdb)\MSSQLLocalDB",
            @"(localdb)\v11.0",
            @".",
        };

        // Verbinding naar CarverDB (voor normaal gebruik)
        public static SqlConnection GetConnection()
        {
            EnsureInstanceFound();
            return new SqlConnection(BuildConnectionString(_instanceName!, "CarverDB"));
        }

        // Verbinding naar master (voor database aanmaken)
        public static SqlConnection GetMasterConnection()
        {
            EnsureInstanceFound();
            return new SqlConnection(BuildConnectionString(_instanceName!, "master"));
        }

        private static void EnsureInstanceFound()
        {
            if (_instanceName != null) return;

            foreach (string instance in CandidateInstances)
            {
                try
                {
                    using SqlConnection conn = new SqlConnection(
                        BuildConnectionString(instance, "master"));
                    conn.Open();
                    _instanceName = instance;
                    return;
                }
                catch { }
            }

            throw new NoSqlServerException(
                "Er is geen SQL Server-instantie gevonden op deze computer.\n\n" +
                "Installeer SQL Server Express via:\n" +
                "https://www.microsoft.com/sql-server/sql-server-downloads");
        }

        private static string BuildConnectionString(string dataSource, string catalog)
        {
            return $"Data Source={dataSource};Initial Catalog={catalog};" +
                   "Integrated Security=True;Encrypt=False;Connect Timeout=3;";
        }
    }

    internal class NoSqlServerException : Exception
    {
        public NoSqlServerException(string message) : base(message) { }
    }
}