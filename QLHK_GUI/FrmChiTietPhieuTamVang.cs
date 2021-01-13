using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHK_BUS;
using QLHK_DTO;

namespace QLHK_GUI
{
    public partial class FrmChiTietPhieuTamVang : Form
    {
        PhieuTamVang phieuTamVang;
        PhieuTamVangBUS bus = new PhieuTamVangBUS();
        public FrmChiTietPhieuTamVang(PhieuTamVang phieu)
        {
            InitializeComponent();


            if (phieu == null)
            {
                SetThemState();

                phieuTamVang = new PhieuTamVang();
                phieuTamVang.NgayKhaiBao = DateTime.Now;
                phieuTamVang.ThoiGianBatDau = DateTime.Now;
                phieuTamVang.ThoiGianKetThuc = DateTime.Now;
            }
            else
            {
                SetSuaState();
                disableSua();
                rbKhong.Select();

                phieuTamVang = phieu;
            }

            setData(phieuTamVang);

            rbCo.Click += RbCo_Click;
            rbKhong.Click += RbKhong_Click;

            btnLuuSua.Click += BtnLuu_Click;
            btnLuuThem.Click += BtnLuuThem_Click;
            btnQuayLai.Click += BtnQuayLai_Click;
        }

        private void BtnLuuThem_Click(object sender, EventArgs e)
        {
            getData();

            string error = "";
            if (!bus.Validate(phieuTamVang, ref error))
            {
                MessageBox.Show(error);
                return;
            }

            bool result = bus.Add(phieuTamVang);
            if (result)
                MessageBox.Show("Thêm phiếu tạm vắng thành công");
            else
                MessageBox.Show("Có lỗi trong việc thêm phiếu tạm vắng");
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            setData(phieuTamVang);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            getData();

            string error = "";
            if (!bus.Validate(phieuTamVang, ref error))
            {
                MessageBox.Show(error);
                return;
            }

            bool result = bus.Update(phieuTamVang);
            if (result)
                MessageBox.Show("Cập nhật phiếu xin tạm vắng thành công");
            else
                MessageBox.Show("có lỗi trong việc cập nhật phiếu tạm vắng");
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
            phieuTamVang.NguoiKhaiBao = tbHoTen.Text;
            phieuTamVang.SoCmndCccd = tbCmndCccd.Text;
            phieuTamVang.NgheNghiep = tbNgheNghiep.Text;
            phieuTamVang.NoiLamViec = tbNoiLamViec.Text;
            phieuTamVang.SoNha = tbDiaChi.Text;

            phieuTamVang.QuanHeChuHo = tbQuanHe.Text;
            phieuTamVang.TenCanBo = tbNguoiCapPhieu.Text;
            phieuTamVang.DanhSachTreEm = tbDanhSachTreEm.Text;

            phieuTamVang.NoiTamTru = tbNoiTamTru.Text;
            phieuTamVang.LyDo = tbLyDo.Text;

            phieuTamVang.ThoiGianBatDau = dtpTgBd.Value;
            phieuTamVang.ThoiGianKetThuc = dtpTgKt.Value;
            phieuTamVang.NgayKhaiBao = DateTime.Now;

            dtpNgayGhi.Value = phieuTamVang.NgayKhaiBao;
        }

        private void enableSua()
        {
            tbHoTen.Enabled = true;
            tbCmndCccd.Enabled = true;
            tbNgheNghiep.Enabled = true;
            tbNoiLamViec.Enabled = true;
            tbDiaChi.Enabled = true;

            tbQuanHe.Enabled = true;
            tbNguoiCapPhieu.Enabled = true;
            tbDanhSachTreEm.Enabled = true;

            tbNoiTamTru.Enabled = true;
            tbLyDo.Enabled = true;

            dtpTgBd.Enabled = true;
            dtpTgKt.Enabled = true;

            btnLuuSua.Enabled = true;
            btnQuayLai.Enabled = true;
        }

        private void disableSua()
        {
            tbHoTen.Enabled = false;
            tbCmndCccd.Enabled = false;
            tbNgheNghiep.Enabled = false;
            tbNoiLamViec.Enabled = false;
            tbDiaChi.Enabled = false;

            tbQuanHe.Enabled = false;
            tbNguoiCapPhieu.Enabled = false;
            tbDanhSachTreEm.Enabled = false;

            tbNoiTamTru.Enabled = false;
            tbLyDo.Enabled = false;

            dtpTgBd.Enabled = false;
            dtpTgKt.Enabled = false;

            btnLuuSua.Enabled = false;
            btnQuayLai.Enabled = false;
        }

        private void setData(PhieuTamVang result)
        {
            tbHoTen.Text = result.NguoiKhaiBao;
            tbCmndCccd.Text = result.SoCmndCccd;
            tbNgheNghiep.Text  = result.NgheNghiep ;
            tbNoiLamViec.Text  = result.NoiLamViec ;
            tbDiaChi.Text = result.SoNha ;

            tbQuanHe.Text = result.QuanHeChuHo ;
            tbNguoiCapPhieu.Text = result.TenCanBo ;
            tbDanhSachTreEm.Text = result.DanhSachTreEm;

            tbNoiTamTru.Text = result.NoiTamTru ;
            tbLyDo.Text = result.LyDo ;

            dtpTgBd.Value = result.ThoiGianBatDau;
            dtpTgKt.Value = result.ThoiGianKetThuc;
            dtpNgayGhi.Value = result.NgayKhaiBao;
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
