namespace DB_Testing
{
    partial class noOfReq
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnLoadReport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadReport
            // 
            this.btnLoadReport.AutoSize = true;
            this.btnLoadReport.BackColor = System.Drawing.Color.Indigo;
            this.btnLoadReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadReport.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnLoadReport.ForeColor = System.Drawing.Color.White;
            this.btnLoadReport.Location = new System.Drawing.Point(148, 316);
            this.btnLoadReport.Name = "btnLoadReport";
            this.btnLoadReport.Size = new System.Drawing.Size(283, 38);
            this.btnLoadReport.TabIndex = 0;
            this.btnLoadReport.Text = "Show Specialties Without Requests";
            this.btnLoadReport.UseVisualStyleBackColor = false;
            this.btnLoadReport.Click += new System.EventHandler(this.btnLoadReport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(490, 256);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblTitle.Location = new System.Drawing.Point(167, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(565, 33);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Specialties with No Requests This Month";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dataGridView1);
            this.panelMain.Controls.Add(this.btnLoadReport);
            this.panelMain.Location = new System.Drawing.Point(136, 135);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(607, 370);
            this.panelMain.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Location = new System.Drawing.Point(207, 100);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(480, 21);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "This report lists specialties with no requests placed this month.";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Indigo;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(23, 501);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "↩";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // noOfReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 569);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelMain);
            this.Name = "noOfReq";
            this.Text = "Requests Summary";
            this.Load += new System.EventHandler(this.noOfReq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDescription;
    }
}
