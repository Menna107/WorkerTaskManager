using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    partial class ClientDashboardForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnRequestTask = new System.Windows.Forms.Button();
            this.btnViewTasks = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.lblTitle.Location = new System.Drawing.Point(263, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Client Dashboard";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.Location = new System.Drawing.Point(22, 38);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(234, 23);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Choose what you want to do:";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // btnRequestTask
            // 
            this.btnRequestTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.btnRequestTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequestTask.FlatAppearance.BorderSize = 0;
            this.btnRequestTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestTask.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRequestTask.ForeColor = System.Drawing.Color.White;
            this.btnRequestTask.Location = new System.Drawing.Point(138, 108);
            this.btnRequestTask.Name = "btnRequestTask";
            this.btnRequestTask.Size = new System.Drawing.Size(240, 40);
            this.btnRequestTask.TabIndex = 0;
            this.btnRequestTask.Text = "Request Task";
            this.btnRequestTask.UseVisualStyleBackColor = false;
            this.btnRequestTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViewTasks
            // 
            this.btnViewTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.btnViewTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewTasks.FlatAppearance.BorderSize = 0;
            this.btnViewTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTasks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnViewTasks.ForeColor = System.Drawing.Color.White;
            this.btnViewTasks.Location = new System.Drawing.Point(138, 175);
            this.btnViewTasks.Name = "btnViewTasks";
            this.btnViewTasks.Size = new System.Drawing.Size(240, 40);
            this.btnViewTasks.TabIndex = 1;
            this.btnViewTasks.Text = "View Tasks";
            this.btnViewTasks.UseVisualStyleBackColor = false;
            this.btnViewTasks.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.btnDeleteAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAccount.FlatAppearance.BorderSize = 0;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Location = new System.Drawing.Point(138, 246);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(240, 40);
            this.btnDeleteAccount.TabIndex = 2;
            this.btnDeleteAccount.Text = "Delete My Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(138, 313);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(240, 40);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 526);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 46);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "↩";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.White;
            this.panelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOptions.Controls.Add(this.btnRequestTask);
            this.panelOptions.Controls.Add(this.lblDescription);
            this.panelOptions.Controls.Add(this.btnViewTasks);
            this.panelOptions.Controls.Add(this.btnDeleteAccount);
            this.panelOptions.Controls.Add(this.btnLogout);
            this.panelOptions.Location = new System.Drawing.Point(131, 85);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(516, 413);
            this.panelOptions.TabIndex = 2;
            // 
            // ClientDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(809, 584);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.btnBack);
            this.Name = "ClientDashboardForm";
            this.Text = "Client Dashboard";
            this.Load += new System.EventHandler(this.ClientDashboardForm_Load);
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button btnRequestTask;
        private System.Windows.Forms.Button btnViewTasks;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;
    }
}
