using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    public class PhieuTamTru
    {
        private int ma = Init.INT;
        private string nguoiKhaiBao = Init.STRING;
        private string noiTamTru = Init.STRING;
        private string lyDo = Init.STRING;
        private DateTime ngayCap = Init.DATE;
        private string noiCap = Init.STRING;
        private string nguoiCap = Init.STRING;

        public int Ma { get => ma; set => ma = value; }
        public string NguoiKhaiBao { get => nguoiKhaiBao; set => nguoiKhaiBao = value; }
        public string NoiTamTru { get => noiTamTru; set => noiTamTru = value; }
        public string LyDo { get => lyDo; set => lyDo = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public string NoiCap { get => noiCap; set => noiCap = value; }
        public string NguoiCap { get => nguoiCap; set => nguoiCap = value; }
    }
}
