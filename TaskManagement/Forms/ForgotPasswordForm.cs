using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManagement.Controller;
using TaskManagement.Model;
using TaskManagement.Forms;
using TaskManagement.DBconnection;

namespace TaskManagement.Forms
{
    public partial class ForgotPasswordForm : Form
    {
        LogInController _controllauth = new LogInController();
        TaskController _taskController = new TaskController();
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void verify_button_Click(object sender, EventArgs e)
        {
            bool check = _controllauth.userNameExist(username_added.Text.Trim());
            if (check)
            {
                password_added.Visible = true;
                confirmed_password.Visible = true;
                buttonReset.Visible = true;
                warning.Visible = false;
            }
            else
            {
                warning.Text = "Username Not Exist ";
                warning.Visible = true;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (password_added.Text == "" || confirmed_password.Text == "")
            {
                MessageBox.Show("Enter username and Password !");
                return;
            }
            if (password_added.Text == confirmed_password.Text)
            {
                _taskController.changepassword(username_added.Text.Trim(), confirmed_password.Text.Trim());
                MessageBox.Show("Password Changed");
                this.Close();

            }
            else
            {
                warning.Text = "User Already Exist";
                warning.Visible = true;
            }
        }

        private void close_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
