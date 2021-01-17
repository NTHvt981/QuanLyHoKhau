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
    public partial class FrmChiTietNhanKhau : Form
    {
        CongDan congDan;
        CongDanBUS congDanBUS = new CongDanBUS();
        CmndBUS cmndBUS = new CmndBUS();
        CccdBUS cccdBUS = new CccdBUS();

        Cmnd cmnd = null;
        Cccd cccd = null;

        PhieuChuyenKhauBUS chuyenKhauBUS = new PhieuChuyenKhauBUS();
        PhieuChuyenKhau phieuChuyenKhau = null;

        public FrmChiTietNhanKhau(CongDan cd)
        {
            InitializeComponent();
            congDan = cd;

            if (congDan != null)
            {
                SetSuaState();
                disableSua();
                rbKhong.Select();
            }
            else
            {
                congDan = new CongDan();
                congDan.NgaySinh = DateTime.Now;

                SetThemState();
            }

            setData(congDan);
            setCmndCccd();

            btnLuuSua.Click += BtnLuu_Click;
            btnLuuThem.Click += BtnLuuThem_Click;
            btnQuayLai.Click += BtnQuayLai_Click;

            btnHoKhau.Click += BtnHoKhau_Click;

            rbCo.Click += RbCo_Click;
            rbKhong.Click += RbKhong_Click;

            btnXemCccd.Click += BtnXemCccd_Click;
            btnXemCmnd.Click += BtnXemCmnd_Click;
            btnTaoCccd.Click += BtnTaoCccd_Click;
        }

        private void BtnHoKhau_Click(object sender, EventArgs e)
        {
            FrmDanhSachHoKhau frm = new FrmDanhSachHoKhau(FormType.CHI_TIET_NHAN_KHAU);
            frm.ValueEvent += ChonHoKhauEvent;
            frm.Show(this);
        }

        private void ChonHoKhauEvent(HoKhau hoKhau)
        {
            phieuChuyenKhau = chuyenKhauBUS.ChuyenKhau(congDan, hkMoi: hoKhau);

            hoKhau.Update(congDan);
            setData(congDan);
        }

        private void BtnTaoCccd_Click(object sender, EventArgs e)
        {
            Cccd cccd = new Cccd();
            congDan.Update(cccd);

            FrmChiTietCccd frm = new FrmChiTietCccd(cccd);
            frm.AddCccdEvent += Frm_AddCccdEvent;
            frm.UpdateCccdEvent += Frm_UpdateCccdEvent;
            frm.Show(this);
        }

        private void Frm_UpdateCccdEvent(object sender, Cccd cd)
        {

        }

        private void Frm_AddCccdEvent(object sender, Cccd cd)
        {
            cccd = cd;
            tbSoCccd.Text = cd.SoCccd;
        }

        private void BtnXemCmnd_Click(object sender, EventArgs e)
        {
            FrmChiTietCmnd frm = new FrmChiTietCmnd(cmnd);
            frm.Show(this);
        }

        private void BtnXemCccd_Click(object sender, EventArgs e)
        {
            FrmChiTietCccd frm = new FrmChiTietCccd(cccd);
            frm.FormClosed += FrmCccdSua_FormClosed;
            frm.Show(this);
        }

        private void FrmCccdSua_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void BtnLuuThem_Click(object sender, EventArgs e)
        {
            getData();

            string error = "";
            if (!congDanBUS.Validate(congDan, ref error))
            {
                MessageBox.Show(error);
                return;
            }

            bool result = congDanBUS.Add(congDan);
            if (result)
            {
                MessageBox.Show("Thêm nhân khẩu thành công");
            }
            else
                MessageBox.Show("Có lỗi trong việc thêm nhân khẩu");
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            setData(congDan);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            getData();

            string error = "";
            if (!congDanBUS.Validate(congDan, ref error))
            {
                MessageBox.Show(error);
                return;
            }

            bool result = congDanBUS.Update(congDan);
            if (result)
            {
                MessageBox.Show("sửa nhân khẩu thành công");
            }
            else
                MessageBox.Show("Có lỗi trong việc sửa nhân khẩu");

            if (phieuChuyenKhau != null)
                chuyenKhauBUS.Add(phieuChuyenKhau);

            Close();
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
            congDan.HoTen = tbHoTen.Text;
            congDan.GioiTinh = tbGioiTinh.Text;
            congDan.SoCmnd = tbSoCmnd.Text;
            congDan.SoCccd = tbSoCccd.Text;
            congDan.MaHoKhau = tbSoHoKhau.Text;
            congDan.NgaySinh = dtpNgaySinh.Value;
            congDan.QueQuan = tbQueQuan.Text;
            congDan.QuocTich = tbQuocTich.Text;
            congDan.DiaChiHoKhau = tbDiaChi.Text;

            congDan.TonGiao = tbTonGiao.Text;
            congDan.DanToc = tbDanToc.Text;
            congDan.DacDiemNhanDang = tbDacDiemNhanDang.Text;
        }

        private void setData(CongDan result)
        {
            tbHoTen.Text = result.HoTen;
            tbGioiTinh.Text = result.GioiTinh;
            tbSoCmnd.Text = result.SoCmnd;
            tbSoCccd.Text = result.SoCccd;
            tbSoHoKhau.Text = result.MaHoKhau;
            dtpNgaySinh.Value = result.NgaySinh;
            tbQueQuan.Text = result.QueQuan;
            tbQuocTich.Text = result.QuocTich;
            tbDiaChi.Text = result.DiaChiHoKhau;

            tbTonGiao.Text = result.TonGiao;
            tbDanToc.Text = result.DanToc;
            tbDacDiemNhanDang.Text = result.DacDiemNhanDang;
        }

        private void enableSua()
        {
            tbHoTen.Enabled = true;
            tbGioiTinh.Enabled = true;
            tbSoCmnd.Enabled = true;
            tbSoCccd.Enabled = true;
            tbSoHoKhau.Enabled = true;
            dtpNgaySinh.Enabled = true;
            tbQueQuan.Enabled = true;
            tbQuocTich.Enabled = true;
            tbDiaChi.Enabled = true;

            tbDanToc.Enabled = true;
            tbTonGiao.Enabled = true;
            tbDacDiemNhanDang.Enabled = true;

            btnLuuSua.Enabled = true;
            btnQuayLai.Enabled = true;
        }

        private void disableSua()
        {
            tbHoTen.Enabled = false;
            tbGioiTinh.Enabled = false;
            tbSoCmnd.Enabled = false;
            tbSoCccd.Enabled = false;
            tbSoHoKhau.Enabled = false;
            dtpNgaySinh.Enabled = false;
            tbQueQuan.Enabled = false;
            tbQuocTich.Enabled = false;
            tbDiaChi.Enabled = false;

            tbDanToc.Enabled = false;
            tbTonGiao.Enabled = false;
            tbDacDiemNhanDang.Enabled = false;

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

        private void setCmndCccd()
        {
            if (congDan.CoCccd())
            {
                cccd = cccdBUS.Read(congDan.SoCccd);
            }
            else
                btnXemCccd.Enabled = false;

            if (congDan.CoCmnd())
            {
                cmnd = cmndBUS.Read(congDan.SoCmnd);
            }
            else
                btnXemCmnd.Enabled = false;
        }
    }
}
