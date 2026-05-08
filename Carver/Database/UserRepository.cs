using System;
using System.Collections.Generic;
using System.Text;
using Carver.Models;
using Microsoft.Data.SqlClient;

namespace Carver.Database
{
    internal class UserRepository
    {
        public User? Login(string email, string password)
        {
            using(SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    UserRole role = (UserRole)reader.GetInt32(reader.GetOrdinal("Role"));

                    if (role == UserRole.Administrator)
                    {
                        return new Administrator(
                            reader.GetString(reader.GetOrdinal("Name")),
                            reader.GetString(reader.GetOrdinal("Email")),
                            reader.GetString(reader.GetOrdinal("Password"))
                        );
                    }
                    else
                    {
                        return new User(
                            reader.GetString(reader.GetOrdinal("Name")),
                            reader.GetString(reader.GetOrdinal("Email")),
                            reader.GetString(reader.GetOrdinal("Password")),
                            role
                        );
                    }
                }
                return null;
            }
        }
    }
}
