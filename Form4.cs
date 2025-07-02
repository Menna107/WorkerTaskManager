using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");

        public Form4()
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

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Id.Text))
            {
                CustomMessageBox.ShowInfo("Please enter a Worker ID before deleting.", "Missing ID");
                return;
            }

            DialogResult result = CustomMessageBox.Show(
                $"Deleting worker ID {Id.Text} will also remove related records in all linked tables.\n\nAre you sure?",
                "Confirm Deletion"
            );

            if (result != DialogResult.Yes)
                return;

            try
            {
                conn.Open();

                // 1. Check if worker exists
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Workers WHERE workerId = @workerId", conn);
                checkCmd.Parameters.AddWithValue("@workerId", Id.Text);
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    CustomMessageBox.ShowInfo("This Worker ID does not exist. Please check and try again.", "Invalid ID");
                    return;
                }

                // 2. Delete from child tables first
                List<string> childTables = new List<string>
                {
                    "WorkerPhone",
                    "Worker_Locations",
                    "Works_at",
                    "WorksIn",
                    "Have",
                    "Execution"
                };

                foreach (var table in childTables)
                {
                    SqlCommand deleteChild = new SqlCommand($"DELETE FROM {table} WHERE workerId = @workerId", conn);
                    deleteChild.Parameters.AddWithValue("@workerId", Id.Text);
                    deleteChild.ExecuteNonQuery();
                }

                // 3. Delete from Workers
                SqlCommand deleteWorker = new SqlCommand("DELETE FROM Workers WHERE workerId = @workerId", conn);
                deleteWorker.Parameters.AddWithValue("@workerId", Id.Text);
                deleteWorker.ExecuteNonQuery();

                CustomMessageBox.ShowInfo($"Worker with ID {Id.Text} and all related records were deleted successfully.", "Success");
                Id.Clear();
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowInfo("An error occurred: " + ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e) { }
        private void Id_TextChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
    }
}
