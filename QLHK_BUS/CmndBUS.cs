using QLHK_DAL;
using QLHK_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_BUS
{
    public class CmndBUS
    {
        public Cmnd Read(string soCmnd)
        {
            return CmndDAL.GetInstance().Read(soCmnd);
        }
    }
}
