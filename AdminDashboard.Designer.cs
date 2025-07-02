using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.btnBack);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.ForeColor = System.Drawing.Color.Black;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(900, 454);
            this.panelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(860, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Admin Dashboard";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 391);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "↩";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminDashboard
            // 
            this.ClientSize = new System.Drawing.Size(900, 454);
            this.Controls.Add(this.panelMain);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Panel panelMain;
        private Label lblTitle;
        private Button btnBack;
    }
}
