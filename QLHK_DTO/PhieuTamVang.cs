using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    public class PhieuTamVang
    {
        private int ma = Init.INT;
        private int maNguoiKhaiBao = Init.INT;
        private string tenNguoiKhaiBao = Init.STRING;
        private DateTime thoiGianBatDau = Init.DATE;
        private DateTime thoiGianKetThuc = Init.DATE;
        private string noiTamTru = Init.STRING;
        private string lyDo = Init.STRING;
        private DateTime ngayCap = Init.DATE;
        private string noiCap = Init.STRING;
        private string nguoiCap = Init.STRING;

        public CongDan NguoiKhaiBao;

        public string LyDo { get => lyDo; set => lyDo = value; }
        public string NoiTamTru { get => noiTamTru; set => noiTamTru = value; }
        public DateTime ThoiGianKetThuc { get => thoiGianKetThuc; set => thoiGianKetThuc = value; }
        public DateTime ThoiGianBatDau { get => thoiGianBatDau; set => thoiGianBatDau = value; }
        public int Ma { get => ma; set => ma = value; }
        public int MaNguoiKhaiBao { get => maNguoiKhaiBao; set => maNguoiKhaiBao = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public string NoiCap { get => noiCap; set => noiCap = value; }
        public string NguoiCap { get => nguoiCap; set => nguoiCap = value; }
        public string TenNguoiKhaiBao { get => tenNguoiKhaiBao; set => tenNguoiKhaiBao = value; }
    }
}
