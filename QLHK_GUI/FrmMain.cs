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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            closeAllSubMenu();

            btnQuanLyHoKhau.Click += BtnQuanLyHoKhau_Click; ;
            btnQuanLyTamVang.Click += BtnQuanLyTamVang_Click;
            btnQuanLyTamTru.Click += BtnQuanLyTamTru_Click;
            btnQuanLyChuyenKhau.Click += BtnQuanLyChuyenKhau_Click;

            btnTraCuuHoKhau.Click += BtnTraCuuHoKhau_Click;
            btnTraCuuNhanKhau.Click += BtnTraCuuNhanKhau_Click;

            btnCapGiayTamTru.Click += BtnCapGiayTamTru_Click;
            btnCapGiayTamVang.Click += BtnCapGiayTamVang_Click; ;

            btnTraCuuPhieuTamVang.Click += BtnTraCuuPhieuTamVang_Click;
            btnTraCuuTamTru.Click += BtnTraCuuTamTru_Click;

            btnTraCuuBanKhaiNhanKhau.Click += BtnTraCuuBanKhaiNhanKhau_Click;

            btnChuyenKhau.Click += BtnChuyenKhau_Click;

            btnExit.Click += BtnExit_Click;
        }

        private void BtnChuyenKhau_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmChuyenKhau());
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
            openChildForm(new FrmDanhSachHoKhau());
        }

        private void BtnTraCuuBanKhaiNhanKhau_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDanhSachBanKhaiNhanKhau());
        }

        private void BtnTraCuuNhanKhau_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDanhSachNhanKhau());
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
                closeAllSubMenu();
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
                closeAllSubMenu();
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
                closeAllSubMenu();
                openSubMenu(panelSubMenuQLTV);
            }
            else
            {
                panelSubMenuQLTV.Visible = false;
            }
        }

        private void BtnQuanLyChuyenKhau_Click(object sender, EventArgs e)
        {
            if (panelSubMenuCK.Visible == false)
            {
                closeAllSubMenu();
                openSubMenu(panelSubMenuCK);
            }
            else
            {
                panelSubMenuCK.Visible = false;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void BtnTamTru_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDanhSachTamTru());
        }

        private void BtnTamVang_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDanhSachTamVang());
        }

        private void BtnTraCuu_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDanhSachHoKhau());
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

        private void closeAllSubMenu()
        {
            panelSubMenuQLHK.Visible = false;
            panelSubMenuQLTV.Visible = false;
            panelSubMenuQLTT.Visible = false;
            panelSubMenuCK.Visible = false;
        }

        private void openSubMenu(Panel subMenu)
        {
            subMenu.Visible = true;
        }
    }
}
