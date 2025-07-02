namespace DB_Testing
{
    partial class Form10
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
        private System.Windows.Forms.Label lblDescription;

        private void InitializeComponent()
        {
            this.panelGrids = new System.Windows.Forms.Panel();
            this.lblMostTask = new System.Windows.Forms.Label();
            this.dgvMostTask = new System.Windows.Forms.DataGridView();
            this.lblLeastTask = new System.Windows.Forms.Label();
            this.dgvLeastTask = new System.Windows.Forms.DataGridView();
            this.lblMostWorker = new System.Windows.Forms.Label();
            this.dgvMostWorker = new System.Windows.Forms.DataGridView();
            this.lblLeastWorker = new System.Windows.Forms.Label();
            this.dgvLeastWorker = new System.Windows.Forms.DataGridView();
            this.lblMostSpecialty = new System.Windows.Forms.Label();
            this.dgvMostSpecialty = new System.Windows.Forms.DataGridView();
            this.lblLeastSpecialty = new System.Windows.Forms.Label();
            this.dgvLeastSpecialty = new System.Windows.Forms.DataGridView();
            this.btnLoadAllStats = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panelGrids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeastTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeastWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostSpecialty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeastSpecialty)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGrids
            // 
            this.panelGrids.Controls.Add(this.lblMostTask);
            this.panelGrids.Controls.Add(this.dgvMostTask);
            this.panelGrids.Controls.Add(this.lblLeastTask);
            this.panelGrids.Controls.Add(this.dgvLeastTask);
            this.panelGrids.Controls.Add(this.lblMostWorker);
            this.panelGrids.Controls.Add(this.dgvMostWorker);
            this.panelGrids.Controls.Add(this.lblLeastWorker);
            this.panelGrids.Controls.Add(this.dgvLeastWorker);
            this.panelGrids.Controls.Add(this.lblMostSpecialty);
            this.panelGrids.Controls.Add(this.dgvMostSpecialty);
            this.panelGrids.Controls.Add(this.lblLeastSpecialty);
            this.panelGrids.Controls.Add(this.dgvLeastSpecialty);
            this.panelGrids.Location = new System.Drawing.Point(57, 88);
            this.panelGrids.Name = "panelGrids";
            this.panelGrids.Size = new System.Drawing.Size(850, 400);
            this.panelGrids.TabIndex = 0;
            // 
            // lblMostTask
            // 
            this.lblMostTask.AutoSize = true;
            this.lblMostTask.Location = new System.Drawing.Point(592, 10);
            this.lblMostTask.Name = "lblMostTask";
            this.lblMostTask.Size = new System.Drawing.Size(77, 16);
            this.lblMostTask.TabIndex = 0;
            this.lblMostTask.Text = "Most Tasks";
            // 
            // dgvMostTask
            // 
            this.dgvMostTask.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMostTask.ColumnHeadersHeight = 29;
            this.dgvMostTask.Location = new System.Drawing.Point(595, 36);
            this.dgvMostTask.Name = "dgvMostTask";
            this.dgvMostTask.RowHeadersWidth = 51;
            this.dgvMostTask.Size = new System.Drawing.Size(240, 150);
            this.dgvMostTask.TabIndex = 1;
            // 
            // lblLeastTask
            // 
            this.lblLeastTask.AutoSize = true;
            this.lblLeastTask.Location = new System.Drawing.Point(29, 200);
            this.lblLeastTask.Name = "lblLeastTask";
            this.lblLeastTask.Size = new System.Drawing.Size(81, 16);
            this.lblLeastTask.TabIndex = 2;
            this.lblLeastTask.Text = "Least Tasks";
            // 
            // dgvLeastTask
            // 
            this.dgvLeastTask.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLeastTask.ColumnHeadersHeight = 29;
            this.dgvLeastTask.Location = new System.Drawing.Point(32, 226);
            this.dgvLeastTask.Name = "dgvLeastTask";
            this.dgvLeastTask.RowHeadersWidth = 51;
            this.dgvLeastTask.Size = new System.Drawing.Size(240, 150);
            this.dgvLeastTask.TabIndex = 3;
            // 
            // lblMostWorker
            // 
            this.lblMostWorker.AutoSize = true;
            this.lblMostWorker.Location = new System.Drawing.Point(299, 10);
            this.lblMostWorker.Name = "lblMostWorker";
            this.lblMostWorker.Size = new System.Drawing.Size(90, 16);
            this.lblMostWorker.TabIndex = 4;
            this.lblMostWorker.Text = "Most Workers";
            this.lblMostWorker.Click += new System.EventHandler(this.lblMostWorker_Click);
            // 
            // dgvMostWorker
            // 
            this.dgvMostWorker.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMostWorker.ColumnHeadersHeight = 29;
            this.dgvMostWorker.Location = new System.Drawing.Point(303, 36);
            this.dgvMostWorker.Name = "dgvMostWorker";
            this.dgvMostWorker.RowHeadersWidth = 51;
            this.dgvMostWorker.Size = new System.Drawing.Size(240, 150);
            this.dgvMostWorker.TabIndex = 5;
            // 
            // lblLeastWorker
            // 
            this.lblLeastWorker.AutoSize = true;
            this.lblLeastWorker.Location = new System.Drawing.Point(299, 200);
            this.lblLeastWorker.Name = "lblLeastWorker";
            this.lblLeastWorker.Size = new System.Drawing.Size(94, 16);
            this.lblLeastWorker.TabIndex = 6;
            this.lblLeastWorker.Text = "Least Workers";
            this.lblLeastWorker.Click += new System.EventHandler(this.lblLeastWorker_Click);
            // 
            // dgvLeastWorker
            // 
            this.dgvLeastWorker.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLeastWorker.ColumnHeadersHeight = 29;
            this.dgvLeastWorker.Location = new System.Drawing.Point(303, 226);
            this.dgvLeastWorker.Name = "dgvLeastWorker";
            this.dgvLeastWorker.RowHeadersWidth = 51;
            this.dgvLeastWorker.Size = new System.Drawing.Size(240, 150);
            this.dgvLeastWorker.TabIndex = 7;
            // 
            // lblMostSpecialty
            // 
            this.lblMostSpecialty.AutoSize = true;
            this.lblMostSpecialty.Location = new System.Drawing.Point(29, 10);
            this.lblMostSpecialty.Name = "lblMostSpecialty";
            this.lblMostSpecialty.Size = new System.Drawing.Size(106, 16);
            this.lblMostSpecialty.TabIndex = 8;
            this.lblMostSpecialty.Text = "Most Specialties";
            this.lblMostSpecialty.Click += new System.EventHandler(this.lblMostSpecialty_Click);
            // 
            // dgvMostSpecialty
            // 
            this.dgvMostSpecialty.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMostSpecialty.ColumnHeadersHeight = 29;
            this.dgvMostSpecialty.Location = new System.Drawing.Point(32, 36);
            this.dgvMostSpecialty.Name = "dgvMostSpecialty";
            this.dgvMostSpecialty.RowHeadersWidth = 51;
            this.dgvMostSpecialty.Size = new System.Drawing.Size(240, 150);
            this.dgvMostSpecialty.TabIndex = 9;
            // 
            // lblLeastSpecialty
            // 
            this.lblLeastSpecialty.AutoSize = true;
            this.lblLeastSpecialty.Location = new System.Drawing.Point(592, 200);
            this.lblLeastSpecialty.Name = "lblLeastSpecialty";
            this.lblLeastSpecialty.Size = new System.Drawing.Size(110, 16);
            this.lblLeastSpecialty.TabIndex = 10;
            this.lblLeastSpecialty.Text = "Least Specialties";
            this.lblLeastSpecialty.Click += new System.EventHandler(this.lblLeastSpecialty_Click);
            // 
            // dgvLeastSpecialty
            // 
            this.dgvLeastSpecialty.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLeastSpecialty.ColumnHeadersHeight = 29;
            this.dgvLeastSpecialty.Location = new System.Drawing.Point(595, 226);
            this.dgvLeastSpecialty.Name = "dgvLeastSpecialty";
            this.dgvLeastSpecialty.RowHeadersWidth = 51;
            this.dgvLeastSpecialty.Size = new System.Drawing.Size(240, 150);
            this.dgvLeastSpecialty.TabIndex = 11;
            this.dgvLeastSpecialty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeastSpecialty_CellContentClick);
            // 
            // btnLoadAllStats
            // 
            this.btnLoadAllStats.Location = new System.Drawing.Point(447, 508);
            this.btnLoadAllStats.Name = "btnLoadAllStats";
            this.btnLoadAllStats.Size = new System.Drawing.Size(139, 30);
            this.btnLoadAllStats.TabIndex = 12;
            this.btnLoadAllStats.Text = "Load All Stats";
            this.btnLoadAllStats.UseVisualStyleBackColor = true;
            this.btnLoadAllStats.Click += new System.EventHandler(this.btnLoadAllStats_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(30, 530);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "↩";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(358, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(228, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Statistics Overview";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.Gray;
            this.lblDescription.Location = new System.Drawing.Point(133, 52);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(696, 23);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "This form provides an overview of most and least requested tasks, workers, and sp" +
    "ecialties.";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 582);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelGrids);
            this.Controls.Add(this.btnLoadAllStats);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.panelGrids.ResumeLayout(false);
            this.panelGrids.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeastTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeastWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostSpecialty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeastSpecialty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGrids;
        private System.Windows.Forms.DataGridView dgvMostTask;
        private System.Windows.Forms.DataGridView dgvLeastTask;
        private System.Windows.Forms.DataGridView dgvMostWorker;
        private System.Windows.Forms.DataGridView dgvLeastWorker;
        private System.Windows.Forms.DataGridView dgvMostSpecialty;
        private System.Windows.Forms.DataGridView dgvLeastSpecialty;
        private System.Windows.Forms.Button btnLoadAllStats;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMostTask;
        private System.Windows.Forms.Label lblLeastTask;
        private System.Windows.Forms.Label lblMostWorker;
        private System.Windows.Forms.Label lblLeastWorker;
        private System.Windows.Forms.Label lblMostSpecialty;
        private System.Windows.Forms.Label lblLeastSpecialty;
    }
}
