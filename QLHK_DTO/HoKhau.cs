using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    public class HoKhau
    {
        private int ma = -1;
        private string soSo = "";
        private string chuHo = "";
        private string diaChi = "";
        private DateTime ngayLap = DateTime.Now;
        private string loaiSo = "";
        private string lyDoLap = "";
        private string nguoiLam = "";

        public int Ma { get => ma; set => ma = value; }
        public string SoSo { get => soSo; set => soSo = value; }
        public string ChuHo { get => chuHo; set => chuHo = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public string LoaiSo { get => loaiSo; set => loaiSo = value; }
        public string LyDoLap { get => lyDoLap; set => lyDoLap = value; }
        public string NguoiLam { get => nguoiLam; set => nguoiLam = value; }

        public void Update(CongDan congDan)
        {
            congDan.DiaChiThuongTru = DiaChi;
            congDan.MaHoKhau = SoSo;
        }
    }
}
