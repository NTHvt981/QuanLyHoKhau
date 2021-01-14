using QLHK_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_BUS
{
    public class ChuyenKhauBUS
    {
        HoKhauBUS HoKhauBUS;
        CongDanBUS congDanBUS;
        CmndBUS cmndBUS;
        CccdBUS cccdBUS;
        public bool ChuyenKhau(BanKhaiNhanKhau banKhai, PhieuThayDoiHoKhau phieu)
        {
            bool result;

            CongDan cd = new CongDan();
            HoKhau hk = new HoKhau();
            Cmnd cmnd = new Cmnd();
            Cccd cccd = new Cccd();

            banKhai.Update(cd, cmnd, cccd);
            phieu.Update(cd, hk, cmnd, cccd);

            result = HoKhauBUS.Add(hk);
            if (!result) return false;

            if (cccd.Ma != 0)
            {
                result = cccdBUS.Add(cccd);
                if (!result) return false;
            }

            result = congDanBUS.Add(cd);
            if (!result) return false;


            return true;
        }

        public bool Compare(BanKhaiNhanKhau banKhai, PhieuThayDoiHoKhau phieuThayDoi, ref string error)
        {
            if (banKhai.HoTen != phieuThayDoi.HoTen)
            {
                error = "Họ tên không đồng nhất";
                return false;
            }
            if (banKhai.ChuHo != phieuThayDoi.ChuHo)
            {
                error = "tên chủ hộ không đồng nhất";
                return false;
            }
            if (banKhai.DacDiemNhanDang != phieuThayDoi.DacDiemNhanDang)
            {
                error = "đặc điểm nhận dạng không đồng nhất";
                return false;
            }
            if (banKhai.DanToc != phieuThayDoi.DanToc)
            {
                error = "dân tộc không đồng nhất";
                return false;
            }
            if (banKhai.DiaChiHoKhau != phieuThayDoi.DiaChiHoKhau)
            {
                error = "dịa chỉ hộ khẩu không đồng nhất";
                return false;
            }
            if (banKhai.NgaySinh.Date != phieuThayDoi.NgaySinh.Date)
            {
                error = "ngày sinh không đồng nhất";
                return false;
            }
            if (banKhai.NgheNghiep != phieuThayDoi.NgheNghiep)
            {
                error = "nghề nghiệp không đồng nhất";
                return false;
            }
            if (banKhai.QueQuan != phieuThayDoi.QueQuan)
            {
                error = "quê quán không đồng nhất";
                return false;
            }
            if (banKhai.SoCmndCccd != phieuThayDoi.SoCmndCccd)
            {
                error = "Số cmnd/cccd không đồng nhất";
                return false;
            }
            if (banKhai.SoHoSo != phieuThayDoi.SoHoSo)
            {
                error = "Mã hộ khẩu mới không đồng nhất";
                return false;
            }

            return true;
        }

        public void UpdateData(
            BanKhaiNhanKhau banKhai, 
            PhieuThayDoiHoKhau phieu, 
            CongDan congDan,
            HoKhau hoKhau,
            Cmnd cmnd,
            Cccd cccd)
        {
            banKhai.Update(congDan, cmnd, cccd);
            phieu.Update(congDan, hoKhau, cmnd, cccd);
        }
    }
}
