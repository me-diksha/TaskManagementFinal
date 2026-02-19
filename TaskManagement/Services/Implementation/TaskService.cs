using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskManagement.DataAccess.Interfaces;
using TaskManagement.Model;
using TaskManagement.Repositories.Interface;
using TaskManagement.Services.Interface;

namespace TaskManagement.Services.Implementation
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


        public void deletetask(TaskList task) {
        
            _taskrepo.deletetask(task);
        
        }


        public BindingList<TaskList> showtask_forUser(int user_id) { 
          
           return _taskrepo.showtask_forUser(user_id);

        }
        


        public BindingList<TaskList> gettask_byStatus(int userId, bool status) { 
        
            return _taskrepo.gettask_byStatus(userId, status);

        }


    }
}
