using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskManagementAPI.Model;

namespace TaskManagementAPI.Repositories.Interface
{
    public interface ITaskRepo
    {
        void AddTask(TaskList task);
        void updatetask(TaskList task);
        void deletetask(int taskid,int userid);
        BindingList<TaskList> showtask_forUser(int user_id);
        int getNextTaskId(int user_id);
        BindingList<TaskList> gettask_byStatus(int userId, bool status);
    }
}
