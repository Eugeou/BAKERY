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
    public partial class Raw_Material : UserControl
    {
        SQLConnection SQLConnection = new SQLConnection();
        public Raw_Material()
        {
            InitializeComponent();
        }

        private void Raw_Material_Load(object sender, EventArgs e)
        {
            showdata();
        }
        public void showdata()
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            String str = "SELECT RAW_ID, RAW_DATE, SUPPLIER.S_NAME, RAW_QUANTITY, RAW_TOTAL FROM RAW_MATERIAL JOIN SUPPLIER ON RAW_MATERIAL.RAW_PROVIDER = SUPPLIER.S_ID";
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
            FrmRaw raw = new FrmRaw();
            raw.ShowDialog();
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
                    String.Format("RAW_PROVIDER like '%" + id_name.Text + "%'");
                }
                else
                {
                    (dataGridView.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("RAW_ID like '%" + id_name.Text + "%'");
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

        private void reload_Click(object sender, EventArgs e)
        {
            id_name.Clear();
            showdata();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            try
            {
                if (id_name.Text == "")
                {
                    MessageBox.Show("Thông tin không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String strR = "Delete From RAW_MATERIAL Where RAW_ID = '" + id_name.Text + "'";
                    SqlCommand cmdR = new SqlCommand(strR, SQLConnection.con);
                    String strRI = "Delete From RAWINFO Where RAW_ID = '" + id_name.Text + "'";
                    SqlCommand cmdRI = new SqlCommand(strR, SQLConnection.con);
                    try
                    {
                        cmdR.ExecuteNonQuery();
                        cmdRI.ExecuteNonQuery();
                        MessageBox.Show("Đã xóa thông tin thành công");
                        showdata();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView.Rows[e.RowIndex];
                string id = Convert.ToString(row.Cells[0].Value);
                FrmRawInfo frmRawInfo = new FrmRawInfo();
                frmRawInfo.r_ID(id);
                frmRawInfo.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
