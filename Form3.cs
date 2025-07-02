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

        public Form3()
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

            // Keep existing theme colors for delete button
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientId.Text))
            {
                CustomMessageBox.ShowInfo("Please enter a Client ID before deleting.", "Missing ID");
                return;
            }

            DialogResult result = CustomMessageBox.Show(
                "Are you sure?", "Confirm Deletion"
            );


            if (result != DialogResult.Yes)
                return;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;

            try
            {
                conn.Open();

                sqlCommand.CommandText = "SELECT COUNT(*) FROM Clients WHERE client_id = @client_id";
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@client_id", txtClientId.Text);

                int count = (int)sqlCommand.ExecuteScalar();
                if (count > 0)
                {
                    // Check related child records first
                    List<string> blockingTables = new List<string>();

                    // Check Requests
                    sqlCommand.CommandText = "SELECT COUNT(*) FROM Requests WHERE client_id = @Id";
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.AddWithValue("@Id", txtClientId.Text);
                    int reqCount = (int)sqlCommand.ExecuteScalar();
                    if (reqCount > 0) blockingTables.Add("Requests");

                    // Check Execution
                    sqlCommand.CommandText = "SELECT COUNT(*) FROM Execution WHERE clientId = @Id";
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.AddWithValue("@Id", txtClientId.Text);
                    int exeCount = (int)sqlCommand.ExecuteScalar();
                    if (exeCount > 0) blockingTables.Add("Execution");

                    

                    // If there are blocking tables, show error and stop
                    if (blockingTables.Count > 0)
                    {
                        string msg = $"Cannot delete this client because related records exist in:\n\n";
                        foreach (var tbl in blockingTables)
                            msg += $"- {tbl}\n";

                        msg += "\nPlease delete these related records first.";
                        CustomMessageBox.ShowInfo(msg, "Deletion Blocked");
                        return;
                    }

                    // If no blocking child records, safe to delete
                    sqlCommand.CommandText = "DELETE FROM Clients WHERE client_id = @Id";
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.AddWithValue("@Id", txtClientId.Text);
                    sqlCommand.ExecuteNonQuery();

                    CustomMessageBox.ShowInfo($"Client with ID {txtClientId.Text} deleted successfully.", "Success");
                }
                else
                    {
                    CustomMessageBox.ShowInfo("This Client ID does not exist. Please check and try again.", "Invalid ID");
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
    }
}
