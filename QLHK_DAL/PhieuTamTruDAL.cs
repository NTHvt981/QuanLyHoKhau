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
    public class PhieuTamTruDAL
    {
        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        private static PhieuTamTruDAL instance;

        public static PhieuTamTruDAL GetInstance()
        {
            if (instance == null)
                instance = new PhieuTamTruDAL();
            return instance;
        }

        public bool Add(PhieuTamTru ptt)
        {
            string query = string.Empty;
            query += @"
                INSERT INTO [PHIEU_TAM_TRU] (
                    [NguoiKhaiBao], 
                    [NoiTamTru], 
                    [LyDo], 
                    [NgayGhi], 
                    [NoiGhi], 
                    [TenCanBo]
                    )";
            query += @"VALUES (
                @NguoiKhaiBao, 
                @NoiTamTru, 
                @LyDo, 
                @NgayGhi, 
                @NoiGhi, 
                @TenCanBo
                )";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@NguoiKhaiBao", ptt.NguoiKhaiBao);
                    cmd.Parameters.AddWithValue("@NoiTamTru", ptt.NoiTamTru);
                    cmd.Parameters.AddWithValue("@LyDo", ptt.LyDo);
                    cmd.Parameters.AddWithValue("@NgayGhi", ptt.NgayGhi);
                    cmd.Parameters.AddWithValue("@NoiGhi", ptt.NoiGhi);
                    cmd.Parameters.AddWithValue("@TenCanBo", ptt.TenCanBo);

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
        public bool Update(PhieuTamTru ptt)
        {
            string query = string.Empty;
            query += "UPDATE [PHIEU_TAM_TRU] SET ";
            query += "[NguoiKhaiBao] = @NguoiKhaiBao, ";
            query += "[NoiTamTru] = @NoiTamTru, ";
            query += "[LyDo] = @LyDo, ";
            query += "[NgayGhi] = @NgayGhi, ";
            query += "[NoiGhi] = @NoiGhi, ";
            query += "[TenCanBo] = @TenCanBo ";
            query += "WHERE [Ma] = @Ma";

            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@Ma", ptt.Ma);
                    cmd.Parameters.AddWithValue("@NguoiKhaiBao", ptt.NguoiKhaiBao);
                    cmd.Parameters.AddWithValue("@NoiTamTru", ptt.NoiTamTru);
                    cmd.Parameters.AddWithValue("@LyDo", ptt.LyDo);
                    cmd.Parameters.AddWithValue("@NgayGhi", ptt.NgayGhi);
                    cmd.Parameters.AddWithValue("@NoiGhi", ptt.NoiGhi);
                    cmd.Parameters.AddWithValue("@TenCanBo", ptt.TenCanBo);

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
        public bool Delete(PhieuTamTru ptt)
        {
            string query = string.Empty;
            query += "DELETE FROM [PHIEU_TAM_TRU] WHERE [Ma] = @Ma";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Ma", ptt.Ma);
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
            query += "DELETE FROM [PHIEU_TAM_TRU]";
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

        public List<PhieuTamTru> ReadAll()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [PHIEU_TAM_TRU]";

            List<PhieuTamTru> phieus = new List<PhieuTamTru>();

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
                                PhieuTamTru ptt = GetFromReader(reader);

                                phieus.Add(ptt);
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
        public List<PhieuTamTru> ReadAllByKeyword(string key)
        {
            string query = string.Empty;
            query += @"select * from [PHIEU_TAM_TRU]
                    where
                        NguoiKhaiBao like @Param or
                        NoiTamTru like @Param or
                        LyDo like @Param or
                        NoiGhi like @Param or
                        convert(nvarchar(25), NgayGhi, 25) like @Param or
                        TenCanBo like @Param
            ";

            List<PhieuTamTru> phieus = new List<PhieuTamTru>();

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
                                PhieuTamTru ptt = GetFromReader(reader);

                                phieus.Add(ptt);
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

        public PhieuTamTru Read(string ma)
        {
            string query = string.Empty;
            query += "SELECT TOP 1 * ";
            query += "FROM [PHIEU_TAM_TRU] WHERE [Ma]=@Ma";

            PhieuTamTru ptt = new PhieuTamTru();

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

                        ptt = GetFromReader(reader);

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
            return ptt;
        }

        private PhieuTamTru GetFromReader(SqlDataReader reader)
        {
            PhieuTamTru ptt = new PhieuTamTru();

            ptt.Ma = int.Parse(reader["Ma"].ToString());
            ptt.NguoiKhaiBao = reader["NguoiKhaiBao"].ToString();
            ptt.NoiTamTru = reader["NoiTamTru"].ToString();
            ptt.LyDo = reader["LyDo"].ToString();
            ptt.NoiGhi = reader["NoiGhi"].ToString();
            ptt.TenCanBo = reader["TenCanBo"].ToString();

            string NgayGhi;
            NgayGhi = reader["NgayGhi"].ToString();

            if (!string.IsNullOrEmpty(NgayGhi.Trim()))
                ptt.NgayGhi = DateTime.Parse(NgayGhi);

            return ptt;
        }
    }
}
