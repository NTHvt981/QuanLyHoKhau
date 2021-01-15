using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    public class CongDan
    {
        private int ma = Init.INT;
        private string soCmnd;
        private string soCccd;
        private string maHoKhau;

        private string hoTen = Init.STRING;
        private DateTime ngaySinh = Init.DATE;
        private string gioiTinh = Init.STRING;
        private string queQuan = Init.STRING;
        private string quocTich = Init.STRING;
        private string danToc = Init.STRING;
        private string tonGiao = Init.STRING;
        private string dacDiemNhanDang = Init.STRING;
        private string diaChiHoKhau = Init.STRING;

        public int Ma { get => ma; set => ma = value; }
        public string SoCmnd { get => soCmnd; set => soCmnd = value; }
        public string SoCccd { get => soCccd; set => soCccd = value; }
        public string MaHoKhau { get => maHoKhau; set => maHoKhau = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
        public string DiaChiHoKhau { get => diaChiHoKhau; set => diaChiHoKhau = value; }
        public string DanToc { get => danToc; set => danToc = value; }
        public string TonGiao { get => tonGiao; set => tonGiao = value; }
        public string DacDiemNhanDang { get => dacDiemNhanDang; set => dacDiemNhanDang = value; }

        public bool CoCmnd()
        {
            return !string.IsNullOrEmpty(SoCmnd);
        }

        public bool CoCccd()
        {
            return !string.IsNullOrEmpty(SoCccd);
        }

        public void Update(Cmnd cmnd)
        {
            cmnd.HoTen = HoTen;
            cmnd.SoCmnd = SoCmnd;
            cmnd.NgaySinh = NgaySinh;
            cmnd.QueQuan = QueQuan;
            cmnd.DiaChiHoKhau = DiaChiHoKhau;

            cmnd.NgayCap = DateTime.Now;

            cmnd.DacDiemNhanDang = DacDiemNhanDang;
            cmnd.DanToc = DanToc;
            cmnd.HoTen = HoTen;
            cmnd.TonGiao = TonGiao;
        }

        public void Update(Cccd cccd)
        {
            cccd.HoTen = HoTen;
            cccd.SoCccd = SoCccd;
            cccd.NgaySinh = NgaySinh;
            cccd.QueQuan = QueQuan;
            cccd.DiaChiHoKhau = DiaChiHoKhau;
            cccd.QuocTich = QuocTich;
            cccd.GioiTinh = GioiTinh;

            cccd.NgayCap = DateTime.Now;

            cccd.DacDiemNhanDang = DacDiemNhanDang;
            cccd.HoTen = HoTen;
        }

        public void SetChuHo(HoKhau hk)
        {
            hk.TenChuHo = HoTen;
            hk.MaChuHo = Ma;
        }

        public void Update(PhieuTamVang ptv)
        {
            ptv.MaNguoiKhaiBao = Ma;
            ptv.TenNguoiKhaiBao = HoTen;
        }
    }
}
