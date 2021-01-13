using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QLHK_DTO;
using QLHK_DAL;

namespace QLHK_BUS
{
    public class PhieuTamVangBUS
    {
        public const string ERROR_CMND_CCCD_TRONG = "Số CMND/CCCD không để trống";

        public bool Add(PhieuTamVang cd)
        {
            return PhieuTamVangDAL.GetInstance().Add(cd);
        }
        public bool Update(PhieuTamVang cd)
        {
            return PhieuTamVangDAL.GetInstance().Update(cd);
        }
        public bool Delete(PhieuTamVang cd)
        {
            return PhieuTamVangDAL.GetInstance().Delete(cd);
        }
        public bool DeleteAll()
        {
            return PhieuTamVangDAL.GetInstance().DeleteAll();
        }

        public List<PhieuTamVang> ReadAll()
        {
            return PhieuTamVangDAL.GetInstance().ReadAll();
        }
        public List<PhieuTamVang> ReadAllByKeyWord(string key)
        {
            return PhieuTamVangDAL.GetInstance().ReadAllByKeyword(key);
        }

        public PhieuTamVang Read(string ma)
        {
            return PhieuTamVangDAL.GetInstance().Read(ma);
        }

        public bool Validate(PhieuTamVang phieu, ref string error)
        {
            if (DKSoCmndCccdTrong(phieu))
            {
                error = ERROR_CMND_CCCD_TRONG;
                return false;
            }

            if (DKNguoiKhaiBaoTrong(phieu))
            {
                error = "Tên người khai báo không để trống";
                return false;
            }

            if (DKNgheNghiepTrong(phieu))
            {
                error = "Nghề nghiệp không để trống";
                return false;
            }

            if (DKNoiTamTruTrong(phieu))
            {
                error = "Nơi tạm trú không để trống";
                return false;
            }

            if (DKTenCanBoTrong(phieu))
            {
                error = "Tên cán bộ không để trống";
                return false;
            }

            if (DKLyDoTrong(phieu))
            {
                error = "Lý do không để trống";
                return false;
            }

            if (DKThoiGianBatDauTrong(phieu))
            {
                error = "Thời gian bắt đầu không để trống";
                return false;
            }

            if (DKThoiGianKetThucTrong(phieu))
            {
                error = "Thời gian kết thúc không để trống";
                return false;
            }

            if (DKNgayKhaiBaoTrong(phieu))
            {
                error = "Ngày khai báo không để trống";
                return false;
            }

            if (DKNgayDatDauKhongThoa(phieu))
            {
                error = "Ngày kết thúc >= Ngày bắt đầu";
                return false;
            }

            if (DKNgayKhaiBaoKhongThoa(phieu))
            {
                error = "Ngày khai báo <= Ngày bắt đầu";
                return false;
            }

            return true;
        }

        private bool DKSoCmndCccdTrong(PhieuTamVang phieu)
        {
            return string.IsNullOrEmpty(phieu.SoCmndCccd.Trim());
        }

        private bool DKNguoiKhaiBaoTrong(PhieuTamVang phieu)
        {
            return string.IsNullOrEmpty(phieu.NguoiKhaiBao.Trim());
        }

        private bool DKNgheNghiepTrong(PhieuTamVang phieu)
        {
            return string.IsNullOrEmpty(phieu.NgheNghiep.Trim());
        }

        private bool DKNoiTamTruTrong(PhieuTamVang phieu)
        {
            return string.IsNullOrEmpty(phieu.NoiTamTru.Trim());
        }

        private bool DKTenCanBoTrong(PhieuTamVang phieu)
        {
            return string.IsNullOrEmpty(phieu.TenCanBo.Trim());
        }

        private bool DKLyDoTrong(PhieuTamVang phieu)
        {
            return string.IsNullOrEmpty(phieu.LyDo.Trim());
        }

        private bool DKThoiGianBatDauTrong(PhieuTamVang phieu)
        {
            return phieu.ThoiGianBatDau == null;
        }

        private bool DKThoiGianKetThucTrong(PhieuTamVang phieu)
        {
            return phieu.ThoiGianKetThuc == null;
        }

        private bool DKNgayKhaiBaoTrong(PhieuTamVang phieu)
        {
            return phieu.NgayKhaiBao == null;
        }

        private bool DKNgayDatDauKhongThoa(PhieuTamVang phieu)
        {
            return !(phieu.ThoiGianKetThuc >= phieu.ThoiGianBatDau);
        }

        private bool DKNgayKhaiBaoKhongThoa(PhieuTamVang phieu)
        {
            return !(phieu.ThoiGianBatDau >= phieu.NgayKhaiBao);
        }
    }
}
