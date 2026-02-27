using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskManagement.Controller;
using TaskManagement.Model;
using Npgsql;
using TaskManagement.DataAccess;
using TaskManagement.Services.Interface;


namespace TaskManagement.Controller
{
    public class TaskController
    {
        private readonly ITaskService _taskservice;
        public TaskController(ITaskService taskservice)
        {
            _taskservice = taskservice;
        }

        public BindingList<TaskList> showtask(int user_id)
        {
           
           return _taskservice.showtask_forUser(user_id);
        }



      
       


       /* public  string getInfo(int user_id)
        {
            
            using (var conn = DBHelper.GetConnection()) { 
             conn.Open();
             
                using(var cmd= new NpgsqlCommand("SELECT getinfo_fun(@id);", conn))
                {
                    cmd.Parameters.AddWithValue("@id", user_id);
                    return cmd.ExecuteScalar()?.ToString();
                }
            }
            
        }
       */

       /* public string getrole(int user_id)
        {
         
           using(var conn = DBHelper.GetConnection())
            {
                conn.Open();
               
                using( var cmd = new NpgsqlCommand("SELECT getrole_fun(@id);",conn))
                {
                    cmd.Parameters.AddWithValue("@id",user_id);
                    return cmd.ExecuteScalar()?.ToString();
                }
            }
            
        }
       */


       /* public int getNextTaskId(int user_id)
        {
            using (var conn = DBHelper.GetConnection()) {
                conn.Open();

                using(var cmd=new NpgsqlCommand("SELECT get_next_taskid_fun(@uid);", conn))
                {
                    cmd.Parameters.AddWithValue("@uid", user_id);
                   
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
          
           return _taskservice.getNextTaskId(user_id);
            
        }
       */


        public void AddTask(TaskList task) {
           
            
         /*   using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("CALL add_task_proc(@uid,@tid,@desc,@status);", conn))
                {
                    int nextid = getNextTaskId(task.userId);
                    task.taskId = nextid;
                    cmd.Parameters.AddWithValue("@uid", task.userId);
                    cmd.Parameters.AddWithValue("@tid", task.taskId);
                    cmd.Parameters.AddWithValue("@desc", task.description);
                    cmd.Parameters.AddWithValue("@status", task.status);


                    cmd.ExecuteNonQuery(); 

                }

            }
         */
                  _taskservice.AddTask(task);
            }


       
        public void updatetask(TaskList task)
        {
            /*using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                
                using (var cmd = new NpgsqlCommand("CALL update_task_proc(@tid,@uid,@desc,@status);", conn))
                {
                    cmd.Parameters.AddWithValue("@desc", task.description);
                    cmd.Parameters.AddWithValue("@status", task.status);
                    cmd.Parameters.AddWithValue("@tid", task.taskId);
                    cmd.Parameters.AddWithValue("@uid", task.userId);


                    cmd.ExecuteNonQuery();
                }
            }
            */
            _taskservice.updatetask(task);
        }


        public void deletetask(TaskList task)
        {
         

           /* using (var conn = DBHelper.GetConnection())
            {
                conn.Open();

               
                using (var cmd = new NpgsqlCommand("CALL delete_task_proc(@tid,@uid);", conn))
                {
                    cmd.Parameters.AddWithValue("@tid", task.taskId);
                    cmd.Parameters.AddWithValue("@uid", task.userId);

                    cmd.ExecuteNonQuery();
                }
            }*/
           _taskservice.deletetask(task);
        }



       /* public BindingList<UserData> getall(string getrole)

        {
            BindingList<UserData> giveuser= new BindingList<UserData>();
            
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                
                using( var cmd = new NpgsqlCommand("SELECT * FROM getall_fun(@role);",conn))
                {
                    cmd.Parameters.AddWithValue("@role", getrole);

                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            giveuser.Add(new UserData
                            {
                                Id= reader.GetInt32(0),
                                Username= reader.GetString(1),
                                Role= reader.GetString(2)

                            });
                        }
                    }
                }
            }
            return giveuser;
        }
       */



       
        public BindingList<TaskList> gettask_byStatus(int userId, bool status)
        {
            return _taskservice.gettask_byStatus(userId, status);
        }

       /* public BindingList<TaskList> completed_task(int userId,bool status)
        {
            BindingList<TaskList> task_cmp = new BindingList<TaskList>();
           
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                
                using (var cmd = new NpgsqlCommand("SELECT *FROM completedtask_fun(@userId,@status);", conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue ("@status", status);

                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            task_cmp.Add(new TaskList{ 
                            taskId = reader.GetInt32(0),
                            description=reader.GetString(1),
                            status =reader.GetBoolean(2)
                            });
                        }
                    }
                }
                }
            return task_cmp;
        }
       */


       


       /* public BindingList<TaskList> pending_task(int userId,bool status)
        {
            BindingList<TaskList> task_pending = new BindingList<TaskList>();
            
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
              
                using (var cmd = new NpgsqlCommand("SELECT * FROM pendingtask_fun(@userId,@status);", conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@status", status);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            task_pending.Add(new TaskList
                            {
                                taskId = reader.GetInt32(0),
                                description = reader.GetString(1),
                                status = reader.GetBoolean(2)
                            });
                        }
                    }
                }
            }


            return task_pending;
        }
       */

       

  
       /* public void addNewUser(string addusername, string addpassword,string role)
        {
            using (var conn = DBHelper.GetConnection()) {
                conn.Open();
              
                using (var cmd = new NpgsqlCommand("CALL addNewUser_proc(@addusername,@addpassword,@role);", conn))
                {
                    cmd.Parameters.AddWithValue("@addusername", addusername);
                    cmd.Parameters.AddWithValue("@addpassword", addpassword);
                    cmd.Parameters.AddWithValue("@role", role);

                    cmd.ExecuteNonQuery();
                }
            }
            
        }*/
    }
}
