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
    public class BanKhaiNhanKhauDAL
    {
        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        private static BanKhaiNhanKhauDAL instance;

        public static BanKhaiNhanKhauDAL GetInstance()
        {
            if (instance == null)
                instance = new BanKhaiNhanKhauDAL();
            return instance;
        }

        public bool Add(BanKhaiNhanKhau bknk)
        {
            string query = string.Empty;
            query += @"
                INSERT INTO [BAN_KHAI_NHAN_KHAU] (
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
                    [ChuyenMon],
                    [TrinhDoHocVan],
                    [BietTiengDanToc],
                    [TrinhDoNgoaiNgu],
                    [NoiOHienNay],
                    [DanhSachNguoiCungDi],
                    [NgayCap],
                    [NoiCap],
                    [NguoiCap],
                    [DanhSachQuanHeGiaDinh],
                    [DanhSachTienAn],
                    [DanhSachKhenThuong]
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
                @ChuyenMon, 
                @TrinhDoHocVan,
                @BietTiengDanToc,
                @TrinhDoNgoaiNgu,
                @NoiOHienNay,
                @DanhSachNguoiCungDi,
                @NgayCap,
                @NoiCap,
                @NguoiCap,
                @DanhSachQuanHeGiaDinh,
                @DanhSachTienAn,
                @DanhSachKhenThuong
                )";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@BietTiengDanToc", bknk.BietTiengDanToc);
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
                    cmd.Parameters.AddWithValue("@ChuyenMon", bknk.ChuyenMon);
                    cmd.Parameters.AddWithValue("@TrinhDoHocVan", bknk.TrinhDoHocVan);
                    cmd.Parameters.AddWithValue("@TrinhDoNgoaiNgu", bknk.@TrinhDoNgoaiNgu);
                    cmd.Parameters.AddWithValue("@NoiOHienNay", bknk.@NoiOHienNay);
                    cmd.Parameters.AddWithValue("@DanhSachNguoiCungDi", bknk.@DanhSachNguoiCungDi);
                    cmd.Parameters.AddWithValue("@NgayCap", bknk.@NgayCap);
                    cmd.Parameters.AddWithValue("@NoiCap", bknk.@NoiCap);
                    cmd.Parameters.AddWithValue("@NguoiCap", bknk.@NguoiCap);
                    cmd.Parameters.AddWithValue("@DanhSachQuanHeGiaDinh", bknk.@DanhSachQuanHeGiaDinh);
                    cmd.Parameters.AddWithValue("@DanhSachTienAn", bknk.@DanhSachTienAn);
                    cmd.Parameters.AddWithValue("@DanhSachKhenThuong", bknk.@DanhSachKhenThuong);

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
        public bool Update(BanKhaiNhanKhau bknk)
        {
            string query = string.Empty;
            query += "UPDATE [BAN_KHAI_NHAN_KHAU] SET ";
            query += "[SoCmndCccd] = @SoCmndCccd, ";
            query += "[HoTen] = @HoTen, ";
            query += "[ChuHo] = @ChuHo, ";
            query += "[SoHoSo] = @SoHoSo, ";
            query += "[TenThuongGoi] = @TenThuongGoi, ";
            query += "[NgaySinh] = @NgaySinh, ";
            query += "[QueQuan] = @QueQuan, ";
            query += "[DiaChiHoKhau] = @DiaChiHoKhau, ";
            query += "[DanToc] = @DanToc, ";
            query += "[DacDiemNhanDang] = @DacDiemNhanDang, ";
            query += "[NgheNghiep] = @NgheNghiep, ";
            query += "[ChuyenMon] = @ChuyenMon, ";
            query += "[TrinhDoHocVan] = @TrinhDoHocVan, ";
            query += "[BietTiengDanToc] = @BietTiengDanToc, ";
            query += "[TrinhDoNgoaiNgu] = @TrinhDoNgoaiNgu, ";
            query += "[NoiOHienNay] = @NoiOHienNay, ";
            query += "[DanhSachNguoiCungDi] = @DanhSachNguoiCungDi, ";
            query += "[NgayCap] = @NgayCap, ";
            query += "[NoiCap] = @NoiCap, ";
            query += "[NguoiCap] = @NguoiCap, ";
            query += "[DanhSachQuanHeGiaDinh] = @DanhSachQuanHeGiaDinh, ";
            query += "[DanhSachTienAn] = @DanhSachTienAn, ";
            query += "[DanhSachKhenThuong] = @DanhSachKhenThuong ";
            query += "WHERE [Ma] = @Ma";

            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@Ma", bknk.Ma);
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
                    cmd.Parameters.AddWithValue("@ChuyenMon", bknk.ChuyenMon);
                    cmd.Parameters.AddWithValue("@TrinhDoHocVan", bknk.TrinhDoHocVan);
                    cmd.Parameters.AddWithValue("@TrinhDoNgoaiNgu", bknk.@TrinhDoNgoaiNgu);
                    cmd.Parameters.AddWithValue("@NoiOHienNay", bknk.@NoiOHienNay);
                    cmd.Parameters.AddWithValue("@DanhSachNguoiCungDi", bknk.@DanhSachNguoiCungDi);
                    cmd.Parameters.AddWithValue("@NgayCap", bknk.@NgayCap);
                    cmd.Parameters.AddWithValue("@NoiCap", bknk.@NoiCap);
                    cmd.Parameters.AddWithValue("@NguoiCap", bknk.@NguoiCap);
                    cmd.Parameters.AddWithValue("@DanhSachQuanHeGiaDinh", bknk.@DanhSachQuanHeGiaDinh);
                    cmd.Parameters.AddWithValue("@DanhSachTienAn", bknk.@DanhSachTienAn);
                    cmd.Parameters.AddWithValue("@DanhSachKhenThuong", bknk.@DanhSachKhenThuong);

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
        public bool Delete(BanKhaiNhanKhau bknk)
        {
            string query = string.Empty;
            query += "DELETE FROM [BAN_KHAI_NHAN_KHAU] WHERE [Ma] = @Ma";
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
            query += "DELETE FROM [BAN_KHAI_NHAN_KHAU]";
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

        public List<BanKhaiNhanKhau> ReadAll()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [BAN_KHAI_NHAN_KHAU]";

            List<BanKhaiNhanKhau> bknks = new List<BanKhaiNhanKhau>();

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
                                BanKhaiNhanKhau bknk = GetFromReader(reader);

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
        public List<BanKhaiNhanKhau> ReadAllByKeyword(string key)
        {
            string query = string.Empty;
            query += @"select * from [BAN_KHAI_NHAN_KHAU]
                    where
                        SoCmndCccd like @Param or
                        HoTen like @Param or
                        ChuHo like @Param or
                        SoHoSo like @Param or
                        TenThuongGoi like @Param or
                        QueQuan like @Param or
                        DiaChiHoKhau like @Param or
                        DanToc like @Param or
                        DacDiemNhanDang like @Param or
                        NgheNghiep like @Param or
                        ChuyenMon like @Param or
                        TrinhDoHocVan like @Param or
                        BietTiengDanToc like @Param or
                        TrinhDoNgoaiNgu like @Param or
                        NoiOHienNay like @Param or
                        DanhSachNguoiCungDi like @Param or
                        NoiCap like @Param or
                        NguoiCap like @Param or
                        DanhSachQuanHeGiaDinh like @Param or
                        DanhSachTienAn like @Param or
                        DanhSachKhenThuong like @Param
            ";

            List<BanKhaiNhanKhau> congDans = new List<BanKhaiNhanKhau>();

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
                                BanKhaiNhanKhau bknk = GetFromReader(reader);

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

        public BanKhaiNhanKhau Read(string ma)
        {
            string query = string.Empty;
            query += "SELECT TOP 1 * ";
            query += "FROM [BAN_KHAI_NHAN_KHAU] WHERE [Ma]=@Ma";

            BanKhaiNhanKhau bknk = new BanKhaiNhanKhau();

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

                        bknk = GetFromReader(reader);

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
            return bknk;
        }

        private BanKhaiNhanKhau GetFromReader(SqlDataReader reader)
        {
            BanKhaiNhanKhau bknk = new BanKhaiNhanKhau();

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
            bknk.ChuyenMon = reader["ChuyenMon"].ToString();
            bknk.TrinhDoHocVan = reader["TrinhDoHocVan"].ToString();
            bknk.BietTiengDanToc = reader["BietTiengDanToc"].ToString();
            bknk.TrinhDoNgoaiNgu = reader["TrinhDoNgoaiNgu"].ToString();
            bknk.NoiOHienNay = reader["NoiOHienNay"].ToString();
            bknk.DanhSachNguoiCungDi = reader["DanhSachNguoiCungDi"].ToString();
            bknk.NoiCap = reader["NoiCap"].ToString();
            bknk.NguoiCap = reader["NguoiCap"].ToString();
            bknk.DanhSachQuanHeGiaDinh = reader["DanhSachQuanHeGiaDinh"].ToString();
            bknk.DanhSachTienAn = reader["DanhSachTienAn"].ToString();
            bknk.DanhSachKhenThuong = reader["DanhSachKhenThuong"].ToString();

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
