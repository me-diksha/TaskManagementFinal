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
    public partial class EmployeeDash : Form
    {
        UserData current_user;
        TaskController _controllertask = new TaskController();
        public EmployeeDash(UserData user)
        {
            InitializeComponent();
            current_user = user;
            logged_name.Text = _controllertask.getInfo(current_user.Id);
            logged_role.Text = _controllertask.getrole(current_user.Id);
          
            RefreshGrid();
        }



        private void RefreshGrid()
        {
          
            dataGridView1.DataSource = _controllertask.showtask(current_user.Id);
            dataGridView1.Columns["UserId"].Visible = false;
         
        }





        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm(current_user.Id);
            f.ShowDialog();
            
            RefreshGrid();

        }



        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            TaskList task = (TaskList)dataGridView1.CurrentRow.DataBoundItem;
            new EditForm(task).ShowDialog();
            
            RefreshGrid();

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
                MessageBox.Show("Item deleted.");
                RefreshGrid();
            }
            else
            {
             
                MessageBox.Show("Operation cancelled.");
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
