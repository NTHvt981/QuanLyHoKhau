using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHK_DTO;

namespace QLHK_DAL
{
    public class PhieuTamVangDAL
    {
        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        private static PhieuTamVangDAL instance;

        public static PhieuTamVangDAL GetInstance()
        {
            if (instance == null)
                instance = new PhieuTamVangDAL();
            return instance;
        }

        public bool Add(PhieuTamVang ptv)
        {
            string query = string.Empty;
            query += @"
                INSERT INTO [PHIEU_TAM_VANG] (
                    [LyDo], 
                    [MaNguoiKhaiBao], 
                    [TenNguoiKhaiBao], 
                    [NgayCap], 
                    [NguoiCap], 
                    [NoiCap], 
                    [NoiTamTru],
                    [ThoiGianBatDau],
                    [ThoiGianKetThuc]
                    )";
            query += @"VALUES (
                    @LyDo, 
                    @MaNguoiKhaiBao, 
                    @TenNguoiKhaiBao, 
                    @NgayCap, 
                    @NguoiCap, 
                    @NoiCap, 
                    @NoiTamTru,
                    @ThoiGianBatDau,
                    @ThoiGianKetThuc
                )";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    SetParam(ptv, cmd);

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
        public bool Update(PhieuTamVang ptv)
        {
            string query = string.Empty;
            query += "UPDATE [PHIEU_TAM_VANG] SET ";
            query += "[LyDo] = @LyDo, ";
            query += "[MaNguoiKhaiBao] = @MaNguoiKhaiBao, ";
            query += "[TenNguoiKhaiBao] = @TenNguoiKhaiBao, ";
            query += "[NgayCap] = @NgayCap, ";
            query += "[NguoiCap] = @NguoiCap, ";
            query += "[NoiCap] = @NoiCap, ";
            query += "[NoiTamTru] = @NoiTamTru, ";
            query += "[NoiTamTru] = @NoiTamTru, ";
            query += "[ThoiGianBatDau] = @ThoiGianBatDau, ";
            query += "[ThoiGianKetThuc] = @ThoiGianKetThuc ";
            query += "WHERE [Ma] = @Ma";

            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@Ma", ptv.Ma);
                    SetParam(ptv, cmd);

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

        public bool Delete(PhieuTamVang ptv)
        {
            string query = string.Empty;
            query += "DELETE FROM [PHIEU_TAM_VANG] WHERE [Ma] = @Ma";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Ma", ptv.Ma);
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
        public bool DeleteAll()
        {
            string query = string.Empty;
            query += "DELETE FROM [PHIEU_TAM_VANG]";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
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

        public List<PhieuTamVang> ReadAll()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [PHIEU_TAM_VANG]";

            List<PhieuTamVang> ptvs = new List<PhieuTamVang>();

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
                                PhieuTamVang ptv = GetFromReader(reader);

                                ptvs.Add(ptv);
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
            return ptvs;
        }
        public List<PhieuTamVang> ReadAllByKeyword(string key)
        {
            string query = string.Empty;
            query += @"select * from [PHIEU_TAM_VANG]
                    where
                        
            ";

            List<PhieuTamVang> congDans = new List<PhieuTamVang>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Param", '%' + key + '%');

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;

                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                PhieuTamVang ptv = GetFromReader(reader);

                                congDans.Add(ptv);
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
            return congDans;
        }

        public PhieuTamVang Read(string ma)
        {
            string query = string.Empty;
            query += "SELECT TOP 1 * ";
            query += "FROM [PHIEU_TAM_VANG] WHERE [Ma]=@Ma";

            PhieuTamVang ptv = new PhieuTamVang();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Ma", ma);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;

                        reader = cmd.ExecuteReader();
                        reader.Read();

                        ptv = GetFromReader(reader);

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
            return ptv;
        }

        private static void SetParam(PhieuTamVang ptv, SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@LyDo", ptv.LyDo);
            cmd.Parameters.AddWithValue("@MaNguoiKhaiBao", ptv.MaNguoiKhaiBao);
            cmd.Parameters.AddWithValue("@TenNguoiKhaiBao", ptv.TenNguoiKhaiBao);
            cmd.Parameters.AddWithValue("@NgayCap", ptv.NgayCap);
            cmd.Parameters.AddWithValue("@NguoiCap", ptv.NguoiCap);
            cmd.Parameters.AddWithValue("@NoiCap", ptv.NoiCap);
            cmd.Parameters.AddWithValue("@NoiTamTru", ptv.NoiTamTru);
            cmd.Parameters.AddWithValue("@ThoiGianBatDau", ptv.ThoiGianBatDau);
            cmd.Parameters.AddWithValue("@ThoiGianKetThuc", ptv.ThoiGianKetThuc);
        }

        private PhieuTamVang GetFromReader(SqlDataReader reader)
        {
            PhieuTamVang ptv = new PhieuTamVang();

            ptv.LyDo = reader["LyDo"].ToString();
            ptv.Ma = int.Parse( reader["Ma"].ToString());
            ptv.MaNguoiKhaiBao = int.Parse(reader["MaNguoiKhaiBao"].ToString());
            ptv.TenNguoiKhaiBao = reader["TenNguoiKhaiBao"].ToString();
            ptv.NguoiCap = reader["NguoiCap"].ToString();
            ptv.NoiCap = reader["NoiCap"].ToString();
            ptv.NoiTamTru = reader["NoiTamTru"].ToString();

            string ThoiGianBatDau, ThoiGianKetThuc, NgayCap;
            ThoiGianBatDau = reader["ThoiGianBatDau"].ToString();
            ThoiGianKetThuc = reader["ThoiGianKetThuc"].ToString();
            NgayCap = reader["NgayCap"].ToString();

            if (!string.IsNullOrEmpty(ThoiGianBatDau.Trim()))
                ptv.ThoiGianBatDau = DateTime.Parse(ThoiGianBatDau);

            if (!string.IsNullOrEmpty(ThoiGianKetThuc.Trim()))
                ptv.ThoiGianKetThuc = DateTime.Parse(ThoiGianKetThuc);

            if (!string.IsNullOrEmpty(NgayCap.Trim()))
                ptv.NgayCap = DateTime.Parse(NgayCap);

            return ptv;
        }
    }
}
