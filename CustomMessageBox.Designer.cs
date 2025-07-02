using System;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    partial class CustomMessageBox
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblMessage;
        private Button btnYes;
        private Button btnNo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(560, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMessage.Location = new System.Drawing.Point(20, 70);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(560, 60);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // btnYes
            // 
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Location = new System.Drawing.Point(180, 160);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(100, 40);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "Yes";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Location = new System.Drawing.Point(320, 160);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(100, 40);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "No";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // CustomMessageBox
            // 
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.ResumeLayout(false);

        }
    }
}
