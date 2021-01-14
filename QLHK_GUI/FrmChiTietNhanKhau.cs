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

        public delegate void MyEvent(object sender, CongDan cd);
        public event MyEvent AddCongDanEvent;

        public FrmChiTietNhanKhau(CongDan cd)
        {
            InitializeComponent();
            congDan = cd;

            if (congDanBUS.ExistInDatabase(cd))
            {
                SetSuaState();
                disableSua();
                rbKhong.Select();
            }
            else
            {
                SetThemState();
            }

            setData(congDan);
            setCmndCccd();

            btnLuuSua.Click += BtnLuu_Click;
            btnLuuThem.Click += BtnLuuThem_Click;
            btnQuayLai.Click += BtnQuayLai_Click;

            rbCo.Click += RbCo_Click;
            rbKhong.Click += RbKhong_Click;

            btnXemCccd.Click += BtnXemCccd_Click;
            btnXemCmnd.Click += BtnXemCmnd_Click;
            btnTaoCccd.Click += BtnTaoCccd_Click;

            this.FormClosing += FrmChiTietNhanKhau_FormClosing;
        }

        private void BtnTaoCccd_Click(object sender, EventArgs e)
        {
            Cccd cccd = new Cccd();
            congDan.Update(cccd);

            FrmChiTietCccd frm = new FrmChiTietCccd(cccd);
            frm.AddCccdEvent += Frm_AddCccdEvent;
            frm.UpdateCccdEvent += Frm_UpdateCccdEvent;
            frm.Show();
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
            frm.Show();
        }

        private void BtnXemCccd_Click(object sender, EventArgs e)
        {
            FrmChiTietCccd frm = new FrmChiTietCccd(cccd);
            frm.FormClosed += FrmCccdSua_FormClosed;
            frm.Show();
        }

        private void FrmCccdSua_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FrmChiTietNhanKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
            }
            else
            {
            }
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

            MessageBox.Show("Thêm thông tin nhân khẩu thành công\n " +
                "chọn Lưu trong màn hình thông tin nhân khẩu để có thể cập nhật trong CSDL");

            AddCongDanEvent?.Invoke(this, congDan);
            Close();
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

            MessageBox.Show("Sửa thông tin nhân khẩu thành công\n " +
                "chọn Lưu trong màn hình thông tin nhân khẩu để có thể cập nhật trong CSDL");


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
            congDan.DiaChiThuongTru = tbDiaChi.Text;
            congDan.HoTenBo = tbHoTenBo.Text;
            congDan.HoTenMe = tbHoTenMe.Text;
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
            tbDiaChi.Text = result.DiaChiThuongTru;
            tbHoTenBo.Text = result.HoTenBo;
            tbHoTenMe.Text = result.HoTenMe;
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
            tbHoTenBo.Enabled = true;
            tbHoTenMe.Enabled = true;

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
            tbHoTenBo.Enabled = false;
            tbHoTenMe.Enabled = false;

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
