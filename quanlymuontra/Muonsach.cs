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

namespace quanlymuontra
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
            dpsach();
            dpsachm();
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }
        private void button1_MouseMove_1(object sender, MouseEventArgs e)
        {
            this.button1.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.White;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tensach.Text = row.Cells[1].Value.ToString();
                trangthai.Text=row.Cells[2].Value.ToString();
            }
        }
        public void dpsach()
        {
            DLSach dls = new DLSach();
            List<DLSach> bangdl = dls.dLSach();
            dataGridView1.DataSource = bangdl;
        }
        public void dpsachm()
        {
            DLsachmuon dlm = new DLsachmuon();
            List<DLsachmuon> dl = dlm.dLSachmuon();
            dataGridView2.DataSource = dl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tensach.Text == "" || email.Text == "" || hantra.Value == null)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (trangthai.Text == "Không Thể Mượn")
            {
                MessageBox.Show("Sách hiện tại không thể mượn", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                
                if (con.State == ConnectionState.Closed)
                {
                    try
                    {
                        DateTime today = DateTime.Now;
                        con.Open();
                        string themDL = "INSERT into dksach(tensach,trangthai,iduser,email,ngaymuon,hantra) " +
                        "VALUES(@tensach,@trangthai,@iduser,@email,@ngaymuon,@hantra)";

                        using (SqlCommand cmd = new SqlCommand(themDL, con))
                        {
                            trangthai.Text = "Chưa Trả";
                            cmd.Parameters.AddWithValue("@tensach", tensach.Text.Trim());
                            cmd.Parameters.AddWithValue("trangthai", trangthai.Text.Trim());
                            cmd.Parameters.AddWithValue("iduser", iduser.Text.Trim());
                            cmd.Parameters.AddWithValue("email", email.Text.Trim());
                            cmd.Parameters.AddWithValue("@ngaymuon", today.ToString());
                            cmd.Parameters.AddWithValue("@hantra", hantra.Value);
                            
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Mượn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dpsachm();
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
