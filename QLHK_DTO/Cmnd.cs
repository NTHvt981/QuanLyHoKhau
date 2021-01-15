using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    public class Cmnd
    {
        private int ma = Init.INT;
        private string soCmnd = Init.STRING;
        private string hoTen = Init.STRING;
        private DateTime ngaySinh = Init.DATE;
        private string queQuan = Init.STRING;
        private string diaChiHoKhau = Init.STRING;
        private string danToc = Init.STRING;
        private string tonGiao = Init.STRING;
        private string dacDiemNhanDang = Init.STRING;
        private DateTime ngayCap = Init.DATE;
        private string noiCap = Init.STRING;
        private string nguoiCap = Init.STRING;

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

        public void Update(CongDan congDan)
        {
            congDan.HoTen = HoTen;
            congDan.SoCmnd = SoCmnd;
            congDan.NgaySinh = NgaySinh;
            congDan.QueQuan = QueQuan;
            congDan.DiaChiHoKhau = DiaChiHoKhau;

            congDan.DacDiemNhanDang = DacDiemNhanDang;
            congDan.DanToc = DanToc;
            congDan.HoTen = HoTen;
            congDan.TonGiao = TonGiao;
        }
    }
}
