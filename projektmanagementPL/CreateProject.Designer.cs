﻿namespace projektmanagementPL
{
    partial class CreateProject
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
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProjectStart = new System.Windows.Forms.Label();
            this.lblProjectEnde = new System.Windows.Forms.Label();
            this.lblProjectBeschreibung = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectBeschreibung = new System.Windows.Forms.RichTextBox();
            this.btnProjectErstellen = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(37, 67);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(86, 16);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Projektname:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(34, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Projekt erstellen";
            // 
            // lblProjectStart
            // 
            this.lblProjectStart.AutoSize = true;
            this.lblProjectStart.Location = new System.Drawing.Point(37, 97);
            this.lblProjectStart.Name = "lblProjectStart";
            this.lblProjectStart.Size = new System.Drawing.Size(37, 16);
            this.lblProjectStart.TabIndex = 2;
            this.lblProjectStart.Text = "Start:";
            // 
            // lblProjectEnde
            // 
            this.lblProjectEnde.AutoSize = true;
            this.lblProjectEnde.Location = new System.Drawing.Point(37, 133);
            this.lblProjectEnde.Name = "lblProjectEnde";
            this.lblProjectEnde.Size = new System.Drawing.Size(42, 16);
            this.lblProjectEnde.TabIndex = 3;
            this.lblProjectEnde.Text = "Ende:";
            // 
            // lblProjectBeschreibung
            // 
            this.lblProjectBeschreibung.AutoSize = true;
            this.lblProjectBeschreibung.Location = new System.Drawing.Point(37, 164);
            this.lblProjectBeschreibung.Name = "lblProjectBeschreibung";
            this.lblProjectBeschreibung.Size = new System.Drawing.Size(93, 16);
            this.lblProjectBeschreibung.TabIndex = 4;
            this.lblProjectBeschreibung.Text = "Beschreibung:";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(130, 92);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(252, 22);
            this.dateStart.TabIndex = 5;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(130, 126);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(252, 22);
            this.dateEnd.TabIndex = 6;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(129, 64);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(154, 22);
            this.txtProjectName.TabIndex = 7;
            // 
            // txtProjectBeschreibung
            // 
            this.txtProjectBeschreibung.Location = new System.Drawing.Point(130, 164);
            this.txtProjectBeschreibung.Name = "txtProjectBeschreibung";
            this.txtProjectBeschreibung.Size = new System.Drawing.Size(411, 154);
            this.txtProjectBeschreibung.TabIndex = 8;
            this.txtProjectBeschreibung.Text = "";
            // 
            // btnProjectErstellen
            // 
            this.btnProjectErstellen.Location = new System.Drawing.Point(580, 418);
            this.btnProjectErstellen.Name = "btnProjectErstellen";
            this.btnProjectErstellen.Size = new System.Drawing.Size(90, 25);
            this.btnProjectErstellen.TabIndex = 9;
            this.btnProjectErstellen.Text = "Erstellen";
            this.btnProjectErstellen.UseVisualStyleBackColor = true;
            this.btnProjectErstellen.Click += new System.EventHandler(this.btnProjectErstellen_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(12, 418);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(90, 25);
            this.btnGoBack.TabIndex = 10;
            this.btnGoBack.Text = "Zurück";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnProjectErstellen);
            this.Controls.Add(this.txtProjectBeschreibung);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.lblProjectBeschreibung);
            this.Controls.Add(this.lblProjectEnde);
            this.Controls.Add(this.lblProjectStart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblProjectName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateProject";
            this.Text = "CreateProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProjectStart;
        private System.Windows.Forms.Label lblProjectEnde;
        private System.Windows.Forms.Label lblProjectBeschreibung;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.RichTextBox txtProjectBeschreibung;
        private System.Windows.Forms.Button btnProjectErstellen;
        private System.Windows.Forms.Button btnGoBack;
    }
}