using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace quanlymuontra
{
    class DLSach
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");

        public int masach { get; set; }
        public string tensach { get; set; }
        
        
        
        public string trangthai { get; set; }
        public List<DLSach> dLSach()
        {
            List<DLSach> listdata = new List<DLSach>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string chondl = "SELECT * FROM sach WHERE ngayxoa IS NULL";
                    using (SqlCommand cmd = new SqlCommand(chondl, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DLSach dls = new DLSach();
                            dls.masach = (int)reader[masach];
                            dls.tensach = reader["tensach"].ToString();
                            dls.trangthai = reader["trangthai"].ToString();
                            listdata.Add(dls);
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

