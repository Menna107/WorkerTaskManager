using System.Windows.Forms;

namespace DB_Testing

{
    partial class WorkerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button btnBack;

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
            this.panelOptions = new System.Windows.Forms.Panel();
            this.btnAvailableTasks = new System.Windows.Forms.Button();
            this.btnAssignedTasks = new System.Windows.Forms.Button();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(269, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Worker Dashboard";
            //this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.Location = new System.Drawing.Point(24, 28);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(234, 23);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Choose what you want to do:";
            // 
            // panelOptions
            // 
            this.panelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOptions.Controls.Add(this.btnAvailableTasks);
            this.panelOptions.Controls.Add(this.lblDescription);
            this.panelOptions.Controls.Add(this.btnAssignedTasks);
            this.panelOptions.Controls.Add(this.btnUpdateInfo);
            this.panelOptions.Controls.Add(this.btnLogout);
            this.panelOptions.Location = new System.Drawing.Point(175, 108);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(439, 329);
            this.panelOptions.TabIndex = 2;
            // 
            // btnAvailableTasks
            // 
            this.btnAvailableTasks.Location = new System.Drawing.Point(113, 73);
            this.btnAvailableTasks.Name = "btnAvailableTasks";
            this.btnAvailableTasks.Size = new System.Drawing.Size(220, 40);
            this.btnAvailableTasks.TabIndex = 0;
            this.btnAvailableTasks.Text = "View Available Tasks";
            this.btnAvailableTasks.UseVisualStyleBackColor = true;
            this.btnAvailableTasks.Click += new System.EventHandler(this.btnAvailableTasks_Click);
            // 
            // btnAssignedTasks
            // 
            this.btnAssignedTasks.Location = new System.Drawing.Point(113, 133);
            this.btnAssignedTasks.Name = "btnAssignedTasks";
            this.btnAssignedTasks.Size = new System.Drawing.Size(220, 40);
            this.btnAssignedTasks.TabIndex = 1;
            this.btnAssignedTasks.Text = "My Assigned Tasks";
            this.btnAssignedTasks.UseVisualStyleBackColor = true;
            this.btnAssignedTasks.Click += new System.EventHandler(this.btnAssignedTasks_Click);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Location = new System.Drawing.Point(113, 193);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(220, 40);
            this.btnUpdateInfo.TabIndex = 2;
            this.btnUpdateInfo.Text = "Update My Info";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(113, 253);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 40);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(24, 448);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "↩";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // WorkerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "WorkerDashboardForm";
            this.Text = "Worker Dashboard";
            this.Load += new System.EventHandler(this.WorkerDashboardForm_Load);
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAvailableTasks;
        private Button btnAssignedTasks;
        private Button btnUpdateInfo;
        private Button btnLogout;
    }
}
