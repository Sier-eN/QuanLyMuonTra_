using Microsoft.VisualBasic.Devices;
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

    public partial class trangchu : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");
        
        public trangchu()
        {
            InitializeComponent();
            load_tentacgia();
            load_tentheloai();
            dpsach();
        }
        public void load_tentacgia()
        {
            string tacgia = "select tentg from tacgia";
            SqlDataAdapter ad = new SqlDataAdapter(tacgia, con);
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

        private void trangchu_Load(object sender, EventArgs e)
        {

        }
        public void clearFields()
        {
            tensach.Text = "";
            tg.Text = "";
            themtl.Text = "";
            trangthai.SelectedIndex = -1;

        }
        public void dpsach()
        {
            DLThemSach dts = new DLThemSach();
            List<DLThemSach> bangdl = dts.dLThemSach();
            dataGridView1.DataSource = bangdl;
        }
        private void tensach_TextChanged(object sender, EventArgs e)
        {
            string ten = "select masach,tensach,tacgia,theloai,ngayxuatban,trangthai from sach where tensach like N'%" + tensach.Text.Trim() + "%' and ngayxoa IS NULL ";
            SqlDataAdapter ad = new SqlDataAdapter(ten, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            this.button2.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.ForeColor = Color.White;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tg_ValueMemberChanged_1(object sender, EventArgs e)
        {

        }

        private void tg_SelectedValueChanged(object sender, EventArgs e)
        {
            string tacgia = "select masach,tensach,tacgia,theloai,ngayxuatban,trangthai from sach where tacgia = N'" + tg.Text.Trim() + "' and ngayxoa IS NULL";
            SqlDataAdapter ad = new SqlDataAdapter(tacgia, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string reset = "select masach,tensach,tacgia,theloai,ngayxuatban,trangthai from sach where ngayxoa IS NULL";
            SqlDataAdapter ad = new SqlDataAdapter(reset, con);
            DataTable rs = new DataTable();
            ad.Fill(rs);
            dataGridView1.DataSource = rs;
            clearFields();

        }

        private void themtl_SelectedValueChanged(object sender, EventArgs e)
        {
            string tacgia = "select masach,tensach,tacgia,theloai,ngayxuatban,trangthai from sach where theloai = N'" + themtl.Text.Trim() + "' and ngayxoa IS NULL";
            SqlDataAdapter ad = new SqlDataAdapter(tacgia, con);
            DataTable dts = new DataTable();
            ad.Fill(dts);
            dataGridView1.DataSource = dts;
        }

        private void trangthai_SelectedValueChanged(object sender, EventArgs e)
        {
            string tacgia = "select masach,tensach,tacgia,theloai,ngayxuatban,trangthai from sach where trangthai = N'" + trangthai.Text.Trim() + "' and ngayxoa IS NULL";
            SqlDataAdapter ad = new SqlDataAdapter(tacgia, con);
            DataTable dtm = new DataTable();
            ad.Fill(dtm);
            dataGridView1.DataSource = dtm; 
        }
    }
}
