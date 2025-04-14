using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlymuontra
{
    class DLsachmuon
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");

        public int masach { get; set; }
        public string tensach { get; set; }
        
        public string ngaymuon { get; set; }
        
        
        public string hantra {  get; set; } 
        public string trangthai { get; set; }
        public List<DLsachmuon>dLSachmuon()
        {
            List<DLsachmuon> listdata = new List<DLsachmuon>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string chondl = "SELECT * FROM dksach WHERE trangthai = N'Chờ Duyệt Mượn'   ";
                    string chon = "SELECT * FROM dksach WHERE trangthaii = N'Chưa Trả'";
                    using (SqlCommand cmd = new SqlCommand(chondl, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DLsachmuon dlm = new DLsachmuon();
                            dlm.masach = (int)reader[masach];
                            dlm.tensach = reader["tensach"].ToString();
                           
                            dlm.ngaymuon = reader["ngaymuon"].ToString();
                            
                            dlm.hantra = reader["hantra"].ToString();
                            dlm.trangthai = reader["trangthai"].ToString();
                            listdata.Add(dlm);
                        }
                        reader.Close();
                    }
                    using (SqlCommand cmd = new SqlCommand(chon, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DLsachmuon dlm = new DLsachmuon();
                            dlm.masach = (int)reader[masach];
                            dlm.tensach = reader["tensach"].ToString();

                            dlm.ngaymuon = reader["ngaymuon"].ToString();

                            dlm.hantra = reader["hantra"].ToString();
                            dlm.trangthai = reader["trangthai"].ToString();
                            listdata.Add(dlm);
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

