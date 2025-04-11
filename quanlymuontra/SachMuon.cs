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

    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");
        private int masach = 0;
        public Form3()
        {
            InitializeComponent();
            dpsachm();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }
        public void dpsachm()
        {
            DLmuon dl = new DLmuon();
            List<DLmuon> dt = dl.dlmuon();
            dataGridView1.DataSource = dt;
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
                hantra.Text = row.Cells[7].Value.ToString();
            }
        }
        public void clearFields()
        {
            tensach.Text = "";
            email.Text = "";
            trangthai.Text = "";
            ngaymuon.Text = "";
            hantra.Text = "";
            nguoimuon.Text = "";
            masach = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tensach.Text == ""
               || email.Text == ""
               || ngaymuon.Value == null
               || trangthai.Text == ""
               || hantra.Value == null
               || nguoimuon.Text == ""
               )
            {
                MessageBox.Show("Hãy chọn sách muốn trả!!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            } else if(trangthai.Text == "Đã Trả")
                {
                MessageBox.Show("Sách đã trả rồi!!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Bạn Muốn Trả Sách"
                        + masach + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            con.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE dksach SET trangthai = N'Đã Trả' " + ",ngaytra = @ngaytra WHERE masach = @masach";

                            using (SqlCommand cmd = new SqlCommand(updateData, con))
                            {

                                cmd.Parameters.AddWithValue("@ngaytra", today);
                                cmd.Parameters.AddWithValue("@masach", masach);

                                cmd.ExecuteNonQuery();

                                dpsachm();

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

        private void button2_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            this.button2.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.ForeColor = Color.White;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.button1.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.White;
        }
    }
}
