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
    public class PhieuChuyenKhauDAL
    {
        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        private static PhieuChuyenKhauDAL instance;

        public static PhieuChuyenKhauDAL GetInstance()
        {
            if (instance == null)
                instance = new PhieuChuyenKhauDAL();
            return instance;
        }

        public bool Add(PhieuChuyenKhau phieu)
        {
            string query = string.Empty;
            query += @"
                INSERT INTO [PHIEU_CHUYEN_KHAU] (
                    [MaCongDan], 
                    [MaHoKhauChuyenTu], 
                    [MaHoKhauChuyenDen], 
                    [NgayChuyenKhau] 
                    )";
            query += @"VALUES (
                @MaCongDan, 
                @MaHoKhauChuyenTu, 
                @MaHoKhauChuyenDen, 
                @NgayChuyenKhau
                )";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@MaCongDan", phieu.MaCongDan);
                    cmd.Parameters.AddWithValue("@MaHoKhauChuyenTu", phieu.MaHoKhauChuyenTu);
                    cmd.Parameters.AddWithValue("@MaHoKhauChuyenDen", phieu.MaHoKhauChuyenDen);
                    cmd.Parameters.AddWithValue("@NgayChuyenKhau", phieu.NgayChuyenKhau);

                    try
                    {
                        _cnn.Open();
                        cmd.ExecuteNonQuery();
                        _cnn.Close();
                        _cnn.Dispose();
                    }
                    catch (Exception ex)
                    {
                        _cnn.Close();
                        return false;
                    }
                }
            }
            return true;
        }
        public List<PhieuChuyenKhau> ReadAll()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [PHIEU_CHUYEN_KHAU]";

            List<PhieuChuyenKhau> phieus = new List<PhieuChuyenKhau>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;

                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                PhieuChuyenKhau phieu = GetFromReader(reader);

                                phieus.Add(phieu);
                            }
                        }

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
            return phieus;
        }
        private PhieuChuyenKhau GetFromReader(SqlDataReader reader)
        {
            PhieuChuyenKhau phieu = new PhieuChuyenKhau();

            phieu.Ma = int.Parse(reader["Ma"].ToString());
            phieu.MaCongDan = int.Parse(reader["MaCongDan"].ToString());
            phieu.MaHoKhauChuyenDen = int.Parse(reader["MaHoKhauChuyenDen"].ToString());
            phieu.MaHoKhauChuyenTu = int.Parse(reader["MaHoKhauChuyenTu"].ToString());

            string NgayChuyenKhau;
            NgayChuyenKhau = reader["NgayChuyenKhau"].ToString();

            if (!string.IsNullOrEmpty(NgayChuyenKhau.Trim()))
                phieu.NgayChuyenKhau = DateTime.Parse(NgayChuyenKhau);

            phieu.CongDanChuyenKhau = CongDanDAL.GetInstance().Read(phieu.MaCongDan);
            phieu.HoKhauChuyenTu = HoKhauDAL.GetInstance().Read(phieu.MaHoKhauChuyenTu);
            phieu.HoKhauChuyenDen = HoKhauDAL.GetInstance().Read(phieu.MaHoKhauChuyenDen);
            phieu.SelfUpdate();

            return phieu;
        }
    }
}
