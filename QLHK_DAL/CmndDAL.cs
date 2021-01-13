using QLHK_DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DAL
{
    public class CmndDAL
    {
        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        private static CmndDAL instance;

        public static CmndDAL GetInstance()
        {
            if (instance == null)
                instance = new CmndDAL();
            return instance;
        }

        public Cmnd Read(string soCmnd)
        {
            string query = string.Empty;
            query += "SELECT TOP 1 * ";
            query += "FROM [CMND] WHERE [SoCmnd]=@SoCmnd";

            Cmnd cd = new Cmnd();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@SoCmnd", soCmnd);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;

                        reader = cmd.ExecuteReader();
                        reader.Read();

                        cd.Ma = int.Parse(reader["Ma"].ToString());
                        cd.SoCmnd = reader["SoCmnd"].ToString();
                        cd.HoTen = reader["HoTen"].ToString();
                        cd.QueQuan = reader["QueQuan"].ToString();
                        cd.DiaChiHoKhau = reader["DiaChiHoKhau"].ToString();
                        cd.DanToc = reader["DanToc"].ToString();
                        cd.TonGiao = reader["TonGiao"].ToString();
                        cd.DacDiemNhanDang = reader["DacDiemNhanDang"].ToString();
                        cd.NoiCap = reader["NoiCap"].ToString();
                        cd.NguoiCap = reader["NguoiCap"].ToString();

                        cd.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                        cd.NgayCap = DateTime.Parse(reader["NgayCap"].ToString());

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return cd;
        }
    }
}
