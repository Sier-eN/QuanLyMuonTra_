using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlymuontra
{
    public partial class duyetmuontra : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");
        private int masach = 0;
        public duyetmuontra()
        {
            InitializeComponent();
            dpduyet();
        }
        public void clearFields()
        {
            tensach.Text = "";
            email.Text = "";
            trangthai.Text = "";
            ngaymuon.Text = "";
            nguoimuon.Text = "";
            masach = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tensach.Text == ""
               || email.Text == ""
               || ngaymuon.Value == null
               || trangthai.Text == ""
               || nguoimuon.Text == ""
               )
            {
                MessageBox.Show("Hãy chọn sách muốn duyệt!!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (trangthai.Text == "Chờ Duyệt Mượn")
            {
                MessageBox.Show("Chức Năng Chỉ Duyệt Trả!!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Bạn Muốn Duyệt Trả Sách "
                        + masach + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            con.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE dksach SET trangthai = N'Đã Trả'  WHERE masach = @masach";

                            using (SqlCommand cmd = new SqlCommand(updateData, con))
                            {

                                cmd.Parameters.AddWithValue("@masach", masach);


                                cmd.ExecuteNonQuery();

                                dpduyet();

                                MessageBox.Show("Cập Nhật Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
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
                    else
                    {
                        MessageBox.Show("Tạm dừng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }

        }
        public void dpduyet()
        {
            DLduyet dl = new DLduyet();
            List<DLduyet> dt = dl.dluyet();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tensach.Text == ""
               || email.Text == ""
               || ngaymuon.Value == null
               || trangthai.Text == ""
               || nguoimuon.Text == ""
               )
            {
                MessageBox.Show("Hãy chọn sách muốn duyệt!!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (trangthai.Text == "Chờ Duyệt Trả")
            {
                MessageBox.Show("Chức Năng Chỉ Duyệt Mượn!!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Bạn Muốn Duyệt Mượn Sách "
                        + masach + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            con.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE dksach SET trangthai = N'Chưa Trả'  WHERE masach = @masach";

                            using (SqlCommand cmd = new SqlCommand(updateData, con))
                            {


                                cmd.Parameters.AddWithValue("@masach", masach);

                                cmd.ExecuteNonQuery();

                                dpduyet();

                                MessageBox.Show("Cập Nhật Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
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
                    else
                    {
                        MessageBox.Show("Tạm dừng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                masach = (int)row.Cells[0].Value;
                nguoimuon.Text = row.Cells[1].Value.ToString();
                email.Text = row.Cells[2].Value.ToString();
                tensach.Text = row.Cells[3].Value.ToString();
                trangthai.Text = row.Cells[4].Value.ToString();
                ngaymuon.Text = row.Cells[5].Value.ToString();
                row.Cells[7].Value.ToString();
            }
        }

        private void duyetmuontra_Load(object sender, EventArgs e)
        {
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.button1.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.White;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            this.button3.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.ForeColor = Color.White;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            this.button2.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.ForeColor = Color.White;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            this.button4.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            this.button4.ForeColor = Color.White;
        }
    }
}
