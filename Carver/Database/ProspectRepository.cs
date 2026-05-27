using Carver.Models;
using Microsoft.Data.SqlClient;

namespace Carver.Database
{
    internal class ProspectRepository
    {
        public void Add(Prospect prospect)
        {
            using(SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO Prospects (FirstName, LastName, Email, Phone, Address, City, HasDrivingLicense, HasScooterLicense, IsDisabledVehicle)
                                 VALUES (@FirstName, @LastName, @Email, @Phone, @Address, @City, @HasDrivingLicense, @HasScooterLicense, @IsDisabledVehicle)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", prospect.FirstName);
                cmd.Parameters.AddWithValue("@LastName", prospect.LastName);
                cmd.Parameters.AddWithValue("@Email", prospect.Email);
                cmd.Parameters.AddWithValue("@Phone", prospect.Phone);
                cmd.Parameters.AddWithValue("@Address", prospect.Address);
                cmd.Parameters.AddWithValue("@City", prospect.City);
                cmd.Parameters.AddWithValue("@HasDrivingLicense", prospect.HasDrivingLicense);
                cmd.Parameters.AddWithValue("@HasScooterLicense", prospect.HasScooterLicense);
                cmd.Parameters.AddWithValue("@IsDisabledVehicle", prospect.IsDisabledVehicle);

                cmd.ExecuteNonQuery();
            }
        }

        public Prospect? GetById(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Prospects WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Prospect prospect = new Prospect(
                        reader.GetString(reader.GetOrdinal("FirstName")),
                        reader.GetString(reader.GetOrdinal("LastName")),
                        reader.GetString(reader.GetOrdinal("Email")),
                        reader.GetString(reader.GetOrdinal("Phone")),
                        reader.GetString(reader.GetOrdinal("Address")),
                        reader.GetString(reader.GetOrdinal("City"))
                    );
                    prospect.HasDrivingLicense = reader.GetBoolean(reader.GetOrdinal("HasDrivingLicense"));
                    prospect.HasScooterLicense = reader.GetBoolean(reader.GetOrdinal("HasScooterLicense"));
                    prospect.IsDisabledVehicle = reader.GetBoolean(reader.GetOrdinal("IsDisabledVehicle"));
                    return prospect;
                }
                return null;
            }
        }

        public List<Prospect> GetAll()
        {
            List<Prospect> prospects = new List<Prospect>();

            using(SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Prospects";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    Prospect prospect = new Prospect(
                        reader.GetString(reader.GetOrdinal("FirstName")),
                        reader.GetString(reader.GetOrdinal("LastName")),
                        reader.GetString(reader.GetOrdinal("Email")),
                        reader.GetString(reader.GetOrdinal("Phone")),
                        reader.GetString(reader.GetOrdinal("Address")),
                        reader.GetString(reader.GetOrdinal("City"))
                    );
                    prospect.HasDrivingLicense = reader.GetBoolean(reader.GetOrdinal("HasDrivingLicense"));
                    prospect.HasScooterLicense = reader.GetBoolean(reader.GetOrdinal("HasScooterLicense"));
                    prospect.IsDisabledVehicle = reader.GetBoolean(reader.GetOrdinal("IsDisabledVehicle"));

                    prospects.Add(prospect);
                }
            }

            return prospects;
        }

        public void Update(Prospect prospect)
        {
            using(SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE Prospects SET 
                    FirstName = @FirstName, LastName = @LastName, 
                    Email = @Email, Phone = @Phone, 
                    Address = @Address, City = @City, 
                    HasDrivingLicense = @HasDrivingLicense, 
                    HasScooterLicense = @HasScooterLicense, 
                    IsDisabledVehicle = @IsDisabledVehicle
                    WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", prospect.Id);
                cmd.Parameters.AddWithValue("@FirstName", prospect.FirstName);
                cmd.Parameters.AddWithValue("@LastName", prospect.LastName);
                cmd.Parameters.AddWithValue("@Email", prospect.Email);
                cmd.Parameters.AddWithValue("@Phone", prospect.Phone);
                cmd.Parameters.AddWithValue("@Address", prospect.Address);
                cmd.Parameters.AddWithValue("@City", prospect.City);
                cmd.Parameters.AddWithValue("@HasDrivingLicense", prospect.HasDrivingLicense);
                cmd.Parameters.AddWithValue("@HasScooterLicense", prospect.HasScooterLicense);
                cmd.Parameters.AddWithValue("@IsDisabledVehicle", prospect.IsDisabledVehicle);

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(Prospect prospect)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Prospects WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", prospect.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
