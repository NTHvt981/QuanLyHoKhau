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
    public class TaiKhoanDAL
    {
        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        private static TaiKhoanDAL instance;

        public static TaiKhoanDAL GetInstance()
        {
            if (instance == null)
                instance = new TaiKhoanDAL();
            return instance;
        }

        public bool Add(TaiKhoan tk)
        {
            string query = string.Empty;
            query += @"
                INSERT INTO [TAI_KHOAN] ";
            query += @"VALUES (
                @TenNguoiDung, 
                @TenHienThi, 
                @MatKhau, 
                )";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    SetParam(tk, cmd);

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

        private static void SetParam(TaiKhoan tk, SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@TenNguoiDung", tk.TenNguoiDung);
            cmd.Parameters.AddWithValue("@TenHienThi", tk.TenHienThi);
            cmd.Parameters.AddWithValue("@MatKhau", tk.MatKhau);
        }

        public bool Update(TaiKhoan tk)
        {
            string query = string.Empty;
            query += "UPDATE [TAI_KHOAN] SET ";
            query += "[TenHienThi] = @TenHienThi, ";
            query += "[MatKhau] = @MatKhau, ";
            query += "WHERE [TenNguoiDung] = @TenNguoiDung";

            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    SetParam(tk, cmd);

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
        public bool Delete(TaiKhoan tk)
        {
            string query = string.Empty;
            query += "DELETE FROM [TAI_KHOAN] WHERE [TenNguoiDung] = @TenNguoiDung";
            using (SqlConnection _cnn = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _cnn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenNguoiDung", tk.TenNguoiDung);
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

        public List<TaiKhoan> ReadAll()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [TAI_KHOAN]";

            List<TaiKhoan> phieus = new List<TaiKhoan>();

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
                                TaiKhoan tk = GetFromReader(reader);

                                phieus.Add(tk);
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
        public List<TaiKhoan> ReadAllByKeyword(string key)
        {
            string query = string.Empty;
            query += @"select * from [TAI_KHOAN]
                    where
                        TenNguoiDung like @Param or
                        TenHienThi like @Param or
                        MatKhau like @Param 
            ";

            List<TaiKhoan> phieus = new List<TaiKhoan>();

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
                                TaiKhoan tk = GetFromReader(reader);

                                phieus.Add(tk);
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

        public TaiKhoan Read(string tenTk)
        {
            string query = string.Empty;
            query += "SELECT TOP 1 * ";
            query += "FROM [TAI_KHOAN] WHERE [TenNguoiDung]=@TenNguoiDung";

            TaiKhoan tk = new TaiKhoan();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenNguoiDung", tenTk);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;

                        reader = cmd.ExecuteReader();
                        reader.Read();

                        tk = GetFromReader(reader);

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
            return tk;
        }

        private TaiKhoan GetFromReader(SqlDataReader reader)
        {
            TaiKhoan tk = new TaiKhoan();

            tk.TenNguoiDung = reader["TenNguoiDung"].ToString();
            tk.TenHienThi = reader["TenHienThi"].ToString();
            tk.MatKhau = reader["MatKhau"].ToString();

            return tk;
        }
    }
}
