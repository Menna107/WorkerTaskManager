using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class Form10 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");

        //SqlConnection conn = new SqlConnection("server=DESKTOP-ND25F3G;database=Project7DataSet;Integrated Security=True");

        public Form10()
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
                panelGrids.BackColor = Color.FromArgb(40, 40, 40);
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 240, 255);
                lblTitle.ForeColor = Color.FromArgb(60, 20, 100);
                panelGrids.BackColor = Color.White;
            }

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.BackColor = Color.FromArgb(74, 20, 140);
            btnBack.ForeColor = Color.White;
        }
        private void btnLoadAllStats_Click(object sender, EventArgs e)
        {
            // Task: Most and Least Requested
            FillDataGrid(@"
                SELECT TOP 1 taskId, COUNT(*) AS RequestCount
                FROM Requests
                GROUP BY taskId
                ORDER BY RequestCount DESC", dgvMostTask);

            FillDataGrid(@"
                SELECT TOP 1 taskId, COUNT(*) AS RequestCount
                FROM Requests
                GROUP BY taskId
                ORDER BY RequestCount ASC", dgvLeastTask);

            // Worker: Most and Least Executed Requests
            FillDataGrid(@"
                SELECT TOP 1 e.workerId, COUNT(*) AS RequestCount
                FROM Execution e
                JOIN Requests r ON r.taskId = e.taskId AND r.client_id = e.clientId
                GROUP BY e.workerId
                ORDER BY RequestCount DESC", dgvMostWorker);

            FillDataGrid(@"
                SELECT TOP 1 e.workerId, COUNT(*) AS RequestCount
                FROM Execution e
                JOIN Requests r ON r.taskId = e.taskId AND r.client_id = e.clientId
                GROUP BY e.workerId
                ORDER BY RequestCount ASC", dgvLeastWorker);

            // Specialty: Most and Least Requested
            FillDataGrid(@"
                SELECT TOP 1 t.specialtyId, COUNT(*) AS RequestCount
                FROM Requests r
                JOIN Tasks t ON r.taskId = t.taskId
                GROUP BY t.specialtyId
                ORDER BY RequestCount DESC", dgvMostSpecialty);

            FillDataGrid(@"
                SELECT TOP 1 t.specialtyId, COUNT(*) AS RequestCount
                FROM Requests r
                JOIN Tasks t ON r.taskId = t.taskId
                GROUP BY t.specialtyId
                ORDER BY RequestCount ASC", dgvLeastSpecialty);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().Show();
        }
        private void FillDataGrid(string query, DataGridView dgv)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowInfo("Query Error: " + ex.Message, "Query Failed");
            }
        }

        private void dgvMostTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            Label[] labels = new[] { lblMostTask, lblLeastTask, lblMostWorker, lblLeastWorker, lblMostSpecialty, lblLeastSpecialty };

            foreach (var lbl in labels)
            {
                lbl.ForeColor = Color.FromArgb(60, 20, 100);
                lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lbl.BackColor = Color.Transparent;
            }
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btnBack.Width, btnBack.Height);
            btnBack.Region = new Region(path);
        }

        private void lblMostWorker_Click(object sender, EventArgs e)
        {

        }

        private void lblLeastWorker_Click(object sender, EventArgs e)
        {

        }

        private void lblLeastSpecialty_Click(object sender, EventArgs e)
        {

        }

        private void dgvLeastSpecialty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblMostSpecialty_Click(object sender, EventArgs e)
        {

        }
    }
}
