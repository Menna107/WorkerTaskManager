using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class ClientDashboardForm : Form
    {
        private string clientId;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");

        public ClientDashboardForm()
        {
            InitializeComponent();
            ApplyTheme();
        }

        public ClientDashboardForm(string id)
        {
            InitializeComponent();
            clientId = id;
            ApplyTheme();
            MakeBackButtonCircular();
        }
        private void MakeBackButtonCircular()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btnBack.Width, btnBack.Height);
            btnBack.Region = new Region(path);
        }

        private void ApplyTheme()
        {
            bool isDarkMode = ThemeManager.IsDarkMode;

            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);

                if (lblTitle != null)
                    lblTitle.ForeColor = Color.White;
                    lblDescription.ForeColor = Color.White;

                if (panelOptions != null)
                {
                    panelOptions.BackColor = Color.FromArgb(40, 40, 40);
                    panelOptions.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 240, 255);

                if (lblTitle != null)
                    lblTitle.ForeColor = Color.FromArgb(60, 20, 100);

                if (panelOptions != null)
                {
                    panelOptions.BackColor = Color.White;
                    panelOptions.BorderStyle = BorderStyle.FixedSingle;
                }
            }

            if (btnBack != null)
            {
                btnBack.FlatStyle = FlatStyle.Flat;
                btnBack.FlatAppearance.BorderSize = 0;
                btnBack.BackColor = Color.FromArgb(74, 20, 140);
                btnBack.ForeColor = Color.White;
            }

            // Apply the same style to option buttons inside the panel
            foreach (Control ctrl in panelOptions.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = Color.FromArgb(74, 20, 140);
                    btn.ForeColor = Color.White;
                }
            }
        }

        private void ClientDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RequestTaskForm requestForm = new RequestTaskForm(clientId);
            requestForm.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientTasksForm tasksForm = new ClientTasksForm(clientId);
            tasksForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clientId))
            {
                CustomMessageBox.ShowInfo("Client ID is missing. Please log in again.");
                return;
            }

            DialogResult result = CustomMessageBox.Show("Are you sure you want to delete your account?", "Confirm");
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();

                    // Delete all related ClientPhones first
                    string deletePhones = "DELETE FROM ClientPhone WHERE clientId = @clientId";
                    SqlCommand cmdPhones = new SqlCommand(deletePhones, conn);
                    cmdPhones.Parameters.AddWithValue("@clientId", clientId);
                    cmdPhones.ExecuteNonQuery();

                    // Delete all related Executions first
                    string deleteExecutions = "DELETE FROM Execution WHERE clientId = @clientId";
                    SqlCommand cmdExecutions = new SqlCommand(deleteExecutions, conn);
                    cmdExecutions.Parameters.AddWithValue("@clientId", clientId);
                    cmdExecutions.ExecuteNonQuery();

                    // Delete all related Requests first
                    string deleteRequests = "DELETE FROM Requests WHERE client_id = @clientId";
                    SqlCommand cmdRequests = new SqlCommand(deleteRequests, conn);
                    cmdRequests.Parameters.AddWithValue("@clientId", clientId);
                    cmdRequests.ExecuteNonQuery();

                    // Then delete the Client
                    string deleteClient = "DELETE FROM Clients WHERE client_id = @clientId";
                    SqlCommand cmdClient = new SqlCommand(deleteClient, conn);
                    cmdClient.Parameters.AddWithValue("@clientId", clientId);
                    cmdClient.ExecuteNonQuery();

                    CustomMessageBox.ShowInfo("Account deleted.");
                    this.Close();
                    new loginForm().Show();
                }
                catch (Exception ex)
                {
                    CustomMessageBox.ShowInfo("Error deleting account: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.Show("Are you sure you want to exit?", "Exit Confirmation");
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new loginForm().Show();
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
