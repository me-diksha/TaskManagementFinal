using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManagement.Model;
using TaskManagement.Controller;
using Microsoft.Extensions.DependencyInjection;

namespace TaskManagement
{
    public partial class AdminDash : Form
    {
        TaskController _taskcontroller;
        LogInController _controllerauth;
        UserData current_user;
        public AdminDash(LogInController controllerauth,TaskController controller)
        {
            InitializeComponent();
          
            _controllerauth = controllerauth;
            _taskcontroller = controller;
            
            dataGridView1.DataSource = _controllerauth.getall("employee");
            dataGridView1.Columns["Password"].Visible = false;

            //to add show task button
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Show Task";
            btnColumn.Text = "View";
            btnColumn.Name = "btnView";
            btnColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(btnColumn);

        }
        public void SetUserData(UserData user)
        {
            current_user = user;
            logged_name.Text = _controllerauth.getInfo(current_user.Id);
            logged_role.Text = _controllerauth.getrole(current_user.Id);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnView")
            {
                int userId = Convert.ToInt32(
            dataGridView1.Rows[e.RowIndex].Cells["Id"].Value
              );
                
                var empTaskForm=Program.serviceProvider.GetRequiredService<EmpTaskForm>();
                empTaskForm.GetuserId(userId);
                empTaskForm.ShowDialog();
            }
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closebox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
