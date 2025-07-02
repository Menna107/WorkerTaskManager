using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class loginForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");
        //SqlConnection conn = new SqlConnection("server=DESKTOP-ND25F3G;database=Project7DataSet;Integrated Security=True");
        public loginForm()
        {
            InitializeComponent();

            Load += loginForm_Load;

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
                mainPanel.BackColor = Color.FromArgb(40, 40, 40);
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 240, 255);
                lblTitle.ForeColor = Color.FromArgb(60, 20, 100);
                mainPanel.BackColor = Color.White;
            }

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.BackColor = Color.FromArgb(74, 20, 140);
            btnBack.ForeColor = Color.White;
        }

        private void MakeBackButtonCircular()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btnBack.Width, btnBack.Height);
            btnBack.Region = new Region(path);
        }



        private void loginForm_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Client");
            cmbRole.Items.Add("Worker");
            cmbRole.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string role = cmbRole.SelectedItem?.ToString();
            string id = txtId.Text.Trim();

            if (string.IsNullOrEmpty(role) || string.IsNullOrEmpty(id))
            {
                CustomMessageBox.ShowInfo("Please enter all fields.", "Missing Information");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (role == "Client")
                    cmd.CommandText = "SELECT COUNT(*) FROM Clients WHERE client_id = @id";
                else if (role == "Worker")
                    cmd.CommandText = "SELECT COUNT(*) FROM Workers WHERE workerId = @id";

                cmd.Parameters.AddWithValue("@id", id);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    CustomMessageBox.ShowInfo("Login successful!", "Success");
                    this.Close();

                    if (role == "Client")
                        new ClientDashboardForm(id).Show();
                    else
                        new WorkerDashboardForm(id).Show();
                }
                else
                {
                    CustomMessageBox.ShowInfo("Invalid credentials. Please try again.", "Login Failed");
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowInfo("Error: " + ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new SignUp().Show();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
