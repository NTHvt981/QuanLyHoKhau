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
    class PhieuThayDoiHoKhauDAL
    {
        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        private static PhieuThayDoiHoKhauDAL instance;

        public static PhieuThayDoiHoKhauDAL GetInstance()
        {
            if (instance == null)
                instance = new PhieuThayDoiHoKhauDAL();
            return instance;
        }

        public bool Add(PhieuThayDoiHoKhau bknk)
        {
            string query = string.Empty;
            query += @"
                INSERT INTO [PHIEU_THAY_DOI_HO_KHAU] (
                    [SoCmndCccd], 
                    [HoTen], 
                    [ChuHo], 
                    [SoHoSo], 
                    [TenThuongGoi], 
                    [NgaySinh], 
                    [QueQuan],
                    [DiaChiHoKhau],
                    [DanToc],
                    [DacDiemNhanDang],
                    [NgheNghiep],
                    [NgayCap],
                    [NoiCap],
                    [NguoiCap]
                    )";
            query += @"VALUES (
                @SoCmndCccd, 
                @HoTen, 
                @ChuHo, 
                @SoHoSo, 
                @TenThuongGoi, 
                @NgaySinh, 
                @QueQuan, 
                @DiaChiHoKhau, 
                @DanToc, 
                @DacDiemNhanDang, 
                @NgheNghiep, 
                @NgayCap,
                @NoiCap,
                @NguoiCap
                )";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@SoCmndCccd", bknk.SoCmndCccd);
                    cmd.Parameters.AddWithValue("@HoTen", bknk.HoTen);
                    cmd.Parameters.AddWithValue("@ChuHo", bknk.ChuHo);
                    cmd.Parameters.AddWithValue("@SoHoSo", bknk.SoHoSo);
                    cmd.Parameters.AddWithValue("@TenThuongGoi", bknk.TenThuongGoi);
                    cmd.Parameters.AddWithValue("@NgaySinh", bknk.NgaySinh);
                    cmd.Parameters.AddWithValue("@QueQuan", bknk.QueQuan);
                    cmd.Parameters.AddWithValue("@DiaChiHoKhau", bknk.DiaChiHoKhau);
                    cmd.Parameters.AddWithValue("@DanToc", bknk.DanToc);
                    cmd.Parameters.AddWithValue("@DacDiemNhanDang", bknk.DacDiemNhanDang);
                    cmd.Parameters.AddWithValue("@NgheNghiep", bknk.NgheNghiep);
                    cmd.Parameters.AddWithValue("@NgayCap", bknk.@NgayCap);
                    cmd.Parameters.AddWithValue("@NoiCap", bknk.@NoiCap);
                    cmd.Parameters.AddWithValue("@NguoiCap", bknk.@NguoiCap);

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

        public bool Delete(PhieuThayDoiHoKhau bknk)
        {
            string query = string.Empty;
            query += "DELETE FROM [PHIEU_THAY_DOI_HO_KHAU] WHERE [Ma] = @Ma";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Ma", bknk.Ma);
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
            query += "DELETE FROM [PHIEU_THAY_DOI_HO_KHAU]";
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

        public List<PhieuThayDoiHoKhau> ReadAll()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [PHIEU_THAY_DOI_HO_KHAU]";

            List<PhieuThayDoiHoKhau> bknks = new List<PhieuThayDoiHoKhau>();

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
                                PhieuThayDoiHoKhau bknk = GetFromReader(reader);

                                bknks.Add(bknk);
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
            return bknks;
        }
        public List<PhieuThayDoiHoKhau> ReadAllByKeyword(string key)
        {
            string query = string.Empty;
            query += @"select * from [PHIEU_THAY_DOI_HO_KHAU]
                    where
                        SoCmndCccd like @Param or
                        HoTen like @Param or
                        ChuHo like @Param or
                        SoHoSo like @Param or
                        TenThuongGoi like @Param or
                        QueQuan like @Param or
                        QuocTich like @Param or
                        DiaChiHoKhau like @Param or
                        DanToc like @Param or
                        TonGiao like @Param or
                        NgheNghiep like @Param or
                        NoiCap like @Param or
                        NguoiCap like @Param 
            ";

            List<PhieuThayDoiHoKhau> congDans = new List<PhieuThayDoiHoKhau>();

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
                                PhieuThayDoiHoKhau bknk = GetFromReader(reader);

                                congDans.Add(bknk);
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

        private PhieuThayDoiHoKhau GetFromReader(SqlDataReader reader)
        {
            PhieuThayDoiHoKhau bknk = new PhieuThayDoiHoKhau();

            bknk.Ma = int.Parse(reader["Ma"].ToString());
            bknk.SoCmndCccd = reader["SoCmndCccd"].ToString();
            bknk.HoTen = reader["HoTen"].ToString();
            bknk.ChuHo = reader["ChuHo"].ToString();
            bknk.SoHoSo = reader["SoHoSo"].ToString();
            bknk.TenThuongGoi = reader["TenThuongGoi"].ToString();
            bknk.QueQuan = reader["QueQuan"].ToString();
            bknk.DiaChiHoKhau = reader["DiaChiHoKhau"].ToString();
            bknk.DanToc = reader["DanToc"].ToString();
            bknk.DacDiemNhanDang = reader["DacDiemNhanDang"].ToString();
            bknk.ChuHo = reader["ChuHo"].ToString();
            bknk.NoiCap = reader["NoiCap"].ToString();
            bknk.NguoiCap = reader["NguoiCap"].ToString();

            string NgayCap, NgaySinh;
            NgayCap = reader["NgayCap"].ToString();
            NgaySinh = reader["NgaySinh"].ToString();

            if (!string.IsNullOrEmpty(NgayCap.Trim()))
                bknk.NgayCap = DateTime.Parse(NgayCap);

            if (!string.IsNullOrEmpty(NgaySinh.Trim()))
                bknk.NgaySinh = DateTime.Parse(NgaySinh);

            return bknk;
        }
    }
}
