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
using System.IO;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace quanlymuontra
{
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");
        SqlDataReader docdl;
        private int masach = 0;
        public Form5()
        {
            InitializeComponent();
            dpsach();
            load_tentacgia();
            load_tentheloai();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.button1.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tensach.Text == ""
            || themtl.Text == ""
            || tg.Text == ""
            || nxb.Value == null
            || trangthai.Text == "")
            {
                MessageBox.Show("Hãy chọn sách trước", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Bạn có muốn XÓA dữ liệu:"
                        + masach + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            con.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE sach SET ngayxoa = @ngayxoa WHERE masach = @masach";

                            using (SqlCommand cmd = new SqlCommand(updateData, con))
                            {
                                cmd.Parameters.AddWithValue("@ngayxoa", today);
                                cmd.Parameters.AddWithValue("@masach", masach);

                                cmd.ExecuteNonQuery();

                                dpsach();

                                MessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            this.button2.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.ForeColor = Color.White;
        }
        public void load_tentacgia()
        {
            string tacgia = "select tentg from tacgia";
            SqlDataAdapter ad = new SqlDataAdapter(tacgia,con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            tg.DataSource = dt;
            tg.DisplayMember = "tentg";
            tg.ValueMember = "tentg";
        }
        public void load_tentheloai()
        {
            string tl = "select tentl from theloai";
            SqlDataAdapter ad = new SqlDataAdapter(tl, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            themtl.DataSource = dt;
            themtl.DisplayMember = "tentl";
            themtl.ValueMember = "tentl";
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.CellClick += dataGridView1_CellContentClick;

        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            this.button3.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (tensach.Text == "" || tg.Text == "" || themtl.Text == "" || trangthai.Text == "" || nxb.Value == null)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                {
                    try
                    {
                        DateTime today = DateTime.Now;
                        con.Open();
                        string themDL = "INSERT into sach(tensach,tacgia,theloai,ngayxuatban,trangthai,ngaythem) " +
                        "VALUES(@tensach,@tacgia,@theloai,@ngayxuatban,@trangthai,@ngaythem)";

                        using (SqlCommand cmd = new SqlCommand(themDL, con))
                        {
                            cmd.Parameters.AddWithValue("@tensach", tensach.Text.Trim());
                            cmd.Parameters.AddWithValue("@tacgia", tg.Text.Trim());
                            cmd.Parameters.AddWithValue("@theloai", themtl.Text.Trim());
                            cmd.Parameters.AddWithValue("@ngayxuatban", nxb.Value);
                            cmd.Parameters.AddWithValue("@trangthai", trangthai.Text.Trim());
                            cmd.Parameters.AddWithValue("@ngaythem", today.ToString());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dpsach();
                            clearFields();
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


        public void dpsach()
        {
            DLThemSach dts = new DLThemSach();
            List<DLThemSach> bangdl = dts.dLThemSach();
            dataGridView1.DataSource = bangdl;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                masach = (int)row.Cells[0].Value;
                tensach.Text = row.Cells[1].Value.ToString();
                tg.Text = row.Cells[2].Value.ToString();
                themtl.Text = row.Cells[3].Value.ToString();
                nxb.Text = row.Cells[4].Value.ToString();
                trangthai.Text = row.Cells[5].Value.ToString();
            }

        }

        public void clearFields()
        {
            tensach.Text = "";
            tg.Text = "";
            themtl.Text = "";
            trangthai.SelectedIndex = -1;
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (tensach.Text == ""
               || tg.Text == ""
               || themtl.Text == ""
               || nxb.Value == null
               || trangthai.Text == "")
            {
                MessageBox.Show("Hãy chọn sách trước.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Bạn có thực sự muốn thay đổi dữ liệu:"
                        + masach + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            con.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE sach SET tensach =@tensach" + ", tacgia = @tacgia " + ", theloai= @theloai" +",ngaysua = @ngaysua"+
                                ", trangthai = @trangthai WHERE masach = @masach";

                            using (SqlCommand cmd = new SqlCommand(updateData, con))
                            {
                                cmd.Parameters.AddWithValue("@tensach", tensach.Text.Trim());
                                cmd.Parameters.AddWithValue("@tacgia", tg.Text.Trim());
                                cmd.Parameters.AddWithValue("@theloai", themtl.Text.Trim());
                                cmd.Parameters.AddWithValue("@ngayxuatban", nxb.Value);
                                cmd.Parameters.AddWithValue("@trangthai", trangthai.Text.Trim());
                                cmd.Parameters.AddWithValue("@ngaysua", today);
                                cmd.Parameters.AddWithValue("@masach", masach);

                                cmd.ExecuteNonQuery();

                                dpsach();

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

        private void button4_Click_1(object sender, EventArgs e)
        {
            clearFields();
        }

        private void tg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
