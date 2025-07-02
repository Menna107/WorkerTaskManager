using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class Form5 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");

        //SqlConnection conn = new SqlConnection("server=DESKTOP-ND25F3G;database=Project7DataSet;Integrated Security=True");

        public Form5()
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
        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxTables.Items.Add(reader["TABLE_NAME"].ToString());
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading table names: " + ex.Message);
            }
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btnBack.Width, btnBack.Height);
            btnBack.Region = new Region(path);
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (comboBoxTables.SelectedItem == null)
            {
                CustomMessageBox.ShowInfo("Please select a table first.", "Missing Selection");
                return;
            }

            string selectedTable = comboBoxTables.SelectedItem.ToString();

            try
            {
                string query = $"SELECT * FROM [{selectedTable}]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowInfo("An error occurred while loading the data:\n" + ex.Message, "Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().Show();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
