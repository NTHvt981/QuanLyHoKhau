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
    public partial class FrmDangNhap : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

        public FrmDangNhap()
        {
            InitializeComponent();

            btnDangNhap.Click += BtnDangNhap_Click;
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            //check if ten dang nhap or mat khau is null
            if (string.IsNullOrEmpty(tbTenTaiKhoan.Text))
            {
                MessageBox.Show("Tên đăng nhập không để trống");
                return;
            }

            if (string.IsNullOrEmpty(tbMatKhau.Text))
            {
                MessageBox.Show("Mật khẩu không để trống");
                return;
            }

            string tenTk, matKhau;
            tenTk = tbTenTaiKhoan.Text;
            matKhau = tbMatKhau.Text;

            //check if account exist
            if (!taiKhoanBUS.ExistInDatabase(tenTk))
            {
                MessageBox.Show("Tài khoản này không tồn tại");
                return;
            }

            //check if password correct
            if (!taiKhoanBUS.LogIn(tenTk, matKhau))
            {
                MessageBox.Show("Mật khẩu cho tài khoản này không đúng \nXin hãy nhập lại");
                return;
            }

            MessageBox.Show("Đăng nhập thành công");
            TaiKhoan.TaiKhoanHienTai = taiKhoanBUS.Read(tenTk);
            OpenFormMain();
        }

        private void OpenFormMain()
        {
            FrmMain frmMain = new FrmMain();
            frmMain.FormClosed += FrmMain_FormClosed;
            frmMain.Show();
            this.Hide();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
