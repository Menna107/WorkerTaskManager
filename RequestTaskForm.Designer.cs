using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    partial class RequestTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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



        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FName = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbSpecialty = new System.Windows.Forms.ComboBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(150, 95);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(220, 30);
            this.FName.TabIndex = 4;
            // 
            // LName
            // 
            this.LName.Location = new System.Drawing.Point(150, 135);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(220, 30);
            this.LName.TabIndex = 6;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(150, 175);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(220, 30);
            this.email.TabIndex = 8;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(150, 55);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(220, 30);
            this.Id.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Task ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Avg Fee:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(283, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Insert a New Task";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Avg Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Task Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Specialty:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(92, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Insert Task";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbSpecialty
            // 
            this.cmbSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecialty.Location = new System.Drawing.Point(150, 215);
            this.cmbSpecialty.Name = "cmbSpecialty";
            this.cmbSpecialty.Size = new System.Drawing.Size(220, 31);
            this.cmbSpecialty.TabIndex = 10;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.Id);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.FName);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.LName);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.email);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.cmbSpecialty);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Location = new System.Drawing.Point(189, 74);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(422, 369);
            this.mainPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(25, 448);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "↩";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RequestTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "RequestTaskForm";
            this.Text = "Request Task";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Project7DataSet project7DataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private Project7DataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private Project7DataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSpecialty;
    }
}