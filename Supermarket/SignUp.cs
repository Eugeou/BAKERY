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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Supermarket
{
    public partial class SignUp : Form
    {
        SQLConnection SQLConnection = new SQLConnection();
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            SQLConnection.OpenConnection();
            auto_id();
        }
        private bool CheckKey(string sql)
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, SQLConnection.con);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string sql_UserName = "SELECT EM_USERNAME FROM EMPLOYEE WHERE EM_EMAIL= '" + usn.Text + "'";
                string sql_Email = "SELECT EM_EMAIL FROM EMPLOYEE WHERE EM_EMAIL= '" + mail.Text + "'";
                string sql_Phone = "SELECT EM_PHONE FROM EMPLOYEE WHERE EM_PHONE= '" + phone.Text + "'";
                if (id.Text == "" || name.Text == "" || usn.Text == "" || pass.Text == "" || phone.Text == "" || mail.Text == "")
                {
                    MessageBox.Show("Thông tin đăng ký không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CheckKey(sql_UserName))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!this.mail.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("Email không đúng đỉnh dạng", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CheckKey(sql_Email) && CheckKey(sql_Phone))
                {
                    MessageBox.Show("Email và số điện thoại không đúng", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (CheckKey(sql_Email) || (!this.mail.Text.Contains('@') || !this.mail.Text.Contains('.')))
                {
                    MessageBox.Show("Email đã được đăng ký bởi tài khoản khác", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CheckKey(sql_Phone) || phone.Text.Length < 10)
                {
                    MessageBox.Show("Số điện thoại không đúng", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string e_position;
                    if (position.Text == "Nhân Viên")
                    {
                        e_position = "NV";
                    }
                    else
                    {
                        e_position = "QTV";
                    }
                    // string query = "INSERT INTO EMPLOYEE(EM_ID, EM_NAME, EM_USERNAME, EM_PASSWORD, EM_PHONE, EM_EMAIL) VALUES(@EM_ID, @EM_NAME, @EM_USERNAME, @EM_PASSWORD, @EM_PHONE, @EM_EMAIL)";
                    SqlCommand sqlCommand = new SqlCommand("InsertEM", SQLConnection.con);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@EM_ID", id.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_Name", name.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_USERNAME", usn.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_PASSWORD", pass.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_PHONE", phone.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_EMAIL", mail.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_POSITION", e_position);
                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Đã đăng ký tài khoản thành công");
                        auto_id();
                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void auto_id()
        {
            SqlCommand sqlCommand = new SqlCommand("AUTOEMID", SQLConnection.con);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            object obj = sqlCommand.ExecuteScalar();
            this.id.Text = obj.ToString();
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void clear()
        {
            name.Clear();
            usn.Clear();
            phone.Clear();
            pass.Clear();
            mail.Clear();
        }
    }
}
