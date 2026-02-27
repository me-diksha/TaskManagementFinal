using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManagement.Apiservices;

using TaskManagement.Forms;
using TaskManagement.Model;


namespace TaskManagement.Forms
{
    public partial class ForgotPasswordForm : Form
    {
        private readonly APIauthService _authservice;


        public ForgotPasswordForm(APIauthService authservice)
        {
            InitializeComponent();
            _authservice = authservice;

        }

        private async void verify_button_Click(object sender, EventArgs e)
        {
            bool check = await _authservice.usernameExist(username_added.Text.Trim());
            if (check)
            {
                //password_added.Visible = true;
                confirmed_password.Visible = true;
                buttonReset.Visible = true;
                warning.Visible = false;
                eyeclose.Visible = true;
            }
            else
            {
                warning.Text = "Username Not Exist ";
                warning.Visible = true;
                //password_added.Visible =false;
                confirmed_password.Visible = false;
                buttonReset.Visible = false;
                eyeclose.Visible = false;
            }
        }

        private async void buttonReset_Click(object sender, EventArgs e)
        {
            bool check = await _authservice.usernameExist(username_added.Text.Trim());

            if (check)
            {

                if (confirmed_password.Text == "")
                {
                    MessageBox.Show("Enter username and Password !",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                warning.Visible = false;

                bool result = await _authservice.changePassword(
                    username_added.Text.Trim(),
                    confirmed_password.Text.Trim()
                );

                if (result)
                {
                    MessageBox.Show("Password Changed",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password not Changed",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();

                //else
                //{
                //    warning.Visible = true;
                //    warning.Text = "Passwords do not match!";
                //}
            }
            else
            {
                MessageBox.Show("Username does not exist",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eyeopen_Click(object sender, EventArgs e)
        {
            confirmed_password.UseSystemPasswordChar = true;
            eyeopen.Visible = false;
            eyeclose.Visible = true;
        }

        private void eyeclose_Click(object sender, EventArgs e)
        {
            confirmed_password.UseSystemPasswordChar = false;
            eyeclose.Visible = false;
            eyeopen.Visible = true;

        }
        private void close_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
