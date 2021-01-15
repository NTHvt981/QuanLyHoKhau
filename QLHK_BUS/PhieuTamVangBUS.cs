using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QLHK_DTO;
using QLHK_DAL;

namespace QLHK_BUS
{
    public class PhieuTamVangBUS
    {
        public const string ERROR_CMND_CCCD_TRONG = "Số CMND/CCCD không để trống";

        public bool Add(PhieuTamVang cd)
        {
            return PhieuTamVangDAL.GetInstance().Add(cd);
        }
        public bool Update(PhieuTamVang cd)
        {
            return PhieuTamVangDAL.GetInstance().Update(cd);
        }
        public bool Delete(PhieuTamVang cd)
        {
            return PhieuTamVangDAL.GetInstance().Delete(cd);
        }
        public bool DeleteAll()
        {
            return PhieuTamVangDAL.GetInstance().DeleteAll();
        }

        public List<PhieuTamVang> ReadAll()
        {
            return PhieuTamVangDAL.GetInstance().ReadAll();
        }
        public List<PhieuTamVang> ReadAllByKeyWord(string key)
        {
            return PhieuTamVangDAL.GetInstance().ReadAllByKeyword(key);
        }

        public PhieuTamVang Read(string ma)
        {
            return PhieuTamVangDAL.GetInstance().Read(ma);
        }

        public bool Validate(PhieuTamVang phieu, ref string error)
        {

            return true;
        }
    }
}
