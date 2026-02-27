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
    public partial class EditForm : Form
    {
        public TaskList selectedTask;
        TaskController _taskcontroller;
       
        public EditForm(TaskController controller)
        {
            InitializeComponent();
            _taskcontroller = controller;
         

        }

        public void SetTask(TaskList task)
        {
            selectedTask = task;
            
            update_description.Text = selectedTask.description;
            chkStatus.Checked = selectedTask.status;

        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            selectedTask.Description = update_description.Text;
            selectedTask.Status=chkStatus.Checked;
            
                
            
            _taskcontroller.updatetask(selectedTask);
            
            MessageBox.Show(" Task updated ! ","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
