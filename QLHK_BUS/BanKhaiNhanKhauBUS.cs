using QLHK_DAL;
using QLHK_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_BUS
{
    public class BanKhaiNhanKhauBUS
    {
        public bool Add(BanKhaiNhanKhau bknk)
        {
            return BanKhaiNhanKhauDAL.GetInstance().Add(bknk);
        }
        public bool Delete(BanKhaiNhanKhau bknk)
        {
            return BanKhaiNhanKhauDAL.GetInstance().Add(bknk);
        }
        public bool DeleteAll()
        {
            return BanKhaiNhanKhauDAL.GetInstance().DeleteAll();
        }

        public List<BanKhaiNhanKhau> ReadAll()
        {
            return BanKhaiNhanKhauDAL.GetInstance().ReadAll();
        }
        public List<BanKhaiNhanKhau> ReadAllByKeyword(string key)
        {
            return BanKhaiNhanKhauDAL.GetInstance().ReadAllByKeyword(key);
        }

        public bool Validate(BanKhaiNhanKhau banKhai, ref string error)
        {
            if (DKHoTenTrong(banKhai))
            {
                error = "Họ tên không để trống";
                return false;
            }

            if (DKSoCmndCccdTrong(banKhai))
            {
                error = "Số cmnd/cccd không để trống";
                return false;
            }

            if (DKSoCmndCccdKhongHopLe(banKhai))
            {
                error = "Số cmnd/cccd không hợp lệ";
                return false;
            }

            if (DKMaHoKhauTrong(banKhai))
            {
                error = "Mã hộ khẩu không để trống";
                return false;
            }

            if (DKNguoiCapTrong(banKhai))
            {
                error = "tên người cấp không để trống";
                return false;
            }

            if (DKNoiCapTrong(banKhai))
            {
                error = "nơi cấp không để trống";
                return false;
            }

            if (DKChuHoTrong(banKhai))
            {
                error = "tên chủ hộ không để trống";
                return false;
            }

            return true;
        }

        private bool DKHoTenTrong(BanKhaiNhanKhau banKhai)
        {
            return string.IsNullOrEmpty(banKhai.HoTen.Trim());
        }

        private bool DKSoCmndCccdTrong(BanKhaiNhanKhau banKhai)
        {
            return string.IsNullOrEmpty(banKhai.SoCmndCccd.Trim());
        }
        private bool DKSoCmndCccdKhongHopLe(BanKhaiNhanKhau banKhai)
        {
            if (banKhai.SoCmndCccd.Length != 9 && banKhai.SoCmndCccd.Length != 12)
                return true;

            return false;
        }

        private bool DKMaHoKhauTrong(BanKhaiNhanKhau banKhai)
        {
            return string.IsNullOrEmpty(banKhai.SoHoSo.Trim());
        }

        private bool DKNguoiCapTrong(BanKhaiNhanKhau banKhai)
        {
            return string.IsNullOrEmpty(banKhai.NguoiCap.Trim());
        }

        private bool DKNoiCapTrong(BanKhaiNhanKhau banKhai)
        {
            return string.IsNullOrEmpty(banKhai.NoiCap.Trim());
        }

        private bool DKChuHoTrong(BanKhaiNhanKhau banKhai)
        {
            return string.IsNullOrEmpty(banKhai.ChuHo.Trim());
        }
    }
}
