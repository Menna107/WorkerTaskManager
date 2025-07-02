using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DB_Testing
{
    public partial class WorkerRegister : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");
        //SqlConnection conn = new SqlConnection("server=DESKTOP-ND25F3G;database=Project7DataSet;Integrated Security=True");
        public WorkerRegister()
        {
            InitializeComponent(); 
            ThemeManager.ApplyTheme(this); // استخدام الثيم العام

            ApplyTheme();
            ApplyStyles();
        }

        private void ApplyTheme()
        {
            bool isDark = ThemeManager.IsDarkMode;

            this.BackColor = isDark ? Color.FromArgb(30, 30, 30) : Color.FromArgb(240, 240, 255);
            mainPanel.BackColor = isDark ? Color.FromArgb(40, 40, 40) : Color.White;
            lblTitle.ForeColor = isDark ? Color.White : Color.FromArgb(74, 20, 140);

            foreach (Control ctrl in mainPanel.Controls)
            {
                if (ctrl is Label lbl)
                    lbl.ForeColor = isDark ? Color.White : Color.Black;
            }
        }

        private void ApplyStyles()
        {
            StyleButton(btnRegister);
            StyleBackButton(btnBack);
        }

        private void StyleButton(Button btn)
        {
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.BackColor = Color.FromArgb(74, 20, 140);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(100, 40, 160);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(74, 20, 140);
        }

        private void StyleBackButton(Button btn)
        {
            btn.Text = "↩";
            btn.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            btn.BackColor = Color.FromArgb(74, 20, 140);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(100, 40, 160);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(74, 20, 140);

            MakeButtonRound(btn);
        }

        private void MakeButtonRound(Button btn)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }

        private void WorkerRegister_Load(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWorkerId.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                CustomMessageBox.ShowInfo("Please fill in all fields before submitting.", "Missing Information");
                return;
            }

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;

            try
            {
                conn.Open();

                sqlCommand.CommandText = "SELECT COUNT(*) FROM Workers WHERE workerId = @workerId";
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@workerId", txtWorkerId.Text);

                int count = (int)sqlCommand.ExecuteScalar();
                if (count > 0)
                {
                    CustomMessageBox.ShowInfo("This ID already exists. Please enter a different ID.", "Duplicate ID");
                }
                else
                {
                    sqlCommand.CommandText = "INSERT INTO Workers(workerId, FName, LName, email) VALUES (@workerId, @fName, @lName, @email)";
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.AddWithValue("@workerId", txtWorkerId.Text);
                    sqlCommand.Parameters.AddWithValue("@fName", txtFirstName.Text);
                    sqlCommand.Parameters.AddWithValue("@lName", txtLastName.Text);
                    sqlCommand.Parameters.AddWithValue("@email", txtEmail.Text);

                    sqlCommand.ExecuteNonQuery();
                    CustomMessageBox.ShowInfo("Worker registered successfully!", "Success");
                }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorkerRegister_Resize(object sender, EventArgs e)
        {
            MakeButtonRound(btnBack);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
