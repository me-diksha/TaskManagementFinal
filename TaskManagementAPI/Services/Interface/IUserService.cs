using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskManagementAPI.Model;

namespace TaskManagementAPI.Services.Interface
{
    public interface IUserService
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
