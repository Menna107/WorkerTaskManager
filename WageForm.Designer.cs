namespace DB_Testing
{
    partial class WageForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(98, 65);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "From :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "To :";
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(98, 98);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowHeadersWidth = 51;
            this.dataGridViewResults.Size = new System.Drawing.Size(434, 255);
            this.dataGridViewResults.TabIndex = 4;
            this.dataGridViewResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResults_CellContentClick);
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(207, 372);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(180, 35);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Load Wage Report";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dateTimePicker1);
            this.panelMain.Controls.Add(this.dateTimePicker2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.dataGridViewResults);
            this.panelMain.Controls.Add(this.btnCalculate);
            this.panelMain.Location = new System.Drawing.Point(129, 106);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(588, 423);
            this.panelMain.TabIndex = 6;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblTitle.Location = new System.Drawing.Point(262, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(283, 29);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Workers\' Wage Report";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.Gray;
            this.lblDescription.Location = new System.Drawing.Point(151, 73);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(543, 21);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "This report shows the total wage for each worker in the selected range.";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Indigo;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(30, 513);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "↩";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // WageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 565);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "WageForm";
            this.Text = "Wage Report";
            this.Load += new System.EventHandler(this.WageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnBack;
    }
}
