using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    public class PhieuChuyenKhau
    {
        private int ma = Init.INT;
        private int maCongDan = Init.INT;
        private int maHoKhauChuyenTu = Init.INT;
        private int maHoKhauChuyenDen = Init.INT;
        private DateTime ngayChuyenKhau = Init.DATE;

        private CongDan congDanChuyenKhau;
        private HoKhau hoKhauChuyenTu;
        private HoKhau hoKhauChuyenDen;

        private string hoTen = Init.STRING;
        private string soHKMoi = Init.STRING;
        private string soHKCu = Init.STRING;
        private string diaChiHKMoi = Init.STRING;
        private string diaChiHKCu = Init.STRING;

        public int MaHoKhauChuyenDen { get => maHoKhauChuyenDen; set => maHoKhauChuyenDen = value; }
        public int MaHoKhauChuyenTu { get => maHoKhauChuyenTu; set => maHoKhauChuyenTu = value; }
        public int MaCongDan { get => maCongDan; set => maCongDan = value; }
        public int Ma { get => ma; set => ma = value; }
        public DateTime NgayChuyenKhau { get => ngayChuyenKhau; set => ngayChuyenKhau = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoHKMoi { get => soHKMoi; set => soHKMoi = value; }
        public string SoHKCu { get => soHKCu; set => soHKCu = value; }
        public string DiaChiHKMoi { get => diaChiHKMoi; set => diaChiHKMoi = value; }
        public string DiaChiHKCu { get => diaChiHKCu; set => diaChiHKCu = value; }
        public CongDan CongDanChuyenKhau { get => congDanChuyenKhau; set => congDanChuyenKhau = value; }
        public HoKhau HoKhauChuyenTu { get => hoKhauChuyenTu; set => hoKhauChuyenTu = value; }
        public HoKhau HoKhauChuyenDen { get => hoKhauChuyenDen; set => hoKhauChuyenDen = value; }

        public void SelfUpdate()
        {
            HoTen = CongDanChuyenKhau.HoTen;
            SoHKMoi = HoKhauChuyenDen.SoHoKhau;
            SoHKCu = HoKhauChuyenTu.SoHoKhau;
            DiaChiHKMoi = HoKhauChuyenDen.DiaChi;
            DiaChiHKCu = HoKhauChuyenTu.DiaChi;
        }
    }
}
