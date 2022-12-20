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
    public partial class Sellers : UserControl
    {
        SQLConnection SQLConnection = new SQLConnection();
        public Sellers()
        {
            InitializeComponent();
        }

        private void Sellers_Load(object sender, EventArgs e)
        {
            showdata();
        }
        public void showdata()
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            String str = "SELECT * FROM EMPLOYEE";
            SqlCommand sqlCommand = new SqlCommand(str, SQLConnection.con);
            sqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            dataGridView.DataSource = dt;
            SQLConnection.CloseConnection();
        }

        private void change_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            seller.ShowDialog();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            id_name.Clear();
            showdata();
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
                    String.Format("EM_Name like '%" + id_name.Text + "%'");
                }
                else
                {
                    (dataGridView.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("EM_ID like '%" + id_name.Text + "%'");
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
