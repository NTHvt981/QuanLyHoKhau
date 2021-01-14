using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    public class BanKhaiNhanKhau
    {
        private string danhSachKhenThuong = "";
        private string danhSachTienAn = "";
        private string danhSachQuanHeGiaDinh = "";
        private string nguoiCap = "";
        private string noiCap = "";
        private DateTime ngayCap = DateTime.Now;
        private string danhSachNguoiCungDi = "";
        private string noiOHienNay = "";
        private string trinhDoNgoaiNgu = "";
        private string bietTiengDanToc = "";
        private string trinhDoHocVan = "";
        private string chuyenMon = "";
        private string ngheNghiep = "";
        private string dacDiemNhanDang = "";
        private string danToc = "";
        private string diaChiHoKhau = "";
        private string queQuan = "";
        private DateTime ngaySinh = DateTime.Now;
        private string tenThuongGoi = "";
        private string soHoSo = "";
        private string chuHo = "";
        private string hoTen = "";
        private string soCmndCccd = "";
        private int ma = -1;

        public string DanhSachKhenThuong { get => danhSachKhenThuong; set => danhSachKhenThuong = value; }
        public string DanhSachTienAn { get => danhSachTienAn; set => danhSachTienAn = value; }
        public string DanhSachQuanHeGiaDinh { get => danhSachQuanHeGiaDinh; set => danhSachQuanHeGiaDinh = value; }
        public string NguoiCap { get => nguoiCap; set => nguoiCap = value; }
        public string NoiCap { get => noiCap; set => noiCap = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public string DanhSachNguoiCungDi { get => danhSachNguoiCungDi; set => danhSachNguoiCungDi = value; }
        public string NoiOHienNay { get => noiOHienNay; set => noiOHienNay = value; }
        public string TrinhDoNgoaiNgu { get => trinhDoNgoaiNgu; set => trinhDoNgoaiNgu = value; }
        public string BietTiengDanToc { get => bietTiengDanToc; set => bietTiengDanToc = value; }
        public string TrinhDoHocVan { get => trinhDoHocVan; set => trinhDoHocVan = value; }
        public string ChuyenMon { get => chuyenMon; set => chuyenMon = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public string DacDiemNhanDang { get => dacDiemNhanDang; set => dacDiemNhanDang = value; }
        public string DanToc { get => danToc; set => danToc = value; }
        public string DiaChiHoKhau { get => diaChiHoKhau; set => diaChiHoKhau = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string TenThuongGoi { get => tenThuongGoi; set => tenThuongGoi = value; }
        public string SoHoSo { get => soHoSo; set => soHoSo = value; }
        public string ChuHo { get => chuHo; set => chuHo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoCmndCccd { get => soCmndCccd; set => soCmndCccd = value; }
        public int Ma { get => ma; set => ma = value; }

        public bool CoCmnd()
        {
            return SoCmndCccd.Length == 9;
        }

        public bool CoCccd()
        {
            return SoCmndCccd.Length == 12;
        }

        public void Update(CongDan congDan, Cmnd cmnd, Cccd cccd)
        {
            congDan.HoTen = HoTen;
            congDan.DiaChiThuongTru = DiaChiHoKhau;
            congDan.NgaySinh = NgaySinh;
            congDan.QueQuan = QueQuan;
            congDan.QuocTich = "Việt nam";

            if (CoCccd())
            {
                cmnd.Ma = 0;
                cccd.SoCccd = SoCmndCccd;
                congDan.SoCccd = SoCmndCccd;
                congDan.Update(cccd);
            }
            else
            {
                cmnd.Ma = 0;
                cccd.Ma = 0;
            }
        }
    }
}
