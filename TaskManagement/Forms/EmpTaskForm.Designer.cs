namespace TaskManagement
{
    partial class EmpTaskForm
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
            dataGridView1 = new DataGridView();
            taskId = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            status = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            buttoncompleted_task = new Button();
            buttonpendingtask = new Button();
            buttonshowtask = new Button();
            button1 = new Button();
            info = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightYellow;
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
            dataGridView1.Location = new Point(23, 57);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(591, 359);
            dataGridView1.TabIndex = 0;
            // 
            // taskId
            // 
            taskId.DataPropertyName = "taskId";
            taskId.FillWeight = 73.8578644F;
            taskId.HeaderText = "Task ID";
            taskId.Name = "taskId";
            taskId.ReadOnly = true;
            // 
            // description
            // 
            description.DataPropertyName = "description";
            description.FillWeight = 152.284271F;
            description.HeaderText = "Description";
            description.MinimumWidth = 10;
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.FillWeight = 73.8578644F;
            status.HeaderText = "Is Completed";
            status.Name = "status";
            status.ReadOnly = true;
            status.Resizable = DataGridViewTriState.True;
            status.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(43, 20);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 1;
            label1.Text = "Task Status of";
            // 
            // buttoncompleted_task
            // 
            buttoncompleted_task.BackColor = Color.DarkGoldenrod;
            buttoncompleted_task.FlatStyle = FlatStyle.Flat;
            buttoncompleted_task.ForeColor = SystemColors.Control;
            buttoncompleted_task.Location = new Point(26, 433);
            buttoncompleted_task.Margin = new Padding(3, 2, 3, 2);
            buttoncompleted_task.Name = "buttoncompleted_task";
            buttoncompleted_task.Padding = new Padding(2);
            buttoncompleted_task.Size = new Size(130, 32);
            buttoncompleted_task.TabIndex = 2;
            buttoncompleted_task.Text = "Completed Task";
            buttoncompleted_task.UseVisualStyleBackColor = false;
            buttoncompleted_task.Click += buttoncompleted_task_Click;
            // 
            // buttonpendingtask
            // 
            buttonpendingtask.BackColor = Color.DarkGoldenrod;
            buttonpendingtask.FlatStyle = FlatStyle.Flat;
            buttonpendingtask.ForeColor = SystemColors.Control;
            buttonpendingtask.Location = new Point(223, 433);
            buttonpendingtask.Margin = new Padding(3, 2, 3, 2);
            buttonpendingtask.Name = "buttonpendingtask";
            buttonpendingtask.Padding = new Padding(2);
            buttonpendingtask.Size = new Size(111, 32);
            buttonpendingtask.TabIndex = 3;
            buttonpendingtask.Text = "Pending Task";
            buttonpendingtask.UseVisualStyleBackColor = false;
            buttonpendingtask.Click += buttonpendingtask_Click;
            // 
            // buttonshowtask
            // 
            buttonshowtask.BackColor = Color.DarkGoldenrod;
            buttonshowtask.FlatStyle = FlatStyle.Flat;
            buttonshowtask.ForeColor = SystemColors.Control;
            buttonshowtask.Location = new Point(397, 432);
            buttonshowtask.Margin = new Padding(3, 2, 3, 2);
            buttonshowtask.Name = "buttonshowtask";
            buttonshowtask.Padding = new Padding(2);
            buttonshowtask.Size = new Size(82, 33);
            buttonshowtask.TabIndex = 4;
            buttonshowtask.Text = "All Task";
            buttonshowtask.UseVisualStyleBackColor = false;
            buttonshowtask.Click += buttonshowtask_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGoldenrod;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(537, 432);
            button1.Name = "button1";
            button1.Padding = new Padding(2);
            button1.Size = new Size(75, 33);
            button1.TabIndex = 5;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // info
            // 
            info.AutoSize = true;
            info.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            info.ForeColor = Color.DarkGoldenrod;
            info.Location = new Point(173, 20);
            info.Name = "info";
            info.Size = new Size(65, 25);
            info.TabIndex = 6;
            info.Text = "label2";
            // 
            // EmpTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(637, 496);
            ControlBox = false;
            Controls.Add(info);
            Controls.Add(button1);
            Controls.Add(buttonshowtask);
            Controls.Add(buttonpendingtask);
            Controls.Add(buttoncompleted_task);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmpTaskForm";
            Text = "Task Status";
            Load += EmpTaskForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button buttoncompleted_task;
        private Button buttonpendingtask;
        private Button buttonshowtask;
        private Button button1;
        private Label info;
        private DataGridViewTextBoxColumn taskId;
        private DataGridViewTextBoxColumn description;
        private DataGridViewCheckBoxColumn status;
    }
}