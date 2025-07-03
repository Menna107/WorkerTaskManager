using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DB_Testing
{
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");
        //SqlConnection conn = new SqlConnection("server=DESKTOP-ND25F3G;database=Project7DataSet;Integrated Security=True");

        private int clientId;

        public Form3()
        {
            InitializeComponent();
            this.clientId = clientId;
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

            // Keep existing theme colors for delete button
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
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

        private void Form3_Load(object sender, EventArgs e)
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

        private void lblInstruction_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
