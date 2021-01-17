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
            bool result = CongDanDAL.GetInstance().Update(cd);

            if (result)
            {
                HoKhau hk = HoKhauDAL.GetInstance().ReadByMaChuHo(cd.Ma);

                if (hk != null)
                {
                    cd.SetChuHo(hk);
                    HoKhauDAL.GetInstance().Update(hk);
                }

            }

            return result;
        }
        public bool Delete(CongDan cd)
        {
            return CongDanDAL.GetInstance().Delete(cd);
        }

        public List<CongDan> ReadAll()
        {
            return CongDanDAL.GetInstance().ReadAll();
        }

        public CongDan Read(int ma)
        {
            return CongDanDAL.GetInstance().Read(ma);
        }

        public List<CongDan> ReadAllByMaHoKhau(string soSo)
        {
            return CongDanDAL.GetInstance().ReadAllBySoHoKhau(soSo);
        }
        public List<CongDan> ReadAllByKeyWord(string key)
        {
            return CongDanDAL.GetInstance().ReadAllByKeyWord(key);
        }

        public bool ExistInDatabase(CongDan cd)
        {
            return !(cd.Ma == -1);
        }

        public bool Validate(CongDan cd, ref string error)
        {

            return true;
        }
    }
}
