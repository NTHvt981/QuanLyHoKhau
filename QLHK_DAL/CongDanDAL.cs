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
    public class CongDanDAL
    {
        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        private static CongDanDAL instance;

        public static CongDanDAL GetInstance()
        {
            if (instance == null)
                instance = new CongDanDAL();
            return instance;
        }
        public bool Add(CongDan cd)
        {
            string query = string.Empty;
            query += "INSERT INTO [CONG_DAN] ([SoCmnd], [SoCccd], [MaHoKhau], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [QuocTich], [DiaChiThuongTru], [HoTenBo], [HoTenMe])";
            query += "VALUES (@SoCmnd, @SoCccd, @MaHoKhau, @HoTen, @NgaySinh, @GioiTinh, @QueQuan, @QuocTich, @DiaChiThuongTru, @HoTenBo, @HoTenMe)";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@MaHoKhau", cd.MaHoKhau);
                    cmd.Parameters.AddWithValue("@HoTen", cd.HoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", cd.NgaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", cd.GioiTinh);
                    cmd.Parameters.AddWithValue("@QueQuan", cd.QueQuan);
                    cmd.Parameters.AddWithValue("@QuocTich", cd.QuocTich);
                    cmd.Parameters.AddWithValue("@DiaChiThuongTru", cd.DiaChiThuongTru);
                    cmd.Parameters.AddWithValue("@HoTenBo", cd.HoTenBo);
                    cmd.Parameters.AddWithValue("@HoTenMe", cd.HoTenMe);


                    if (!string.IsNullOrEmpty(cd.SoCccd))
                        cmd.Parameters.AddWithValue("@SoCccd", cd.SoCccd);
                    else
                        cmd.Parameters.AddWithValue("@SoCccd", DBNull.Value);
                    if (!string.IsNullOrEmpty(cd.SoCmnd))
                        cmd.Parameters.AddWithValue("@SoCmnd", cd.SoCmnd);
                    else
                        cmd.Parameters.AddWithValue("@SoCmnd", DBNull.Value);

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
        public bool Update(CongDan cd)
        {
            string query = string.Empty;
            query += "UPDATE [CONG_DAN] SET "; 
            query += "[SoCmnd] = @SoCmnd, ";
            query += "[SoCccd] = @SoCccd, ";
            query += "[MaHoKhau] = @MaHoKhau, ";
            query += "[HoTen] = @HoTen, ";
            query += "[NgaySinh] = @NgaySinh, ";
            query += "[GioiTinh] = @GioiTinh, ";
            query += "[QueQuan] = @QueQuan, ";
            query += "[QuocTich] = @QuocTich, ";
            query += "[DiaChiThuongTru] = @DiaChiThuongTru, ";
            query += "[HoTenBo] = @HoTenBo, ";
            query += "[HoTenMe] = @HoTenMe ";
            query += "WHERE [Ma] = @Ma";

            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@Ma", cd.Ma);
                    cmd.Parameters.AddWithValue("@MaHoKhau", cd.MaHoKhau);
                    cmd.Parameters.AddWithValue("@HoTen", cd.HoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", cd.NgaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", cd.GioiTinh);
                    cmd.Parameters.AddWithValue("@QueQuan", cd.QueQuan);
                    cmd.Parameters.AddWithValue("@QuocTich", cd.QuocTich);
                    cmd.Parameters.AddWithValue("@DiaChiThuongTru", cd.DiaChiThuongTru);
                    cmd.Parameters.AddWithValue("@HoTenBo", cd.HoTenBo);
                    cmd.Parameters.AddWithValue("@HoTenMe", cd.HoTenMe);

                    //cmd.Parameters.AddWithValue("@SoCccd", cd.SoCccd);
                    //cmd.Parameters.AddWithValue("@SoCmnd", cd.SoCmnd);

                    if (!string.IsNullOrEmpty(cd.SoCccd))
                        cmd.Parameters.AddWithValue("@SoCccd", cd.SoCccd);
                    else
                        cmd.Parameters.AddWithValue("@SoCccd", DBNull.Value);
                    if (!string.IsNullOrEmpty(cd.SoCmnd))
                        cmd.Parameters.AddWithValue("@SoCmnd", cd.SoCmnd);
                    else
                        cmd.Parameters.AddWithValue("@SoCmnd", DBNull.Value);

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
        public bool Delete(CongDan cd)
        {
            string query = string.Empty;
            query += "DELETE FROM [CONG_DAN] WHERE [Ma] = @Ma";
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

        public List<CongDan> ReadAll()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [CONG_DAN]";

            List<CongDan> congDans = new List<CongDan>();

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
                                CongDan cd = new CongDan();

                                cd.Ma = int.Parse(reader["Ma"].ToString());
                                cd.SoCmnd = reader["SoCmnd"].ToString();
                                cd.SoCccd = reader["SoCccd"].ToString();
                                cd.MaHoKhau = reader["MaHoKhau"].ToString();
                                cd.HoTen = reader["HoTen"].ToString();
                                cd.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                                cd.GioiTinh = reader["GioiTinh"].ToString();
                                cd.QueQuan = reader["QueQuan"].ToString();
                                cd.QuocTich = reader["QuocTich"].ToString();
                                cd.DiaChiThuongTru = reader["DiaChiThuongTru"].ToString();
                                cd.HoTenBo = reader["HoTenBo"].ToString();
                                cd.HoTenMe = reader["HoTenMe"].ToString();

                                congDans.Add(cd);
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

        public CongDan Read(string ma)
        {
            string query = string.Empty;
            query += "SELECT TOP 1 * ";
            query += "FROM [CONG_DAN] WHERE [Ma]=@Ma";

            CongDan cd = new CongDan();

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

                        cd.Ma = int.Parse(reader["Ma"].ToString());
                        cd.SoCmnd = reader["SoCmnd"].ToString();
                        cd.SoCccd = reader["SoCccd"].ToString();
                        cd.MaHoKhau = reader["MaHoKhau"].ToString();
                        cd.HoTen = reader["HoTen"].ToString();
                        cd.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                        cd.GioiTinh = reader["GioiTinh"].ToString();
                        cd.QueQuan = reader["QueQuan"].ToString();
                        cd.QuocTich = reader["QuocTich"].ToString();
                        cd.DiaChiThuongTru = reader["DiaChiThuongTru"].ToString();
                        cd.HoTenBo = reader["HoTenBo"].ToString();
                        cd.HoTenMe = reader["HoTenMe"].ToString();

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


        public List<CongDan> ReadAllByMaHoKhau(string ma)
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [CONG_DAN] WHERE [MaHoKhau]=@Ma";

            List<CongDan> congDans = new List<CongDan>();

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
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                CongDan cd = new CongDan();

                                cd.Ma = int.Parse(reader["Ma"].ToString());
                                cd.SoCmnd = reader["SoCmnd"].ToString();
                                cd.SoCccd = reader["SoCccd"].ToString();
                                cd.MaHoKhau = reader["MaHoKhau"].ToString();
                                cd.HoTen = reader["HoTen"].ToString();
                                cd.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                                cd.GioiTinh = reader["GioiTinh"].ToString();
                                cd.QueQuan = reader["QueQuan"].ToString();
                                cd.QuocTich = reader["QuocTich"].ToString();
                                cd.DiaChiThuongTru = reader["DiaChiThuongTru"].ToString();
                                cd.HoTenBo = reader["HoTenBo"].ToString();
                                cd.HoTenMe = reader["HoTenMe"].ToString();

                                congDans.Add(cd);
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

        public CongDan ReadByMaHoKhau(string ma)
        {
            string query = string.Empty;
            query += "SELECT TOP 1 * ";
            query += "FROM [CONG_DAN] WHERE [MaHoKhau]=@Ma";

            CongDan cd = new CongDan();

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

                        cd.Ma = int.Parse(reader["Ma"].ToString());
                        cd.SoCmnd = reader["SoCmnd"].ToString();
                        cd.SoCccd = reader["SoCccd"].ToString();
                        cd.MaHoKhau = reader["MaHoKhau"].ToString();
                        cd.HoTen = reader["HoTen"].ToString();
                        cd.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                        cd.GioiTinh = reader["GioiTinh"].ToString();
                        cd.QueQuan = reader["QueQuan"].ToString();
                        cd.QuocTich = reader["QuocTich"].ToString();
                        cd.DiaChiThuongTru = reader["DiaChiThuongTru"].ToString();
                        cd.HoTenBo = reader["HoTenBo"].ToString();
                        cd.HoTenMe = reader["HoTenMe"].ToString();

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
