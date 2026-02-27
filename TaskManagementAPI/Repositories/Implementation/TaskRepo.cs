using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskManagementAPI.DataAccess.Interfaces;
using TaskManagementAPI.Model;
using TaskManagementAPI.Repositories.Interface;

//interact with tasklist table
namespace TaskManagementAPI.Repositories.Implementation
{
    public class TaskRepo:ITaskRepo
    {
        private readonly IDataAccess _dataAccess;
        public TaskRepo(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
       public void AddTask(TaskList task) {
            int nextid = getNextTaskId(task.userId);
            task.taskId = nextid;
            string sql = "CALL add_task_proc(@uid,@tid,@desc,@status);";
            var parameters = new Dictionary<string, object>
            {
                {"@uid", task.userId},
                { "@tid", task.taskId},
                { "@desc", task.description},
                {"@status", task.status }
                
              
            };
            _dataAccess.ExecuteNonQuery(sql, parameters);

        }


        public void updatetask(TaskList task) {
            string sql = "CALL update_task_proc(@tid,@uid,@desc,@status);";
            var parameters = new Dictionary<string, object>
            {
                {"@uid", task.userId},
                { "@tid", task.taskId},
                { "@desc", task.description},
                {"@status", task.status }


            };
            _dataAccess.ExecuteNonQuery(sql, parameters);
        }


       public void deletetask(int taskid,int userid) {
            string sql = "CALL delete_task_proc(@tid,@uid);";
            var parameters = new Dictionary<string, object>
            {
                {"@uid", userid},
                { "@tid", taskid}
               


            };
            _dataAccess.ExecuteNonQuery(sql, parameters);
        }


        public BindingList<TaskList> showtask_forUser(int user_id) {
            BindingList<TaskList> task_currentuser = new BindingList<TaskList>();
            string sql = "SELECT * FROM showtask_fun(@uid);";
            var parameters = new Dictionary<string, object>
            {
                {"@uid", user_id},

            };
            using var reader = _dataAccess.ExecuteReader(sql, parameters);
            while (reader.Read())
            {
                task_currentuser.Add(new TaskList
                {
                    userId = user_id,
                    taskId = reader.GetInt32(0),
                    description = reader.GetString(1),
                    status = reader.GetBoolean(2)

                });
            }

            return task_currentuser;
        }


       public int getNextTaskId(int user_id) {

            string sql = "SELECT get_next_taskid_fun(@uid);";
            var parameters = new Dictionary<string, object>
            {
                {"@uid", user_id},

            };
           return Convert.ToInt32( _dataAccess.ExecuteScalar(sql, parameters)); 
        }


       public BindingList<TaskList> gettask_byStatus(int userId, bool status) {

            BindingList<TaskList> task_cmp = new BindingList<TaskList>();
            string sql = "SELECT *FROM completedtask_fun(@userId,@status);";
            var parameters = new Dictionary<string, object>
            {
                {"@userId", userId },
                {"@status", status }
            };
            using var reader = _dataAccess.ExecuteReader(sql, parameters);
            while (reader.Read())
            {
                task_cmp.Add(new TaskList
                {
                
                    taskId = reader.GetInt32(0),
                    description = reader.GetString(1),
                    status = reader.GetBoolean(2)

                });
            }
            return task_cmp;
        }

    }
}
