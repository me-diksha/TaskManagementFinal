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
using Microsoft.Extensions.DependencyInjection;
namespace TaskManagement
{
    public partial class LogInForm : Form
    {
        private readonly LogInController _controllerauth;
        private readonly IServiceProvider _serviceProvider;
        public LogInForm(IServiceProvider provider,LogInController controller)
        {
            InitializeComponent();
            _controllerauth = controller;
            _serviceProvider = provider;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //login button
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
                   
                    //new EmployeeDash(newuser).Show();
                    var employeeDash = _serviceProvider.GetRequiredService<EmployeeDash>();
                    employeeDash.SetUserData(newuser);
                    employeeDash.Show();
                   
                }
                else
                {

                  
                    var admindash=_serviceProvider.GetRequiredService<AdminDash>();
                    admindash.SetUserData(newuser);
                    admindash.Show();
                    
                }
            }
        }

        private void ask_create_account_Click(object sender, EventArgs e)
        {
            var signupForm = _serviceProvider.GetRequiredService<SignUpForm>();
            signupForm.Show();
        }



      
        private void eyeopen_Click(object sender, EventArgs e)
        {
            password_added.UseSystemPasswordChar = true;
            eyeopen.Visible = false;
            eyeclose.Visible = true;
        }

        private void eyeclose_Click(object sender, EventArgs e)
        {
            password_added.UseSystemPasswordChar = false;
            eyeclose.Visible = false;
            eyeopen.Visible = true;

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
            var forgotPasswordForm = _serviceProvider.GetRequiredService<ForgotPasswordForm>();
            forgotPasswordForm.Show();
        }
    }
}
