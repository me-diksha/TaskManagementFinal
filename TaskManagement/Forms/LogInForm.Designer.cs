namespace TaskManagement
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            splitContainer1 = new SplitContainer();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            eyeclose = new PictureBox();
            eyeopen = new PictureBox();
            ask_create_account = new Label();
            label6 = new Label();
            warning = new Label();
            buttonLogin = new Button();
            forgot_page_load = new Label();
            password_added = new TextBox();
            username_added = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eyeclose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeopen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
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
            splitContainer1.Panel2.Controls.Add(eyeclose);
            splitContainer1.Panel2.Controls.Add(eyeopen);
            splitContainer1.Panel2.Controls.Add(ask_create_account);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(warning);
            splitContainer1.Panel2.Controls.Add(buttonLogin);
            splitContainer1.Panel2.Controls.Add(forgot_page_load);
            splitContainer1.Panel2.Controls.Add(password_added);
            splitContainer1.Panel2.Controls.Add(username_added);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(700, 372);
            splitContainer1.SplitterDistance = 221;
            splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(14, 173);
            label5.Name = "label5";
            label5.Size = new Size(117, 21);
            label5.TabIndex = 2;
            label5.Text = "INDIA Pvt. Ltd.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(10, 144);
            label4.Name = "label4";
            label4.Size = new Size(190, 30);
            label4.TabIndex = 1;
            label4.Text = "SONAR SOFTECH";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(43, 100);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 0;
            label3.Text = "WELCOME";
            // 
            // eyeclose
            // 
            eyeclose.BackColor = Color.Transparent;
            eyeclose.Image = (Image)resources.GetObject("eyeclose.Image");
            eyeclose.Location = new Point(362, 183);
            eyeclose.Name = "eyeclose";
            eyeclose.Size = new Size(33, 40);
            eyeclose.SizeMode = PictureBoxSizeMode.StretchImage;
            eyeclose.TabIndex = 16;
            eyeclose.TabStop = false;
            eyeclose.Click += eyeclose_Click;
            // 
            // eyeopen
            // 
            eyeopen.BackColor = Color.Transparent;
            eyeopen.Image = (Image)resources.GetObject("eyeopen.Image");
            eyeopen.Location = new Point(361, 182);
            eyeopen.Name = "eyeopen";
            eyeopen.Size = new Size(34, 41);
            eyeopen.SizeMode = PictureBoxSizeMode.StretchImage;
            eyeopen.TabIndex = 15;
            eyeopen.TabStop = false;
            eyeopen.Visible = false;
            eyeopen.Click += eyeopen_Click;
            // 
            // ask_create_account
            // 
            ask_create_account.AutoSize = true;
            ask_create_account.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            ask_create_account.ForeColor = Color.DarkGoldenrod;
            ask_create_account.Location = new Point(273, 310);
            ask_create_account.Name = "ask_create_account";
            ask_create_account.Size = new Size(61, 20);
            ask_create_account.TabIndex = 8;
            ask_create_account.Text = "Sign Up";
            ask_create_account.Click += ask_create_account_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(146, 315);
            label6.Name = "label6";
            label6.Size = new Size(128, 15);
            label6.TabIndex = 7;
            label6.Text = "Dont have an account?";
            // 
            // warning
            // 
            warning.AutoSize = true;
            warning.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            warning.ForeColor = Color.Firebrick;
            warning.Location = new Point(141, 138);
            warning.Name = "warning";
            warning.Size = new Size(52, 15);
            warning.TabIndex = 6;
            warning.Text = "warning";
            warning.Visible = false;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.DarkGoldenrod;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.ForeColor = SystemColors.Control;
            buttonLogin.Location = new Point(178, 254);
            buttonLogin.Margin = new Padding(3, 2, 3, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Padding = new Padding(2);
            buttonLogin.Size = new Size(117, 39);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += button1_Click;
            // 
            // forgot_page_load
            // 
            forgot_page_load.AutoSize = true;
            forgot_page_load.ForeColor = Color.DarkGoldenrod;
            forgot_page_load.Location = new Point(123, 220);
            forgot_page_load.Name = "forgot_page_load";
            forgot_page_load.Size = new Size(100, 15);
            forgot_page_load.TabIndex = 4;
            forgot_page_load.Text = "Forgot Password?";
            forgot_page_load.Click += forgot_page_load_Click;
            // 
            // password_added
            // 
            password_added.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            password_added.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password_added.ForeColor = Color.DarkGoldenrod;
            password_added.Location = new Point(127, 196);
            password_added.Margin = new Padding(3, 2, 3, 2);
            password_added.Name = "password_added";
            password_added.PlaceholderText = "Enter Password";
            password_added.Size = new Size(229, 22);
            password_added.TabIndex = 3;
            password_added.TextAlign = HorizontalAlignment.Center;
            password_added.UseSystemPasswordChar = true;
            // 
            // username_added
            // 
            username_added.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            username_added.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username_added.ForeColor = Color.DarkGoldenrod;
            username_added.Location = new Point(128, 164);
            username_added.Margin = new Padding(4, 3, 4, 3);
            username_added.Name = "username_added";
            username_added.PlaceholderText = "Enter Username";
            username_added.Size = new Size(227, 22);
            username_added.TabIndex = 2;
            username_added.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(209, 100);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sonar_img;
            pictureBox1.Location = new Point(168, 6);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(700, 372);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)eyeclose).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeopen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Button buttonLogin;
        private Label forgot_page_load;
        private TextBox password_added;
        private TextBox username_added;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label warning;
        private Label ask_create_account;
        private Label label6;
        private Label close_form;
        private PictureBox eyeopen;
        private PictureBox eyeclose;
    }
}
