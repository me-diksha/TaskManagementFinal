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
    public partial class AdminDash : Form
    {
        TaskController controller = new TaskController();
        UserData curruser;
        public AdminDash(UserData user)
        {
            InitializeComponent();
            curruser = user;
            logged_name.Text = controller.getInfo(curruser.Id);
            logged_role.Text = controller.getrole(curruser.Id);
            dataGridView1.DataSource = controller.getall("employee");
            dataGridView1.Columns["Password"].Visible = false;

            //to add show task button
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Show Task";
            btnColumn.Text = "View";
            btnColumn.Name = "btnView";
            btnColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(btnColumn);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnView")
            {
                int userId = Convert.ToInt32(
            dataGridView1.Rows[e.RowIndex].Cells["Id"].Value
              );
                EmpTaskForm empTaskForm = new EmpTaskForm(userId);
                empTaskForm.ShowDialog();
            }
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }

        private void closebox_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }
    }
}
