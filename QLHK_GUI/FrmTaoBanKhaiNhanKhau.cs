using QLHK_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHK_GUI
{
    public partial class FrmTaoBanKhaiNhanKhau : Form
    {
        BanKhaiNhanKhau banKhai;
        public delegate void MyEvent(object sender, BanKhaiNhanKhau cd);
        public event MyEvent AddBanKhaiEvent;
        public FrmTaoBanKhaiNhanKhau(BanKhaiNhanKhau bk)
        {
            InitializeComponent();

            if (bk == null)
            {
                banKhai = new BanKhaiNhanKhau();
                banKhai.NgayCap = DateTime.Now;
                banKhai.NgaySinh = DateTime.Now;
            }
            else
                banKhai = bk;

            setData(banKhai);

            btnLuuThem.Click += BtnLuuThem_Click;
        }

        private void BtnLuuThem_Click(object sender, EventArgs e)
        {
            getData();
            AddBanKhaiEvent?.Invoke(this, banKhai);
            Close();
        }

        private void getData()
        {
            banKhai.DiaChiHoKhau = tbNoiOHienNay.Text;
            banKhai.DacDiemNhanDang = "";

            banKhai.BietTiengDanToc = tbBietTiengDanToc.Text;
            banKhai.HoTen = tbHoTen.Text;
            banKhai.NgheNghiep = tbNgheNghiep.Text;
            banKhai.NguoiCap = tbNguoiCap.Text;
            banKhai.NoiCap = tbNoiCap.Text;
            banKhai.NoiOHienNay = tbNoiOHienNay.Text;
            banKhai.QueQuan = tbQueQuan.Text;
            banKhai.SoCmndCccd = tbSoCmndCccd.Text;
            banKhai.SoHoSo = tbSoHoKhau.Text;
            banKhai.TenThuongGoi = tbTenThuongGoi.Text;
            banKhai.TrinhDoHocVan = tbTrinhDoHocVan.Text;
            banKhai.TrinhDoNgoaiNgu = tbTrinhDoNgoaiNgu.Text;
            banKhai.BietTiengDanToc = tbBietTiengDanToc.Text;
            banKhai.ChuHo = tbChuHo.Text;
            banKhai.ChuyenMon = tbChuyenMon.Text;
            banKhai.DanhSachKhenThuong = tbDanhSachKhenThuong.Text;
            banKhai.DanhSachNguoiCungDi = tbDanhSachNguoiCungDi.Text;
            banKhai.DanhSachQuanHeGiaDinh = tbDanhSachQuanHeGiaDinh.Text;
            banKhai.DanhSachTienAn = tbDanhSachTienAn.Text;
            banKhai.DanToc = tbDanToc.Text;

            dtpNgayCap.Value = banKhai.NgayCap;
            dtpNgaySinh.Value = banKhai.NgaySinh;
        }

        private void setData(BanKhaiNhanKhau result)
        {
            tbBietTiengDanToc.Text = result.BietTiengDanToc;
            tbChuHo.Text = result.ChuHo;
            tbChuyenMon.Text = result.ChuyenMon;
            tbDanhSachKhenThuong.Text = result.DanhSachKhenThuong;
            tbDanhSachNguoiCungDi.Text = result.DanhSachNguoiCungDi;
            tbDanhSachQuanHeGiaDinh.Text = result.DanhSachQuanHeGiaDinh;
            tbDanhSachTienAn.Text = result.DanhSachTienAn;
            tbDanToc.Text = result.DanToc;
            tbHoTen.Text = result.HoTen;
            tbNgheNghiep.Text = result.NgheNghiep;
            tbNguoiCap.Text = result.NguoiCap;
            tbNoiCap.Text = result.NoiCap;
            tbNoiOHienNay.Text = result.NoiOHienNay;
            tbQueQuan.Text = result.QueQuan;
            tbSoCmndCccd.Text = result.SoCmndCccd;
            tbSoHoKhau.Text = result.SoHoSo;
            tbTenThuongGoi.Text = result.TenThuongGoi;
            tbTrinhDoHocVan.Text = result.TrinhDoHocVan;
            tbTrinhDoNgoaiNgu.Text = result.TrinhDoNgoaiNgu;
            dtpNgayCap.Value = result.NgayCap;
            dtpNgaySinh.Value = result.NgaySinh;
        }
    }
}
