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
    public partial class FrmRaw : Form
    {
        SQLConnection conn = new SQLConnection();
        int Quantity = 1;
        int grandTotal = 0;
        public FrmRaw()
        {
            InitializeComponent();
        }
        private void GetSupplier()
        {
            conn = new SQLConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select S_ID, S_NAME FROM SUPPLIER";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                provider.Items.Add(dr["S_ID"].ToString() + " | " + dr["S_NAME"].ToString());
            }
            conn.CloseConnection();
        }
        private void auto_id()
        {
            conn = new SQLConnection();
            conn.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand("AUTORAWID", conn.con);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            object obj = sqlCommand.ExecuteScalar();
            this.id.Text = obj.ToString();
            conn.CloseConnection();
        }

        private void clear()
        {
            name.Clear();
            quantity.Clear();
            price.Clear();
        }
        private bool CheckKey(string sql)
        {
            conn = new SQLConnection();
            conn.OpenConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn.con);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Raw_Load(object sender, EventArgs e)
        {
            auto_id();
            GetSupplier();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {

                if (id.Text == "" || name.Text == "" || provider.Text == ""|| quantity.Text == ""|| price.Text == "")
                {
                    MessageBox.Show("Chưa nhập đầy đủ thông tin", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                int total = Convert.ToInt32(price.Text) * Convert.ToInt32(quantity.Text);
                grandTotal += total;
                DateTime dateTime = DateTime.Now;
                // Kiểm tra mã phiếu hàng đã tồn tại trong csdl chưa.
                string checkRAW = "SELECT RAW_ID FROM RAW_MATERIAL WHERE RAW_ID= '" + id.Text + "'";
                if (!CheckKey(checkRAW))
                {                    
                    // string query = "INSERT INTO RAW_MATERIAL(RAW_ID, RAW_DATE, RAW_PROVIDER, RAW_QUANTITY, RAW_TOTAL) VALUES(@RAW_ID, @RAW_DATE, @RAW_PROVIDER, @RAW_QUANTITY, @RAW_TOTAL)";
                    SqlCommand sqlCommand = new SqlCommand("InsertRaw", conn.con);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@RAW_ID", id.Text);
                    sqlCommand.Parameters.AddWithValue("@RAW_DATE", dateTime);
                    sqlCommand.Parameters.AddWithValue("@RAW_PROVIDER", provider.Text.Substring(0,7));
                    sqlCommand.Parameters.AddWithValue("@RAW_QUANTITY", Quantity);
                    sqlCommand.Parameters.AddWithValue("@RAW_TOTAL", grandTotal);
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    string update_gt = "UPDATE RAW_MATERIAL SET RAW_TOTAL ='" + grandTotal + "' WHERE RAW_ID = '" + id.Text + "'";
                    SqlCommand sqlCommand_gt = new SqlCommand(update_gt, conn.con);
                    string update_q = "UPDATE RAW_MATERIAL SET RAW_QUANTITY ='" + Quantity + "' WHERE RAW_ID = '" + id.Text + "'";
                    SqlCommand sqlCommand_q = new SqlCommand(update_q, conn.con);
                    sqlCommand_gt.ExecuteNonQuery();
                    sqlCommand_q.ExecuteNonQuery();
                }

                string sql = "INSERT INTO RAWINFO(RI_ID,RAW_ID,RI_NAME,RI_QUANTITY,RI_PRICE,RI_TOTAL)VALUES (";
                sql += "N'" + Quantity + "','" + id.Text + "',N'" + name.Text + "','" + quantity.Text + "','" + price.Text + "','" + total + "')";
                SqlCommand sqlCommandRI = new SqlCommand(sql, conn.con);
                sqlCommandRI.ExecuteNonQuery();
                MessageBox.Show("Bạn đã thêm nguyên liệu thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();

                ++Quantity;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string checkRAW = "SELECT RAW_ID FROM RAW_MATERIAL WHERE RAW_ID= '" + id.Text + "'";
                if (CheckKey(checkRAW))
                {
                    clear();
                    auto_id();
                    Quantity = 1;
                    MessageBox.Show("Bạn đã thêm phiếu hàng thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Chưa nhập nguyên liệu nào", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
