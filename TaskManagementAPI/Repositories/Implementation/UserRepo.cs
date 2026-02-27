using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskManagementAPI.DataAccess.Interfaces;
using TaskManagementAPI.Model;
using TaskManagementAPI.Repositories.Interface;

//interact with userdata table
namespace TaskManagementAPI.Repositories.Implementation
{ 
    public class UserRepo:IUserRepo
    {
        private readonly IDataAccess _dataAccess;
        public UserRepo(IDataAccess dataAccess) {
           _dataAccess= dataAccess;
        }


        //for login controller
        public UserData authenticate(string username, string password)
        {
            string sql = "SELECT *FROM authenticate_user_fun(@username,@password);";
            var parameters = new Dictionary<string, object>
            {
                {"@username", username },
                {"@password", password }
            };
            using var reader = _dataAccess.ExecuteReader(sql, parameters);
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
            return null;
            }


        public bool userNameExist(string username)
        {
         string sql= "SELECT userNameExist_fun(@username)";
            var parameters = new Dictionary<string, object>{
                {"@username", username}
             
            };
            return Convert.ToBoolean(_dataAccess.ExecuteScalar(sql,parameters));
        }

        public bool addNewUser(string addusername, string addpassword, string role)
        {
            try
            {
                string sql = "CALL addNewUser_proc(@addusername,@addpassword,@role);";
                var parameters = new Dictionary<string, object> {
                { "@addusername", addusername},
                { "@addpassword", addpassword},
                {"@role", role }
            };

                _dataAccess.ExecuteNonQuery(sql, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool changepassword(string username_added, string updated_password)
        {
            try {
                string sql = "CALL changepassword_proc(@username_added,@updated_password);";
                var parameters = new Dictionary<string, object>
            {
                {"@username_added", username_added },
                {"@updated_password", updated_password }
            };

                _dataAccess.ExecuteNonQuery(sql, parameters);
                return true;
            }
            catch
            {
                return false;
            }
            }


       public string getInfo(int user_id)
        {

            string sql = "SELECT getinfo_fun(@id);";
            var parameters = new Dictionary<string, object>
            {
                {"@id", user_id }
            };
            return _dataAccess.ExecuteScalar(sql,parameters)?.ToString();
        }


       public string getrole(int user_id) {

            string sql = "SELECT getrole_fun(@id);";
            var parameters = new Dictionary<string, object>
            {
                {"@id", user_id }
            };
            return _dataAccess.ExecuteScalar(sql, parameters)?.ToString();
        }


       public BindingList<UserData> getall(string getrole) 
        {
            BindingList<UserData> giveuser = new BindingList<UserData>();
            string sql = "SELECT * FROM getall_fun(@role);";
            var parameters = new Dictionary<string, object>
            {
                {"@role", getrole }
            };

            using var reader=_dataAccess.ExecuteReader(sql, parameters);
            while (reader.Read())
            {
                giveuser.Add(new UserData
                {
                    Id = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Role = reader.GetString(2)

                });
            }
            return giveuser;

        }
    }
}
