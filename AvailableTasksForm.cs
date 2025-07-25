﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class AvailableTasksForm : Form
    {
        private Form previousForm;
        private string workerId;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");

        // Constructor now receives previous form to return to, and workerId
        public AvailableTasksForm(string workerId)
        {
            InitializeComponent();
            this.workerId = workerId;
            ApplyTheme();
            MakeBackButtonCircular();
            LoadTasks();
        }

        private void ApplyTheme()
        {
            bool isDark = ThemeManager.IsDarkMode;

            this.BackColor = isDark ? Color.FromArgb(30, 30, 30) : Color.FromArgb(240, 240, 255);
            lblTitle.ForeColor = isDark ? Color.White : Color.FromArgb(60, 20, 100);

            dataGridViewTasks.BackgroundColor = isDark ? Color.FromArgb(40, 40, 40) : Color.White;
            dataGridViewTasks.ForeColor = isDark ? Color.WhiteSmoke : Color.Black;
            dataGridViewTasks.GridColor = Color.Gray;

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.BackColor = Color.FromArgb(74, 20, 140);
            btnBack.ForeColor = Color.White;
        }

        private void MakeBackButtonCircular()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btnBack.Width, btnBack.Height);
            btnBack.Region = new Region(path);
        }

        private void LoadTasks()
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    @"SELECT taskId, taskName, avgTime, avgFee 
                      FROM Tasks 
                      WHERE taskId NOT IN 
                      (SELECT taskId FROM Execution WHERE workerId = @workerId)", conn);

                adapter.SelectCommand.Parameters.AddWithValue("@workerId", workerId);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridViewTasks.DataSource = table;
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowInfo("Error loading tasks: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new WorkerDashboardForm(workerId).Show();
        }


        private void lblTitle_Click(object sender, EventArgs e)
        {
            // Optional event
        }


        private void AvailableTasksForm_Load(object sender, EventArgs e)
        {

        }
    }
}
