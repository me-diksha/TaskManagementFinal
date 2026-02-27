using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManagement.Model;

using TaskManagement.Apiservices;

namespace TaskManagement
{
    public partial class EmpTaskForm : Form
    {
        private readonly APIauthService _authservice;

        private readonly APITaskService _taskService;
        int userId;
        public EmpTaskForm(APIauthService authservice, APITaskService taskService)
        {
            InitializeComponent();

            _authservice = authservice;
            _taskService = taskService;
        }
        public async void GetuserId(int user_Id)
        {
            userId = user_Id;
            info.Text = await _authservice.getname(userId);
            dataGridView1.DataSource = await _taskService.GetTask(userId);
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridView1.Columns["UserId"].Visible = false;
            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }
        private async void buttoncompleted_task_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =await _taskService.GetTaskByStatus(userId,true);
         
            RefreshGrid();
        }



        private async void buttonpendingtask_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await _taskService.GetTaskByStatus(userId,false);
            
            RefreshGrid();
        }



        private async void buttonshowtask_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await _taskService.GetTask(userId);
            
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
