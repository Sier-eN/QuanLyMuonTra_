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
    public class user
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");
        public int id { get; set; }
        public string taikhoan { get; set; }
        public string matkhau { get; set; }
        public string email { get; set; }
        public string quyen { get; set; }
        public List<user> dluser()
        {
            List<user> listdata = new List<user>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string chondl = "SELECT * FROM taikhoan ";
                    using (SqlCommand cmd = new SqlCommand(chondl, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            user dlu = new user();
                            dlu.id = (int)reader["id"];
                            dlu.taikhoan = reader["taikhoan"].ToString();
                            dlu.matkhau = reader["matkhau"].ToString();
                            dlu.email = reader["email"].ToString();
                            dlu.quyen = reader["quyen"].ToString();
                            listdata.Add(dlu);
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
