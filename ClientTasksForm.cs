using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class ClientTasksForm : Form
    {
        private string clientId;
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");

        public ClientTasksForm(string id)
        {
            InitializeComponent();
            clientId = id;

            ThemeManager.ApplyTheme(this);
            ApplyTheme();
            MakeBackButtonCircular();
            LoadTasks();
        }

        private void MakeBackButtonCircular()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btnBack.Width, btnBack.Height);
            btnBack.Region = new Region(path);
        }

        private void ApplyTheme()
        {
            bool isDarkMode = ThemeManager.IsDarkMode;

            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                lblTitle.ForeColor = Color.White;

                mainPanel.BackColor = Color.FromArgb(40, 40, 40);
                dataGridViewTasks.BackgroundColor = Color.FromArgb(45, 45, 45);
                dataGridViewTasks.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
                dataGridViewTasks.DefaultCellStyle.ForeColor = Color.White;
                dataGridViewTasks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 20, 140);
                dataGridViewTasks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 240, 255);
                lblTitle.ForeColor = Color.FromArgb(60, 20, 100);

                mainPanel.BackColor = Color.White;
                dataGridViewTasks.BackgroundColor = Color.White;
                dataGridViewTasks.DefaultCellStyle.BackColor = Color.White;
                dataGridViewTasks.DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewTasks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 20, 140);
                dataGridViewTasks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            }

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.BackColor = Color.FromArgb(74, 20, 140);
            btnBack.ForeColor = Color.White;
        }

        private void LoadTasks()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Tasks";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewTasks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tasks: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientDashboardForm(clientId).ShowDialog();
            this.Close();
        }

        private void ClientTasksForm_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
