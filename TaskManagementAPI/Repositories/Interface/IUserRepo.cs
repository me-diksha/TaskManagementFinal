using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskManagementAPI.Model;

namespace TaskManagementAPI.Repositories.Interface
{
    public interface IUserRepo
    {
        UserData authenticate(string username, string password);
        bool userNameExist(string username);

        bool addNewUser(string addusername, string addpassword, string role);

        bool changepassword(string username_added, string updated_password);
        string getInfo(int user_id);
        string getrole(int user_id);


        BindingList<UserData> getall(string getrole);
    }
}
