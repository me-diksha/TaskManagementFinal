using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.Model
{
    public class TaskList
    { 
        public int userId {  get; set; }
        public int taskId { get; set; }
        public string description { get; set; }
        public bool status { get; set; }
    }
}
