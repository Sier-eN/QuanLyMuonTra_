using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlymuontra
{
    class theloai
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");

        public int id { get; set; }
        public string tentl { get; set; }
        public List<theloai> dLtl()
        {
            List<theloai> listdata = new List<theloai>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string chondl = "SELECT * FROM theloai ";
                    using (SqlCommand cmd = new SqlCommand(chondl, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            theloai dltl = new theloai();
                            dltl.id = (int)reader[id];
                            dltl.tentl = reader["tentl"].ToString();
                            listdata.Add(dltl);
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
