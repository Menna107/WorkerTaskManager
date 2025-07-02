using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class WageForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");

        public WageForm()
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

                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;

                dataGridViewResults.BackgroundColor = Color.FromArgb(50, 50, 50);
                dataGridViewResults.DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                dataGridViewResults.DefaultCellStyle.ForeColor = Color.White;
                dataGridViewResults.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 20, 140);
                dataGridViewResults.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                btnCalculate.BackColor = Color.FromArgb(74, 20, 140);
                btnCalculate.ForeColor = Color.White;

                dateTimePicker1.CalendarMonthBackground = Color.FromArgb(60, 60, 60);
                dateTimePicker2.CalendarMonthBackground = Color.FromArgb(60, 60, 60);
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 240, 255);
                lblTitle.ForeColor = Color.FromArgb(60, 20, 100);
                panelMain.BackColor = Color.White;

                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;

                dataGridViewResults.BackgroundColor = Color.White;
                dataGridViewResults.DefaultCellStyle.BackColor = Color.White;
                dataGridViewResults.DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewResults.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
                dataGridViewResults.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                btnCalculate.BackColor = Color.FromArgb(74, 20, 140);
                btnCalculate.ForeColor = Color.White;

                dateTimePicker1.CalendarMonthBackground = Color.White;
                dateTimePicker2.CalendarMonthBackground = Color.White;
            }

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.BackColor = Color.FromArgb(74, 20, 140);
            btnBack.ForeColor = Color.White;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;

            if (startDate > endDate)
            {
                CustomMessageBox.ShowInfo("Please select a valid date range: Start Date must be before End Date.", "Invalid Dates");
                return;
            }

            string query = @"
                SELECT 
                    w.workerId,
                    w.Fname + ' ' + w.LName AS WorkerName,
                    SUM(t.avgFee * ISNULL(c.clientRating, 1)) AS TotalDueWage
                FROM 
                    dbo.Execution e
                    INNER JOIN dbo.Workers w ON e.workerId = w.workerId
                    INNER JOIN dbo.Tasks t ON e.taskId = t.taskId
                    INNER JOIN dbo.Clients c ON e.clientId = c.client_id
                    INNER JOIN dbo.Requests r ON r.taskId = e.taskId AND r.client_id = e.clientId
                WHERE 
                    r.placementTime BETWEEN @startDate AND @endDate
                GROUP BY 
                    w.workerId, w.Fname, w.LName
                ORDER BY 
                    w.workerId;
            ";


            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@startDate", SqlDbType.DateTime).Value = startDate;
                cmd.Parameters.Add("@endDate", SqlDbType.DateTime).Value = endDate;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        CustomMessageBox.ShowInfo("No wage data found for the selected date range.", "No Data");
                        dataGridViewResults.DataSource = null;
                    }
                    else
                    {
                        dataGridViewResults.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.ShowInfo("An error occurred while calculating wages:\n" + ex.Message, "Error");
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }

        private void dataGridViewResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new AdminDashboard().Show();
        }

        private void WageForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btnBack.Width, btnBack.Height);
            btnBack.Region = new Region(path);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
