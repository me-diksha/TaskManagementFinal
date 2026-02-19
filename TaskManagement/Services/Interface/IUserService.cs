using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskManagement.Model;

namespace TaskManagement.Services.Interface
{
    public interface IUserService
    {
        UserData authenticate(string username, string password);
        bool userNameExist(string username);

        void addNewUser(string addusername, string addpassword, string role);

        void changepassword(string username_added, string updated_password);
        string getInfo(int user_id);
        string getrole(int user_id);

        BindingList<UserData> getall(string getrole);
    }
}
