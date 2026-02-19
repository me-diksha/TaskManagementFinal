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
        TaskController _taskcontroller;
        LogInController _controllerauth;
        int userId;
        public EmpTaskForm(TaskController controller,LogInController controllerauth)
        {
            InitializeComponent();
            
            _controllerauth = controllerauth;
            _taskcontroller = controller;
            
        }
        public void GetuserId(int user_Id)
        {
            userId = user_Id;
            info.Text = _controllerauth.getInfo(userId);
            dataGridView1.DataSource = _taskcontroller.showtask(userId);
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridView1.Columns["userId"].Visible = false;
            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }
        private void buttoncompleted_task_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _taskcontroller.gettask_byStatus(userId,true);
         
            RefreshGrid();
        }



        private void buttonpendingtask_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _taskcontroller.gettask_byStatus(userId,false);
            
            RefreshGrid();
        }



        private void buttonshowtask_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _taskcontroller.showtask(userId);
            
            RefreshGrid();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {  
            //when back btn clicked
            this.Close();
        }

        private void EmpTaskForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
