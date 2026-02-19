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
using TaskManagement.DataAccess;

namespace TaskManagement.Forms
{
    public partial class ForgotPasswordForm : Form
    {
        LogInController _controllauth;
       
        public ForgotPasswordForm(LogInController controlauth)
        {
            InitializeComponent();
            _controllauth = controlauth;
           
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
                eyeclose.Visible = true;
            }
            else
            {
                warning.Text = "Username Not Exist ";
                warning.Visible = true;
                password_added.Visible =false;
                confirmed_password.Visible = false;
                buttonReset.Visible = false;
                eyeclose.Visible = true;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            bool check = _controllauth.userNameExist(username_added.Text.Trim());
            if (check)
            {
                if (password_added.Text == "" || confirmed_password.Text == "")
                {
                    MessageBox.Show("Enter username and Password !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (password_added.Text == confirmed_password.Text)
                {   warning.Visible = false;
                    _controllauth.changepassword(username_added.Text.Trim(), confirmed_password.Text.Trim());
                    MessageBox.Show("Password Changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
            }
            else
            {
                warning.Text = "Username Not Exist";
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
            password_added.UseSystemPasswordChar = false;
            eyeclose.Visible = false;
            eyeopen.Visible = true;

        }
        private void close_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
