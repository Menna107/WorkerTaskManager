using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class RequestTaskForm : Form
    {
        private string clientId;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True");

        private Dictionary<string, int> specialtiesFromDb = new Dictionary<string, int>();

        public RequestTaskForm(string id)
        {
            InitializeComponent();
            clientId = id;

            this.Load += RequestTaskForm_Load;

            // Apply theme on form load
            ThemeManager.ApplyTheme(this);
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
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Label)
                        ctrl.ForeColor = Color.White;
                    else if (ctrl is TextBox || ctrl is ComboBox)
                        ctrl.BackColor = Color.FromArgb(45, 45, 45);
                }
                
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 240, 255);
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Label)
                        ctrl.ForeColor = Color.FromArgb(60, 20, 100);
                    else if (ctrl is TextBox || ctrl is ComboBox)
                        ctrl.BackColor = Color.White;
                }
               
            }
        }

        private void RequestTaskForm_Load(object sender, EventArgs e)
        {
            cmbSpecialty.Items.Clear();
            specialtiesFromDb.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT specialtyID, specialtyName FROM Specialties", connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);

                        if (!string.IsNullOrEmpty(name))
                        {
                            specialtiesFromDb[name] = id;
                            cmbSpecialty.Items.Add(name);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowInfo("Error loading specialties: " + ex.Message);
            }

            if (cmbSpecialty.Items.Count > 0)
                cmbSpecialty.SelectedIndex = 0;

            LoadTasks();
        }

        private void LoadTasks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Tasks", connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowInfo("Error loading data: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbSpecialty.SelectedItem == null)
            {
                CustomMessageBox.ShowInfo("Please select a specialty.");
                return;
            }

            if (!int.TryParse(LName.Text, out int avgTime) || !int.TryParse(email.Text, out int avgFee))
            {
                CustomMessageBox.ShowInfo("Please enter valid numbers for Average Time and Average Fee.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = connection;

                        sqlCommand.CommandText = "SELECT COUNT(*) FROM Tasks WHERE taskId = @taskId";
                        sqlCommand.Parameters.Clear();
                        sqlCommand.Parameters.AddWithValue("@taskId", Id.Text);

                        int count = (int)sqlCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            CustomMessageBox.ShowInfo("This ID already exists. Please enter a different ID.");
                        }
                        else
                        {
                            string selectedSpecialtyName = cmbSpecialty.SelectedItem.ToString();
                            int specialtyId = specialtiesFromDb[selectedSpecialtyName];

                            sqlCommand.CommandText = "INSERT INTO Tasks (taskId, taskName, avgTime, avgFee, specialtyId) " +
                                                     "VALUES (@taskId, @taskName, @avgTime, @avgFee, @specialtyId)";

                            sqlCommand.Parameters.Clear();
                            sqlCommand.Parameters.AddWithValue("@taskId", Id.Text);
                            sqlCommand.Parameters.AddWithValue("@taskName", FName.Text);
                            sqlCommand.Parameters.AddWithValue("@avgTime", avgTime);
                            sqlCommand.Parameters.AddWithValue("@avgFee", avgFee);
                            sqlCommand.Parameters.AddWithValue("@specialtyId", specialtyId);

                            sqlCommand.ExecuteNonQuery();
                            CustomMessageBox.ShowInfo("Insertion was successfully completed.");
                            LoadTasks();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowInfo("An error occurred: " + ex.Message);
            }

            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void Id_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new ClientDashboardForm(clientId).Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
