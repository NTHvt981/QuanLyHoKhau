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
    public class CccdDAL
    {
        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        private static CccdDAL instance;

        public static CccdDAL GetInstance()
        {
            if (instance == null)
                instance = new CccdDAL();
            return instance;
        }
        public bool Add(Cccd cd)
        {
            string query = string.Empty;
            query += @"
                INSERT INTO [CCCD] (
                [SoCccd], [HoTen], [GioiTinh], [NgaySinh], [QueQuan], [QuocTich], 
                [DiaChiHoKhau], [ThoiHan], [DacDiemNhanDang], [NgayCap], [NoiCap], [NguoiCap]) 
                VALUES 
                (@SoCccd, @HoTen, @GioiTinh, @NgaySinh, @QueQuan, @QuocTich, @DiaChiHoKhau, 
                @ThoiHan, @DacDiemNhanDang, @NgayCap, @NoiCap, @NguoiCap)";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@SoCccd", cd.SoCccd);
                    cmd.Parameters.AddWithValue("@HoTen", cd.HoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", cd.GioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", cd.NgaySinh);
                    cmd.Parameters.AddWithValue("@QueQuan", cd.QueQuan);
                    cmd.Parameters.AddWithValue("@QuocTich", cd.QuocTich);
                    cmd.Parameters.AddWithValue("@DiaChiHoKhau", cd.DiaChiHoKhau);
                    cmd.Parameters.AddWithValue("@ThoiHan", cd.ThoiHan);
                    cmd.Parameters.AddWithValue("@DacDiemNhanDang", cd.DacDiemNhanDang);
                    cmd.Parameters.AddWithValue("@NgayCap", cd.NgayCap);
                    cmd.Parameters.AddWithValue("@NoiCap", cd.NoiCap);
                    cmd.Parameters.AddWithValue("@NguoiCap", cd.NguoiCap);


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
        public bool Update(Cccd cd)
        {
            string query = string.Empty;
            query += "UPDATE [CCCD] SET ";
            query += "[SoCccd] = @SoCccd, ";
            query += "[HoTen] = @HoTen, ";
            query += "[GioiTinh] = @GioiTinh, ";
            query += "[NgaySinh] = @NgaySinh, ";
            query += "[QueQuan] = @QueQuan, ";
            query += "[QuocTich] = @QuocTich, ";
            query += "[DiaChiHoKhau] = @DiaChiHoKhau, ";
            query += "[ThoiHan] = @ThoiHan, ";
            query += "[DacDiemNhanDang] = @DacDiemNhanDang, ";
            query += "[NgayCap] = @NgayCap, ";
            query += "[NoiCap] = @NoiCap, ";
            query += "[NguoiCap] = @NguoiCap ";
            query += "WHERE [Ma] = @Ma";

            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@Ma", cd.Ma);
                    cmd.Parameters.AddWithValue("@HoTen", cd.HoTen);
                    cmd.Parameters.AddWithValue("@SoCccd", cd.SoCccd);
                    cmd.Parameters.AddWithValue("@GioiTinh", cd.GioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", cd.NgaySinh);
                    cmd.Parameters.AddWithValue("@QueQuan", cd.QueQuan);
                    cmd.Parameters.AddWithValue("@QuocTich", cd.QuocTich);
                    cmd.Parameters.AddWithValue("@DiaChiHoKhau", cd.DiaChiHoKhau);
                    cmd.Parameters.AddWithValue("@ThoiHan", cd.ThoiHan);
                    cmd.Parameters.AddWithValue("@DacDiemNhanDang", cd.DacDiemNhanDang);
                    cmd.Parameters.AddWithValue("@NgayCap", cd.NgayCap);
                    cmd.Parameters.AddWithValue("@NoiCap", cd.NoiCap);
                    cmd.Parameters.AddWithValue("@NguoiCap", cd.NguoiCap);

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
        public bool Delete(Cccd cd)
        {
            string query = string.Empty;
            query += "DELETE FROM [CCCD] WHERE [Ma] = @Ma";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Ma", cd.Ma);
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


        public Cccd Read(string ma)
        {
            string query = string.Empty;
            query += "SELECT TOP 1 * ";
            query += "FROM [CCCD] WHERE [SoCccd]=@SoCccd";

            Cccd cd = new Cccd();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@SoCccd", ma);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;

                        reader = cmd.ExecuteReader();
                        reader.Read();

                        cd = GetFromReader(reader);

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

        private Cccd GetFromReader(SqlDataReader reader)
        {
            Cccd cd = new Cccd();

            cd.Ma = int.Parse(reader["Ma"].ToString());
            cd.SoCccd = reader["SoCccd"].ToString();
            cd.HoTen = reader["HoTen"].ToString();
            cd.GioiTinh = reader["GioiTinh"].ToString();
            cd.QueQuan = reader["QueQuan"].ToString();
            cd.QuocTich = reader["QuocTich"].ToString();
            cd.DiaChiHoKhau = reader["DiaChiHoKhau"].ToString();
            cd.ThoiHan = DateTime.Parse( reader["ThoiHan"].ToString());
            cd.DacDiemNhanDang = reader["DacDiemNhanDang"].ToString();
            cd.NgayCap = DateTime.Parse(reader["NgayCap"].ToString());
            cd.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
            cd.NoiCap = reader["NoiCap"].ToString();
            cd.NguoiCap = reader["NguoiCap"].ToString();

            return cd;
        }
    }
}
