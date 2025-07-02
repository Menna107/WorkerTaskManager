using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class AdminDashboard : Form
    {
        private Button[] buttons;

        public AdminDashboard()
        {
            InitializeComponent();
            this.Load += AdminDashboard_Load;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this); 
            ApplyCustomTheme();            
            StyleBackButton(btnBack);      

            string[] texts = {
                "Delete Client", "Delete Worker", "Show Table", "Update Specialty",
                "Show Report", "High Rated Workers", "Requests Count", "Wage Form",
                "Workers' Specialties", "Most/Least Tasks", "Match Workers", "Logout"
            };

            EventHandler[] handlers = {
                button1_Click, button2_Click, button4_Click, button5_Click,
                button8_Click, button7_Click, button6_Click, button3_Click,
                button10_Click, button9_Click, button12_Click, button11_Click
            };

            buttons = new Button[texts.Length];
            int startY = 120;
            int x = 50;
            int y = startY;

            for (int i = 0; i < buttons.Length; i++)
            {
                Button btn = new Button();
                btn.Text = texts[i];
                btn.Size = new Size(250, 40);
                btn.Location = new Point(x, y);
                btn.Click += handlers[i];
                StyleButton(btn); 
                panelMain.Controls.Add(btn);
                buttons[i] = btn;

                y += 50;
                if ((i + 1) % 4 == 0)
                {
                    y = startY;
                    x += 270;
                }
            }
        }

        private void ApplyCustomTheme()
        {
            bool isDark = ThemeManager.IsDarkMode;
            panelMain.BackColor = isDark ? Color.FromArgb(30, 30, 30) : Color.White;
            panelMain.ForeColor = isDark ? Color.White : Color.Black;
            lblTitle.ForeColor = isDark ? Color.White : Color.FromArgb(74, 20, 140);
        }

        private void StyleButton(Button btn)
        {
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.BackColor = Color.FromArgb(74, 20, 140);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(100, 40, 160);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(74, 20, 140);
        }

        private void StyleBackButton(Button btn)
        {
            btn.Text = "↩";
            btn.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            btn.BackColor = Color.FromArgb(74, 20, 140);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(100, 40, 160);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(74, 20, 140);

            MakeButtonRound(btn);
        }

        private void MakeButtonRound(Button btn)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUp().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form5().Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form7().Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form9().Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HighRatedWorkersForm().Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new noOfReq().Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WageForm().Show();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form8().Show();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form10().Show();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form11().Show();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.Show("Are you sure you want to exit?", "Exit Confirmation");
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void panelMain_Paint(object sender, PaintEventArgs e) { }
        private void lblTitle_Click(object sender, EventArgs e) { }

        private void lblTitle_Click_1(object sender, EventArgs e)
        {

        }
    }
}
