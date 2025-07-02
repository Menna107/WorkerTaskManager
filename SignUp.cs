using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);

            ApplyTheme();
            ApplyStyles();
        }

        private void ApplyTheme()
        {
            bool isDarkMode = ThemeManager.IsDarkMode;
            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                lblTitle.ForeColor = Color.White;
                lblSignUpAs.ForeColor = Color.White;
                lblHaveAccount.ForeColor = Color.White;
                mainPanel.BackColor = Color.FromArgb(40, 40, 40);
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 240, 255);
                lblTitle.ForeColor = Color.FromArgb(60, 20, 100);
                lblSignUpAs.ForeColor = Color.Black;
                lblHaveAccount.ForeColor = Color.Black;
                mainPanel.BackColor = Color.White;
            }
        }

        private void ApplyStyles()
        {
            StyleButton(btnClient, "👤");
            StyleButton(btnWorker, "👷‍♂️");
            StyleButton(btnAdmin, "🛠");
            StyleButton(btnLogin, "🔑");

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.BackColor = Color.FromArgb(74, 20, 140);
            btnBack.ForeColor = Color.White;
        }

        private void StyleButton(Button btn, string icon)
        {
            btn.Text = $"{icon} {btn.Text}";
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(74, 20, 140);
            btn.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientRegister clientForm = new ClientRegister();
            clientForm.FormClosed += (s, args) => this.Show();
            clientForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkerRegister workerForm = new WorkerRegister();
            workerForm.FormClosed += (s, args) => this.Show();
            workerForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminForm = new AdminDashboard();
            adminForm.FormClosed += (s, args) => this.Show();
            adminForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WelcomeForm().Show();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetButtonRound(btnBack);
        }

        private void SetButtonRound(Button btn)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }
    }
}
