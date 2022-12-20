using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            control_panel.Top = dashboard.Top;
            control_panel.Height = dashboard.Height;           
        }

        private void product_Click(object sender, EventArgs e)
        {
            control_panel.Top = product.Top;
            control_panel.Height = product.Height;
            products1.showdata();
            products1.BringToFront();
        }

        private void product_type_Click(object sender, EventArgs e)
        {
            control_panel.Top = product_type.Top;
            control_panel.Height = product_type.Height;
            categories1.showdata();
            categories1.BringToFront();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            control_panel.Top = employee.Top;
            control_panel.Height = employee.Height;
            sellers1.showdata();
            sellers1.BringToFront();
        }

        private void bill_Click(object sender, EventArgs e)
        {
            control_panel.Top = bill.Top;
            control_panel.Height = bill.Height;
            bill1.showdata();
            bill1.BringToFront();
        }

        private void raw_Click(object sender, EventArgs e)
        {
            control_panel.Top = raw.Top;
            control_panel.Height = raw.Height;
            raw_Material2.showdata();
            raw_Material2.BringToFront();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void raw_Material1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void supplier_Click(object sender, EventArgs e)
        {
            control_panel.Top = supplier.Top;
            control_panel.Height = supplier.Height;
            supplier1.showdata();
            supplier1.BringToFront();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            control_panel.Top = customer.Top;
            control_panel.Height = customer.Height;
            customers1.showdata();
            customers1.BringToFront();
        }
    }
}
