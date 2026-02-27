using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskManagementAPI.DataAccess.Interfaces;
using TaskManagementAPI.Model;
using TaskManagementAPI.Repositories.Interface;
using TaskManagementAPI.Services.Interface;

namespace TaskManagementAPI.Services.Implementation
{
    public class TaskService:ITaskService
    {
        private readonly ITaskRepo _taskrepo;
        public TaskService(ITaskRepo taskrepo)
        {
            _taskrepo = taskrepo;
        }


        public void AddTask(TaskList task) {
            if (string.IsNullOrWhiteSpace(task.description))
            {
                throw new Exception("Task Description can't be negative");
            }
            _taskrepo.AddTask(task);
        }


        public void updatetask(TaskList task) { 
        
            _taskrepo.updatetask(task);
        }


        public void deletetask(int taskid,int userid) {
        
            _taskrepo.deletetask(taskid,userid);
        
        }


        public BindingList<TaskList> showtask_forUser(int user_id) { 
          
           return _taskrepo.showtask_forUser(user_id);

        }
        


        public BindingList<TaskList> gettask_byStatus(int userId, bool status) { 
        
            return _taskrepo.gettask_byStatus(userId, status);

        }


    }
}
