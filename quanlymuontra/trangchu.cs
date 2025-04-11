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
        public void dpsach()
        {
            DLThemSach dts = new DLThemSach();
            List<DLThemSach> bangdl = dts.dLThemSach();
            dataGridView1.DataSource = bangdl;
        }
        private void tg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string tuTK = tg.Text.Trim();
            string sql = $"SELECT masach,tensach,tacgia,theloai,ngayxuatban,trangthai FROM sach " +
                $"WHERE tacgia = '{tuTK}' ";
            DataTable dt = new DataTable();
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }

        }
      
        
        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
