using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class Form11 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");

        // Connection string - update server/database if needed
        //SqlConnection conn = new SqlConnection("server=DESKTOP-ND25F3G;database=Project7DataSet;Integrated Security=True");

        public Form11()
        {
            InitializeComponent();
            LoadRequests();
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
                panel1.BackColor = Color.FromArgb(40, 40, 40);
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 240, 255);
                lblTitle.ForeColor = Color.FromArgb(60, 20, 100);
                panel1.BackColor = Color.White;
            }

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.BackColor = Color.FromArgb(74, 20, 140);
            btnBack.ForeColor = Color.White;
        }
        // Load all request IDs into the ComboBox
        private void LoadRequests()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT requestId FROM Requests", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbRequests.DataSource = dt;
                cmbRequests.DisplayMember = "requestId";
                cmbRequests.ValueMember = "requestId";
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowInfo("Error loading requests: " + ex.Message, "Load Error");
            }
        }

        // Button click event to show matching workers for the selected request
        private void btnShowWorkers_Click(object sender, EventArgs e)
        {
            if (cmbRequests.SelectedValue == null)
            {
                CustomMessageBox.ShowInfo("Please select a request ID first.", "No Selection");
                return;
            }

            string query = @"
                SELECT DISTINCT w.workerId, w.Fname, w.LName, w.email
                FROM Workers w
                JOIN Have h ON w.workerId = h.workerId
                JOIN WorksIn wi ON w.workerId = wi.workerId
                JOIN Works_at wa ON w.workerId = wa.workerId
                JOIN Requests r ON r.requestId = @RequestId
                JOIN Tasks t ON r.taskId = t.taskId
                WHERE h.specialtyId = t.specialtyId
                  AND wa.timeSlotId = r.perferredTimeSlotId";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@RequestId", cmbRequests.SelectedValue);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvMatchingWorkers.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    CustomMessageBox.ShowInfo("No matching workers found for the selected request.", "No Matches");
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowInfo("Error fetching workers: " + ex.Message, "Fetch Error");
            }
        }

        private void dgvMatchingWorkers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().Show();
        }
        private void Form11_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btnBack.Width, btnBack.Height);
            btnBack.Region = new Region(path);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
