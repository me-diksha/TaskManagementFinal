namespace TaskManagement
{
    partial class EmployeeDash
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDash));
            dataGridView1 = new DataGridView();
            taskId = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            status = new DataGridViewCheckBoxColumn();
            btnAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            logged_role = new Label();
            logged_name = new Label();
            log_out = new Label();
            closebox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closebox).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SeaShell;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { taskId, description, status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(259, 41);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(454, 370);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // taskId
            // 
            taskId.DataPropertyName = "taskId";
            taskId.FillWeight = 65.03594F;
            taskId.HeaderText = "Task ID";
            taskId.Name = "taskId";
            taskId.ReadOnly = true;
            // 
            // description
            // 
            description.DataPropertyName = "description";
            description.FillWeight = 150.477219F;
            description.HeaderText = "Task Description";
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.FillWeight = 94.38533F;
            status.HeaderText = "Is Completed";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkGoldenrod;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(306, 425);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(2);
            btnAdd.Size = new Size(82, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.DarkGoldenrod;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.ForeColor = SystemColors.Control;
            buttonEdit.Location = new Point(447, 425);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Padding = new Padding(2);
            buttonEdit.Size = new Size(82, 40);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "EDIT";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.DarkGoldenrod;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = SystemColors.Control;
            buttonDelete.Location = new Point(590, 425);
            buttonDelete.Margin = new Padding(3, 2, 3, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Padding = new Padding(2);
            buttonDelete.Size = new Size(82, 40);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGoldenrod;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(logged_role);
            panel1.Controls.Add(logged_name);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 488);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(231, 25);
            label1.TabIndex = 3;
            label1.Text = "EMPLOYEE DASHBOARD";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 72);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // logged_role
            // 
            logged_role.AutoSize = true;
            logged_role.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logged_role.ForeColor = SystemColors.Control;
            logged_role.Location = new Point(133, 118);
            logged_role.Name = "logged_role";
            logged_role.Size = new Size(50, 20);
            logged_role.TabIndex = 1;
            logged_role.Text = "label2";
            // 
            // logged_name
            // 
            logged_name.AutoSize = true;
            logged_name.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logged_name.ForeColor = SystemColors.Control;
            logged_name.Location = new Point(132, 85);
            logged_name.Name = "logged_name";
            logged_name.Size = new Size(48, 20);
            logged_name.TabIndex = 0;
            logged_name.Text = "label1";
            // 
            // log_out
            // 
            log_out.AutoSize = true;
            log_out.ForeColor = Color.DarkGoldenrod;
            log_out.Location = new Point(610, 14);
            log_out.Name = "log_out";
            log_out.Size = new Size(54, 15);
            log_out.TabIndex = 5;
            log_out.Text = "LOGOUT";
            log_out.Click += log_out_Click;
            // 
            // closebox
            // 
            closebox.Image = (Image)resources.GetObject("closebox.Image");
            closebox.Location = new Point(669, 7);
            closebox.Name = "closebox";
            closebox.Size = new Size(32, 29);
            closebox.SizeMode = PictureBoxSizeMode.StretchImage;
            closebox.TabIndex = 6;
            closebox.TabStop = false;
            closebox.Click += closebox_Click;
            // 
            // EmployeeDash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 488);
            ControlBox = false;
            Controls.Add(closebox);
            Controls.Add(log_out);
            Controls.Add(panel1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "EmployeeDash";
            Text = "Employee Dashboard";
            Load += EmployeeDash_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)closebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Panel panel1;
        private Label logged_role;
        private Label logged_name;
        private PictureBox pictureBox1;
        private Label log_out;
        private Label label1;
        private PictureBox closebox;
        private DataGridViewTextBoxColumn taskId;
        private DataGridViewTextBoxColumn description;
        private DataGridViewCheckBoxColumn status;
    }
}