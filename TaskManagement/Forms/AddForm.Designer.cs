namespace TaskManagement
{
    partial class AddForm
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
            label1 = new Label();
            label2 = new Label();
            new_description = new TextBox();
            label3 = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            chkstatus = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 71);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 0;
            label1.Text = "Description :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 111);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 1;
            label2.Text = "Status :";
            // 
            // new_description
            // 
            new_description.Location = new Point(181, 68);
            new_description.Margin = new Padding(3, 2, 3, 2);
            new_description.Multiline = true;
            new_description.Name = "new_description";
            new_description.Size = new Size(110, 26);
            new_description.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGoldenrod;
            label3.Location = new Point(32, 20);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 4;
            label3.Text = "ADD NEW TASK";
            label3.Click += label3_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.DarkGoldenrod;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = SystemColors.Control;
            buttonSave.Location = new Point(216, 159);
            buttonSave.Margin = new Padding(3, 2, 3, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(2);
            buttonSave.Size = new Size(82, 38);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.DarkGoldenrod;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = SystemColors.Control;
            buttonCancel.Location = new Point(306, 159);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Padding = new Padding(2);
            buttonCancel.Size = new Size(82, 38);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // chkstatus
            // 
            chkstatus.AutoSize = true;
            chkstatus.BackColor = SystemColors.Control;
            chkstatus.FlatAppearance.BorderColor = Color.White;
            chkstatus.FlatAppearance.CheckedBackColor = Color.DarkGoldenrod;
            chkstatus.FlatStyle = FlatStyle.Flat;
            chkstatus.Location = new Point(184, 113);
            chkstatus.Name = "chkstatus";
            chkstatus.Size = new Size(82, 19);
            chkstatus.TabIndex = 7;
            chkstatus.Text = "Completed";
            chkstatus.UseVisualStyleBackColor = false;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 199);
            Controls.Add(chkstatus);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(label3);
            Controls.Add(new_description);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddForm";
            Text = "ADD TASK";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox new_description;
        private Label label3;
        private Button buttonSave;
        private Button buttonCancel;
        private CheckBox chkstatus;
    }
}