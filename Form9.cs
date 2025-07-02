using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class Form9 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");

        public Form9()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            bool isDarkMode = ThemeManager.IsDarkMode;
            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                lblTitle.ForeColor = Color.White;
                panelMain.BackColor = Color.FromArgb(40, 40, 40);
                lblDescription.ForeColor = Color.LightGray;
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 240, 255);
                lblTitle.ForeColor = Color.FromArgb(60, 20, 100);
                panelMain.BackColor = Color.White;
                lblDescription.ForeColor = Color.FromArgb(80, 60, 120);
            }

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.BackColor = Color.FromArgb(74, 20, 140);
            btnBack.ForeColor = Color.White;

            btnLoadReport.BackColor = Color.Indigo;
            btnLoadReport.ForeColor = Color.White;
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            string query = @"
                SELECT 
                    W.Fname + ' ' + W.LName AS WorkerName,
                    COUNT(E.executionId) AS TasksCompleted
                FROM 
                    Workers W
                JOIN 
                    Execution E ON W.workerId = E.workerId
                GROUP BY 
                    W.Fname, W.LName;
            ";

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewReport.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowInfo("An error occurred while loading the report:\n" + ex.Message, "Error");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btnBack.Width, btnBack.Height);
            btnBack.Region = new Region(path);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            // No action needed
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
