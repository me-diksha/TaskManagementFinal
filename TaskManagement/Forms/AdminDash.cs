using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManagement.Model;
using TaskManagement.Apiservices;

using Microsoft.Extensions.DependencyInjection;

namespace TaskManagement
{
    public partial class AdminDash : Form
    {
        private readonly APIauthService _authservice;

        private readonly APITaskService _taskService;
        UserData current_user;
        public AdminDash(APIauthService authservice, APITaskService taskService)
        {
            InitializeComponent();

            _authservice = authservice;
            _taskService = taskService;
           

        }
        public void SetUserData(UserData user)
        {
            current_user = user;
            //logged_name.Text = _controllerauth.getInfo(current_user.Id);
            logged_name.Text = user.Username;
            logged_role.Text = user.Role;
            //logged_role.Text = _controllerauth.getrole(current_user.Id);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnView")
            {
                int userId = Convert.ToInt32(
            dataGridView1.Rows[e.RowIndex].Cells["Id"].Value
              );

                var empTaskForm = Program.serviceProvider.GetRequiredService<EmpTaskForm>();
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

        //private void AdminDash_Load(object sender, EventArgs e)
        //{
        //    dataGridView1.DataSource = _authservice.getallUser("employee");
        //    dataGridView1.Columns["Password"].Visible = false;

        //    //to add show task button
        //    DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
        //    btnColumn.HeaderText = "Show Task";
        //    btnColumn.Text = "View";
        //    btnColumn.Name = "btnView";
        //    btnColumn.UseColumnTextForButtonValue = true;

        //    dataGridView1.Columns.Add(btnColumn);
        //}
        private async void AdminDash_Load(object sender, EventArgs e)
        {
            try
            {
                var users = await _authservice.getallUser("employee");

                dataGridView1.DataSource = users;
                dataGridView1.Columns["Password"].Visible = false;

                // Add button column safely
                if (!dataGridView1.Columns.Contains("btnView"))
                {
                    DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                    btnColumn.HeaderText = "Show Task";
                    btnColumn.Text = "View";
                    btnColumn.Name = "btnView";
                    btnColumn.UseColumnTextForButtonValue = true;

                    dataGridView1.Columns.Add(btnColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }
    }
}
