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
    public partial class EmpTaskForm : Form
    {
        TaskController controller = new TaskController();
        int userId;
        public EmpTaskForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            info.Text = controller.getInfo(userId);
            dataGridView1.DataSource = controller.showtask(userId);
            //dataGridView1.Columns["userId"].Visible = false;
            RefreshGrid();
        }


        private void RefreshGrid()
        {
            dataGridView1.Columns["userId"].Visible = false;
            //dataGridView1.Columns["taskId"].HeaderText = "TaskID";
            //dataGridView1.Columns["description"].HeaderText = "Description";
            //dataGridView1.Columns["status"].HeaderText = "Is Completed";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }
        private void buttoncompleted_task_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.completed_task(userId,true);
            //dataGridView1.Columns["userId"].Visible = false;
            RefreshGrid();
        }



        private void buttonpendingtask_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.pending_task(userId,false);
            //dataGridView1.Columns["userId"].Visible = false;
            RefreshGrid();
        }



        private void buttonshowtask_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.showtask(userId);
            //dataGridView1.Columns["userId"].Visible = false;
            RefreshGrid();
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

        private void button1_Click(object sender, EventArgs e)
        {  //when back btn clicked
            this.Close();
        }

        private void EmpTaskForm_Load(object sender, EventArgs e)
        {
            //dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
        }
    }
}
