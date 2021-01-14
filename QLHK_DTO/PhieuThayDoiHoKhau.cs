using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    public class PhieuThayDoiHoKhau
    {
        private int ma;
        private string maHoKhau = "";
        private string soCmndCccd = "";
        private string hoTen = "";
        private string chuHo = "";
        private string soHoSo = "";
        private string tenThuongGoi = "";
        private DateTime ngaySinh = DateTime.Now;
        private string queQuan = "";
        private string quocTich = "";
        private string diaChiHoKhau = "";
        private string dacDiemNhanDang = "";
        private string danToc = "";
        private string tonGiao = "";
        private string ngheNghiep = "";
        private DateTime ngayCap = DateTime.Now;
        private string noiCap = "";
        private string nguoiCap = "";

        public string NguoiCap { get => nguoiCap; set => nguoiCap = value; }
        public string NoiCap { get => noiCap; set => noiCap = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public string TonGiao { get => tonGiao; set => tonGiao = value; }
        public string DanToc { get => danToc; set => danToc = value; }
        public string DacDiemNhanDang { get => dacDiemNhanDang; set => dacDiemNhanDang = value; }
        public string DiaChiHoKhau { get => diaChiHoKhau; set => diaChiHoKhau = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string TenThuongGoi { get => tenThuongGoi; set => tenThuongGoi = value; }
        public string SoHoSo { get => soHoSo; set => soHoSo = value; }
        public string ChuHo { get => chuHo; set => chuHo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoCmndCccd { get => soCmndCccd; set => soCmndCccd = value; }
        public string MaHoKhau { get => maHoKhau; set => maHoKhau = value; }
        public int Ma { get => ma; set => ma = value; }

        public bool CoCmnd()
        {
            return SoCmndCccd.Length == 9;
        }

        public bool CoCccd()
        {
            return SoCmndCccd.Length == 12;
        }

        public void Update(CongDan congDan, HoKhau hk, Cmnd cmnd, Cccd cccd)
        {
            congDan.DiaChiThuongTru = DiaChiHoKhau;
            congDan.HoTen = HoTen;
            congDan.MaHoKhau = SoHoSo;
            congDan.NgaySinh = NgaySinh;
            congDan.QueQuan = QueQuan;
            congDan.QuocTich = "Việt Nam";
           
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

            hk.ChuHo = ChuHo;
            hk.DiaChi = DiaChiHoKhau;
            hk.LoaiSo = "K-13";
            hk.LyDoLap = "Chuyển khẩu";
            hk.NgayLap = DateTime.Now;
            hk.NguoiLam = NguoiCap;
            hk.SoSo = SoHoSo;
        }
    }
}
