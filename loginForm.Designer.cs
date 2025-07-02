using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    partial class loginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Panel mainPanel;
        private Label lblId;
        private Label lblRole;
        private TextBox txtId;
        private ComboBox cmbRole;
        private Button btnLogin;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
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
            this.lblTitle.Size = new System.Drawing.Size(800, 71);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Login";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.lblId);
            this.mainPanel.Controls.Add(this.txtId);
            this.mainPanel.Controls.Add(this.lblRole);
            this.mainPanel.Controls.Add(this.cmbRole);
            this.mainPanel.Controls.Add(this.btnLogin);
            this.mainPanel.Location = new System.Drawing.Point(196, 118);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(437, 209);
            this.mainPanel.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblId.Location = new System.Drawing.Point(36, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(80, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtId.Location = new System.Drawing.Point(126, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(250, 34);
            this.txtId.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRole.Location = new System.Drawing.Point(36, 78);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(80, 25);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role:";
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbRole.Location = new System.Drawing.Point(126, 78);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(250, 36);
            this.cmbRole.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(148, 142);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 46);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
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
            // loginForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.btnBack);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

    }
}
