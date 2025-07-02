namespace DB_Testing
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project7DataSet = new DB_Testing.Project7DataSet();
            this.Id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.workersTableAdapter = new DB_Testing.Project7DataSetTableAdapters.WorkersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project7DataSet)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 36;
            this.button1.Text = "Delete Worker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // project7DataSet
            // 
            this.project7DataSet.DataSetName = "Project7DataSet";
            this.project7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(157, 35);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(212, 22);
            this.Id.TabIndex = 33;
            this.Id.TextChanged += new System.EventHandler(this.Id_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Worker ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(266, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 33);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Delete Worker";
            this.lblTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.button1);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.Id);
            this.panelMain.Location = new System.Drawing.Point(153, 129);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(441, 168);
            this.panelMain.TabIndex = 37;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Location = new System.Drawing.Point(14, 398);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "↩";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project7DataSet)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTitle;
        private Project7DataSet project7DataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private Project7DataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnBack;
    }
}
