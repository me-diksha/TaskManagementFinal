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
        TaskController controller=new TaskController();
        public EditForm(TaskList t)
        {
            InitializeComponent();
            selectedTask = t;
            update_description.Text = selectedTask.description;
            //update_status.Text = Convert.ToString(selectedTask.status);
            chkStatus.Checked = selectedTask.status;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            selectedTask.description = update_description.Text;
            //selectedTask.status = Convert.ToBoolean(update_status.Text);
            selectedTask.status=chkStatus.Checked;
            controller.updatetask(selectedTask);
            MessageBox.Show(" Task updated ! ");
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
