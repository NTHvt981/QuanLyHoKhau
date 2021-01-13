using QLHK_DAL;
using QLHK_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_BUS
{
    public class BanKhaiNhanKhauBUS
    {
        public bool Add(BanKhaiNhanKhau bknk)
        {
            return BanKhaiNhanKhauDAL.GetInstance().Add(bknk);
        }
        public bool Update(BanKhaiNhanKhau bknk)
        {
            return BanKhaiNhanKhauDAL.GetInstance().Update(bknk);
        }
        public bool Delete(BanKhaiNhanKhau bknk)
        {
            return BanKhaiNhanKhauDAL.GetInstance().Add(bknk);
        }
        public bool DeleteAll()
        {
            return BanKhaiNhanKhauDAL.GetInstance().DeleteAll();
        }

        public List<BanKhaiNhanKhau> ReadAll()
        {
            return BanKhaiNhanKhauDAL.GetInstance().ReadAll();
        }
        public List<BanKhaiNhanKhau> ReadAllByKeyword(string key)
        {
            return BanKhaiNhanKhauDAL.GetInstance().ReadAllByKeyword(key);
        }

        public BanKhaiNhanKhau Read(string ma)
        {
            return BanKhaiNhanKhauDAL.GetInstance().Read(ma);
        }
    }
}
