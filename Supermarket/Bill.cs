using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.Usercontrol
{
    public partial class Bill : UserControl
    {
        SQLConnection SQLConnection = new SQLConnection();
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            showdata();
        }
        public void showdata()
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            String str = "SELECT B_ID, B_DATE, CUSTOMER.CUS_NAME, EMPLOYEE.EM_NAME, B_PRICE FROM BILL JOIN CUSTOMER ON BILL.CUS_ID = CUSTOMER.CUS_ID JOIN EMPLOYEE ON BILL.EM_ID = EMPLOYEE.EM_ID";
            SqlCommand sqlCommand = new SqlCommand(str, SQLConnection.con);
            sqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            dataGridView.DataSource = dt;
            SQLConnection.CloseConnection();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            try
            {
                if (comboBox1.Text == "" || id_name.Text == "")
                {
                    MessageBox.Show("Thông tin không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (comboBox1.Text == "Tên")
                {
                    (dataGridView.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("CUS_ID like '%" + id_name.Text + "%'");
                }
                else
                {
                    (dataGridView.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("B_ID like '%" + id_name.Text + "%'");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConnection.CloseConnection();
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn muốn thêm hóa đơn ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reload_Click(object sender, EventArgs e)
        {
            id_name.Clear();
            showdata();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView.Rows[e.RowIndex];
                string id = Convert.ToString(row.Cells[0].Value);
                FrmBillInfo frm = new FrmBillInfo();
                frm.b_ID(id);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
