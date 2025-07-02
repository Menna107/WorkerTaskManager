namespace DB_Testing
{
    partial class Form3
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
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(129, 31);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(220, 22);
            this.txtClientId.TabIndex = 0;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(50, 34);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(62, 16);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = " Client ID ";
            this.lblInstruction.Click += new System.EventHandler(this.lblInstruction_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblTitle.Location = new System.Drawing.Point(273, 57);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(188, 33);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Delete Client";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(145, 86);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Client";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lblInstruction);
            this.panelMain.Controls.Add(this.txtClientId);
            this.panelMain.Controls.Add(this.btnDelete);
            this.panelMain.Location = new System.Drawing.Point(150, 120);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(440, 150);
            this.panelMain.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 350);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "↩";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 422);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form3";
            this.Text = "Delete Client";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnBack;
    }
}
