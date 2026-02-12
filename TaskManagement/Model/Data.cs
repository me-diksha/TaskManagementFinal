using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TaskManagement.Model
{
    public static class Data
    {  
        public static BindingList<UserData> users;
        public static BindingList<TaskList>tasks;
        static Data()
        {
            users = new BindingList<UserData>();
            tasks = new BindingList<TaskList>();

            users.Add(new UserData{ Id=1,Username="diksha",Password="1234",Role="admin"});
            users.Add(new UserData { Id = 2, Username = "rk", Password = "369", Role = "employee" });
            users.Add(new UserData { Id = 3, Username = "janvi", Password = "2345", Role = "employee" });

            tasks.Add(new TaskList { userId = 2, taskId = 1, description = "Fix bug", status = false });
            tasks.Add(new TaskList {userId=2,taskId=2, description="Kitchen work",status = false });
            tasks.Add(new TaskList{userId=3, taskId=1,description="Fix button",status=false });
            tasks.Add(new TaskList { userId = 3, taskId = 2, description = "Fix error", status = true });
        }
    }  
}
