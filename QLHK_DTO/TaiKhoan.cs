using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHK_DTO
{
    public class TaiKhoan
    {
        private string tenNguoiDung = Init.STRING;
        private string tenHienThi = Init.STRING;
        private string matKhau = Init.STRING;

        public static TaiKhoan TaiKhoanHienTai = null;

        public string TenNguoiDung { get => tenNguoiDung; set => tenNguoiDung = value; }
        public string TenHienThi { get => tenHienThi; set => tenHienThi = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
