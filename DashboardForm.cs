using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Testing
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
        private string role;
        private string userId;

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            //wrong
        }
        public DashboardForm(string userRole, string id)
        {
            InitializeComponent();
            role = userRole;
            userId = id;

            this.Text = $"{role} Dashboard";
            label1.Text = $"Welcome, {role} #{userId}";
        }
    }
}
