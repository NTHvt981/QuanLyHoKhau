using QLHK_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_BUS
{
    class PhieuThayDoiHoKhauBUS
    {

        public bool Validate(PhieuThayDoiHoKhau phieu, ref string error)
        {
            if (DKHoTenTrong(phieu))
            {
                error = "Họ tên không để trống";
                return false;
            }

            if (DKSoCmndCccdTrong(phieu))
            {
                error = "Số cmnd/cccd không để trống";
                return false;
            }

            if (DKSoCmndCccdKhongHopLe(phieu))
            {
                error = "Số cmnd/cccd không hợp lệ";
                return false;
            }

            if (DKMaHoKhauTrong(phieu))
            {
                error = "Mã hộ khẩu không để trống";
                return false;
            }

            if (DKNguoiCapTrong(phieu))
            {
                error = "tên người cấp không để trống";
                return false;
            }

            if (DKNoiCapTrong(phieu))
            {
                error = "nơi cấp không để trống";
                return false;
            }

            if (DKChuHoTrong(phieu))
            {
                error = "tên chủ hộ không để trống";
                return false;
            }

            return true;
        }

        private bool DKHoTenTrong(PhieuThayDoiHoKhau phieu)
        {
            return string.IsNullOrEmpty(phieu.HoTen.Trim());
        }

        private bool DKSoCmndCccdTrong(PhieuThayDoiHoKhau phieu)
        {
            return string.IsNullOrEmpty(phieu.SoCmndCccd.Trim());
        }
        private bool DKSoCmndCccdKhongHopLe(PhieuThayDoiHoKhau phieu)
        {
            if (phieu.SoCmndCccd.Length != 9 && phieu.SoCmndCccd.Length != 12)
                return true;

            return false;
        }

        private bool DKMaHoKhauTrong(PhieuThayDoiHoKhau phieu)
        {
            return string.IsNullOrEmpty(phieu.SoHoSo.Trim());
        }

        private bool DKNguoiCapTrong(PhieuThayDoiHoKhau phieu)
        {
            return string.IsNullOrEmpty(phieu.NguoiCap.Trim());
        }

        private bool DKNoiCapTrong(PhieuThayDoiHoKhau phieu)
        {
            return string.IsNullOrEmpty(phieu.NoiCap.Trim());
        }

        private bool DKChuHoTrong(PhieuThayDoiHoKhau phieu)
        {
            return string.IsNullOrEmpty(phieu.ChuHo.Trim());
        }
    }
}
