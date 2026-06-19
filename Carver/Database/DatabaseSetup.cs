using Microsoft.Data.SqlClient;

namespace Carver.Database
{
    internal static class DatabaseSetup
    {
        public static void EnsureDatabase()
        {
            CreateDatabaseIfNotExists();
            CreateTablesIfNotExists();
        }

        public static bool NeedsFirstAdmin()
        {
            using SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM Users WHERE Role = 1", conn);
            return (int)cmd.ExecuteScalar() == 0;
        }

        private static void CreateDatabaseIfNotExists()
        {
            // Master-verbinding gebruiken, want CarverDB bestaat mogelijk nog niet
            using SqlConnection conn = DBConnection.GetMasterConnection();
            conn.Open();

            string sql = @"
                IF NOT EXISTS (
                    SELECT name FROM sys.databases WHERE name = 'CarverDB'
                )
                CREATE DATABASE CarverDB;";

            new SqlCommand(sql, conn).ExecuteNonQuery();
        }

        private static void CreateTablesIfNotExists()
        {
            using SqlConnection conn = DBConnection.GetConnection();
            conn.Open();

            string sql = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
                CREATE TABLE Users (
                    Id          INT IDENTITY(1,1) PRIMARY KEY,
                    Name        NVARCHAR(100)  NOT NULL,
                    Email       NVARCHAR(150)  NOT NULL UNIQUE,
                    Password    NVARCHAR(255)  NOT NULL,
                    Role        INT            NOT NULL DEFAULT 0,
                    CreatedAt   DATETIME       NOT NULL DEFAULT GETDATE(),
                    UpdatedAt   DATETIME       NOT NULL DEFAULT GETDATE()
                );

                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Prospects')
                CREATE TABLE Prospects (
                    Id                  INT IDENTITY(1,1) PRIMARY KEY,
                    FirstName           NVARCHAR(100)  NOT NULL,
                    LastName            NVARCHAR(100)  NOT NULL,
                    Email               NVARCHAR(150)  NOT NULL,
                    Phone               NVARCHAR(20)   NOT NULL,
                    Address             NVARCHAR(200)  NOT NULL,
                    City                NVARCHAR(100)  NOT NULL,
                    HasDrivingLicense   BIT            NOT NULL DEFAULT 0,
                    HasScooterLicense   BIT            NOT NULL DEFAULT 0,
                    IsDisabledVehicle   BIT            NOT NULL DEFAULT 0,
                    CreatedAt           DATETIME       NOT NULL DEFAULT GETDATE(),
                    UpdatedAt           DATETIME       NOT NULL DEFAULT GETDATE()
                );

                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'TestDrives')
                CREATE TABLE TestDrives (
                    Id              INT IDENTITY(1,1) PRIMARY KEY,
                    ProspectId      INT            NOT NULL,
                    CarverModel     INT            NOT NULL,
                    ScheduledAt     DATETIME       NOT NULL,
                    Reason          NVARCHAR(500)  NOT NULL,
                    Status          INT            NOT NULL DEFAULT 0,
                    CreatedAt       DATETIME       NOT NULL DEFAULT GETDATE(),
                    CONSTRAINT FK_TestDrives_Prospects
                        FOREIGN KEY (ProspectId) REFERENCES Prospects(Id)
                );

                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Experiences')
                CREATE TABLE Experiences (
                    Id                  INT IDENTITY(1,1) PRIMARY KEY,
                    TestDriveId         INT NOT NULL UNIQUE,
                    MeetExpectation     INT NOT NULL,
                    PriceSatisfaction   INT NOT NULL,
                    OptionsAdequate     INT NOT NULL,
                    WillPurchase        INT NOT NULL,
                    CONSTRAINT FK_Experiences_TestDrives
                        FOREIGN KEY (TestDriveId) REFERENCES TestDrives(Id)
                );";

            new SqlCommand(sql, conn).ExecuteNonQuery();
        }
    }
}