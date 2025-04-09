using static System.Net.Mime.MediaTypeNames;
using System.Data;
using System.Data.SqlClient;
using System;

namespace quanlymuontra
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 m8 = new Form8();
            m8.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '*';
        }

        public string taikhoan = "";
        public string loaitk;

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttk.Text))
            {
                MessageBox.Show("Nhập Tài Khoàn!!");
                txttk.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("Nhập Mật Khẩu!!");
                txtpass.Select();
                return;
            }
            taikhoan=txttk.Text;
            loaitk = "";
            if (taikhoan.Equals("admin"))
            {
                loaitk = "admin";
            }
            else if (taikhoan.Equals("user"))
            {
                loaitk="user";
            }
            if(con.State== ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM taikhoan WHERE taikhoan = @taikhoan AND matkhau = @matkhau", con);
            cmd.Parameters.AddWithValue("@taikhoan", txttk.Text);
            cmd.Parameters.AddWithValue("@matkhau", txtpass.Text);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            var rs = dt;
            if(rs.Rows.Count > 0)
            {
                MessageBox.Show("Đăng Nhập Thành Công");
                giaodienchinh gdc = new giaodienchinh();
                gdc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai TÀI KHOẢN hoặc MẬT KHẨU"); 
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.button1.BackColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = ColorTranslator.FromHtml("34, 55, 113");
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            this.button2.BackColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackColor = ColorTranslator.FromHtml("34, 55, 113");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 m7 = new Form7();
            m7.Show();
            this.Hide();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            this.label3.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            this.label3.ForeColor = Color.White;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }
    }
}
