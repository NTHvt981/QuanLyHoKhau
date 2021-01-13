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

            btnTraCuu.Click += BtnTraCuu_Click;
            btnTamVang.Click += BtnTamVang_Click;
            btnTamTru.Click += BtnTamTru_Click;
            btnChuyenKhau.Click += BtnChuyenKhau_Click;
            btnExit.Click += BtnExit_Click;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnChuyenKhau_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDanhSachBanKhaiNhanKhau());
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
    }
}
