using QLHK_BUS;
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
    public partial class FrmChiTietBanKhaiNhanKhau : Form
    {
        BanKhaiNhanKhau banKhai;
        BanKhaiNhanKhauBUS bus = new BanKhaiNhanKhauBUS();
        public FrmChiTietBanKhaiNhanKhau(BanKhaiNhanKhau bk)
        {
            InitializeComponent();

            if (bk == null)
            {
                SetThemState();

                banKhai = new BanKhaiNhanKhau();
                banKhai.NgayCap = DateTime.Now;
                banKhai.NgaySinh = DateTime.Now;
            }
            else
            {
                SetSuaState();
                disableSua();
                rbKhong.Select();

                banKhai = bk;
            }

            setData(banKhai);

            btnLuuSua.Click += BtnLuu_Click;
            btnLuuThem.Click += BtnLuuThem_Click;
            btnQuayLai.Click += BtnQuayLai_Click;

            rbCo.Click += RbCo_Click;
            rbKhong.Click += RbKhong_Click;
        }

        private void BtnLuuThem_Click(object sender, EventArgs e)
        {
            getData();

            bool result = bus.Add(banKhai);
            if (result)
                MessageBox.Show("Thêm bản khai nhân khẩu thành công");
            else
                MessageBox.Show("Có lỗi trong việc thêm bản khai nhân khẩu");
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            setData(banKhai);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            getData();

            bool result = bus.Update(banKhai);
            if (result)
                MessageBox.Show("Cập nhật bản khai nhân khẩu thành công");
            else
                MessageBox.Show("có lỗi trong việc cập nhật bản khai nhân khẩu");
        }

        private void RbKhong_Click(object sender, EventArgs e)
        {
            disableSua();
        }

        private void RbCo_Click(object sender, EventArgs e)
        {
            enableSua();
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

        private void enableSua()
        {
            tbBietTiengDanToc.Enabled = true;
            tbChuHo.Enabled = true;
            tbChuyenMon.Enabled = true;
            tbDanhSachKhenThuong.Enabled = true;
            tbDanhSachNguoiCungDi.Enabled = true;
            tbDanhSachQuanHeGiaDinh.Enabled = true;
            tbDanhSachTienAn.Enabled = true;
            tbDanToc.Enabled = true;
            tbHoTen.Enabled = true;
            tbNgheNghiep.Enabled = true;
            tbNguoiCap.Enabled = true;
            tbNoiCap.Enabled = true;
            tbNoiOHienNay.Enabled = true;
            tbQueQuan.Enabled = true;
            tbSoCmndCccd.Enabled = true;
            tbSoHoKhau.Enabled = true;
            tbTenThuongGoi.Enabled = true;
            tbTrinhDoHocVan.Enabled = true;
            tbTrinhDoNgoaiNgu.Enabled = true;
            dtpNgayCap.Enabled = true;
            dtpNgaySinh.Enabled = true;

            btnLuuSua.Enabled = true;
            btnQuayLai.Enabled = true;
        }

        private void disableSua()
        {
            tbBietTiengDanToc.Enabled = false;
            tbChuHo.Enabled = false;
            tbChuyenMon.Enabled = false;
            tbDanhSachKhenThuong.Enabled = false;
            tbDanhSachNguoiCungDi.Enabled = false;
            tbDanhSachQuanHeGiaDinh.Enabled = false;
            tbDanhSachTienAn.Enabled = false;
            tbDanToc.Enabled = false;
            tbHoTen.Enabled = false;
            tbNgheNghiep.Enabled = false;
            tbNguoiCap.Enabled = false;
            tbNoiCap.Enabled = false;
            tbNoiOHienNay.Enabled = false;
            tbQueQuan.Enabled = false;
            tbSoCmndCccd.Enabled = false;
            tbSoHoKhau.Enabled = false;
            tbTenThuongGoi.Enabled = false;
            tbTrinhDoHocVan.Enabled = false;
            tbTrinhDoNgoaiNgu.Enabled = false;
            dtpNgayCap.Enabled = false;
            dtpNgaySinh.Enabled = false;

            btnLuuSua.Enabled = false;
            btnQuayLai.Enabled = false;
        }

        private void SetThemState()
        {
            lbSua.Visible = false;
            rbCo.Visible = false;
            rbKhong.Visible = false;
            btnQuayLai.Visible = false;
            btnLuuSua.Visible = false;
        }

        private void SetSuaState()
        {
            btnLuuThem.Visible = false;
        }
    }
}
