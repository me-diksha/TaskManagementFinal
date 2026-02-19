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
        TaskController _controllertask ;
        BindingList<TaskList> _taskBindingList;
        public AddForm(TaskController controller)
        {
            InitializeComponent();
            _controllertask = controller;
            new_description.Text = "";
        }

        public void SetUserId(int id,BindingList<TaskList>ta)
        {
            curruser_id = id;
            _taskBindingList= ta;

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (new_description.Text == "")
            {
                MessageBox.Show("Add task description", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            TaskList newtask = new TaskList
            {
               
                userId = curruser_id,
                description = new_description.Text,
                status = chkstatus.Checked
            };
            _controllertask.AddTask(newtask);
            _taskBindingList.Add(newtask);
            MessageBox.Show("Task added ! ","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
