using QLHK_DAL;
using QLHK_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_CSDL_TEST
{
    class HoKhauFakeData
    {
        string[] ChuHos = { "Nguyễn A", "Hồ B", "Quang C" };
        string[] DiaChis = { "113/45/16 Hoàng Kim Q.Thủ Đức", "15B Hoàng Hoa Thám Q.Tân Bình" };
        DateTime NgayLap = DateTime.Parse("15/5/2015");
        string[] LoaiSos = { "K13", "K11" };
        string[] LyDoLaps = { "Tạo mới sổ", "Mất sổ", "Chuyển hộ khẩu" };
        string[] NguoiLaps = { "Nguyễn Văn A", "Hà Thị B" };

        public void AddData()
        {
            bool a = HoKhauDAL.GetInstance().DeleteAll();
            if (a)
                Console.WriteLine("Xoa du lieu thanh cong");
            else
                Console.WriteLine("Xoa du lieu that bai");

            int dem = 1;

            foreach (string chuHo in ChuHos)
            {

                foreach (string diaChi in DiaChis)
                {

                    foreach (string lyDo in LyDoLaps)
                    {

                        foreach (string nguoiLap in NguoiLaps)
                        {
                            HoKhau hk = new HoKhau();
                            hk.ChuHo = chuHo;
                            hk.DiaChi = diaChi;
                            hk.SoSo = "HK-" + dem.ToString();
                            hk.NgayLap = NgayLap;
                            hk.LyDoLap = lyDo;
                            hk.NguoiLam = nguoiLap;
                            hk.LoaiSo = "K131";
                            bool kq = HoKhauDAL.GetInstance().Add(hk);

                            if (kq == true)
                                Console.WriteLine("Them ho khau thanh cong");
                            else
                                Console.WriteLine("Co loi them ho khau");

                            dem += 1;
                        }   
                    }
                }
            }
        }
    }
}
