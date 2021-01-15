using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    public class Cccd
    {
        private int ma = Init.INT;
        private string soCccd = Init.STRING;
        private string hoTen = Init.STRING;
        private DateTime ngaySinh = Init.DATE;
        private string gioiTinh = Init.STRING;
        private string queQuan = Init.STRING;
        private string quocTich = Init.STRING;
        private string diaChiHoKhau = Init.STRING;
        private DateTime thoiHan = Init.DATE;
        private string dacDiemNhanDang = Init.STRING;
        private DateTime ngayCap = Init.DATE;
        private string noiCap = Init.STRING;
        private string nguoiCap = Init.STRING;

        public string NguoiCap { get => nguoiCap; set => nguoiCap = value; }
        public string NoiCap { get => noiCap; set => noiCap = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public string DacDiemNhanDang { get => dacDiemNhanDang; set => dacDiemNhanDang = value; }
        public DateTime ThoiHan { get => thoiHan; set => thoiHan = value; }
        public string DiaChiHoKhau { get => diaChiHoKhau; set => diaChiHoKhau = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoCccd { get => soCccd; set => soCccd = value; }
        public int Ma { get => ma; set => ma = value; }

        public void Update(CongDan congDan)
        {
            congDan.HoTen = HoTen;
            congDan.SoCccd = SoCccd;
            congDan.NgaySinh = NgaySinh;
            congDan.QueQuan = QueQuan;
            congDan.DiaChiHoKhau = DiaChiHoKhau;
            congDan.QuocTich = QuocTich;
            congDan.GioiTinh = GioiTinh;

            congDan.DacDiemNhanDang = DacDiemNhanDang;
            congDan.HoTen = HoTen;
        }
    }
}
