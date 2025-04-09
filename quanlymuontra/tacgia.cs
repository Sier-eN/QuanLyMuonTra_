using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlymuontra
{
    class tacgia
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F26RCTP\MSSQLSERVER01;Initial Catalog=quanlymuontra;Integrated Security=True");

        public int id { get; set; }
        public string tentg { get; set; }
        public List<tacgia> dLtg()
        {
            List<tacgia> listdata = new List<tacgia>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string chondl = "SELECT * FROM tacgia ";
                    using (SqlCommand cmd = new SqlCommand(chondl, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            tacgia dltg = new tacgia();
                            dltg.id = (int)reader[id];
                            dltg.tentg = reader["tentg"].ToString();
                            listdata.Add(dltg);
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
