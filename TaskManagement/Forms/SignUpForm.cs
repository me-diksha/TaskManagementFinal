using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManagement.Model;
using TaskManagement.Controller;
using TaskManagement.DBconnection;

namespace TaskManagement
{
    public partial class SignUpForm : Form
    {
        public TaskController controller;
        public LogInController _controllerauth;
        public SignUpForm()
        {
            InitializeComponent();
            controller = new TaskController();
            _controllerauth=new LogInController();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (username_added.Text == "" || password_added.Text == "" || confirmed_password.Text == "")
            {
                MessageBox.Show("Enter username and Password !");
                return;
            }
            if (password_added.Text == confirmed_password.Text) {
                bool check = _controllerauth.userNameExist(username_added.Text.Trim());
                if (check == false)
                {
                    controller.addNewUser(username_added.Text.Trim(), confirmed_password.Text.Trim(), "employee");
                    MessageBox.Show(" Account Created ");
                    this.Close();
                }
                else
                {
                    warning.Text = "User Already Exist";
                    warning.Visible = true;
                }
                //controller.addNewUser(username_added.Text.Trim(),confirmed_password.Text.Trim(),"employee");
                //this.Close();
            }
            else
            {
                warning.Text = "Password not same";
                warning.Visible = true;
            }
        }
    }
}
