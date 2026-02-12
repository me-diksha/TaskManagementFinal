using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManagement.Model;
using TaskManagement.Controller;
namespace TaskManagement
{
    public partial class AddForm : Form
    {
        int curruser_id;
        TaskController _controllertask = new TaskController();
        public AddForm(int currid)
        {
            InitializeComponent();
            curruser_id = currid;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (new_description.Text == "")
            {
                MessageBox.Show("Add task description ");
                return;
            }
            //int nextTaskId = 1;
            //foreach (TaskList task in Data.tasks)
            //{
            //    if (task.userId == curruser_id && task.taskId >= nextTaskId)
            //    {
            //        nextTaskId = task.taskId + 1;
            //    }
            //}
            TaskList newtask = new TaskList
            {
                //taskId = nextTaskId,
                userId = curruser_id,
                description = new_description.Text,
                status = chkstatus.Checked
            };
            _controllertask.AddTask(newtask);
            MessageBox.Show("Task added ! ");
            
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
