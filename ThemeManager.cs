using System.Drawing;
using System.Windows.Forms;

namespace DB_Testing
{
    public static class ThemeManager
    {
        public static bool IsDarkMode { get; set; } = false;

        public static void ApplyTheme(Form form)
        {
            Color backColor = IsDarkMode ? Color.FromArgb(30, 30, 30) : Color.FromArgb(240, 240, 255);
            Color foreColor = IsDarkMode ? Color.White : Color.Black;
            Color panelColor = IsDarkMode ? Color.FromArgb(40, 40, 40) : Color.White;

            form.BackColor = backColor;

            foreach (Control ctrl in form.Controls)
            {
                ApplyThemeToControl(ctrl, backColor, foreColor, panelColor);
            }
        }

        private static void ApplyThemeToControl(Control control, Color backColor, Color foreColor, Color panelColor)
        {
            if (control is Panel)
                control.BackColor = panelColor;
            else if (control is Label lbl)
            {
                if (lbl.Name == "lblTitle")
                    lbl.ForeColor = IsDarkMode ? Color.White : Color.MediumPurple;
                else
                    lbl.ForeColor = foreColor;
            }
            else if (control is Button btn)
            {
                btn.BackColor = Color.FromArgb(74, 20, 140); 
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }

            foreach (Control child in control.Controls)
            {
                ApplyThemeToControl(child, backColor, foreColor, panelColor);
            }
        }
    }
}
