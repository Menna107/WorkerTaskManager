using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class Form8 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");

        //SqlConnection conn = new SqlConnection("server=DESKTOP-ND25F3G;database=Project7DataSet;Integrated Security=True");

        public Form8()
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
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 240, 255);
                lblTitle.ForeColor = Color.FromArgb(60, 20, 100);
                panelMain.BackColor = Color.White;
            }

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.BackColor = Color.FromArgb(74, 20, 140);
            btnBack.ForeColor = Color.White;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"
                    SELECT 
                        W.workerId AS [Worker ID],
                        W.Fname AS [First Name],
                        W.LName AS [Last Name],
                        S.specialtyName AS [Specialty]
                    FROM 
                        Workers W
                    INNER JOIN 
                        Have H ON W.workerId = H.workerId
                    INNER JOIN 
                        Specialties S ON H.specialtyId = S.specialtyID;
                ";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowInfo("Error loading data: " + ex.Message, "Load Error");
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().Show(); 
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btnBack.Width, btnBack.Height);
            btnBack.Region = new Region(path);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
