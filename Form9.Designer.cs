namespace DB_Testing
{
    partial class Form9
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Button btnLoadReport;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDescription;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.btnLoadReport = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewReport.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(36, 25);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RowHeadersWidth = 51;
            this.dataGridViewReport.RowTemplate.Height = 26;
            this.dataGridViewReport.Size = new System.Drawing.Size(430, 182);
            this.dataGridViewReport.TabIndex = 0;
            // 
            // btnLoadReport
            // 
            this.btnLoadReport.AutoSize = true;
            this.btnLoadReport.BackColor = System.Drawing.Color.Indigo;
            this.btnLoadReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadReport.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnLoadReport.ForeColor = System.Drawing.Color.White;
            this.btnLoadReport.Location = new System.Drawing.Point(156, 225);
            this.btnLoadReport.Name = "btnLoadReport";
            this.btnLoadReport.Size = new System.Drawing.Size(192, 42);
            this.btnLoadReport.TabIndex = 1;
            this.btnLoadReport.Text = "Show Tasks Report";
            this.btnLoadReport.UseVisualStyleBackColor = false;
            this.btnLoadReport.Click += new System.EventHandler(this.btnLoadReport_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dataGridViewReport);
            this.panelMain.Controls.Add(this.btnLoadReport);
            this.panelMain.Location = new System.Drawing.Point(91, 133);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(504, 281);
            this.panelMain.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Location = new System.Drawing.Point(123, 98);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(451, 21);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "This report shows how many tasks each worker completed.";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblTitle.Location = new System.Drawing.Point(168, 56);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(355, 33);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Tasks per Worker Report";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Indigo;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 451);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "↩";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 503);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form9";
            this.Text = "Tasks Report";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
