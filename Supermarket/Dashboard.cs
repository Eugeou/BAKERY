using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Dashboard : UserControl
    {
        private DBLogic model;
        public Dashboard()
        {
            InitializeComponent();
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLastWeek.Select();
            model = new DBLogic();
            LoadData();
        }
        private void LoadData()
        {

            var Refresh = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (Refresh == true)
            {
                // 3 first panel
                lbNumofOrder.Text = model.NumOrder.ToString();
                lbTotalRevenues.Text = "$" + model.TotalRevenue.ToString();
                lbTotalProfits.Text = "$" + model.TotalProfit.ToString();
                // 3 label at Total Counter
                lbNumCustomer.Text = model.NumCustomer.ToString();
                lbNumSupplier.Text = model.NumSupplier.ToString();
                lbProductQuantity.Text = model.NumProduct.ToString();
                //Area chart of Revenue
                chartTotalRevenue.DataSource = model.TotalRevenues;
                chartTotalRevenue.Series[0].XValueMember = "Date";
                chartTotalRevenue.Series[0].YValueMembers = "TotalAmount";
                chartTotalRevenue.DataBind();
                //Dounut chart of Top 5 best selling
                chartTop5.DataSource = model.TopProduct;
                chartTop5.Series[0].XValueMember = "Key";
                chartTop5.Series[1].YValueMembers = "Value";
                chartTop5.DataBind();
                //Datagridview of Stock
                dgvStock.DataSource = model.Stock;
                dgvStock.Columns[0].HeaderText = "Tên món";
                dgvStock.Columns[1].HeaderText = "Số lượng";
                Console.WriteLine("Loaded!!!");
            }
            else Console.WriteLine("Fail to load!!!");

        }
        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOk.Visible = false;
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOk.Visible = true;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLastWeek_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {

            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
