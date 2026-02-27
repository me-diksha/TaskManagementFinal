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
    public partial class EditForm : Form
    {
        public TaskList selectedTask;
        private readonly APITaskService _taskservice;
       
        public EditForm(APITaskService taskservice)
        {
            InitializeComponent();
           _taskservice = taskservice;
         

        }

        public void SetTask(TaskList task)
        {
            selectedTask = task;
            
            update_description.Text = selectedTask.description;
            chkStatus.Checked = selectedTask.status;

        }
        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            selectedTask.Description = update_description.Text;
            selectedTask.Status=chkStatus.Checked;
            
                
            
            bool result= await _taskservice.Updatetask(selectedTask);
            if (result)
            {
                MessageBox.Show(" Task updated ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
