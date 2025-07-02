using System.Drawing;
using System.Windows.Forms;
using System;

namespace DB_Testing
{
    partial class AvailableTasksForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Button btnBack;
        private DataGridView dataGridViewTasks;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(284, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Available Tasks";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(22, 448);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "↩";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTasks.ColumnHeadersHeight = 29;
            this.dataGridViewTasks.Location = new System.Drawing.Point(93, 98);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.RowHeadersWidth = 51;
            this.dataGridViewTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTasks.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewTasks.TabIndex = 1;
            // 
            // AvailableTasksForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridViewTasks);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "AvailableTasksForm";
            this.Text = "Available Tasks";
            this.Load += new System.EventHandler(this.AvailableTasksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
