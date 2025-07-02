using System;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            ApplyTheme();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplyTheme(); 
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = radioDark.Checked;
            this.Hide();
            new SignUp().Show();
        }

        private void ThemeChanged(object sender, EventArgs e)
        {
            ThemeManager.IsDarkMode = radioDark.Checked;
            ApplyTheme(); 
        }

        private void ApplyTheme()
        {
            bool isDark = ThemeManager.IsDarkMode;

            this.BackColor = isDark ? Color.FromArgb(30, 30, 30) : Color.FromArgb(240, 240, 255);
            panelMain.BackColor = isDark ? Color.FromArgb(40, 40, 40) : Color.White;

            lblExplanation.ForeColor = isDark ? Color.White : Color.Black;
            lblDescription.ForeColor = isDark ? Color.Silver : Color.Black;

            radioLight.ForeColor = isDark ? Color.White : Color.Black;
            lblTitle.ForeColor = isDark ? Color.White : Color.FromArgb(74, 20, 140);
            radioDark.ForeColor = isDark ? Color.White : Color.Black;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click_1(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
