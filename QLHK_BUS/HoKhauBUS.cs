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
    }
}
