namespace DB_Testing
{
    partial class HighRatedWorkersForm
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
            this.dgvHighRated = new System.Windows.Forms.DataGridView();
            this.btnLoadWorkers = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighRated)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHighRated
            // 
            this.dgvHighRated.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHighRated.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHighRated.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHighRated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHighRated.Location = new System.Drawing.Point(39, 32);
            this.dgvHighRated.Name = "dgvHighRated";
            this.dgvHighRated.RowHeadersWidth = 51;
            this.dgvHighRated.RowTemplate.Height = 26;
            this.dgvHighRated.Size = new System.Drawing.Size(430, 181);
            this.dgvHighRated.TabIndex = 0;
            this.dgvHighRated.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHighRated_CellContentClick);
            // 
            // btnLoadWorkers
            // 
            this.btnLoadWorkers.AutoSize = true;
            this.btnLoadWorkers.BackColor = System.Drawing.Color.Indigo;
            this.btnLoadWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadWorkers.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnLoadWorkers.ForeColor = System.Drawing.Color.White;
            this.btnLoadWorkers.Location = new System.Drawing.Point(175, 229);
            this.btnLoadWorkers.Name = "btnLoadWorkers";
            this.btnLoadWorkers.Size = new System.Drawing.Size(150, 36);
            this.btnLoadWorkers.TabIndex = 1;
            this.btnLoadWorkers.Text = "Load Workers";
            this.btnLoadWorkers.UseVisualStyleBackColor = false;
            this.btnLoadWorkers.Click += new System.EventHandler(this.btnLoadWorkers_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblTitle.Location = new System.Drawing.Point(226, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(289, 33);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "High Rated Workers";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSubtitle.Location = new System.Drawing.Point(177, 70);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(386, 21);
            this.lblSubtitle.TabIndex = 5;
            this.lblSubtitle.Text = "Shows workers with consistent 4.5+ client ratings.";
            this.lblSubtitle.Click += new System.EventHandler(this.lblSubtitle_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dgvHighRated);
            this.panelMain.Controls.Add(this.btnLoadWorkers);
            this.panelMain.Location = new System.Drawing.Point(101, 105);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(526, 281);
            this.panelMain.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Indigo;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(22, 405);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "↩";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // HighRatedWorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 462);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "HighRatedWorkersForm";
            this.Text = "High Rated Workers";
            this.Load += new System.EventHandler(this.HighRatedWorkersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighRated)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHighRated;
        private System.Windows.Forms.Button btnLoadWorkers;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnBack;
    }
}
