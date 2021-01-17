using QLHK_DAL;
using QLHK_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_BUS
{
    public class PhieuChuyenKhauBUS
    {
        public PhieuChuyenKhau ChuyenKhau(CongDan cd, HoKhau hkMoi)
        {
            HoKhau hkCu = HoKhauDAL.GetInstance().ReadBySoHoKhau(cd.MaHoKhau);
            if (hkCu == null) return null;

            if (hkCu.Ma == hkMoi.Ma) return null;

            PhieuChuyenKhau phieu = new PhieuChuyenKhau();
            phieu.NgayChuyenKhau = Init.DATE;
            phieu.MaCongDan = cd.Ma;
            phieu.MaHoKhauChuyenTu = hkCu.Ma;
            phieu.MaHoKhauChuyenDen = hkMoi.Ma;

            return phieu;
        }

        public bool Add(PhieuChuyenKhau phieu)
        {
            return PhieuChuyenKhauDAL.GetInstance().Add(phieu);
        }
        public List<PhieuChuyenKhau> ReadAll()
        {
            return PhieuChuyenKhauDAL.GetInstance().ReadAll();
        }
    }
}
