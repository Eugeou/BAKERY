using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Supermarket
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void dashboard3_Click(object sender, EventArgs e)
        {
            control_panel.Width = dashboard.Width;
            control_panel.Height = dashboard.Height;
            
        }

        private void product_Click(object sender, EventArgs e)
        {
            control_panel.Width = product.Width;
            control_panel.Height = product.Height;
        }

        private void product_type_Click(object sender, EventArgs e)
        {
            control_panel.Width = product_type.Width;
            control_panel.Height = product_type.Height;
        }

        private void employee_Click(object sender, EventArgs e)
        {
            control_panel.Width = employee.Width;
            control_panel.Height = employee.Height;
        }

        private void bill_Click(object sender, EventArgs e)
        {
            control_panel.Width = bill.Width;
            control_panel.Height = bill.Height;
        }

        private void raw_Click(object sender, EventArgs e)
        {
            control_panel.Width = raw.Width;
            control_panel.Height = raw.Height;
        }

        private void setting_Click(object sender, EventArgs e)
        {
            
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        

        private void dashboard3_Load(object sender, EventArgs e)
        {
            control_panel.Width = dashboard.Width;
            control_panel.Height = dashboard.Height;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
