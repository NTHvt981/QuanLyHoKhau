using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    public class Cmnd
    {
        private int ma;
        private string soCmnd;
        private string hoTen;
        private DateTime ngaySinh;
        private string queQuan;
        private string diaChiHoKhau;
        private string danToc;
        private string tonGiao;
        private string dacDiemNhanDang;
        private DateTime ngayCap;
        private string noiCap;
        private string nguoiCap;

        public string NguoiCap { get => nguoiCap; set => nguoiCap = value; }
        public string NoiCap { get => noiCap; set => noiCap = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public string DacDiemNhanDang { get => dacDiemNhanDang; set => dacDiemNhanDang = value; }
        public string TonGiao { get => tonGiao; set => tonGiao = value; }
        public string DanToc { get => danToc; set => danToc = value; }
        public string DiaChiHoKhau { get => diaChiHoKhau; set => diaChiHoKhau = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoCmnd { get => soCmnd; set => soCmnd = value; }
        public int Ma { get => ma; set => ma = value; }
    }
}
