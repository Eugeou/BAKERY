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

namespace Supermarket
{
    public partial class Products : UserControl
    {
        SQLConnection SQLConnection = new SQLConnection();
        public Products()
        {
            InitializeComponent();
        }

        public void showdata()
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            String str = "Select PRO_ID, PRO_NAME, PRO_QUANTITY, PRO_PRICE, PRO_DESCRIPTION, CATEGORY.CAT_NAME FROM PRODUCT JOIN CATEGORY ON PRODUCT.CAT_ID = CATEGORY.CAT_ID";
            SqlCommand sqlCommand = new SqlCommand(str, SQLConnection.con);
            sqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            dataGridView.DataSource = dt;
            SQLConnection.CloseConnection();
        }
        private void Products_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            id_name.Clear();
            showdata();
        }

        private void change_Click(object sender, EventArgs e)
        {
            FrmProduct frmProduct = new FrmProduct();
            frmProduct.ShowDialog();
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
                else if (comboBox1.Text.Length == 4)
                {
                    (dataGridView.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("CAT_NAME like '%" + id_name.Text + "%'");
                }
                else
                {
                    (dataGridView.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("PRO_ID like '%" + id_name.Text + "%'");
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
    }
}
