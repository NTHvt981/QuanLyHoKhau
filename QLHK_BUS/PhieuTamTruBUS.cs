using QLHK_DAL;
using QLHK_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_BUS
{
    public class PhieuTamTruBUS
    {
        public bool Add(PhieuTamTru cd)
        {
            return PhieuTamTruDAL.GetInstance().Add(cd);
        }
        public bool Update(PhieuTamTru cd)
        {
            return PhieuTamTruDAL.GetInstance().Update(cd);
        }
        public bool Delete(PhieuTamTru cd)
        {
            return PhieuTamTruDAL.GetInstance().Delete(cd);
        }
        public bool DeleteAll()
        {
            return PhieuTamTruDAL.GetInstance().DeleteAll();
        }

        public List<PhieuTamTru> ReadAll()
        {
            return PhieuTamTruDAL.GetInstance().ReadAll();
        }
        public List<PhieuTamTru> ReadAllByKeyWord(string key)
        {
            return PhieuTamTruDAL.GetInstance().ReadAllByKeyword(key);
        }

        public PhieuTamTru Read(string ma)
        {
            return PhieuTamTruDAL.GetInstance().Read(ma);
        }

        public bool Validate(PhieuTamTru phieu, ref string error)
        {
            if (DKNguoiKhaiBaoTrong(phieu))
            {
                error = "Tên người khai báo không để trống";
                return false;
            }
            if (DKNoiTamTruTrong(phieu))
            {
                error = "Nơi tạm trú không để trống";
                return false;
            }
            if (DKLyDoTrong(phieu))
            {
                error = "Lý do không để trống";
                return false;
            }
            if (DKNgayGhiTrong(phieu))
            {
                error = "Ngày ghi phiếu không để trống";
                return false;
            }
            if (DKNoiGhiTrong(phieu))
            {
                error = "Nơi ghi phiếu không để trống";
                return false;
            }
            if (DKTenCanBoTrong(phieu))
            {
                error = "Tên cán bộ ghi phiếu không để trống";
                return false;
            }

            return true;
        }

        private bool DKNguoiKhaiBaoTrong(PhieuTamTru phieu)
        {
            return string.IsNullOrEmpty(phieu.NguoiKhaiBao.Trim());
        }

        private bool DKNoiTamTruTrong(PhieuTamTru phieu)
        {
            return string.IsNullOrEmpty(phieu.NoiTamTru.Trim());
        }

        private bool DKLyDoTrong(PhieuTamTru phieu)
        {
            return string.IsNullOrEmpty(phieu.LyDo.Trim());
        }

        private bool DKNgayGhiTrong(PhieuTamTru phieu)
        {
            return (phieu.NgayGhi == null);
        }

        private bool DKNoiGhiTrong(PhieuTamTru phieu)
        {
            return string.IsNullOrEmpty(phieu.NoiGhi.Trim());
        }

        private bool DKTenCanBoTrong(PhieuTamTru phieu)
        {
            return string.IsNullOrEmpty(phieu.TenCanBo.Trim());
        }
    }
}
