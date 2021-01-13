using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    public class BanKhaiNhanKhau
    {
        public string DanhSachKhenThuong { get; set; }
        public string DanhSachTienAn { get; set; }
        public string DanhSachQuanHeGiaDinh { get; set; }
        public string NguoiCap { get; set; }
        public string NoiCap { get; set; }
        public DateTime NgayCap { get; set; }
        public string DanhSachNguoiCungDi { get; set; }
        public string NoiOHienNay { get; set; }
        public string TrinhDoNgoaiNgu { get; set; }
        public string BietTiengDanToc { get; set; }
        public string TrinhDoHocVan { get; set; }
        public string ChuyenMon { get; set; }
        public string NgheNghiep { get; set; }
        public string DacDiemNhanDang { get; set; }
        public string DanToc { get; set; }
        public string DiaChiHoKhau { get; set; }
        public string QueQuan { get; set; }
        public DateTime NgaySinh { get; set; }
        public string TenThuongGoi { get; set; }
        public string SoHoSo { get; set; }
        public string ChuHo { get; set; }
        public string HoTen { get; set; }
        public string SoCmndCccd { get; set; }
        public int Ma { get; set; }

        public bool CoCmnd()
        {
            return SoCmndCccd.Length == 9;
        }

        public bool CoCccd()
        {
            return SoCmndCccd.Length == 12;
        }
    }
}
