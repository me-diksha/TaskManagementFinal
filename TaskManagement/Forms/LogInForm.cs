using TaskManagement.Model;
using TaskManagement.Controller;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManagement.Forms;
namespace TaskManagement
{
    public partial class LogInForm : Form
    {
        LogInController _controllerauth = new LogInController();
        public LogInForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username_added.Text == "" || password_added.Text == "" || username_added.Text == "Enter username")
            {
                MessageBox.Show("Enter username and Password !");
                return;
            }
            UserData newuser = _controllerauth.authenticate(username_added.Text.Trim(), password_added.Text.Trim());
            if (newuser == null)
            {
                warning.Text = "Invalid Username and Password";
                warning.Visible = true;
                return;
            }
            else
            {
                warning.Visible=false;
                if (newuser.Role == "employee")
                {
                    new EmployeeDash(newuser).Show();
                }
                else
                {

                    new AdminDash(newuser).Show();
                }
            }
        }

        private void ask_create_account_Click(object sender, EventArgs e)
        {
            SignUpForm f = new SignUpForm();
            f.Show();
        }



        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (password_added.Text == "Enter password")
                return;

            password_added.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void close_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void forgot_page_load_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm f = new ForgotPasswordForm();
            f.Show();
        }
    }
}
