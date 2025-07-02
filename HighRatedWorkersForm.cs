using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class HighRatedWorkersForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");

        private ToolTip toolTip;

        public HighRatedWorkersForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ApplyTheme();
            AddToolTips();
        }

        private void AddToolTips()
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(btnLoadWorkers, "Click to load workers rated 4.5+ by all their clients.");
            toolTip.SetToolTip(btnBack, "Return to the Admin Dashboard");
        }

        private void ApplyTheme()
        {
            bool isDarkMode = ThemeManager.IsDarkMode;

            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                lblTitle.ForeColor = Color.White;
                lblSubtitle.ForeColor = Color.LightGray;
                panelMain.BackColor = Color.FromArgb(40, 40, 40);
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 240, 255);
                lblTitle.ForeColor = Color.Indigo;
                lblSubtitle.ForeColor = Color.DarkSlateGray;
                panelMain.BackColor = Color.White;
            }

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.BackColor = Color.FromArgb(74, 20, 140);
            btnBack.ForeColor = Color.White;

            btnLoadWorkers.BackColor = Color.Indigo;
            btnLoadWorkers.ForeColor = Color.White;
        }

        private void btnLoadWorkers_Click(object sender, EventArgs e)
        {
            string query = @"
                DECLARE @MinRating FLOAT = 4.5;

                SELECT w.workerId, w.Fname, w.LName
                FROM dbo.Workers w
                WHERE NOT EXISTS(
                    SELECT 1
                    FROM dbo.Execution e
                    JOIN dbo.Clients c ON e.clientId = c.client_id
                    WHERE e.workerId = w.workerId
                      AND (c.clientRating < @MinRating OR c.clientRating IS NULL)
                );";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvHighRated.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowInfo("An error occurred while loading high rated workers:\n" + ex.Message, "Error");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().Show();
        }

        private void HighRatedWorkersForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btnBack.Width, btnBack.Height);
            btnBack.Region = new Region(path);
        }

        private void dgvHighRated_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }
    }
}
