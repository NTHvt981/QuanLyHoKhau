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
    public class HoKhauDAL
    {
        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        private static HoKhauDAL instance;

        public static HoKhauDAL GetInstance()
        {
            if (instance == null)
                instance = new HoKhauDAL();
            return instance;
        }

        public bool Add(HoKhau cd)
        {
            string query = string.Empty;
            query += @"
                INSERT INTO [HO_KHAU] (
                    [SoSo], 
                    [ChuHo], 
                    [DiaChi], 
                    [NgayLap], 
                    [LoaiSo], 
                    [LyDoLap], 
                    [NguoiLam]
                    )";
            query += @"VALUES (
                @SoSo, 
                @ChuHo, 
                @DiaChi, 
                @NgayLap, 
                @LoaiSo, 
                @LyDoLap, 
                @NguoiLam
                )";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@SoSo", cd.SoSo);
                    cmd.Parameters.AddWithValue("@ChuHo", cd.ChuHo);
                    cmd.Parameters.AddWithValue("@DiaChi", cd.DiaChi);
                    cmd.Parameters.AddWithValue("@NgayLap", cd.NgayLap);
                    cmd.Parameters.AddWithValue("@LoaiSo", cd.LoaiSo);
                    cmd.Parameters.AddWithValue("@LyDoLap", cd.LyDoLap);
                    cmd.Parameters.AddWithValue("@NguoiLam", cd.NguoiLam);

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
        public bool Update(HoKhau cd)
        {
            string query = string.Empty;
            query += "UPDATE [HO_KHAU] SET ";
            query += "[SoSo] = @SoSo, ";
            query += "[ChuHo] = @ChuHo, ";
            query += "[DiaChi] = @DiaChi, ";
            query += "[NgayLap] = @NgayLap, ";
            query += "[LoaiSo] = @LoaiSo, ";
            query += "[LyDoLap] = @LyDoLap, ";
            query += "[NguoiLam] = @NguoiLam ";
            query += "WHERE [Ma] = @Ma";

            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@Ma", cd.Ma);
                    cmd.Parameters.AddWithValue("@SoSo", cd.SoSo);
                    cmd.Parameters.AddWithValue("@ChuHo", cd.ChuHo);
                    cmd.Parameters.AddWithValue("@DiaChi", cd.DiaChi);
                    cmd.Parameters.AddWithValue("@NgayLap", cd.NgayLap);
                    cmd.Parameters.AddWithValue("@LoaiSo", cd.LoaiSo);
                    cmd.Parameters.AddWithValue("@LyDoLap", cd.LyDoLap);
                    cmd.Parameters.AddWithValue("@NguoiLam", cd.NguoiLam);

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
        public bool Delete(HoKhau cd)
        {
            string query = string.Empty;
            query += "DELETE FROM [HO_KHAU] WHERE [Ma] = @Ma";
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
        public bool DeleteAll()
        {
            string query = string.Empty;
            query += "DELETE FROM [HO_KHAU]";
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

        public List<HoKhau> ReadAll()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [HO_KHAU]";

            List<HoKhau> congDans = new List<HoKhau>();

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
                                HoKhau cd = GetFromReader(reader);

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
        public List<HoKhau> ReadAllByKeyword(string key)
        {
            string query = string.Empty;
            query += @"select * from [HO_KHAU]
                    where
                        SoSo like @Param or
                        ChuHo like @Param or
                        DiaChi like @Param or
                        LoaiSo like @Param or
                        LyDoLap like @Param or
                        NguoiLam like @Param
            ";

            List<HoKhau> congDans = new List<HoKhau>();

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
                                HoKhau cd = GetFromReader(reader);

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

        public HoKhau Read(string ma)
        {
            string query = string.Empty;
            query += "SELECT TOP 1 * ";
            query += "FROM [HO_KHAU] WHERE [Ma]=@Ma";

            HoKhau cd = new HoKhau();

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

        private HoKhau GetFromReader(SqlDataReader reader)
        {
            HoKhau hk = new HoKhau();

            hk.Ma = int.Parse(reader["Ma"].ToString());
            hk.SoSo = reader["SoSo"].ToString();
            hk.ChuHo = reader["ChuHo"].ToString();
            hk.DiaChi = reader["DiaChi"].ToString();
            hk.NgayLap = DateTime.Parse(reader["NgayLap"].ToString());
            hk.LoaiSo = reader["LoaiSo"].ToString();
            hk.LyDoLap = reader["LyDoLap"].ToString();
            hk.NguoiLam = reader["NguoiLam"].ToString();

            return hk;
        }
    }
}
