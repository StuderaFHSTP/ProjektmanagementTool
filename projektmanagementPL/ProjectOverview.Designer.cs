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
            this.listViewProjectOverview = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblProjectOverviewTitle
            // 
            this.lblProjectOverviewTitle.AutoSize = true;
            this.lblProjectOverviewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectOverviewTitle.Location = new System.Drawing.Point(276, 25);
            this.lblProjectOverviewTitle.Name = "lblProjectOverviewTitle";
            this.lblProjectOverviewTitle.Size = new System.Drawing.Size(132, 36);
            this.lblProjectOverviewTitle.TabIndex = 0;
            this.lblProjectOverviewTitle.Text = "Projekte";
            // 
            // listViewProjectOverview
            // 
            this.listViewProjectOverview.HideSelection = false;
            this.listViewProjectOverview.Location = new System.Drawing.Point(13, 75);
            this.listViewProjectOverview.Name = "listViewProjectOverview";
            this.listViewProjectOverview.Size = new System.Drawing.Size(705, 261);
            this.listViewProjectOverview.TabIndex = 1;
            this.listViewProjectOverview.UseCompatibleStateImageBehavior = false;
            // 
            // ProjectOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 385);
            this.Controls.Add(this.listViewProjectOverview);
            this.Controls.Add(this.lblProjectOverviewTitle);
            this.Name = "ProjectOverview";
            this.Text = "ProjectOverview";
            this.Load += new System.EventHandler(this.ProjectOverview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectOverviewTitle;
        private System.Windows.Forms.ListView listViewProjectOverview;
    }
}