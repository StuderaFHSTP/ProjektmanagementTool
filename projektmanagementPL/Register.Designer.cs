namespace projektmanagementPL
{
    partial class Register
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.lblAbteilung = new System.Windows.Forms.Label();
            this.lblRolle = new System.Windows.Forms.Label();
            this.ddAbteilung = new System.Windows.Forms.ComboBox();
            this.ddRolle = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(310, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 32);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Registrierung";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(353, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 22);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(266, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Vorname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(353, 116);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(170, 22);
            this.txtSurname.TabIndex = 4;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(266, 119);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(76, 16);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Nachname:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(353, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(265, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // txtPasswort
            // 
            this.txtPasswort.Location = new System.Drawing.Point(353, 173);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(170, 22);
            this.txtPasswort.TabIndex = 4;
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Location = new System.Drawing.Point(265, 176);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(65, 16);
            this.lblPasswort.TabIndex = 5;
            this.lblPasswort.Text = "Passwort:";
            // 
            // lblAbteilung
            // 
            this.lblAbteilung.AutoSize = true;
            this.lblAbteilung.Location = new System.Drawing.Point(265, 204);
            this.lblAbteilung.Name = "lblAbteilung";
            this.lblAbteilung.Size = new System.Drawing.Size(66, 16);
            this.lblAbteilung.TabIndex = 5;
            this.lblAbteilung.Text = "Abteilung:";
            // 
            // lblRolle
            // 
            this.lblRolle.AutoSize = true;
            this.lblRolle.Location = new System.Drawing.Point(266, 232);
            this.lblRolle.Name = "lblRolle";
            this.lblRolle.Size = new System.Drawing.Size(42, 16);
            this.lblRolle.TabIndex = 5;
            this.lblRolle.Text = "Rolle:";
            // 
            // ddAbteilung
            // 
            this.ddAbteilung.FormattingEnabled = true;
            this.ddAbteilung.Location = new System.Drawing.Point(353, 201);
            this.ddAbteilung.Name = "ddAbteilung";
            this.ddAbteilung.Size = new System.Drawing.Size(171, 24);
            this.ddAbteilung.TabIndex = 6;
            // 
            // ddRolle
            // 
            this.ddRolle.FormattingEnabled = true;
            this.ddRolle.Location = new System.Drawing.Point(353, 231);
            this.ddRolle.Name = "ddRolle";
            this.ddRolle.Size = new System.Drawing.Size(171, 24);
            this.ddRolle.TabIndex = 6;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(316, 274);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(178, 31);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "registrieren";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(266, 388);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(273, 16);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Error: User konnte nicht erstellt werden";
            this.lblError.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.ddRolle);
            this.Controls.Add(this.ddAbteilung);
            this.Controls.Add(this.lblRolle);
            this.Controls.Add(this.lblAbteilung);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.Label lblAbteilung;
        private System.Windows.Forms.Label lblRolle;
        private System.Windows.Forms.ComboBox ddAbteilung;
        private System.Windows.Forms.ComboBox ddRolle;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblError;
    }
}