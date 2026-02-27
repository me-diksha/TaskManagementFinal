using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskManagementAPI.Model;
using TaskManagementAPI.Services.Interface;
using TaskManagementAPI.Repositories.Interface;

namespace TaskManagementAPI.Services.Implementation
{
    public class UserService:IUserService
    {
        private readonly IUserRepo _userRepo;
        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }


        public UserData authenticate(string username, string password) {

            return _userRepo.authenticate(username, password);

        }


        public bool userNameExist(string username) {

            return _userRepo.userNameExist(username);

        }

        public bool addNewUser(string addusername, string addpassword, string role)
        {
           return _userRepo.addNewUser(addusername, addpassword, role);

        }

        public bool changepassword(string username_added, string updated_password) {

            return _userRepo.changepassword(username_added, updated_password);
        }


        public string getInfo(int user_id) {

            return _userRepo.getInfo(user_id);

        }


        public string getrole(int user_id) { 
        
            return _userRepo.getrole(user_id);

        }


        public BindingList<UserData> getall(string getrole) {

            return _userRepo.getall(getrole);

        }


    }
}
