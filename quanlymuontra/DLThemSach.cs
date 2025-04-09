using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace quanlymuontra
{
    class DLThemSach
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");

        public int masach { get; set; }
        public string tensach { get; set; }
        public string tacgia { get; set; }
        public string theloai { get; set; }
        public string ngayxuatban { get; set; }
        public string trangthai { get; set; }
        public List<DLThemSach> dLThemSach()
        {
            List<DLThemSach> listdata = new List<DLThemSach>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string chondl = "SELECT * FROM sach WHERE ngayxoa IS NULL";
                    using (SqlCommand cmd = new SqlCommand(chondl, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        
                        while(reader.Read())
                        {
                            DLThemSach dts = new DLThemSach();
                            dts.masach = (int)reader[masach];
                            dts.tensach = reader["tensach"].ToString();
                            dts.tacgia = reader["tacgia"].ToString();
                            dts.theloai = reader["theloai"].ToString();
                            dts.ngayxuatban = reader["ngayxuatban"].ToString();
                            dts.trangthai = reader["trangthai"].ToString();
                            listdata.Add(dts);
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Loi ket noi CSDL: "+ex);
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
