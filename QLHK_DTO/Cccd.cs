using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    public class Cccd
    {
        private int ma = -1;
        private string soCccd;
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string queQuan;
        private string quocTich;
        private string diaChiHoKhau;
        private DateTime thoiHan;
        private string dacDiemNhanDang;
        private DateTime ngayCap;
        private string noiCap;
        private string nguoiCap;

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
    }
}
