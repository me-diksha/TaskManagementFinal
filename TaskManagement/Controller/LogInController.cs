using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskManagement.DataAccess;
using TaskManagement.Model;
using TaskManagement.Services.Interface;
namespace TaskManagement.Controller
{
    public class LogInController
    {
        //private string connectionString = "Host=localhost;Port=5432;Database=Datadb;Username=postgres;Password=1234";
        private readonly IUserService _userService;

        public LogInController(IUserService userService)
        {
            _userService = userService;

        }
        public UserData authenticate(string username, string password)
        {

           /* using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
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
           */
           return _userService.authenticate(username, password);

        }

        public bool userNameExist(string username)
        {
            /*using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                
                using (var cmd = new NpgsqlCommand("SELECT userNameExist_fun(@username)", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                   
                    //return (bool)cmd.ExecuteScalar();
                    return Convert.ToBoolean(cmd.ExecuteScalar());

                }
            }*/
            return _userService.userNameExist(username);

        }
        public void addNewUser(string addusername, string addpassword, string role)
        {
            _userService.addNewUser(addusername, addpassword, role);

        }
        public void changepassword(string username_added, string updated_password)
        {
            _userService.changepassword(username_added, updated_password);
        }

        public string getInfo(int user_id)
        {
            return _userService.getInfo(user_id);
        }

        public string getrole(int user_id)
        {
            return _userService.getrole(user_id);
        }

        public BindingList<UserData> getall(string getrole)
        {
            return _userService.getall(getrole);
        }
    }

}