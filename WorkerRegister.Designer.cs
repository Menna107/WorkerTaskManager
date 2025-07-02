using System.Windows.Forms;

namespace DB_Testing
{
    partial class WorkerRegister
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Panel mainPanel;

        private Label lblWorkerId;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;

        private TextBox txtWorkerId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;

        private Button btnRegister;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblWorkerId = new System.Windows.Forms.Label();
            this.txtWorkerId = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Worker Registration";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.lblWorkerId);
            this.mainPanel.Controls.Add(this.txtWorkerId);
            this.mainPanel.Controls.Add(this.lblFirstName);
            this.mainPanel.Controls.Add(this.txtFirstName);
            this.mainPanel.Controls.Add(this.lblLastName);
            this.mainPanel.Controls.Add(this.txtLastName);
            this.mainPanel.Controls.Add(this.lblEmail);
            this.mainPanel.Controls.Add(this.txtEmail);
            this.mainPanel.Controls.Add(this.btnRegister);
            this.mainPanel.Location = new System.Drawing.Point(183, 92);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(441, 264);
            this.mainPanel.TabIndex = 1;
            // 
            // lblWorkerId
            // 
            this.lblWorkerId.Location = new System.Drawing.Point(42, 27);
            this.lblWorkerId.Name = "lblWorkerId";
            this.lblWorkerId.Size = new System.Drawing.Size(100, 23);
            this.lblWorkerId.TabIndex = 0;
            this.lblWorkerId.Text = "Worker ID:";
            // 
            // txtWorkerId
            // 
            this.txtWorkerId.Location = new System.Drawing.Point(162, 27);
            this.txtWorkerId.Name = "txtWorkerId";
            this.txtWorkerId.Size = new System.Drawing.Size(205, 22);
            this.txtWorkerId.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(42, 67);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(100, 23);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(162, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(205, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(42, 107);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(162, 107);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(205, 22);
            this.txtLastName.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(42, 147);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(162, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(162, 200);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 35);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 403);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "↩";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // WorkerRegister
            // 
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.btnBack);
            this.Name = "WorkerRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worker Register";
            this.Load += new System.EventHandler(this.WorkerRegister_Load);
            this.Resize += new System.EventHandler(this.WorkerRegister_Resize);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
