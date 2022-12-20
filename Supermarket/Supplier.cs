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
    public partial class Supplier : UserControl
    {
        SQLConnection SQLConnection = new SQLConnection();
        public Supplier()
        {
            InitializeComponent();
        }
        public void showdata()
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            String str = "SELECT * FROM SUPPLIER";
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
                else if (comboBox1.Text.Length == 4)
                {
                    (dataGridView.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("S_Name like '%" + id_name.Text + "%'");
                }
                else
                {
                    (dataGridView.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("S_ID like '%" + id_name.Text + "%'");
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
            FrmSuppiler frmSuppiler = new FrmSuppiler();
            frmSuppiler.ShowDialog();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            id_name.Clear();
            showdata();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            showdata();
        }
    }
}
