using QLHK_DTO;
using QLHK_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_BUS
{
    public class CongDanBUS
    {
        public bool Add(CongDan cd)
        {
            return CongDanDAL.GetInstance().Add(cd);
        }
        public bool Update(CongDan cd)
        {
            return CongDanDAL.GetInstance().Update(cd);
        }
        public bool Delete(CongDan cd)
        {
            return CongDanDAL.GetInstance().Delete(cd);
        }

        public List<CongDan> ReadAll()
        {
            return CongDanDAL.GetInstance().ReadAll();
        }

        public CongDan Read(string ma)
        {
            return CongDanDAL.GetInstance().Read(ma);
        }

        public List<CongDan> ReadAllByMaHoKhau(string soSo)
        {
            return CongDanDAL.GetInstance().ReadAllByMaHoKhau(soSo);
        }
        public List<CongDan> ReadAllByKeyWord(string key)
        {
            return CongDanDAL.GetInstance().ReadAllByKeyWord(key);
        }

        public CongDan ReadByMaHoKhau(string soSo)
        {
            return CongDanDAL.GetInstance().ReadByMaHoKhau(soSo);
        }

        public bool ExistInDatabase(CongDan cd)
        {
            return !(cd.Ma == -1);
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
