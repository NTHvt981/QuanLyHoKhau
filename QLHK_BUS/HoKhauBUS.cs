using QLHK_DTO;
using QLHK_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_BUS
{
    public class HoKhauBUS
    {
        public bool Add(HoKhau cd)
        {
            return HoKhauDAL.GetInstance().Add(cd);
        }
        public bool Update(HoKhau cd)
        {
            return HoKhauDAL.GetInstance().Update(cd);
        }
        public bool Delete(HoKhau cd)
        {
            List<CongDan> congDans = CongDanDAL.GetInstance().ReadAllBySoHoKhau(cd.SoHoKhau);

            foreach (CongDan congDan in congDans)
            {
                congDan.EmptyHoKhau();
                CongDanDAL.GetInstance().Update(congDan);
            }

            return HoKhauDAL.GetInstance().Delete(cd);
        }
        public bool DeleteAll()
        {
            return HoKhauDAL.GetInstance().DeleteAll();
        }

        public List<HoKhau> ReadAll()
        {
            return HoKhauDAL.GetInstance().ReadAll();
        }
        public List<HoKhau> ReadAllByKeyWord(string key)
        {
            return HoKhauDAL.GetInstance().ReadAllByKeyword(key);
        }

        public HoKhau Read(string ma)
        {
            return HoKhauDAL.GetInstance().Read(ma);
        }

        public bool Validate(HoKhau cd, ref string error)
        {
            if (DKSoSoTrong(cd, ref error))
                return false;

            return true;
        }

        private bool DKSoSoTrong(HoKhau cd, ref string error)
        {
            if (string.IsNullOrEmpty(cd.SoHoKhau))
            {
                error = "Số sổ hộ khẩu trống";
                return true;
            }

            return false;
        }

    }
}
