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
    public partial class FrmChiTietChuyenKhau : Form
    {
        private const string NOT_FOUND = "Dữ liệu không tồn tại";
        public FrmChiTietChuyenKhau(PhieuChuyenKhau phieu)
        {
            InitializeComponent();

            if (phieu != null)
            {
                SetCongDanWidgets(phieu.CongDanChuyenKhau);
                SetHoKhauChuyenTuWidgets(phieu.HoKhauChuyenTu);
                SetHoKhauChuyenDenWidgets(phieu.HoKhauChuyenDen);

                dtpNgayChuyenKhau.Value = phieu.NgayChuyenKhau;
            }
        }

        private void SetCongDanWidgets(CongDan cd)
        {
            if (cd != null)
            {
                tbHoTen.Text = cd.HoTen;
                tbGioiTinh.Text = cd.GioiTinh;
                tbSoCmnd.Text = cd.SoCmnd;
                tbSoCccd.Text = cd.SoCccd;
                tbQuocTich.Text = cd.QuocTich;
                dtpNgaySinh.Value = cd.NgaySinh;
            }
            else
            {
                tbHoTen.Text = NOT_FOUND;
                tbGioiTinh.Text = NOT_FOUND;
                tbSoCmnd.Text = NOT_FOUND;
                tbSoCccd.Text = NOT_FOUND;
                tbQuocTich.Text = NOT_FOUND;
                dtpNgaySinh.Value = DateTime.Now.Date;
            }
        }
        private void SetHoKhauChuyenTuWidgets(HoKhau hk)
        {
            if (hk != null)
            {
                tbChuHKTu.Text = hk.TenChuHo;
                tbDiaChiHKTu.Text = hk.DiaChi;
                tbSoHKTu.Text = hk.SoHoKhau;
            }
            else
            {
                tbChuHKTu.Text = NOT_FOUND;
                tbDiaChiHKTu.Text = NOT_FOUND;
                tbSoHKTu.Text = NOT_FOUND;
            }
        }
        private void SetHoKhauChuyenDenWidgets(HoKhau hk)
        {
            if (hk != null)
            {
                tbChuHKDen.Text = hk.TenChuHo;
                tbDiaChiHKDen.Text = hk.DiaChi;
                tbSoHKDen.Text = hk.SoHoKhau;
            }
            else
            {
                tbChuHKDen.Text = NOT_FOUND;
                tbDiaChiHKDen.Text = NOT_FOUND;
                tbSoHKDen.Text = NOT_FOUND;
            }
        }
    }
}
