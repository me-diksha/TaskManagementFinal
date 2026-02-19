using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManagement.Controller;
using TaskManagement.Model;


namespace TaskManagement
{
    public partial class EmployeeDash : Form
    {
        UserData current_user;
        TaskController _controllertask ;
        LogInController _controllerauth;
        BindingList<TaskList> tasks=new BindingList<TaskList>();
        public EmployeeDash(LogInController contollerauth,TaskController controller)
        {
            InitializeComponent();
            _controllertask = controller;
            _controllerauth = contollerauth;
           
        }

        public void SetUserData(UserData user)
        {
            current_user = user;
            logged_name.Text = _controllerauth.getInfo(current_user.Id);
            logged_role.Text = _controllerauth.getrole(current_user.Id);

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            tasks = _controllertask.showtask(current_user.Id);
            dataGridView1.DataSource = tasks;
            dataGridView1.Columns["UserId"].Visible = false;
         
        }





        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = Program.serviceProvider.GetRequiredService<AddForm>();
            addForm.SetUserId(current_user.Id,tasks);
            addForm.Show();
          
        }



        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            TaskList task = (TaskList)dataGridView1.CurrentRow.DataBoundItem;
            
            var editForm = Program.serviceProvider.GetRequiredService<EditForm>();
            editForm.SetTask(task);
            editForm.Show();
            //if (editForm.ShowDialog(this) == DialogResult.OK)
            //{
            //    RefreshGrid();
               
            //}
        }



        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            
            
            
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this item?",
                      "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (result == DialogResult.Yes)
            {
              
                TaskList task = (TaskList)dataGridView1.CurrentRow.DataBoundItem;
                _controllertask.deletetask(task);
                MessageBox.Show("Item deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tasks.Remove(task);
            }
            else
            {
             
                MessageBox.Show("Operation cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            TaskList task = (TaskList)dataGridView1.CurrentRow.DataBoundItem;
        }



        private void log_out_Click(object sender, EventArgs e)
        {
        
            this.Close();
        }


       


        private void EmployeeDash_Load(object sender, EventArgs e)
        {
            

        }

        private void closebox_Click(object sender, EventArgs e)
        {
            this.Close();
       
        }
    }
}
