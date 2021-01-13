using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    class Utils
    {
        static void ChuyenHoKhau(PhieuThayDoiHoKhau doiHoKhau, HoKhau hoKhau)
        {
            hoKhau.ChuHo = doiHoKhau.ChuHo;
            hoKhau.DiaChi = doiHoKhau.DiaChiHoKhau;
            hoKhau.LyDoLap = "Đổi sổ";
            
            hoKhau.NgayLap = doiHoKhau.NgayCap;
            hoKhau.NguoiLam = doiHoKhau.NguoiCap;
        }

        static void ChuyenNhanKhau(CongDan congDan, Cmnd cmnd, Cccd cccd, BanKhaiNhanKhau banKhai)
        {
            congDan.HoTen = banKhai.HoTen;
            congDan.DiaChiThuongTru = banKhai.DiaChiHoKhau;
        }
    }
}
