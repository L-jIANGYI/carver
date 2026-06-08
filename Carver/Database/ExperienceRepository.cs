using Carver.Models;
using Microsoft.Data.SqlClient;

namespace Carver.Database
{
    internal class ExperienceRepository
    {
        public void Add(Experience experience)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO Experiences 
                    (TestDriveId, MeetExpectation, PriceSatisfaction, OptionsAdequate, WillPurchase) 
                    VALUES 
                    (@TestDriveId, @MeetExpectation, @PriceSatisfaction, @OptionsAdequate, @WillPurchase)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TestDriveId", experience.TestDriveId);
                cmd.Parameters.AddWithValue("@MeetExpectation", (int)experience.MeetExpectation);
                cmd.Parameters.AddWithValue("@PriceSatisfaction", (int)experience.PriceSatisfaction);
                cmd.Parameters.AddWithValue("@OptionsAdequate", (int)experience.OptionsAdequate);
                cmd.Parameters.AddWithValue("@WillPurchase", (int)experience.WillPurchase);

                cmd.ExecuteNonQuery();
            }
        }

        public Experience? GetByTestDriveId(int testDriveId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Experiences WHERE TestDriveId = @TestDriveId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TestDriveId", testDriveId);
                SqlDataReader reader = cmd.ExecuteReader();

                return reader.Read() ? MapExperience(reader) : null;
            }
        }

        public List<Experience> GetAll()
        {
            List<Experience> experiences = new List<Experience>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Experiences";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    experiences.Add(MapExperience(reader));
            }

            return experiences;
        }

        private Experience MapExperience(SqlDataReader reader)
        {
            Experience experience = new Experience(reader.GetInt32(reader.GetOrdinal("TestDriveId")))
            {
                MeetExpectation = (ExperienceAnswer)reader.GetInt32(reader.GetOrdinal("MeetExpectation")),
                PriceSatisfaction = (ExperienceAnswer)reader.GetInt32(reader.GetOrdinal("PriceSatisfaction")),
                OptionsAdequate = (ExperienceAnswer)reader.GetInt32(reader.GetOrdinal("OptionsAdequate")),
                WillPurchase = (ExperienceAnswer)reader.GetInt32(reader.GetOrdinal("WillPurchase"))
            };

            experience.Id = reader.GetInt32(reader.GetOrdinal("Id"));
            return experience;
        }
    }
}
