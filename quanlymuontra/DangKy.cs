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

namespace quanlymuontra
{
    public partial class Form7 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.button1.BackColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = ColorTranslator.FromHtml("34, 55, 113");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttk.Text == "" || txtemail.Text == "" || txtmk.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                        String kttk = "SELECT * FROM taikhoan Where taikhoan = '"
                            + txttk.Text.Trim() + "'";
                        using (SqlCommand kt = new SqlCommand(kttk, con))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(kt);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            if (dt.Rows.Count >= 1)
                            {
                                MessageBox.Show(txttk.Text + "Tên Đăng Nhập Đã tồn tại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string themDL = "INSERT INTO taikhoan (taikhoan, matkhau, email, quyen,date_create) " +
                                    "VALUES( @taikhoan,@matkhau,@email,'user',@date)";
                                DateTime date = DateTime.Today;
                                using (SqlCommand cmd = new SqlCommand(themDL, con))
                                {
                                    cmd.Parameters.AddWithValue("@taikhoan", txttk.Text.Trim());
                                    cmd.Parameters.AddWithValue("@matkhau", txtmk.Text.Trim());
                                    cmd.Parameters.AddWithValue("@email", txtemail.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Đăng ký thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                    Form1 m1 = new Form1();
                                    m1.Show();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối CSDL: " + ex, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { con.Close(); }
                }
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 m1 = new Form1();
            m1.Show();
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            this.label5.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            this.label5.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtmk.PasswordChar = '\0';
            }
            else
            {
                txtmk.PasswordChar = '*';
            }
        }

        private void txtmk_TextChanged(object sender, EventArgs e)
        {
            txtmk.PasswordChar = '*';
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
