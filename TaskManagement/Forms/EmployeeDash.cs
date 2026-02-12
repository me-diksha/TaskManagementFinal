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
            //dataGridView1.DataSource = _controllertask.showtask(current_user.Id);
            //dataGridView1.Columns["UserId"].Visible = false;
            RefreshGrid();
        }



        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _controllertask.showtask(current_user.Id);
            dataGridView1.Columns["UserId"].Visible = false;
            //dataGridView1.Columns["taskId"].HeaderText = "Task ID";
            //dataGridView1.Columns["description"].HeaderText = "Task Description";
            //dataGridView1.Columns["status"].HeaderText = "Is Completed";
            //dataGridView1.Columns["taskId"].Visible = false;
        }





        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm(current_user.Id);
            f.ShowDialog();
            //dataGridView1.Refresh();
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = _controllertask.showtask(current_user.Id);
            //dataGridView1.Columns["UserId"].Visible = false;
            RefreshGrid();

        }



        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            TaskList task = (TaskList)dataGridView1.CurrentRow.DataBoundItem;
            new EditForm(task).ShowDialog();
            //dataGridView1.Refresh();
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = _controllertask.showtask(current_user.Id);
            //dataGridView1.Columns["UserId"].Visible = false;
            RefreshGrid();

        }



        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            TaskList task = (TaskList)dataGridView1.CurrentRow.DataBoundItem;
            _controllertask.deletetask(task);
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = _controllertask.showtask(current_user.Id);
            //dataGridView1.Columns["UserId"].Visible = false;
            RefreshGrid();

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            TaskList task = (TaskList)dataGridView1.CurrentRow.DataBoundItem;
        }



        private void log_out_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }


        //private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        //{
        //    string rowNumber = (e.RowIndex + 1).ToString();

        //    using (SolidBrush brush = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
        //    {
        //        e.Graphics.DrawString(
        //            rowNumber,
        //            dataGridView1.Font,
        //            brush,
        //            e.RowBounds.Left + 10,
        //            e.RowBounds.Top + 4
        //        );
        //    }
        //}


        private void EmployeeDash_Load(object sender, EventArgs e)
        {
            //dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;

        }

        private void closebox_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }
    }
}
