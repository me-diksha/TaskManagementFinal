using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManagement.Model;
using TaskManagement.Apiservices;

namespace TaskManagement
{
    public partial class AddForm : Form
    {
        int curruser_id;
        private readonly APITaskService _taskservice;
        BindingList<TaskList> _taskBindingList;
        public AddForm(  APITaskService taskservice)
        {
            InitializeComponent();
            _taskservice = taskservice;
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

        private async void buttonSave_Click(object sender, EventArgs e)
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
            var result= await _taskservice.Addtask(newtask);
            if (result!=null) {
                _taskBindingList.Add(result);
                MessageBox.Show("Task added ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
                MessageBox.Show("Operation canceled! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            
            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
