using System;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class CustomMessageBox : Form
    {
        public static DialogResult Show(string message, string title)
        {
            using (var msgBox = new CustomMessageBox())
            {
                msgBox.lblTitle.Text = title;
                msgBox.lblMessage.Text = message;
                return msgBox.ShowDialog();
            }
        }

        public CustomMessageBox()
        {
            InitializeComponent();  
            ApplyTheme();     
        }

        private void ApplyTheme()
        {
            bool isDark = ThemeManager.IsDarkMode;

            this.BackColor = isDark ? Color.FromArgb(30, 30, 30) : Color.White;
            lblTitle.ForeColor = Color.FromArgb(74, 20, 140); ;
            lblMessage.ForeColor = isDark ? Color.Gainsboro : Color.Black;

            btnYes.BackColor = btnNo.BackColor = Color.FromArgb(74, 20, 140);
            btnYes.ForeColor = btnNo.ForeColor = Color.White;
            btnYes.FlatAppearance.BorderSize = btnNo.FlatAppearance.BorderSize = 0;
            btnYes.Cursor = btnNo.Cursor = Cursors.Hand;

            btnYes.MouseEnter += (s, e) => btnYes.BackColor = Color.FromArgb(100, 40, 160);
            btnYes.MouseLeave += (s, e) => btnYes.BackColor = Color.FromArgb(74, 20, 140);

            btnNo.MouseEnter += (s, e) => btnNo.BackColor = Color.FromArgb(100, 40, 160);
            btnNo.MouseLeave += (s, e) => btnNo.BackColor = Color.FromArgb(74, 20, 140);
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        public static void ShowInfo(string message, string title = "Message")
        {
            using (var msgBox = new CustomMessageBox())
            {
                msgBox.lblTitle.Text = title;
                msgBox.lblMessage.Text = message;

                msgBox.btnNo.Visible = false;
                msgBox.btnYes.Text = "OK";

                msgBox.btnYes.Location = new Point(
                    (msgBox.ClientSize.Width - msgBox.btnYes.Width) / 2,
                    msgBox.btnYes.Location.Y
                );

                msgBox.ShowDialog();
            }
        }


    }
}
