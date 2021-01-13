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
                    [SoCmndCccd], 
                    [NguoiKhaiBao], 
                    [NgheNghiep], 
                    [NoiLamViec], 
                    [ThoiGianBatDau], 
                    [ThoiGianKetThuc], 
                    [NoiTamTru],
                    [LyDo],
                    [QuanHeChuHo],
                    [SoNha],
                    [DanhSachTreEm],
                    [NgayKhaiBao],
                    [TenCanBo]
                    )";
            query += @"VALUES (
                @SoCmndCccd, 
                @NguoiKhaiBao, 
                @NgheNghiep, 
                @NoiLamViec, 
                @ThoiGianBatDau, 
                @ThoiGianKetThuc, 
                @NoiTamTru, 
                @LyDo, 
                @QuanHeChuHo, 
                @SoNha, 
                @DanhSachTreEm, 
                @NgayKhaiBao, 
                @TenCanBo
                )";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@SoCmndCccd", ptv.SoCmndCccd);
                    cmd.Parameters.AddWithValue("@NguoiKhaiBao", ptv.NguoiKhaiBao);
                    cmd.Parameters.AddWithValue("@NgheNghiep", ptv.NgheNghiep);
                    cmd.Parameters.AddWithValue("@NoiLamViec", ptv.NoiLamViec);
                    cmd.Parameters.AddWithValue("@ThoiGianBatDau", ptv.ThoiGianBatDau);
                    cmd.Parameters.AddWithValue("@ThoiGianKetThuc", ptv.ThoiGianKetThuc);
                    cmd.Parameters.AddWithValue("@NoiTamTru", ptv.NoiTamTru);
                    cmd.Parameters.AddWithValue("@LyDo", ptv.LyDo);
                    cmd.Parameters.AddWithValue("@QuanHeChuHo", ptv.QuanHeChuHo);
                    cmd.Parameters.AddWithValue("@SoNha", ptv.SoNha);
                    cmd.Parameters.AddWithValue("@DanhSachTreEm", ptv.DanhSachTreEm);
                    cmd.Parameters.AddWithValue("@NgayKhaiBao", ptv.NgayKhaiBao);
                    cmd.Parameters.AddWithValue("@TenCanBo", ptv.TenCanBo);

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
            query += "[SoCmndCccd] = @SoCmndCccd, ";
            query += "[NguoiKhaiBao] = @NguoiKhaiBao, ";
            query += "[NgheNghiep] = @NgheNghiep, ";
            query += "[NoiLamViec] = @NoiLamViec, ";
            query += "[ThoiGianBatDau] = @ThoiGianBatDau, ";
            query += "[ThoiGianKetThuc] = @ThoiGianKetThuc, ";
            query += "[NoiTamTru] = @NoiTamTru, ";
            query += "[LyDo] = @LyDo, ";
            query += "[QuanHeChuHo] = @QuanHeChuHo, ";
            query += "[SoNha] = @SoNha, ";
            query += "[DanhSachTreEm] = @DanhSachTreEm, ";
            query += "[NgayKhaiBao] = @NgayKhaiBao, ";
            query += "[TenCanBo] = @TenCanBo ";
            query += "WHERE [Ma] = @Ma";

            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@Ma", ptv.Ma);
                    cmd.Parameters.AddWithValue("@SoCmndCccd", ptv.SoCmndCccd);
                    cmd.Parameters.AddWithValue("@NguoiKhaiBao", ptv.NguoiKhaiBao);
                    cmd.Parameters.AddWithValue("@NgheNghiep", ptv.NgheNghiep);
                    cmd.Parameters.AddWithValue("@NoiLamViec", ptv.NoiLamViec);
                    cmd.Parameters.AddWithValue("@ThoiGianBatDau", ptv.ThoiGianBatDau);
                    cmd.Parameters.AddWithValue("@ThoiGianKetThuc", ptv.ThoiGianKetThuc);
                    cmd.Parameters.AddWithValue("@NoiTamTru", ptv.NoiTamTru);
                    cmd.Parameters.AddWithValue("@LyDo", ptv.LyDo);
                    cmd.Parameters.AddWithValue("@QuanHeChuHo", ptv.QuanHeChuHo);
                    cmd.Parameters.AddWithValue("@SoNha", ptv.SoNha);
                    cmd.Parameters.AddWithValue("@DanhSachTreEm", ptv.DanhSachTreEm);
                    cmd.Parameters.AddWithValue("@NgayKhaiBao", ptv.NgayKhaiBao);
                    cmd.Parameters.AddWithValue("@TenCanBo", ptv.TenCanBo);

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
                        SoCmndCccd like @Param or
                        NguoiKhaiBao like @Param or
                        NgheNghiep like @Param or
                        NoiLamViec like @Param or
                        convert(nvarchar(25), ThoiGianBatDau, 25) like @Param or
                        convert(nvarchar(25), ThoiGianKetThuc, 25) like @Param or
                        NoiTamTru like @Param or
                        LyDo like @Param or
                        QuanHeChuHo like @Param or
                        SoNha like @Param or
                        DanhSachTreEm like @Param or
                        convert(nvarchar(25), NgayKhaiBao, 25) like @Param or
                        TenCanBo like @Param
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

        private PhieuTamVang GetFromReader(SqlDataReader reader)
        {
            PhieuTamVang ptv = new PhieuTamVang();

            ptv.Ma = int.Parse(reader["Ma"].ToString());
            ptv.SoCmndCccd = reader["SoCmndCccd"].ToString();
            ptv.NguoiKhaiBao = reader["NguoiKhaiBao"].ToString();
            ptv.NgheNghiep = reader["NgheNghiep"].ToString();
            ptv.NoiLamViec = reader["NoiLamViec"].ToString();
            ptv.NoiTamTru = reader["NoiTamTru"].ToString();
            ptv.LyDo = reader["LyDo"].ToString();
            ptv.QuanHeChuHo = reader["QuanHeChuHo"].ToString();
            ptv.SoNha = reader["SoNha"].ToString();
            ptv.DanhSachTreEm = reader["DanhSachTreEm"].ToString();
            ptv.TenCanBo = reader["TenCanBo"].ToString();

            string ThoiGianBatDau, ThoiGianKetThuc, NgayKhaiBao;
            ThoiGianBatDau = reader["ThoiGianBatDau"].ToString();
            ThoiGianKetThuc = reader["ThoiGianKetThuc"].ToString();
            NgayKhaiBao = reader["NgayKhaiBao"].ToString();

            if (!string.IsNullOrEmpty(ThoiGianBatDau.Trim()))
                ptv.ThoiGianBatDau = DateTime.Parse(ThoiGianBatDau);

            if (!string.IsNullOrEmpty(ThoiGianKetThuc.Trim()))
                ptv.ThoiGianKetThuc = DateTime.Parse(ThoiGianKetThuc);

            if (!string.IsNullOrEmpty(NgayKhaiBao.Trim()))
                ptv.NgayKhaiBao = DateTime.Parse(NgayKhaiBao);

            return ptv;
        }
    }
}
