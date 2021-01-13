using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    public class CongDan
    {
        private int ma = -1;
        private string soCmnd;
        private string soCccd;
        private string maHoKhau;

        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string queQuan;
        private string quocTich;

        private string diaChiThuongTru;
        private string hoTenBo;
        private string hoTenMe;

        public int Ma { get => ma; set => ma = value; }
        public string SoCmnd { get => soCmnd; set => soCmnd = value; }
        public string SoCccd { get => soCccd; set => soCccd = value; }
        public string MaHoKhau { get => maHoKhau; set => maHoKhau = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
        public string DiaChiThuongTru { get => diaChiThuongTru; set => diaChiThuongTru = value; }
        public string HoTenBo { get => hoTenBo; set => hoTenBo = value; }
        public string HoTenMe { get => hoTenMe; set => hoTenMe = value; }

        public bool CoCmnd()
        {
            return !string.IsNullOrEmpty(SoCmnd);
        }

        public bool CoCccd()
        {
            return !string.IsNullOrEmpty(SoCccd);
        }
    }
}
