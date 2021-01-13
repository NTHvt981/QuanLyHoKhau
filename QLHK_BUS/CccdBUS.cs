using QLHK_DAL;
using QLHK_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_BUS
{
    public class CccdBUS
    {
        public bool Add(Cccd cd)
        {
            return CccdDAL.GetInstance().Add(cd);
        }
        public bool Update(Cccd cd)
        {
            return CccdDAL.GetInstance().Update(cd);
        }
        public bool Delete(Cccd cd)
        {
            return CccdDAL.GetInstance().Delete(cd);
        }

        public Cccd Read(string ma)
        {
            return CccdDAL.GetInstance().Read(ma);
        }
    }
}
