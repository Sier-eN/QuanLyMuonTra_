using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace quanlymuontra
{
    public partial class Form8 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    String kttk = "SELECT * FROM taikhoan Where email = '"
                        + email.Text.Trim() + "'";
                    using (SqlCommand kt = new SqlCommand(kttk, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(kt);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count >= 1)
                        {
                            MessageBox.Show(email.Text + " Tìm Thầy Email Hãy Nhập Mật Khẩu Mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtpass.Visible = true;
                            txtpass2.Visible = true;
                            doimatkhau.Visible = true;
                            hienmatkhau.Visible = true;
                            label2.Visible = true;
                            label5.Visible = true;

                        }
                        else
                        {
                            MessageBox.Show("Email Không Tồn Tại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void doimatkhau_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "" || txtpass2.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtpass.Text != txtpass2.Text)
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtpass.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải lớn hơn 6 ký tự", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    String kte = "SELECT * FROM taikhoan Where email = '" + email.Text.Trim() + "'";
                    using (SqlCommand kt = new SqlCommand(kte, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(kt);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count >= 1)
                        {
                            string capnhat = "UPDATE taikhoan SET matkhau = @matkhau WHERE email = @email";
                            using (SqlCommand cmd = new SqlCommand(capnhat, con))
                            {
                                cmd.Parameters.AddWithValue("email", email.Text.Trim());
                                cmd.Parameters.AddWithValue("matkhau", txtpass.Text.Trim());
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Form1 f = new Form1();
                                f.Show();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi: " + ex, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form8_Load_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            this.label3.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            this.label3.ForeColor = Color.White;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.button1.BackColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = ColorTranslator.FromHtml("34, 55, 113");
        }

        private void doimatkhau_MouseMove(object sender, MouseEventArgs e)
        {
            this.doimatkhau.BackColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void doimatkhau_MouseLeave(object sender, EventArgs e)
        {
            this.doimatkhau.BackColor = ColorTranslator.FromHtml("34, 55, 113");
        }

        private void hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (hienmatkhau.Checked)
            {
                txtpass.PasswordChar = '\0';
                txtpass2.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
                txtpass2.PasswordChar = '*';
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
