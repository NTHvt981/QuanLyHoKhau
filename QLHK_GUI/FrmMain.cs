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
    public enum FormType
    {
        MAIN,
        CHI_TIET_HO_KHAU,
        CHI_TIET_NHAN_KHAU,
        CHI_TIET_PHIEU_TAM_VANG,
        CHI_TIET_PHIEU_TAM_TRU,
    }
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            closeAllSubMenu();

            btnQuanLyHoKhau.Click += BtnQuanLyHoKhau_Click; ;
            btnQuanLyTamVang.Click += BtnQuanLyTamVang_Click;
            btnQuanLyTamTru.Click += BtnQuanLyTamTru_Click;
            btnQuanLyTraCuu.Click += BtnQuanLyTraCuu_Click;

            btnTraCuuHoKhau.Click += BtnTraCuuHoKhau_Click;
            btnTraCuuNhanKhau.Click += BtnTraCuuNhanKhau_Click;

            btnCapGiayTamTru.Click += BtnCapGiayTamTru_Click;
            btnCapGiayTamVang.Click += BtnCapGiayTamVang_Click; ;

            btnDanhSachTamVang.Click += BtnTraCuuPhieuTamVang_Click;
            btnDanhSachTamTru.Click += BtnTraCuuTamTru_Click;

            btnTraCuuChuyenKhau.Click += BtnTraCuuChuyenKhau_Click;

            btnExit.Click += BtnExit_Click;
        }

        private void BtnQuanLyTraCuu_Click(object sender, EventArgs e)
        {
            if (panelSubMenuTC.Visible == false)
            {
                openSubMenu(panelSubMenuTC);
            }
            else
            {
                panelSubMenuQLHK.Visible = false;
            }
        }

        private void closeAllSubMenu()
        {
            panelSubMenuQLHK.Visible = false;
            panelSubMenuQLTT.Visible = false;
            panelSubMenuQLTV.Visible = false;
            panelSubMenuTC.Visible = false;
        }

        private void BtnTraCuuChuyenKhau_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDanhSachChuyenKhau());
        }

        private void BtnTraCuuTamTru_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDanhSachTamTru());
        }

        private void BtnTraCuuPhieuTamVang_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDanhSachTamVang());
        }
        private void BtnTraCuuHoKhau_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDanhSachHoKhau(FormType.MAIN));
        }

        private void BtnTraCuuNhanKhau_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDanhSachNhanKhau(FormType.MAIN));
        }

        private void BtnCapGiayTamTru_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmChiTietPhieuTamTru(null));
        }
        private void BtnCapGiayTamVang_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmChiTietPhieuTamVang(null));
        }


        private void BtnQuanLyHoKhau_Click(object sender, EventArgs e)
        {
            if (panelSubMenuQLHK.Visible == false)
            {
                openSubMenu(panelSubMenuQLHK);
            }
            else
            {
                panelSubMenuQLHK.Visible = false;
            }
        }

        private void BtnQuanLyTamTru_Click(object sender, EventArgs e)
        {
            if (panelSubMenuQLTT.Visible == false)
            {
                openSubMenu(panelSubMenuQLTT);
            }
            else
            {
                panelSubMenuQLTT.Visible = false;
            }
        }

        private void BtnQuanLyTamVang_Click(object sender, EventArgs e)
        {
            if (panelSubMenuQLTV.Visible == false)
            {
                openSubMenu(panelSubMenuQLTV);
            }
            else
            {
                panelSubMenuQLTV.Visible = false;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            TaiKhoan.TaiKhoanHienTai = null;
            Close();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelSubForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void openSubMenu(Panel subMenu)
        {
            subMenu.Visible = true;
        }
    }
}
