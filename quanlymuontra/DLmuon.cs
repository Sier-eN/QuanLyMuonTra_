using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlymuontra
{
    class DLmuon
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");

        public int masach { get; set; }
        public string iduser { get; set; }   
        public string email { get; set; }
        public string tensach { get; set; }
        public string trangthai { get; set; }
        public string ngaymuon { get; set; }
        public string ngaytra {  get; set; }
        public string hantra { get; set; }
        
        public List<DLmuon> dlmuon()
        {
            List<DLmuon> listdata = new List<DLmuon>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string chondl = "SELECT * FROM dksach Where trangthai = N'Chưa Trả' ";
                    string chond = "SELECT * FROM dksach Where trangthai = N'Chờ Duyệt Trả' ";
                    string chon = "SELECT * FROM dksach Where trangthai = N'Chờ Duyệt Mượn' ";
                    using (SqlCommand cm = new SqlCommand(chon, con))
                    {
                        SqlDataReader reader = cm.ExecuteReader();

                        while (reader.Read())
                        {
                            DLmuon dl = new DLmuon();
                            dl.masach = (int)reader[masach];
                            dl.iduser = reader["iduser"].ToString();
                            dl.email = reader["email"].ToString();
                            dl.tensach = reader["tensach"].ToString();
                            dl.trangthai = reader["trangthai"].ToString();
                            dl.ngaymuon = reader["ngaymuon"].ToString();
                            dl.ngaytra = reader["ngaytra"].ToString();
                            dl.hantra = reader["hantra"].ToString();

                            listdata.Add(dl);
                        }
                        reader.Close();
                    }
                    using (SqlCommand cm = new SqlCommand(chond, con))
                    {
                        SqlDataReader reader = cm.ExecuteReader();
                        while (reader.Read())
                        {
                            DLmuon dl = new DLmuon();
                            dl.masach = (int)reader[masach];
                            dl.iduser = reader["iduser"].ToString();
                            dl.email = reader["email"].ToString();
                            dl.tensach = reader["tensach"].ToString();
                            dl.trangthai = reader["trangthai"].ToString();
                            dl.ngaymuon = reader["ngaymuon"].ToString();
                            dl.ngaytra = reader["ngaytra"].ToString();
                            dl.hantra = reader["hantra"].ToString();
                            listdata.Add(dl);
                        }
                        reader.Close();
                    }
                    using (SqlCommand cm = new SqlCommand(chondl, con))
                    {
                        SqlDataReader reader = cm.ExecuteReader();

                        while (reader.Read())
                        {
                            DLmuon dl= new DLmuon();
                            dl.masach = (int)reader[masach];
                            dl.iduser = reader["iduser"].ToString();
                            dl.email = reader["email"].ToString();
                            dl.tensach = reader["tensach"].ToString();
                            dl.trangthai = reader["trangthai"].ToString();
                            dl.ngaymuon = reader["ngaymuon"].ToString();
                            dl.ngaytra = reader["ngaytra"].ToString();
                            dl.hantra = reader["hantra"].ToString();
                            
                            listdata.Add(dl);
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Loi ket noi CSDL: " + ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return listdata;

        }
    }
}

