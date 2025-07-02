using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class noOfReq : Form
    {
        public noOfReq()
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
                lblDescription.ForeColor = Color.LightGray;
                panelMain.BackColor = Color.FromArgb(40, 40, 40);
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 240, 255);
                lblTitle.ForeColor = Color.FromArgb(60, 20, 100);
                lblDescription.ForeColor = Color.FromArgb(80, 60, 120);
                panelMain.BackColor = Color.White;
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
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");

            string query = @"
                SELECT DISTINCT s.specialtyName
                FROM Specialties s
                JOIN Tasks t ON t.specialtyId = s.specialtyID
                WHERE NOT EXISTS (
                    SELECT 1
                    FROM Requests r
                    WHERE r.taskId = t.taskId
                      AND MONTH(r.placementTime) = MONTH(GETDATE())
                      AND YEAR(r.placementTime) = YEAR(GETDATE())
                );";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    CustomMessageBox.ShowInfo("No specialties found without requests this month.", "Info");
                    return;
                }
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowInfo("An error occurred while loading the data:\n" + ex.Message, "Error");
            }
        }

        private void noOfReq_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btnBack.Width, btnBack.Height);
            btnBack.Region = new Region(path);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().Show();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            // No action needed
        }
    }
}
