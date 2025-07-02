using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class ClientRegister : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4RIBR5F;Initial Catalog=Project7;Integrated Security=True;TrustServerCertificate=True;");
        //SqlConnection conn = new SqlConnection("server=DESKTOP-ND25F3G;database=Project7DataSet;Integrated Security=True");
        public ClientRegister()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this); // ← استخدمي ThemeManager
            SetupFormLayout();
            ApplyTheme();
            ApplyStyles();
        }

        private void ApplyTheme()
        {
            bool isDark = ThemeManager.IsDarkMode; // ← استخدمي ThemeManager بدلاً من الدالة المحلية
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
            StyleButton(btnRegister, "Register");

            btnBack.Text = "↩";
            btnBack.BackColor = Color.FromArgb(74, 20, 140);
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            btnBack.Size = new Size(40, 40);
            btnBack.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBack.Width, btnBack.Height, 40, 40));
            btnBack.Cursor = Cursors.Hand;

            btnBack.MouseEnter += (s, e) => btnBack.BackColor = Color.FromArgb(100, 40, 160);
            btnBack.MouseLeave += (s, e) => btnBack.BackColor = Color.FromArgb(74, 20, 140);
        }

        private void StyleButton(Button btn, string icon)
        {
            btn.Text = $"{icon} {btn.Text}";
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.BackColor = Color.FromArgb(74, 20, 140);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(100, 40, 160);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(74, 20, 140);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect,
                                                        int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUp().Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientId.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                CustomMessageBox.ShowInfo("Please fill in all fields.", "Warning");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Clients WHERE client_id = @id", conn);
                cmd.Parameters.AddWithValue("@id", txtClientId.Text);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    CustomMessageBox.ShowInfo("This ID already exists.", "Duplicate ID");
                    return;
                }

                cmd = new SqlCommand("INSERT INTO Clients(client_id, fName, lName, email, paymentWay) VALUES (@id, @fn, @ln, @em, @pw)", conn);
                cmd.Parameters.AddWithValue("@id", txtClientId.Text);
                cmd.Parameters.AddWithValue("@fn", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@ln", txtLastName.Text);
                cmd.Parameters.AddWithValue("@em", txtEmail.Text);
                cmd.Parameters.AddWithValue("@pw", txtPaymentWay.Text);
                cmd.ExecuteNonQuery();

                CustomMessageBox.ShowInfo("Registered successfully.", "Success");
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

        private void ClientRegister_Load(object sender, EventArgs e) => MakeButtonRound(btnBack);
        private void ClientRegister_Resize(object sender, EventArgs e) => MakeButtonRound(btnBack);

        private void MakeButtonRound(Button btn)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }

        private void SetupFormLayout()
        {
            lblClientId.Text = "Client ID";
            lblClientId.Location = new Point(20, 20);
            txtClientId.Location = new Point(130, 20);
            txtClientId.Size = new Size(240, 22);

            lblFirstName.Text = "First Name";
            lblFirstName.Location = new Point(20, 60);
            txtFirstName.Location = new Point(130, 60);
            txtFirstName.Size = new Size(240, 22);

            lblLastName.Text = "Last Name";
            lblLastName.Location = new Point(20, 100);
            txtLastName.Location = new Point(130, 100);
            txtLastName.Size = new Size(240, 22);

            lblEmail.Text = "Email";
            lblEmail.Location = new Point(20, 140);
            txtEmail.Location = new Point(130, 140);
            txtEmail.Size = new Size(240, 22);

            lblPaymentWay.Text = "Payment Way";
            lblPaymentWay.Location = new Point(20, 180);
            txtPaymentWay.Location = new Point(130, 180);
            txtPaymentWay.Size = new Size(240, 22);
        }

        private void lblTitle_Click(object sender, EventArgs e) { }
    }
}
