namespace DB_Testing
{
    partial class Form11
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private System.Windows.Forms.Label lblDescription;


        private void InitializeComponent()
        {
            this.btnShowWorkers = new System.Windows.Forms.Button();
            this.dgvMatchingWorkers = new System.Windows.Forms.DataGridView();
            this.cmbRequests = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchingWorkers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowWorkers
            // 
            this.btnShowWorkers.AutoSize = true;
            this.btnShowWorkers.Location = new System.Drawing.Point(210, 264);
            this.btnShowWorkers.Name = "btnShowWorkers";
            this.btnShowWorkers.Size = new System.Drawing.Size(143, 27);
            this.btnShowWorkers.TabIndex = 0;
            this.btnShowWorkers.Text = "Show Workers";
            this.btnShowWorkers.UseVisualStyleBackColor = true;
            this.btnShowWorkers.Click += new System.EventHandler(this.btnShowWorkers_Click);
            // 
            // dgvMatchingWorkers
            // 
            this.dgvMatchingWorkers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMatchingWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatchingWorkers.Location = new System.Drawing.Point(32, 73);
            this.dgvMatchingWorkers.Name = "dgvMatchingWorkers";
            this.dgvMatchingWorkers.RowHeadersWidth = 51;
            this.dgvMatchingWorkers.RowTemplate.Height = 26;
            this.dgvMatchingWorkers.Size = new System.Drawing.Size(444, 185);
            this.dgvMatchingWorkers.TabIndex = 1;
            this.dgvMatchingWorkers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatchingWorkers_CellContentClick);
            // 
            // cmbRequests
            // 
            this.cmbRequests.FormattingEnabled = true;
            this.cmbRequests.Location = new System.Drawing.Point(32, 24);
            this.cmbRequests.Name = "cmbRequests";
            this.cmbRequests.Size = new System.Drawing.Size(167, 24);
            this.cmbRequests.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMatchingWorkers);
            this.panel1.Controls.Add(this.cmbRequests);
            this.panel1.Controls.Add(this.btnShowWorkers);
            this.panel1.Location = new System.Drawing.Point(125, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 312);
            this.panel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(235, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 33);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Matching Workers";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Location = new System.Drawing.Point(26, 441);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "↩";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.Gray;
            this.lblDescription.Location = new System.Drawing.Point(106, 77);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(566, 23);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Select a request ID to view workers who match its specialty and time slot.";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 503);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Name = "Form11";
            this.Text = "Matching Workers";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchingWorkers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowWorkers;
        private System.Windows.Forms.DataGridView dgvMatchingWorkers;
        private System.Windows.Forms.ComboBox cmbRequests;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
    }
}
