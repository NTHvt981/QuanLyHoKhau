using QLHK_DTO;
using QLHK_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_BUS
{
    public class HoKhauBUS
    {
        public bool Add(HoKhau cd)
        {
            return HoKhauDAL.GetInstance().Add(cd);
        }
        public bool Update(HoKhau cd)
        {
            return HoKhauDAL.GetInstance().Update(cd);
        }
        public bool Delete(HoKhau cd)
        {
            return HoKhauDAL.GetInstance().Delete(cd);
        }
        public bool DeleteAll()
        {
            return HoKhauDAL.GetInstance().DeleteAll();
        }

        public List<HoKhau> ReadAll()
        {
            return HoKhauDAL.GetInstance().ReadAll();
        }
        public List<HoKhau> ReadAllByKeyWord(string key)
        {
            return HoKhauDAL.GetInstance().ReadAllByKeyword(key);
        }

        public HoKhau Read(string ma)
        {
            return HoKhauDAL.GetInstance().Read(ma);
        }

        public bool Validate(CongDan cd, ref string error)
        {
            if (DKHoTenTrong(cd))
            {
                error = "họ tên không để trống";
                return false;
            }

            if (DKGioiTinhTrong(cd))
            {
                error = "giới tính không để trống";
                return false;
            }

            if (DKNgaySinhTrong(cd))
            {
                error = "ngày sinh không để trống";
                return false;
            }

            if (DKQueQuanTrong(cd))
            {
                error = "quê quán không để trống";
                return false;
            }

            if (DKQuocTichTrong(cd))
            {
                error = "quốc tịch không để trống";
                return false;
            }

            return true;
        }

        private bool DKHoTenTrong(CongDan phieu)
        {
            return string.IsNullOrEmpty(phieu.HoTen.Trim());
        }

        private bool DKNgaySinhTrong(CongDan phieu)
        {
            return phieu.NgaySinh == null;
        }

        private bool DKGioiTinhTrong(CongDan phieu)
        {
            return string.IsNullOrEmpty(phieu.GioiTinh.Trim());
        }

        private bool DKQueQuanTrong(CongDan phieu)
        {
            return string.IsNullOrEmpty(phieu.QueQuan.Trim());
        }

        private bool DKQuocTichTrong(CongDan phieu)
        {
            return string.IsNullOrEmpty(phieu.QuocTich.Trim());
        }
    }
}
