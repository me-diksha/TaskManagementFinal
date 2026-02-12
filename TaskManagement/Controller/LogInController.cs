using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Model;
using Npgsql;
using TaskManagement.DBconnection;
namespace TaskManagement.Controller
{
    public class LogInController
    {
        private string connectionString = "Host=localhost;Port=5432;Database=Datadb;Username=postgres;Password=1234";
        public UserData authenticate(string username, string password)
        {

            //string query = "SELECT id,username,password,role FROM userdata WHERE username=@username AND password=@password";
            //var conn = DBHelper.GetConnection();
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT *FROM authenticate_user_fun(@username,@password);", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new UserData
                            {
                                Id = reader.GetInt32(0),
                                Username = reader.GetString(1),
                                Password = reader.GetString(2),
                                Role = reader.GetString(3)

                            };
                        }
                    }
                }
            }
            return null;

        }

        public bool userNameExist(string username)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                //string query = "SELECT COUNT(*) FROM userdata WHERE username= @username;";
                using (var cmd = new NpgsqlCommand("SELECT userNameExist_fun(@username)", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    //int count=Convert.ToInt32(cmd.ExecuteScalar())  ;
                    //return count > 0;
                    return (bool)cmd.ExecuteScalar();
                }
            }

        }
    }

}