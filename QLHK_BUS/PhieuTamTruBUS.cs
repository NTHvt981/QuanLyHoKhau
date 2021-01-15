using QLHK_DAL;
using QLHK_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_BUS
{
    public class PhieuTamTruBUS
    {
        public bool Add(PhieuTamTru cd)
        {
            return PhieuTamTruDAL.GetInstance().Add(cd);
        }
        public bool Update(PhieuTamTru cd)
        {
            return PhieuTamTruDAL.GetInstance().Update(cd);
        }
        public bool Delete(PhieuTamTru cd)
        {
            return PhieuTamTruDAL.GetInstance().Delete(cd);
        }
        public bool DeleteAll()
        {
            return PhieuTamTruDAL.GetInstance().DeleteAll();
        }

        public List<PhieuTamTru> ReadAll()
        {
            return PhieuTamTruDAL.GetInstance().ReadAll();
        }
        public List<PhieuTamTru> ReadAllByKeyWord(string key)
        {
            return PhieuTamTruDAL.GetInstance().ReadAllByKeyword(key);
        }

        public PhieuTamTru Read(string ma)
        {
            return PhieuTamTruDAL.GetInstance().Read(ma);
        }

        public bool Validate(PhieuTamTru phieu, ref string error)
        {

            return true;
        }
    }
}
