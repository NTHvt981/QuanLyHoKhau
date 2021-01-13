using QLHK_DTO;
using QLHK_BUS;
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
    public partial class FrmChiTietCccd : Form
    {
        Cccd cccd;
        CccdBUS bus = new CccdBUS();

        public delegate void MyEvent(object sender, Cccd cd);
        public event MyEvent AddCccdEvent;
        public event MyEvent UpdateCccdEvent;

        public FrmChiTietCccd(Cccd cd)
        {
            InitializeComponent();

            cccd = cd;
            if (cccd.Ma == -1)
            {
                SetThemState();

                cccd.NgayCap = DateTime.Now;
                cccd.NgaySinh = DateTime.Now;
                cccd.ThoiHan = DateTime.Now;
            }
            else
            {
                SetSuaState();
                disableSua();
                rbKhong.Select();
            }
            setData(cccd);

            btnLuuSua.Click += BtnLuuSua_Click;
            btnLuuThem.Click += BtnLuuThem_Click;

            rbCo.Click += RbCo_Click;
            rbKhong.Click += RbKhong_Click;
        }

        private void RbKhong_Click(object sender, EventArgs e)
        {
            disableSua();
        }

        private void RbCo_Click(object sender, EventArgs e)
        {
            enableSua();
        }

        private void BtnLuuThem_Click(object sender, EventArgs e)
        {
            getData();

            bool result = bus.Add(cccd);
            if (result)
            {
                MessageBox.Show("Thêm thông tin Căn cước công dân thành công");

                AddCccdEvent?.Invoke(this, cccd);
                Close();
            }
            else
                MessageBox.Show("Có lỗi trong việc thêm thông tin căn cước công dân");
        }

        private void BtnLuuSua_Click(object sender, EventArgs e)
        {
            getData();

            bool result = bus.Update(cccd);
            if (result)
            {
                MessageBox.Show("Sửa thông tin Căn cước công dân thành công");

                UpdateCccdEvent?.Invoke(this, cccd);
                Close();
            }
            else
                MessageBox.Show("Có lỗi trong việc Sửa thông tin căn cước công dân");
        }

        private void getData()
        {
            cccd.HoTen = tbHoTen.Text;
            cccd.SoCccd = tbSoCccd.Text;
            cccd.GioiTinh = tbGioiTinh.Text;
            cccd.QueQuan = tbQueQuan.Text;
            cccd.QuocTich = tbQuocTich.Text;
            cccd.DiaChiHoKhau = tbDiaChi.Text;
            cccd.DacDiemNhanDang = tbDacDiem.Text;
            cccd.NoiCap = tbNoiCap.Text;
            cccd.NguoiCap = tbNguoiCap.Text;
            cccd.NgayCap = DateTime.Now;
            cccd.NgaySinh = dtpNgaySinh.Value;
            cccd.ThoiHan = dtpThoiHan.Value;
        }

        private void setData(Cccd result)
        {
            tbHoTen.Text = result.HoTen;
            tbSoCccd.Text = result.SoCccd;
            tbGioiTinh.Text = result.GioiTinh;
            tbQueQuan.Text = result.QueQuan;
            tbQuocTich.Text = result.QuocTich;
            tbDiaChi.Text = result.DiaChiHoKhau;
            tbDacDiem.Text = result.DacDiemNhanDang;
            tbNoiCap.Text = result.NoiCap;
            tbNguoiCap.Text = result.NguoiCap;

            if (result.NgayCap != null)
                dtpNgayCap.Value = result.NgayCap;
            if (result.NgaySinh != null)
                dtpNgaySinh.Value = result.NgaySinh;
            if (result.ThoiHan != null)
                dtpThoiHan.Value = result.ThoiHan;

        }

        private void enableSua()
        {
            tbHoTen.Enabled = true;
            tbGioiTinh.Enabled = true;
            tbQueQuan.Enabled = true;
            tbQuocTich.Enabled = true;
            tbDiaChi.Enabled = true;
            tbDacDiem.Enabled = true;
            tbNoiCap.Enabled = true;
            tbNguoiCap.Enabled = true;
            dtpNgaySinh.Enabled = true;
            dtpThoiHan.Enabled = true;

            btnLuuSua.Enabled = true;
            btnQuayLai.Enabled = true;
        }

        private void disableSua()
        {
            tbHoTen.Enabled = false;
            tbSoCccd.Enabled = false;
            tbGioiTinh.Enabled = false;
            tbQueQuan.Enabled = false;
            tbQuocTich.Enabled = false;
            tbDiaChi.Enabled = false;
            tbDacDiem.Enabled = false;
            tbNoiCap.Enabled = false;
            tbNguoiCap.Enabled = false;
            dtpNgaySinh.Enabled = false;
            dtpNgayCap.Enabled = false;
            dtpThoiHan.Enabled = false;

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

            tbSoCccd.ReadOnly = true;
        }
    }
}
