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
    public partial class FrmCategory : Form
    {
        SQLConnection SQLConnection = new SQLConnection();
        public FrmCategory()
        {
            InitializeComponent();
        }
        private void auto_id()
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand("AUTOCATEID", SQLConnection.con);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            object obj = sqlCommand.ExecuteScalar();
            this.id.Text = obj.ToString();
            SQLConnection.CloseConnection();
        }
        private void clear()
        {
            id.Clear();
            name.Clear();
            description.Clear();
        }
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (id.Text == "" || name.Text == "")
                {
                    MessageBox.Show("Thông tin không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLConnection = new SQLConnection();
                    SQLConnection.OpenConnection();
                    // string query = "INSERT INTO RAW_MATERIAL(RAW_ID, RAW_NAME, RAW_PROVIDER, RAW_QUANTITY, RAW_UNIT , RAW_PRICE, RAW_TOTAL) VALUES(@RAW_ID, @RAW_NAME, @RAW_PROVIDER, @RAW_QUANTITY, @RAW_UNIT , @RAW_PRICE, @RAW_TOTAL)";
                    SqlCommand sqlCommand = new SqlCommand("InsertCate", SQLConnection.con);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@CAT_ID", id.Text);
                    sqlCommand.Parameters.AddWithValue("@CAT_NAME", name.Text);
                    sqlCommand.Parameters.AddWithValue("@CAT_DESCRIPTION", description.Text);
                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Đã thêm nguyên liệu thành công");
                        clear();
                        auto_id();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    SQLConnection.CloseConnection();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (id.Text == "" || name.Text == "" )
                {
                    MessageBox.Show("Thông tin không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLConnection = new SQLConnection();
                    SQLConnection.OpenConnection();
                    String str = "Delete From CATEGORY Where CAT_ID = '" + id.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, SQLConnection.con);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã xóa thông tin thành công");
                        clear();
                        auto_id();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    SQLConnection.CloseConnection();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (id.Text == "" || name.Text == "" )
                {
                    MessageBox.Show("Thông tin không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLConnection = new SQLConnection();
                    SQLConnection.OpenConnection();
                    String str = "Update CATEGORY Set CAT_NAME = N'" + name.Text + "',CAT_DESCRIPTION = N'" + description.Text + "' Where CAT_ID = '" + id.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, SQLConnection.con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã thay đổi thông tin thành công");
                        clear();
                        auto_id();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    SQLConnection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void search_id_Click(object sender, EventArgs e)
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            try
            {
                String str = "Select CAT_ID, CAT_NAME, CAT_DESCRIPTION From CATEGORY Where CAT_ID = '" + id.Text + "'";

                SqlCommand cmd = new SqlCommand(str, SQLConnection.con);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id.Text = dr.GetValue(0).ToString();
                    name.Text = dr.GetValue(1).ToString();
                    description.Text = dr.GetValue(2).ToString();
                }
                else
                {
                    MessageBox.Show("Nguyên liệu không tồn tại", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message); 
                } 
            finally
            {
                SQLConnection.CloseConnection();
            }           
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            auto_id();
        }
    }
}
