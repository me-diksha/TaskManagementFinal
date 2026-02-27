using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManagement.Model;
using TaskManagement.Controller;
using TaskManagement.DataAccess;

namespace TaskManagement
{
    public partial class SignUpForm : Form
    {

        public LogInController _controllerauth;
        public SignUpForm(LogInController controller)
        {
            InitializeComponent();

            _controllerauth = controller;
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
            if (password_added.Text == confirmed_password.Text)
            {
                bool check = _controllerauth.userNameExist(username_added.Text.Trim());
                if (check == false)
                {
                    _controllerauth.addNewUser(username_added.Text.Trim(), confirmed_password.Text.Trim(), "employee");
                    MessageBox.Show(" Account Created ");
                    this.Close();
                }
                else
                {
                    warning.Text = "User Already Exist";
                    warning.Visible = true;
                }

            }
            else
            {
                warning.Text = "Password not same";
                warning.Visible = true;
            }
        }

        private void eyeopen_Click(object sender, EventArgs e)
        {
            password_added.UseSystemPasswordChar = true;
            eyeopen.Visible = false;
            eyeclose.Visible = true;
        }

        private void eyeclose_Click(object sender, EventArgs e)
        {
            password_added.UseSystemPasswordChar=false;
            eyeclose.Visible = false;
            eyeopen.Visible = true;

        }
    }
}
