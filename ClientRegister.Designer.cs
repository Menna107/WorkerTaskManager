using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    partial class ClientRegister
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Panel mainPanel;

        private Label lblClientId;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblPaymentWay;

        private TextBox txtClientId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPaymentWay;

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
            this.lblClientId = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPaymentWay = new System.Windows.Forms.Label();
            this.txtPaymentWay = new System.Windows.Forms.TextBox();
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
            this.lblTitle.Text = "Client Registration";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.lblClientId);
            this.mainPanel.Controls.Add(this.txtClientId);
            this.mainPanel.Controls.Add(this.lblFirstName);
            this.mainPanel.Controls.Add(this.txtFirstName);
            this.mainPanel.Controls.Add(this.lblLastName);
            this.mainPanel.Controls.Add(this.txtLastName);
            this.mainPanel.Controls.Add(this.lblEmail);
            this.mainPanel.Controls.Add(this.txtEmail);
            this.mainPanel.Controls.Add(this.lblPaymentWay);
            this.mainPanel.Controls.Add(this.txtPaymentWay);
            this.mainPanel.Controls.Add(this.btnRegister);
            this.mainPanel.Location = new System.Drawing.Point(200, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(400, 309);
            this.mainPanel.TabIndex = 1;
            // 
            // lblClientId
            // 
            this.lblClientId.Location = new System.Drawing.Point(0, 0);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(100, 23);
            this.lblClientId.TabIndex = 0;
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(0, 0);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(100, 22);
            this.txtClientId.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(0, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(100, 23);
            this.lblFirstName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(0, 0);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(0, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(0, 0);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(0, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(0, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // lblPaymentWay
            // 
            this.lblPaymentWay.Location = new System.Drawing.Point(0, 0);
            this.lblPaymentWay.Name = "lblPaymentWay";
            this.lblPaymentWay.Size = new System.Drawing.Size(100, 23);
            this.lblPaymentWay.TabIndex = 8;
            // 
            // txtPaymentWay
            // 
            this.txtPaymentWay.Location = new System.Drawing.Point(0, 0);
            this.txtPaymentWay.Name = "txtPaymentWay";
            this.txtPaymentWay.Size = new System.Drawing.Size(100, 22);
            this.txtPaymentWay.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(134, 251);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 35);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 403);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 11;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ClientRegister
            // 
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ClientRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Register";
            this.Load += new System.EventHandler(this.ClientRegister_Load);
            this.Resize += new System.EventHandler(this.ClientRegister_Resize);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
