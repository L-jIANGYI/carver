using Carver.Models;
using Microsoft.Data.SqlClient;

namespace Carver.Database
{
    internal class TestDriveRepository
    {
        private ProspectRepository _prospectRepo = new ProspectRepository();

        public void Add(TestDrive testDrive)
        {
            using(SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO TestDrives 
                    (ProspectId, CarverId, ScheduledAt, Reason, Status) 
                    VALUES 
                    (@ProspectId, @CarverId, @ScheduledAt, @Reason, @Status)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProspectId", testDrive.Prospect.Id);
                cmd.Parameters.AddWithValue("@CarverId", testDrive.Carver.Id);
                cmd.Parameters.AddWithValue("@ScheduledAt", testDrive.ScheduledAt);
                cmd.Parameters.AddWithValue("@Reason", testDrive.Reason);
                cmd.Parameters.AddWithValue("@Status", (int)testDrive.Status);

                cmd.ExecuteNonQuery();
            }
        }

        public List<TestDrive> GetByStatus(TestDriveStatus status)
        {
            List<TestDrive> testDrives = new List<TestDrive>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = @"SELECT t.*, c.Id AS CarverId, c.ModelType
                    FROM TestDrives t
                    INNER JOIN Carvers c ON t.CarverId = c.Id
                    WHERE t.Status = @Status
                    ORDER BY t.ScheduledAt";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Status", (int)status);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Prospect prospect = _prospectRepo.GetById(reader.GetInt32(reader.GetOrdinal("ProspectId")))!;

                    CarverModelType modelType = (CarverModelType)reader.GetInt32(reader.GetOrdinal("ModelType"));
                    Models.Carver carver = new Models.Carver(modelType);

                    TestDrive testDrive = new TestDrive(
                        prospect,
                        carver,
                        reader.GetDateTime(reader.GetOrdinal("ScheduledAt")),
                        reader.GetString(reader.GetOrdinal("Reason"))
                    );
                    testDrive.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    testDrive.Status = (TestDriveStatus)reader.GetInt32(reader.GetOrdinal("Status"));

                    testDrives.Add(testDrive);
                }
            }

            return testDrives;
        }

        public List<TestDrive> GetAll()
        {
            List<TestDrive> testDrives = new List<TestDrive>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = @"SELECT t.*, c.Id AS CarverId, c.ModelType
                    FROM TestDrives t
                    INNER JOIN Carvers c ON t.CarverId = c.Id
                    ORDER BY t.ScheduledAt";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Prospect prospect = _prospectRepo.GetById(reader.GetInt32(reader.GetOrdinal("ProspectId")))!;

                    CarverModelType modelType = (CarverModelType)reader.GetInt32(reader.GetOrdinal("ModelType"));
                    Models.Carver carver = new Models.Carver(modelType);

                    TestDrive testDrive = new TestDrive(
                        prospect,
                        carver,
                        reader.GetDateTime(reader.GetOrdinal("ScheduledAt")),
                        reader.GetString(reader.GetOrdinal("Reason"))
                    );
                    testDrive.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    testDrive.Status = (TestDriveStatus)reader.GetInt32(reader.GetOrdinal("Status"));

                    testDrives.Add(testDrive);
                }
            }
            return testDrives;
        }

        public void UpdateStatus(int id, TestDriveStatus newStatus)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE TestDrives SET Status = @Status WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Status", (int)newStatus);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(TestDrive testDrive) 
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE TestDrives 
                    SET CarverId = @CarverId, 
                        ScheduledAt = @ScheduledAt, 
                        Reason = @Reason
                    WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", testDrive.Id);
                cmd.Parameters.AddWithValue("@CarverId", testDrive.Carver.Id);
                cmd.Parameters.AddWithValue("@ScheduledAt", testDrive.ScheduledAt);
                cmd.Parameters.AddWithValue("@Reason", testDrive.Reason);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(TestDrive testDrive)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = @"DELETE FROM TestDrives WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", testDrive.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
