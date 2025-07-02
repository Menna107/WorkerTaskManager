using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    partial class SignUp
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblSignUpAs;
        private System.Windows.Forms.Label lblHaveAccount;
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnWorker;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblSignUpAs = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnWorker = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.separator = new System.Windows.Forms.Label();
            this.lblHaveAccount = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(4, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Create Your Account";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.lblSignUpAs);
            this.mainPanel.Controls.Add(this.btnClient);
            this.mainPanel.Controls.Add(this.btnWorker);
            this.mainPanel.Controls.Add(this.btnAdmin);
            this.mainPanel.Controls.Add(this.separator);
            this.mainPanel.Controls.Add(this.lblHaveAccount);
            this.mainPanel.Controls.Add(this.btnLogin);
            this.mainPanel.Location = new System.Drawing.Point(196, 118);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(400, 250);
            this.mainPanel.TabIndex = 2;
            // 
            // lblSignUpAs
            // 
            this.lblSignUpAs.Location = new System.Drawing.Point(20, 20);
            this.lblSignUpAs.Name = "lblSignUpAs";
            this.lblSignUpAs.Size = new System.Drawing.Size(150, 25);
            this.lblSignUpAs.TabIndex = 0;
            this.lblSignUpAs.Text = "Sign up as:";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(30, 60);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(100, 35);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Client";
            this.btnClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWorker
            // 
            this.btnWorker.Location = new System.Drawing.Point(145, 60);
            this.btnWorker.Name = "btnWorker";
            this.btnWorker.Size = new System.Drawing.Size(100, 35);
            this.btnWorker.TabIndex = 2;
            this.btnWorker.Text = "Worker";
            this.btnWorker.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(260, 60);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(100, 35);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.Click += new System.EventHandler(this.button3_Click);
            // 
            // separator
            // 
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Location = new System.Drawing.Point(20, 115);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(360, 2);
            this.separator.TabIndex = 4;
            // 
            // lblHaveAccount
            // 
            this.lblHaveAccount.Location = new System.Drawing.Point(30, 140);
            this.lblHaveAccount.Name = "lblHaveAccount";
            this.lblHaveAccount.Size = new System.Drawing.Size(200, 25);
            this.lblHaveAccount.TabIndex = 5;
            this.lblHaveAccount.Text = "Already have an account?";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(240, 135);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 35);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 398);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "↩";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SignUp
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.btnBack);
            this.Name = "SignUp";
            this.Text = "Sign Up";
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
