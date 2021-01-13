using QLHK_DTO;
using QLHK_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_BUS
{
    public class CongDanBUS
    {
        public bool Add(CongDan cd)
        {
            return CongDanDAL.GetInstance().Add(cd);
        }
        public bool Update(CongDan cd)
        {
            return CongDanDAL.GetInstance().Update(cd);
        }
        public bool Delete(CongDan cd)
        {
            return CongDanDAL.GetInstance().Delete(cd);
        }

        public List<CongDan> ReadAll()
        {
            return CongDanDAL.GetInstance().ReadAll();
        }

        public CongDan Read(string ma)
        {
            return CongDanDAL.GetInstance().Read(ma);
        }

        public List<CongDan> ReadAllByMaHoKhau(string soSo)
        {
            return CongDanDAL.GetInstance().ReadAllByMaHoKhau(soSo);
        }

        public CongDan ReadByMaHoKhau(string soSo)
        {
            return CongDanDAL.GetInstance().ReadByMaHoKhau(soSo);
        }

        public bool ExistInDatabase(CongDan cd)
        {
            return !(cd.Ma == -1);
        }


    }
}
