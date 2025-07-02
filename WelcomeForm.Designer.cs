using System;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    partial class WelcomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Panel panelMain;
        private Label lblExplanation;
        private Label lblDescription;
        private RadioButton radioLight;
        private RadioButton radioDark;
        private Button btnContinue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.radioLight = new System.Windows.Forms.RadioButton();
            this.radioDark = new System.Windows.Forms.RadioButton();
            this.btnContinue = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.lblTitle.Location = new System.Drawing.Point(100, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Task Manager";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click_1);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.lblExplanation);
            this.panelMain.Controls.Add(this.lblDescription);
            this.panelMain.Controls.Add(this.radioLight);
            this.panelMain.Controls.Add(this.radioDark);
            this.panelMain.Controls.Add(this.btnContinue);
            this.panelMain.Location = new System.Drawing.Point(131, 98);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(550, 349);
            this.panelMain.TabIndex = 1;
            // 
            // lblExplanation
            // 
            this.lblExplanation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblExplanation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblExplanation.Location = new System.Drawing.Point(30, 27);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(540, 90);
            this.lblExplanation.TabIndex = 1;
            this.lblExplanation.Text = "This application helps you register clients and workers,\nmanage tasks and assign " +
    "feedback efficiently.\nPlease choose your preferred theme to continue.";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDescription.ForeColor = System.Drawing.Color.Gray;
            this.lblDescription.Location = new System.Drawing.Point(29, 127);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(400, 30);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Choose your preferred theme:";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // radioLight
            // 
            this.radioLight.Checked = true;
            this.radioLight.ForeColor = System.Drawing.Color.Black;
            this.radioLight.Location = new System.Drawing.Point(51, 175);
            this.radioLight.Name = "radioLight";
            this.radioLight.Size = new System.Drawing.Size(150, 30);
            this.radioLight.TabIndex = 3;
            this.radioLight.TabStop = true;
            this.radioLight.Text = "Light Mode";
            this.radioLight.CheckedChanged += new System.EventHandler(this.ThemeChanged);
            // 
            // radioDark
            // 
            this.radioDark.ForeColor = System.Drawing.Color.Black;
            this.radioDark.Location = new System.Drawing.Point(51, 210);
            this.radioDark.Name = "radioDark";
            this.radioDark.Size = new System.Drawing.Size(150, 30);
            this.radioDark.TabIndex = 4;
            this.radioDark.Text = "Dark Mode";
            this.radioDark.CheckedChanged += new System.EventHandler(this.ThemeChanged);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(184, 273);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(180, 40);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // WelcomeForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
