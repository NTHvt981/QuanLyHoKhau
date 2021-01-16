using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    class PhieuChuyenKhau
    {
        private int ma = Init.INT;
        private int maCongDan = Init.INT;
        private int maHoKhauChuyenTu = Init.INT;
        private int maHoKhauChuyenDen = Init.INT;

        public CongDan congDan;
        public HoKhau hoKhauChuyenTu;
        public HoKhau hoKhauChuyenDen;

        public int MaHoKhauChuyenDen { get => maHoKhauChuyenDen; set => maHoKhauChuyenDen = value; }
        public int MaHoKhauChuyenTu { get => maHoKhauChuyenTu; set => maHoKhauChuyenTu = value; }
        public int MaCongDan { get => maCongDan; set => maCongDan = value; }
        public int Ma { get => ma; set => ma = value; }
    }
}
