namespace projektmanagementPL
{
    partial class CreateTask
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
            this.lblCreateTask = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.datePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.lblWorker = new System.Windows.Forms.Label();
            this.txtAssignedUser = new System.Windows.Forms.TextBox();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.txtTaskDescription = new System.Windows.Forms.RichTextBox();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreateTask
            // 
            this.lblCreateTask.AutoSize = true;
            this.lblCreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTask.Location = new System.Drawing.Point(148, 20);
            this.lblCreateTask.Name = "lblCreateTask";
            this.lblCreateTask.Size = new System.Drawing.Size(191, 32);
            this.lblCreateTask.TabIndex = 0;
            this.lblCreateTask.Text = "Task erstellen";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(33, 65);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(81, 16);
            this.lblTaskName.TabIndex = 1;
            this.lblTaskName.Text = "Task Name:";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(136, 65);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(243, 22);
            this.txtTaskName.TabIndex = 2;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new System.Drawing.Point(36, 109);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(65, 16);
            this.lblDeadline.TabIndex = 3;
            this.lblDeadline.Text = "Deadline:";
            // 
            // datePickerDeadline
            // 
            this.datePickerDeadline.Location = new System.Drawing.Point(136, 103);
            this.datePickerDeadline.Name = "datePickerDeadline";
            this.datePickerDeadline.Size = new System.Drawing.Size(243, 22);
            this.datePickerDeadline.TabIndex = 4;
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Location = new System.Drawing.Point(36, 141);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(150, 16);
            this.lblWorker.TabIndex = 5;
            this.lblWorker.Text = "Mitarbeiter (Nachname):";
            // 
            // txtAssignedUser
            // 
            this.txtAssignedUser.Location = new System.Drawing.Point(202, 138);
            this.txtAssignedUser.Name = "txtAssignedUser";
            this.txtAssignedUser.Size = new System.Drawing.Size(177, 22);
            this.txtAssignedUser.TabIndex = 6;
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.Location = new System.Drawing.Point(36, 174);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(93, 16);
            this.lblTaskDescription.TabIndex = 7;
            this.lblTaskDescription.Text = "Beschreibung:";
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(136, 174);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(243, 96);
            this.txtTaskDescription.TabIndex = 8;
            this.txtTaskDescription.Text = "";
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(407, 268);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTask.TabIndex = 9;
            this.btnCreateTask.Text = "Erstellen";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(26, 268);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 18;
            this.btnGoBack.Text = "Zurück";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 303);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.lblTaskDescription);
            this.Controls.Add(this.txtAssignedUser);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.datePickerDeadline);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.lblCreateTask);
            this.Name = "CreateTask";
            this.Text = "CreateTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateTask;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.DateTimePicker datePickerDeadline;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.TextBox txtAssignedUser;
        private System.Windows.Forms.Label lblTaskDescription;
        private System.Windows.Forms.RichTextBox txtTaskDescription;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Button btnGoBack;
    }
}