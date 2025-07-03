using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class WorkerDashboardForm : Form
    {
        private string workerId;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");

        public WorkerDashboardForm()
        {
            InitializeComponent();
            ApplyTheme();
        }

        public WorkerDashboardForm(string workerId)
        {
            InitializeComponent();
            this.workerId = workerId;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            bool isDarkMode = ThemeManager.IsDarkMode;

            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                lblTitle.ForeColor = Color.White;
                lblDescription.ForeColor = Color.White;
                panelOptions.BackColor = Color.FromArgb(40, 40, 40);
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 240, 255);
                lblTitle.ForeColor = Color.FromArgb(60, 20, 100);
                lblDescription.ForeColor = Color.Black;
                panelOptions.BackColor = Color.White;
            }

            foreach (Control ctrl in panelOptions.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = Color.FromArgb(74, 20, 140);
                    btn.ForeColor = Color.White;
                    btn.Cursor = Cursors.Hand;
                }
            }

            if (btnBack != null)
            {
                btnBack.FlatStyle = FlatStyle.Flat;
                btnBack.FlatAppearance.BorderSize = 0;
                btnBack.BackColor = Color.FromArgb(74, 20, 140);
                btnBack.ForeColor = Color.White;
                MakeBackButtonCircular();
            }
        }

        private void MakeBackButtonCircular()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btnBack.Width, btnBack.Height);
            btnBack.Region = new Region(path);
        }

        private void WorkerDashboardForm_Load(object sender, EventArgs e)
        {
            ApplyTheme();
        }

        private void btnAvailableTasks_Click(object sender, EventArgs e)
        {
            this.Hide();
            AvailableTasksForm availableTasksForm = new AvailableTasksForm(workerId);
            availableTasksForm.ShowDialog();
            this.Close();
        }

        private void btnAssignedTasks_Click(object sender, EventArgs e)
        {

            this.Hide();
            AssignedTasksForm assignedTasksForm = new AssignedTasksForm(workerId);
            assignedTasksForm.ShowDialog();
            this.Close();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 Form6 = new Form6();
            Form6.ShowDialog();
            this.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
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
    }
}
