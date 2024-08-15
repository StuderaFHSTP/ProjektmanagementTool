namespace projektmanagementPL
{
    partial class ProjectOverview
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
            this.lblProjectOverviewTitle = new System.Windows.Forms.Label();
            this.btnProjectOverviewCreate = new System.Windows.Forms.Button();
            this.tableLayoutProjectOverview = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProjectOverviewTitle
            // 
            this.lblProjectOverviewTitle.AutoSize = true;
            this.lblProjectOverviewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectOverviewTitle.Location = new System.Drawing.Point(35, 25);
            this.lblProjectOverviewTitle.Name = "lblProjectOverviewTitle";
            this.lblProjectOverviewTitle.Size = new System.Drawing.Size(132, 36);
            this.lblProjectOverviewTitle.TabIndex = 0;
            this.lblProjectOverviewTitle.Text = "Projekte";
            // 
            // btnProjectOverviewCreate
            // 
            this.btnProjectOverviewCreate.Location = new System.Drawing.Point(329, 25);
            this.btnProjectOverviewCreate.Name = "btnProjectOverviewCreate";
            this.btnProjectOverviewCreate.Size = new System.Drawing.Size(81, 23);
            this.btnProjectOverviewCreate.TabIndex = 2;
            this.btnProjectOverviewCreate.Text = "Erstellen";
            this.btnProjectOverviewCreate.UseVisualStyleBackColor = true;
            this.btnProjectOverviewCreate.Click += new System.EventHandler(this.btnProjectOverviewCreate_Click);
            // 
            // tableLayoutProjectOverview
            // 
            this.tableLayoutProjectOverview.AutoSize = true;
            this.tableLayoutProjectOverview.ColumnCount = 2;
            this.tableLayoutProjectOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutProjectOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutProjectOverview.Location = new System.Drawing.Point(24, 80);
            this.tableLayoutProjectOverview.Name = "tableLayoutProjectOverview";
            this.tableLayoutProjectOverview.RowCount = 2;
            this.tableLayoutProjectOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutProjectOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutProjectOverview.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutProjectOverview.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(24, 344);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 29);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // ProjectOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 385);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.tableLayoutProjectOverview);
            this.Controls.Add(this.btnProjectOverviewCreate);
            this.Controls.Add(this.lblProjectOverviewTitle);
            this.MaximizeBox = false;
            this.Name = "ProjectOverview";
            this.Text = "ProjectOverview";
            this.Load += new System.EventHandler(this.ProjectOverview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectOverviewTitle;
        private System.Windows.Forms.Button btnProjectOverviewCreate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutProjectOverview;
        private System.Windows.Forms.Button btnLogOut;
    }
}