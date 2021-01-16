using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    public class HoKhau
    {
        private int ma = Init.INT;
        private string soHoKhau = Init.STRING;
        private int maChuHo = Init.INT;
        private string tenChuHo = Init.STRING;
        private string diaChi = Init.STRING;
        private string loaiSo = Init.STRING;
        private string lyDoCap = Init.STRING;
        private DateTime ngayCap = Init.DATE;
        private string noiCap = Init.STRING;
        private string nguoiCap = Init.STRING;
        public List<CongDan> congDans = new List<CongDan>(0);
        public CongDan chuHo = null;

        public int Ma { get => ma; set => ma = value; }
        public string SoHoKhau { get => soHoKhau; set => soHoKhau = value; }
        public int MaChuHo { get => maChuHo; set => maChuHo = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public string LoaiSo { get => loaiSo; set => loaiSo = value; }
        public string LyDoCap { get => lyDoCap; set => lyDoCap = value; }
        public string NguoiCap { get => nguoiCap; set => nguoiCap = value; }
        public string NoiCap { get => noiCap; set => noiCap = value; }
        public string TenChuHo { get => tenChuHo; set => tenChuHo = value; }

        public void Update(CongDan congDan)
        {
            congDan.DiaChiHoKhau = DiaChi;
            congDan.MaHoKhau = SoHoKhau;
        }
    }
}
