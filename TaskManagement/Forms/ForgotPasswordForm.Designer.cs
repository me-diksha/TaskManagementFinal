namespace TaskManagement.Forms
{
    partial class ForgotPasswordForm
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
            close_form = new Label();
            label1 = new Label();
            warning = new Label();
            buttonReset = new Button();
            confirmed_password = new TextBox();
            password_added = new TextBox();
            verify_button = new Button();
            username_added = new TextBox();
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
            splitContainer1.Panel2.Controls.Add(close_form);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(warning);
            splitContainer1.Panel2.Controls.Add(buttonReset);
            splitContainer1.Panel2.Controls.Add(confirmed_password);
            splitContainer1.Panel2.Controls.Add(password_added);
            splitContainer1.Panel2.Controls.Add(verify_button);
            splitContainer1.Panel2.Controls.Add(username_added);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(680, 366);
            splitContainer1.SplitterDistance = 226;
            splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(15, 181);
            label5.Name = "label5";
            label5.Size = new Size(117, 21);
            label5.TabIndex = 4;
            label5.Text = "INDIA Pvt. Ltd.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(12, 151);
            label4.Name = "label4";
            label4.Size = new Size(190, 30);
            label4.TabIndex = 3;
            label4.Text = "SONAR SOFTECH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(53, 102);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 2;
            label3.Text = "WELCOME";
            // 
            // close_form
            // 
            close_form.AutoSize = true;
            close_form.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close_form.ForeColor = Color.IndianRed;
            close_form.Location = new Point(401, 11);
            close_form.Name = "close_form";
            close_form.Size = new Size(23, 25);
            close_form.TabIndex = 17;
            close_form.Text = "X";
            close_form.Click += close_form_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(135, 103);
            label1.Name = "label1";
            label1.Size = new Size(148, 21);
            label1.TabIndex = 16;
            label1.Text = "RESET PASSWORD";
            // 
            // warning
            // 
            warning.AutoSize = true;
            warning.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            warning.ForeColor = Color.Firebrick;
            warning.Location = new Point(141, 136);
            warning.Name = "warning";
            warning.Size = new Size(58, 17);
            warning.TabIndex = 15;
            warning.Text = "warning";
            warning.Visible = false;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.DarkGoldenrod;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.ForeColor = SystemColors.Control;
            buttonReset.Location = new Point(186, 300);
            buttonReset.Name = "buttonReset";
            buttonReset.Padding = new Padding(2);
            buttonReset.Size = new Size(75, 28);
            buttonReset.TabIndex = 14;
            buttonReset.Text = "RESET";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Visible = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // confirmed_password
            // 
            confirmed_password.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmed_password.ForeColor = Color.DarkGoldenrod;
            confirmed_password.Location = new Point(106, 245);
            confirmed_password.Name = "confirmed_password";
            confirmed_password.PlaceholderText = "Confirm New Password";
            confirmed_password.Size = new Size(223, 22);
            confirmed_password.TabIndex = 13;
            confirmed_password.TextAlign = HorizontalAlignment.Center;
            confirmed_password.Visible = false;
            // 
            // password_added
            // 
            password_added.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password_added.ForeColor = Color.DarkGoldenrod;
            password_added.Location = new Point(106, 209);
            password_added.Name = "password_added";
            password_added.PlaceholderText = "Add New Password";
            password_added.Size = new Size(218, 22);
            password_added.TabIndex = 6;
            password_added.TextAlign = HorizontalAlignment.Center;
            password_added.Visible = false;
            // 
            // verify_button
            // 
            verify_button.BackColor = Color.DarkGoldenrod;
            verify_button.FlatStyle = FlatStyle.Flat;
            verify_button.ForeColor = SystemColors.Control;
            verify_button.Location = new Point(331, 167);
            verify_button.Name = "verify_button";
            verify_button.Padding = new Padding(2);
            verify_button.Size = new Size(75, 28);
            verify_button.TabIndex = 5;
            verify_button.Text = "VERIFY";
            verify_button.UseVisualStyleBackColor = false;
            verify_button.Click += verify_button_Click;
            // 
            // username_added
            // 
            username_added.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            username_added.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username_added.ForeColor = Color.DarkGoldenrod;
            username_added.Location = new Point(106, 167);
            username_added.Margin = new Padding(4, 3, 4, 3);
            username_added.Multiline = true;
            username_added.Name = "username_added";
            username_added.PlaceholderText = "Enter Username";
            username_added.Size = new Size(218, 28);
            username_added.TabIndex = 4;
            username_added.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = Properties.Resources.sonar_img;
            pictureBox1.Location = new Point(149, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 366);
            ControlBox = false;
            Controls.Add(splitContainer1);
            Name = "ForgotPasswordForm";
            Text = "ForgotPasswordForm";
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
        private PictureBox pictureBox1;
        private Button verify_button;
        private TextBox username_added;
        private TextBox password_added;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox confirmed_password;
        private Button buttonReset;
        private Label warning;
        private Label label1;
        private Label close_form;
    }
}