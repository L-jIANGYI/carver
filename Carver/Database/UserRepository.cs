using Carver.Models;
using Microsoft.Data.SqlClient;

namespace Carver.Database
{
    internal class UserRepository
    {
        public User? Login(string email, string password)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return MapUser(reader); 

                return null;
            }
        }

        public void Add(User user)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Users (Name, Email, Password, Role) VALUES (@Name, @Email, @Password, @Role)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", (int)user.Role);

                cmd.ExecuteNonQuery();
            }
        }

        public List<User> GetAll()
        {
            List<User> users = new List<User>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    users.Add(MapUser(reader));
            }

            return users;
        }

        public void Delete(User user)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Users WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", user.Id);

                cmd.ExecuteNonQuery();
            }
        }

        private User MapUser(SqlDataReader reader)
        {
            UserRole role = (UserRole)reader.GetInt32(reader.GetOrdinal("Role"));

            User user = role == UserRole.Administrator
                ? new Administrator(
                    reader.GetString(reader.GetOrdinal("Name")),
                    reader.GetString(reader.GetOrdinal("Email")),
                    reader.GetString(reader.GetOrdinal("Password")))
                : new User(
                    reader.GetString(reader.GetOrdinal("Name")),
                    reader.GetString(reader.GetOrdinal("Email")),
                    reader.GetString(reader.GetOrdinal("Password")),
                    role);

            user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
            return user;
        }
    }
}
