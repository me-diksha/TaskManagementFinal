namespace TaskManagement
{
    partial class EditForm
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
            update_description = new TextBox();
            buttonUpdate = new Button();
            buttonCancel = new Button();
            chkStatus = new CheckBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 56);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 0;
            label1.Text = "New Description :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(99, 97);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 1;
            label2.Text = "New Status :";
            // 
            // update_description
            // 
            update_description.Location = new Point(201, 54);
            update_description.Margin = new Padding(3, 2, 3, 2);
            update_description.Multiline = true;
            update_description.Name = "update_description";
            update_description.Size = new Size(146, 26);
            update_description.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.DarkGoldenrod;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.ForeColor = SystemColors.Control;
            buttonUpdate.Location = new Point(224, 139);
            buttonUpdate.Margin = new Padding(3, 2, 3, 2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Padding = new Padding(2);
            buttonUpdate.Size = new Size(82, 36);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.DarkGoldenrod;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = SystemColors.Control;
            buttonCancel.Location = new Point(323, 139);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Padding = new Padding(2);
            buttonCancel.Size = new Size(82, 36);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "CANCEL";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.FlatAppearance.CheckedBackColor = Color.DarkGoldenrod;
            chkStatus.FlatStyle = FlatStyle.Flat;
            chkStatus.Location = new Point(206, 100);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(82, 19);
            chkStatus.TabIndex = 6;
            chkStatus.Text = "Completed";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGoldenrod;
            label3.Location = new Point(27, 15);
            label3.Name = "label3";
            label3.Size = new Size(164, 21);
            label3.TabIndex = 7;
            label3.Text = "EDIT CURRENT TASK";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 189);
            Controls.Add(label3);
            Controls.Add(chkStatus);
            Controls.Add(buttonCancel);
            Controls.Add(buttonUpdate);
            Controls.Add(update_description);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditForm";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox update_description;
        private Button buttonUpdate;
        private Button buttonCancel;
        private CheckBox chkStatus;
        private Label label3;
    }
}