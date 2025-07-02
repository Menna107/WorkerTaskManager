using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class Form7 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");

        //SqlConnection conn = new SqlConnection("server=DESKTOP-ND25F3G;database=Project7DataSet;Integrated Security=True");

        public Form7()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ApplyTheme();
            MakeBackButtonCircular();
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
        private void Form7_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this);
            ApplyTheme();
        }

        // زر الرجوع دائري
        private void MakeBackButtonCircular()
        {
            btnBack.Size = new Size(40, 40);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.BackColor = Color.FromArgb(74, 20, 140);
            btnBack.ForeColor = Color.White;

            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(0, 0, btnBack.Width, btnBack.Height);
            btnBack.Region = new Region(circlePath);
        }

        private void btnUpdateSpecialty_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int specialtyId))
            {
                CustomMessageBox.ShowInfo("Please enter a valid Specialty ID (number).", "Validation");
                return;
            }

            string specialtyName = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(specialtyName))
            {
                CustomMessageBox.ShowInfo("Please enter a Specialty Name.", "Validation");
                return;
            }

            try
            {
                string query = "UPDATE Specialties SET specialtyName = @Name WHERE specialtyID = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", specialtyName);
                cmd.Parameters.AddWithValue("@Id", specialtyId);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                    CustomMessageBox.ShowInfo("Specialty updated successfully.", "Success");
                else
                    CustomMessageBox.ShowInfo("No Specialty found with the provided ID.", "Not Found");
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowInfo("An error occurred while updating: " + ex.Message, "Error");
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Optional
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
