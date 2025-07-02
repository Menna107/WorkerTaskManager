using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    partial class ClientTasksForm
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

        private Panel mainPanel;
        private System.Windows.Forms.Button btnBack;
        private Label lblTitle;
        private DataGridView dataGridViewTasks;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(233, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "All Tasks";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.dataGridViewTasks);
            this.mainPanel.Location = new System.Drawing.Point(100, 80);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(600, 320);
            this.mainPanel.TabIndex = 0;
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTasks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.RowHeadersWidth = 51;
            this.dataGridViewTasks.RowTemplate.Height = 24;
            this.dataGridViewTasks.Size = new System.Drawing.Size(600, 320);
            this.dataGridViewTasks.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 448);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "↩";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ClientTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(785, 509);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "ClientTasksForm";
            this.Text = "My Tasks";
            this.Load += new System.EventHandler(this.ClientTasksForm_Load);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
