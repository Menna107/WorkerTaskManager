namespace DB_Testing
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(430, 182);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnLoadData
            // 
            this.btnLoadData.AutoSize = true;
            this.btnLoadData.BackColor = System.Drawing.Color.Indigo;
            this.btnLoadData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoadData.Location = new System.Drawing.Point(173, 279);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(117, 34);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Show Data";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(20, 25);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(173, 32);
            this.comboBoxTables.TabIndex = 2;
            this.comboBoxTables.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.comboBoxTables);
            this.panelMain.Controls.Add(this.btnLoadData);
            this.panelMain.Controls.Add(this.dataGridView1);
            this.panelMain.Location = new System.Drawing.Point(127, 95);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(516, 340);
            this.panelMain.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblTitle.Location = new System.Drawing.Point(257, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Database Browser";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Indigo;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(24, 447);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "↩";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 499);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form5";
            this.Text = "selectData";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
    }
}
