using System.Drawing;
using System.Windows.Forms;
using System;

namespace DB_Testing
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.panelWorkerId = new System.Windows.Forms.Panel();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblWorkerId = new System.Windows.Forms.Label();
            this.txtWorkerId = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelWorkerId.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.Location = new System.Drawing.Point(256, 52);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(300, 41);
            this.lblFormTitle.TabIndex = 100;
            this.lblFormTitle.Text = "Update Worker Info";
            this.lblFormTitle.Click += new System.EventHandler(this.lblFormTitle_Click);
            lblFormTitle.ForeColor = Color.FromArgb(74, 20, 140);

            // 
            // panelWorkerId
            // 
            this.panelWorkerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWorkerId.Controls.Add(this.txtLname);
            this.panelWorkerId.Controls.Add(this.lblLname);
            this.panelWorkerId.Controls.Add(this.txtFname);
            this.panelWorkerId.Controls.Add(this.lblFname);
            this.panelWorkerId.Controls.Add(this.lblRating);
            this.panelWorkerId.Controls.Add(this.txtEmail);
            this.panelWorkerId.Controls.Add(this.txtRating);
            this.panelWorkerId.Controls.Add(this.lblEmail);
            this.panelWorkerId.Controls.Add(this.lblWorkerId);
            this.panelWorkerId.Controls.Add(this.txtWorkerId);
            this.panelWorkerId.Controls.Add(this.buttonUpdate);
            this.panelWorkerId.Location = new System.Drawing.Point(143, 107);
            this.panelWorkerId.Name = "panelWorkerId";
            this.panelWorkerId.Size = new System.Drawing.Size(497, 294);
            this.panelWorkerId.TabIndex = 101;
            this.panelWorkerId.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWorkerId_Paint);
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(174, 187);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(270, 22);
            this.txtLname.TabIndex = 1;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(60, 190);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(75, 16);
            this.lblLname.TabIndex = 0;
            this.lblLname.Text = "Last Name:";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(174, 148);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(270, 22);
            this.txtFname.TabIndex = 1;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(58, 148);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(75, 16);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First Name:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(60, 107);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(49, 16);
            this.lblRating.TabIndex = 0;
            this.lblRating.Text = "Rating:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(174, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(174, 104);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(270, 22);
            this.txtRating.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(60, 68);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblWorkerId
            // 
            this.lblWorkerId.AutoSize = true;
            this.lblWorkerId.Location = new System.Drawing.Point(58, 30);
            this.lblWorkerId.Name = "lblWorkerId";
            this.lblWorkerId.Size = new System.Drawing.Size(70, 16);
            this.lblWorkerId.TabIndex = 0;
            this.lblWorkerId.Text = "Worker ID:";
            this.lblWorkerId.Click += new System.EventHandler(this.lblWorkerId_Click);
            // 
            // txtWorkerId
            // 
            this.txtWorkerId.Location = new System.Drawing.Point(174, 30);
            this.txtWorkerId.Name = "txtWorkerId";
            this.txtWorkerId.Size = new System.Drawing.Size(270, 22);
            this.txtWorkerId.TabIndex = 1;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(151, 237);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(160, 42);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update Worker";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 408);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "↩";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form6
            // 
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.panelWorkerId);
            this.Controls.Add(this.btnBack);
            this.Name = "Form6";
            this.Text = "Update Worker Info";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panelWorkerId.ResumeLayout(false);
            this.panelWorkerId.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblFormTitle;

        private System.Windows.Forms.Panel panelWorkerId;
        private System.Windows.Forms.Label lblWorkerId;
        private System.Windows.Forms.TextBox txtWorkerId;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtRating;

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button btnBack;
    }
}
