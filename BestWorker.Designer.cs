namespace DB_Testing
{
    partial class BestWorker
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.timePickerTo = new System.Windows.Forms.DateTimePicker();
            this.From = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(135, 328);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(102, 32);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "btnShow";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(634, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // timePickerFrom
            // 
            this.timePickerFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerFrom.Location = new System.Drawing.Point(166, 20);
            this.timePickerFrom.Name = "timePickerFrom";
            this.timePickerFrom.Size = new System.Drawing.Size(228, 30);
            this.timePickerFrom.TabIndex = 2;
            // 
            // timePickerTo
            // 
            this.timePickerTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerTo.Location = new System.Drawing.Point(166, 60);
            this.timePickerTo.Name = "timePickerTo";
            this.timePickerTo.Size = new System.Drawing.Size(228, 30);
            this.timePickerTo.TabIndex = 3;
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Location = new System.Drawing.Point(79, 20);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(52, 22);
            this.From.TabIndex = 4;
            this.From.Text = "From";
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Location = new System.Drawing.Point(79, 60);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(31, 22);
            this.To.TabIndex = 5;
            this.To.Text = "To";
            // 
            // BestWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.timePickerTo);
            this.Controls.Add(this.timePickerFrom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShow);
            this.Name = "BestWorker";
            this.Text = "BestWorker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker timePickerFrom;
        private System.Windows.Forms.DateTimePicker timePickerTo;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label To;
    }
}