using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskManagement.Model;
using TaskManagement.Services.Interface;
using TaskManagement.Repositories.Interface;

namespace TaskManagement.Services.Implementation
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

        public void addNewUser(string addusername, string addpassword, string role)
        {
            _userRepo.addNewUser(addusername, addpassword, role);

        }

        public void changepassword(string username_added, string updated_password) {

            _userRepo.changepassword(username_added, updated_password);
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
