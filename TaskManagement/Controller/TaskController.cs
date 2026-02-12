using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskManagement.Controller;
using TaskManagement.Model;
using Npgsql;
using TaskManagement.DBconnection;


namespace TaskManagement.Controller
{
    public class TaskController
    {


        public BindingList<TaskList> showtask(int user_id)
        {
            BindingList<TaskList> task_currentuser = new BindingList<TaskList>();
            
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                //string query = "SELECT taskid,description,status FROM tasklist WHERE userid=@uid ";
                using (var cmd = new NpgsqlCommand("SELECT * FROM showtask_fun(@uid);", conn))
                {
                    cmd.Parameters.AddWithValue("@uid", user_id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) {
                            task_currentuser.Add(new TaskList
                            {  userId=user_id,
                               taskId=reader.GetInt32(0),
                               description=reader.GetString(1),
                               status=reader.GetBoolean(2)

                            });
                        } 
                    }
                }
            }
            return task_currentuser;
        }




        public void changepassword(string username_added,string updated_password)
        {
            using (var conn = DBHelper.GetConnection()) {
                conn.Open();
                //string query = "UPDATE userdata SET password=@updated_password WHERE username=@username_added;";
                using (var cmd = new NpgsqlCommand("CALL changepassword_proc(@username_added,@updated_password);", conn))
                {


                    cmd.Parameters.AddWithValue("@username_added", username_added);
                    cmd.Parameters.AddWithValue("@updated_password", updated_password);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        


        public  string getInfo(int user_id)
        {
            
            using (var conn = DBHelper.GetConnection()) { 
             conn.Open();
                //string query = "SELECT username FROM userdata WHERE id=@id";
                using(var cmd= new NpgsqlCommand("SELECT getinfo_fun(@id);", conn))
                {
                    cmd.Parameters.AddWithValue("@id", user_id);
                    return cmd.ExecuteScalar()?.ToString();
                }
            }
            
        }


        public string getrole(int user_id)
        {
         
           using(var conn = DBHelper.GetConnection())
            {
                conn.Open();
                //string query = "SELECT role FROM userdata WHERE id=@id";
                using( var cmd = new NpgsqlCommand("SELECT getrole_fun(@id);",conn))
                {
                    cmd.Parameters.AddWithValue("@id",user_id);
                    return cmd.ExecuteScalar()?.ToString();
                }
            }
            
        }



        public int getNextTaskId(int user_id)
        {
            using (var conn = DBHelper.GetConnection()) {
                conn.Open();

                //string query = "SELECT COALESCE(MAX(taskid),0)+1 FROM tasklist WHERE userid=@uid";
                using(var cmd=new NpgsqlCommand("SELECT get_next_taskid_fun(@uid);", conn))
                {
                    cmd.Parameters.AddWithValue("@uid", user_id);
                   
                    //using execute scalar to directly get single value
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            
        }


        public void AddTask(TaskList task) {
           
            //for db
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                //string query = "INSERT INTO tasklist(userid,taskid,description,status) VALUES (@uid,@tid,@desc,@status);";
                using (var cmd = new NpgsqlCommand("CALL add_task_proc(@uid,@tid,@desc,@status);", conn))
                {
                    int nextid = getNextTaskId(task.userId);
                    task.taskId = nextid;
                    cmd.Parameters.AddWithValue("@uid", task.userId);
                    cmd.Parameters.AddWithValue("@tid", task.taskId);
                    cmd.Parameters.AddWithValue("@desc", task.description);
                    cmd.Parameters.AddWithValue("@status", task.status);


                    cmd.ExecuteNonQuery(); //when we dont want rows in return

                }

            }
            }


        //when edit button on employee click
        public void updatetask(TaskList task)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                //string query = "UPDATE tasklist SET description=@desc,status=@status WHERE taskid= @tid AND userid=@uid ";
                using (var cmd = new NpgsqlCommand("CALL update_task_proc(@tid,@uid,@desc,@status);", conn))
                {
                    cmd.Parameters.AddWithValue("@desc", task.description);
                    cmd.Parameters.AddWithValue("@status", task.status);
                    cmd.Parameters.AddWithValue("@tid", task.taskId);
                    cmd.Parameters.AddWithValue("@uid", task.userId);


                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void deletetask(TaskList task)
        {
         

            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();

                //string query = "DELETE FROM tasklist WHERE taskid=@tid AND userid=@uid;";
                using (var cmd = new NpgsqlCommand("CALL delete_task_proc(@tid,@uid);", conn))
                {
                    cmd.Parameters.AddWithValue("@tid", task.taskId);
                    cmd.Parameters.AddWithValue("@uid", task.userId);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public BindingList<UserData> getall(string getrole)

        {
            BindingList<UserData> giveuser= new BindingList<UserData>();
            
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                //string query = "SELECT id,username,role FROM userdata WHERE role=@role;";
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



       


        public BindingList<TaskList> completed_task(int userId,bool status)
        {
            BindingList<TaskList> task_cmp = new BindingList<TaskList>();
           
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                //string query="SELECT taskid,description,status FROM tasklist WHERE userid=@userId AND status=@status";
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


       


        public BindingList<TaskList> pending_task(int userId,bool status)
        {
            BindingList<TaskList> task_pending = new BindingList<TaskList>();
            
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                //string query = "SELECT taskid,description,status FROM tasklist WHERE userid=@userId AND status=@status";
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

       
        public void addNewUser(string addusername, string addpassword,string role)
        {
            using (var conn = DBHelper.GetConnection()) {
                conn.Open();
                //string query = "INSERT INTO userdata(username,password,role) VALUES (@addusername,@addpassword,@role);";
                using (var cmd = new NpgsqlCommand("CALL addNewUser_proc(@addusername,@addpassword,@role);", conn))
                {
                    cmd.Parameters.AddWithValue("@addusername", addusername);
                    cmd.Parameters.AddWithValue("@addpassword", addpassword);
                    cmd.Parameters.AddWithValue("@role", role);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
