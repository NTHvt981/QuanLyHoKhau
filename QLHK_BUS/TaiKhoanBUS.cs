using QLHK_DAL;
using QLHK_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_BUS
{
    public class TaiKhoanBUS
    {
        public bool Add(TaiKhoan cd)
        {
            return TaiKhoanDAL.GetInstance().Add(cd);
        }
        public bool Update(TaiKhoan cd)
        {
            return TaiKhoanDAL.GetInstance().Update(cd);
        }
        public bool Delete(TaiKhoan cd)
        {
            return TaiKhoanDAL.GetInstance().Delete(cd);
        }

        public List<TaiKhoan> ReadAllByKeyWord(string key)
        {
            return TaiKhoanDAL.GetInstance().ReadAllByKeyword(key);
        }

        public TaiKhoan Read(string tenTk)
        {
            return TaiKhoanDAL.GetInstance().Read(tenTk);
        }
        public bool ExistInDatabase(string ma)
        {
            return TaiKhoanDAL.GetInstance().Read(ma) != null;
        }
        public bool LogIn(string ten, string mk)
        {
            TaiKhoan tkSoSanh = TaiKhoanDAL.GetInstance().Read(ten);

            if (tkSoSanh == null) return false;

            return (mk == tkSoSanh.MatKhau);
        }

        public bool Validate(TaiKhoan tk, ref string error)
        {
            if (string.IsNullOrEmpty(tk.TenNguoiDung))
            {
                error = "Tên đăng nhập không để trống";
                return false;
            }

            if (string.IsNullOrEmpty(tk.TenHienThi))
            {
                error = "Tên hiển thị không để trống";
                return false;
            }

            if (string.IsNullOrEmpty(tk.MatKhau))
            {
                error = "Mật khẩu không để trống";
                return false;
            }

            return true;
        }
    }
}
