using System.Windows.Forms;

namespace DB_Testing
{
    partial class Form8
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

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(202, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Data Tables";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(485, 240);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(285, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 35);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Tables Preview";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dataGridView1);
            this.panelMain.Controls.Add(this.button1);
            this.panelMain.Location = new System.Drawing.Point(113, 121);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(542, 329);
            this.panelMain.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(22, 451);
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
            this.lblDescription.Location = new System.Drawing.Point(133, 84);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(522, 23);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "This form shows each worker along with their specialty information.";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 503);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDescription;

    }
}
