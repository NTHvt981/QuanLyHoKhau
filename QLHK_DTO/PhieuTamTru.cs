using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    public class PhieuTamTru
    {
        private int ma;
        private string nguoiKhaiBao;
        private string noiTamTru;
        private string lyDo;
        private DateTime ngayGhi;
        private string noiGhi;
        private string tenCanBo;

        public int Ma { get => ma; set => ma = value; }
        public string NguoiKhaiBao { get => nguoiKhaiBao; set => nguoiKhaiBao = value; }
        public string NoiTamTru { get => noiTamTru; set => noiTamTru = value; }
        public string LyDo { get => lyDo; set => lyDo = value; }
        public DateTime NgayGhi { get => ngayGhi; set => ngayGhi = value; }
        public string NoiGhi { get => noiGhi; set => noiGhi = value; }
        public string TenCanBo { get => tenCanBo; set => tenCanBo = value; }
    }
}
