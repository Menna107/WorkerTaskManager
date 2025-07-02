using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class BestWorker : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");

        SqlConnection con = new SqlConnection("server=DESKTOP-ND25F3G;database=Project7DataSet;Integrated Security=True");

        public BestWorker()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            TimeSpan fromTime = timePickerFrom.Value.TimeOfDay;
            TimeSpan toTime = timePickerTo.Value.TimeOfDay;

            string query = @"
                SELECT 
                    s.specialtyName,
                    w.workerId,
                    w.Fname,
                    w.LName,
                    w.workerRating
                FROM 
                    Workers w
                JOIN 
                    Have h ON w.workerId = h.workerId
                JOIN 
                    Specialties s ON h.specialtyId = s.specialtyID
                JOIN 
                    Execution e ON w.workerId = e.workerId
                JOIN 
                    Requests r ON e.clientId = r.clientId AND e.tasktId = r.taskId
                WHERE 
                    r.placementTime BETWEEN @startTime AND @endTime
                    AND e.requestState = 'Completed'
                GROUP BY 
                    s.specialtyName, s.specialtyID, w.workerId, w.Fname, w.LName, w.workerRating
                HAVING 
                    w.workerRating = MAX(w.workerRating)
            ";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@startTime", fromTime);
            cmd.Parameters.AddWithValue("@endTime", toTime);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
