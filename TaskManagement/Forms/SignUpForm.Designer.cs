namespace TaskManagement
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            warning = new Label();
            confirmed_password = new TextBox();
            close_form = new Label();
            buttonSignUp = new Button();
            password_added = new TextBox();
            username_added = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.DarkGoldenrod;
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.ControlLightLight;
            splitContainer1.Panel2.Controls.Add(warning);
            splitContainer1.Panel2.Controls.Add(confirmed_password);
            splitContainer1.Panel2.Controls.Add(close_form);
            splitContainer1.Panel2.Controls.Add(buttonSignUp);
            splitContainer1.Panel2.Controls.Add(password_added);
            splitContainer1.Panel2.Controls.Add(username_added);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(694, 338);
            splitContainer1.SplitterDistance = 250;
            splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(18, 164);
            label5.Name = "label5";
            label5.Size = new Size(117, 21);
            label5.TabIndex = 3;
            label5.Text = "INDIA Pvt. Ltd.";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(12, 134);
            label4.Name = "label4";
            label4.Size = new Size(190, 30);
            label4.TabIndex = 2;
            label4.Text = "SONAR SOFTECH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(47, 80);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 1;
            label3.Text = "WELCOME";
            // 
            // warning
            // 
            warning.AutoSize = true;
            warning.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            warning.ForeColor = Color.Firebrick;
            warning.Location = new Point(138, 114);
            warning.Name = "warning";
            warning.Size = new Size(58, 17);
            warning.TabIndex = 13;
            warning.Text = "warning";
            warning.Visible = false;
            // 
            // confirmed_password
            // 
            confirmed_password.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmed_password.ForeColor = Color.DarkGoldenrod;
            confirmed_password.Location = new Point(102, 205);
            confirmed_password.Name = "confirmed_password";
            confirmed_password.PlaceholderText = "Confirm Password";
            confirmed_password.Size = new Size(228, 22);
            confirmed_password.TabIndex = 12;
            confirmed_password.TextAlign = HorizontalAlignment.Center;
            // 
            // close_form
            // 
            close_form.AutoSize = true;
            close_form.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close_form.ForeColor = Color.IndianRed;
            close_form.Location = new Point(395, 9);
            close_form.Name = "close_form";
            close_form.Size = new Size(23, 25);
            close_form.TabIndex = 11;
            close_form.Text = "X";
            close_form.Click += close_form_Click;
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.DarkGoldenrod;
            buttonSignUp.FlatStyle = FlatStyle.Flat;
            buttonSignUp.ForeColor = SystemColors.Control;
            buttonSignUp.Location = new Point(173, 246);
            buttonSignUp.Margin = new Padding(3, 2, 3, 2);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Padding = new Padding(2);
            buttonSignUp.Size = new Size(117, 39);
            buttonSignUp.TabIndex = 6;
            buttonSignUp.Text = "SIGN UP";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // password_added
            // 
            password_added.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password_added.ForeColor = Color.DarkGoldenrod;
            password_added.Location = new Point(102, 177);
            password_added.Name = "password_added";
            password_added.PlaceholderText = "Enter Password";
            password_added.Size = new Size(228, 22);
            password_added.TabIndex = 4;
            password_added.TextAlign = HorizontalAlignment.Center;
            // 
            // username_added
            // 
            username_added.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            username_added.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username_added.ForeColor = Color.DarkGoldenrod;
            username_added.Location = new Point(102, 149);
            username_added.Margin = new Padding(4, 3, 4, 3);
            username_added.Name = "username_added";
            username_added.PlaceholderText = "Enter Username";
            username_added.Size = new Size(228, 22);
            username_added.TabIndex = 3;
            username_added.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(178, 85);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 2;
            label1.Text = "SIGN UP";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = Properties.Resources.sonar_img;
            pictureBox1.Location = new Point(159, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 338);
            ControlBox = false;
            Controls.Add(splitContainer1);
            Name = "SignUpForm";
            Text = "SignUpForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox username_added;
        private TextBox password_added;
        private Button buttonSignUp;
        private TextBox confirmed_password;
        private Label close_form;
        private Label warning;
    }
}