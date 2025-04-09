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

    public partial class giaodienchinh : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");
        public giaodienchinh()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 m2 = new Form1();
            m2.Show();
        }
        private void anmenu()
        {
            qlkspanel.Visible = false;
            qlmspanel.Visible = false;
            qltspanel.Visible = false;
            cdpanel.Visible = false;
        }
        private void hienmenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                anmenu();
                menu.Visible = true;
            }
            else menu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hienmenu(qlmspanel);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hienmenu(qltspanel);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            hienmenu(qlkspanel);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            hienmenu(cdpanel);

        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form giaodien)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = giaodien;
            giaodien.TopLevel = false;
            giaodien.FormBorderStyle = FormBorderStyle.None;
            giaodien.Dock = DockStyle.Fill;
            panelgiaodien.Controls.Add(giaodien);
            panelgiaodien.Tag = giaodien;
            giaodien.BringToFront();
            giaodien.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form4());

        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.button1.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.White;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form3());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form5());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form6());
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            this.button5.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            this.button5.ForeColor = Color.White;
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            this.button7.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            this.button7.ForeColor = Color.White;
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

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            this.button4.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            this.button4.ForeColor = Color.White;
        }

        private void button9_MouseMove(object sender, MouseEventArgs e)
        {
            this.button9.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            this.button9.ForeColor = Color.White;
        }





        private void button13_MouseMove(object sender, MouseEventArgs e)
        {
            this.button13.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            this.button13.ForeColor = Color.White;
        }

        private void button12_MouseMove(object sender, MouseEventArgs e)
        {
            this.button12.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            this.button12.ForeColor = Color.White;
        }
        
        private string taikhoan = "";
        private string loaitk;

        private void giaodienchinh_Load(object sender, EventArgs e)
        {

        }

        private void panelgiaodien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            this.button6.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            this.button6.ForeColor = Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new quanlydl());
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            this.button6.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            this.button6.ForeColor = Color.White;
        }

        private void button10_MouseMove(object sender, MouseEventArgs e)
        {
            this.button6.ForeColor = ColorTranslator.FromHtml("248, 132, 61");
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            this.button6.ForeColor = Color.White;
        }
    }
}
