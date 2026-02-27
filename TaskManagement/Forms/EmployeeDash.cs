using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManagement.Apiservices;

using TaskManagement.Model;


namespace TaskManagement
{
    public partial class EmployeeDash : Form
    {
        UserData current_user;
        private readonly APIauthService _authservice;
       
        private readonly APITaskService _taskService;
       
        BindingList<TaskList> tasks;
        public EmployeeDash(APIauthService authservice, APITaskService taskService)
        {
            InitializeComponent();
            
            _authservice = authservice;
            _taskService = taskService;
        }

        public async void SetUserData(UserData user)
        {
            current_user = user;
            logged_name.Text = await _authservice.getname(current_user.Id);
            logged_role.Text = await _authservice.getrole(current_user.Id);

             RefreshGrid();
        }

        private async  void RefreshGrid()
        {
            var taskslist = await _taskService.GetTask(current_user.Id);
            tasks=new BindingList<TaskList>(taskslist);
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



        private async void buttonDelete_Click(object sender, EventArgs e)
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
                bool ans = await _taskService.Deletetask(task);
                if (ans)
                {
                    MessageBox.Show("Item deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tasks.Remove(task);
                }
                else
                {

                    MessageBox.Show("Operation cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
