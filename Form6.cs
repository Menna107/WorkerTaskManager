using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class Form6 : Form
    {
        private Form previousForm;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");

        public Form6()
        {
            InitializeComponent();
            ApplyTheme();
            MakeBackButtonCircular();
        }

        public Form6(Form prevForm)
        {
            InitializeComponent();
            this.previousForm = prevForm;
            ApplyTheme();
            MakeBackButtonCircular();
        }

        private void ApplyTheme()
        {
            bool isDark = ThemeManager.IsDarkMode;

            this.BackColor = isDark ? Color.FromArgb(30, 30, 30) : Color.FromArgb(240, 240, 255);

            panelWorkerId.BackColor = isDark ? Color.FromArgb(40, 40, 40) : Color.White;
             
            lblFormTitle.ForeColor = isDark ? Color.White : Color.FromArgb(74, 20, 140);


            ApplyThemeToControls(this.Controls, isDark);

            if (btnBack != null)
            {
                btnBack.FlatStyle = FlatStyle.Flat;
                btnBack.FlatAppearance.BorderSize = 0;
                btnBack.BackColor = Color.FromArgb(74, 20, 140);
                btnBack.ForeColor = Color.White;
                MakeBackButtonCircular();
            }
        }


        private void ApplyThemeToControls(Control.ControlCollection controls, bool isDark)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.ForeColor = isDark ? Color.White : Color.Black;
                }
                else if (ctrl is TextBox tb)
                {
                    tb.BackColor = Color.White; 
                    tb.ForeColor = isDark ? Color.Black : Color.Black; 
                    tb.BorderStyle = BorderStyle.FixedSingle; 
                }

                else if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = Color.FromArgb(74, 20, 140);
                    btn.ForeColor = Color.White;
                    btn.Cursor = Cursors.Hand;
                }
                else if (ctrl.HasChildren)
                {
                    ApplyThemeToControls(ctrl.Controls, isDark);
                }
            }
        }

        private void MakeBackButtonCircular()
        {
            if (btnBack == null) return;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btnBack.Width, btnBack.Height);
            btnBack.Region = new Region(path);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Workers SET Fname = @Fname, LName = @LName, email = @Email, workerRating = @Rating WHERE workerId = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Fname", txtFname.Text);
                cmd.Parameters.AddWithValue("@LName", txtLname.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Rating", int.Parse(txtRating.Text));
                cmd.Parameters.AddWithValue("@Id", int.Parse(txtWorkerId.Text));

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    CustomMessageBox.ShowInfo("Worker updated successfully.");
                else
                    CustomMessageBox.ShowInfo("No worker found with the provided ID.");
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowInfo("An error occurred while updating: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WorkerDashboardForm().ShowDialog();
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ApplyTheme();
        }

        private void lblFormTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblWorkerId_Click(object sender, EventArgs e)
        {

        }

        private void panelWorkerId_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
