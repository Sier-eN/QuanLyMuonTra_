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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace quanlymuontra
{
    public partial class qlnd : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");
        private int id = 0;
        public qlnd()
        {
            InitializeComponent();
            dlu();
        }

        private void qlnd_Load(object sender, EventArgs e)
        {
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }
        public void clearFields()
        {
            taikhoan.Text = "";
            matkhau.Text = "";
            txtemail.Text = "";
            quyen.Text = "";
            id = 0;
        }
        public void dlu()
        {
            user dl = new user();
            List<user> dt = dl.dluser();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (taikhoan.Text == ""
               || txtemail.Text == ""
               || matkhau.Text == ""
               || quyen.Text == ""
               )
            {
                MessageBox.Show("Hãy Chọn Người Dùng!!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (quyen.Text == "admin")
            {
                MessageBox.Show("Người Dùng Đã Là ADMIN!!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Bạn Muốn Cấp Quyền Cho Người Dùng:"
                        + id + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            con.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE taikhoan SET quyen = N'admin' WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, con))
                            {

                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();

                                dlu();

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
                id = (int)row.Cells[0].Value;
                taikhoan.Text = row.Cells[1].Value.ToString();
                matkhau.Text = row.Cells[2].Value.ToString();
                txtemail.Text = row.Cells[3].Value.ToString();
                quyen.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (taikhoan.Text == ""
               || txtemail.Text == ""
               || matkhau.Text == ""
               || quyen.Text == ""
               )
            {
                MessageBox.Show("Hãy Chọn Người Dùng!!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (quyen.Text == "user")
            {
                MessageBox.Show("Người Dùng Đã Là USER!!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Bạn Muốn Cấp Quyền Cho Người Dùng:"
                        + id + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            con.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE taikhoan SET quyen = N'user' WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, con))
                            {

                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();

                                dlu();

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

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.button1.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.White;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            this.button2.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.ForeColor = Color.White;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            this.button3.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.ForeColor = Color.White;
        }
    }
}
