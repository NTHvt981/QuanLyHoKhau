using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    public class PhieuTamVang
    {
        private int ma = -1;
        private string soCmndCccd = "";
        private string nguoiKhaiBao = "";
        private string ngheNghiep = "";
        private string noiLamViec = "";
        private DateTime thoiGianBatDau = DateTime.Now;
        private DateTime thoiGianKetThuc = DateTime.Now;
        private string noiTamTru = "";
        private string lyDo = "";
        private string quanHeChuHo = "";
        private string soNha = "";
        private string danhSachTreEm = "";
        private DateTime ngayKhaiBao = DateTime.Now;
        private string tenCanBo = "";

        public string TenCanBo { get => tenCanBo; set => tenCanBo = value; }
        public DateTime NgayKhaiBao { get => ngayKhaiBao; set => ngayKhaiBao = value; }
        public string DanhSachTreEm { get => danhSachTreEm; set => danhSachTreEm = value; }
        public string SoNha { get => soNha; set => soNha = value; }
        public string QuanHeChuHo { get => quanHeChuHo; set => quanHeChuHo = value; }
        public string LyDo { get => lyDo; set => lyDo = value; }
        public string NoiTamTru { get => noiTamTru; set => noiTamTru = value; }
        public DateTime ThoiGianKetThuc { get => thoiGianKetThuc; set => thoiGianKetThuc = value; }
        public DateTime ThoiGianBatDau { get => thoiGianBatDau; set => thoiGianBatDau = value; }
        public string NoiLamViec { get => noiLamViec; set => noiLamViec = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public string NguoiKhaiBao { get => nguoiKhaiBao; set => nguoiKhaiBao = value; }
        public string SoCmndCccd { get => soCmndCccd; set => soCmndCccd = value; }
        public int Ma { get => ma; set => ma = value; }
    }
}
