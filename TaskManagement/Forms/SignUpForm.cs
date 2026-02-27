using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManagement.Apiservices;

using TaskManagement.Model;


namespace TaskManagement
{
    public partial class SignUpForm : Form
    {

        private readonly APIauthService _authservice;
        public SignUpForm(APIauthService authservice)
        {
            InitializeComponent();

            _authservice = authservice;
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


        private async void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (username_added.Text == "" || password_added.Text == "" || confirmed_password.Text == "")
            {
                MessageBox.Show("Enter username and Password !");
                return;
            }
            if (password_added.Text == confirmed_password.Text)
            {
                bool check = await _authservice.usernameExist(username_added.Text.Trim());
                if (check == false)
                {
                   bool result= await _authservice.Adduser(username_added.Text.Trim(), confirmed_password.Text.Trim(), "employee");
                    if(result)MessageBox.Show(" Account Created ");
                    else
                    {
                        MessageBox.Show("User Not added !", "Information");
                    }
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
