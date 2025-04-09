using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace quanlymuontra
{
    public partial class quanlydl : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");
        public quanlydl()
        {
            InitializeComponent();
            dptg();
            dptl();
        }

        private void quanlydl_Load(object sender, EventArgs e)
        {
            
        }
        public void dptg()
        {
            tacgia dltg = new tacgia();
            List<tacgia> bang1 = dltg.dLtg();
            dataGridView2.DataSource = bang1;
        }
        public void dptl()
        {
            theloai dltl = new theloai();
            List<theloai> bang2 = dltl.dLtl();
            dataGridView1.DataSource = bang2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (theloai.Text == "")
            {
                MessageBox.Show("Hãy điền thể loại", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (con.State == ConnectionState.Closed)
                {
                    try
                    {

                        con.Open();
                        string themDL = "INSERT into theloai(tentl) " +
                        "VALUES(@tentl)";

                        using (SqlCommand cmd = new SqlCommand(themDL, con))
                        {

                            cmd.Parameters.AddWithValue("@tentl", theloai.Text.Trim());


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dptl();

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

        private void themtacgia_Click(object sender, EventArgs e)
        {
            if (tacgia.Text == "")
            {
                MessageBox.Show("Hãy điền thể loại", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (con.State == ConnectionState.Closed)
                {
                    try
                    {

                        con.Open();
                        string themDL = "INSERT into tacgia(tentg) " +
                        "VALUES(@tentg)";

                        using (SqlCommand cmd = new SqlCommand(themDL, con))
                        {

                            cmd.Parameters.AddWithValue("@tentg", tacgia.Text.Trim());


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dptg();

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

        private void themtheloai_MouseMove(object sender, MouseEventArgs e)
        {
            this.themtheloai.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void themtheloai_MouseLeave(object sender, EventArgs e)
        {
            this.themtheloai.ForeColor = Color.White;
        }

        private void themtacgia_MouseMove(object sender, MouseEventArgs e)
        {
            this.themtacgia.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void themtacgia_MouseLeave(object sender, EventArgs e)
        {
            this.themtacgia.ForeColor = Color.White;
        }
    }
}
