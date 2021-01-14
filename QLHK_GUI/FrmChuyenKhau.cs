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
    public partial class FrmChuyenKhau : Form
    {
        BanKhaiNhanKhau banKhai = null;
        PhieuThayDoiHoKhau phieu = null;
        ChuyenKhauBUS bus = new ChuyenKhauBUS();

        HoKhauBUS hoKhauBUS = new HoKhauBUS();
        CongDanBUS congDanBUS = new CongDanBUS();
        CccdBUS cccdBUS = new CccdBUS();

        CongDan congDan = new CongDan();
        HoKhau hoKhau = new HoKhau();
        Cmnd cmnd = new Cmnd();
        Cccd cccd = new Cccd();

        public FrmChuyenKhau()
        {
            InitializeComponent();
            btnSoSanh.Enabled = false;
            btnChuyenKhau.Enabled = false;

            btnNhapBan.Click += BtnNhapBan_Click;
            btnNhapPhieu.Click += BtnNhapPhieu_Click;
            btnSoSanh.Click += BtnSoSanh_Click;
            btnChuyenKhau.Click += BtnChuyenKhau_Click;
        }

        private void BtnChuyenKhau_Click(object sender, EventArgs e)
        {
            bus.UpdateData(banKhai, phieu, congDan, hoKhau, cmnd, cccd);

            if (string.IsNullOrEmpty( hoKhau.SoSo))
            {
                MessageBox.Show("");
                return;
            }

            bool result = true;
            result = hoKhauBUS.Add(hoKhau);
            if (!result)
            {
                MessageBox.Show("Thêm hộ khẩu không thành công");
                return;
            }
            else
            {
                MessageBox.Show("Thêm hộ khẩu thành công");
            }

            result = congDanBUS.Add(congDan);
            if (!result)
            {
                MessageBox.Show("Thêm công dân không thành công");
                return;
            }
            else
            {
                MessageBox.Show("Thêm công dân thành công");
            }
        }

        private void BtnSoSanh_Click(object sender, EventArgs e)
        {
            bool result = bus.Compare(banKhai, phieu);
            if (result)
            {
                checkB3.Checked = true;
                MessageBox.Show("Thông tin hợp lệ");

                btnChuyenKhau.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ");

                btnChuyenKhau.Enabled = false;
            }
        }

        private void BtnNhapPhieu_Click(object sender, EventArgs e)
        {
            FrmTaoPhieuThayDoiHoKhau frmTaoPhieu = new FrmTaoPhieuThayDoiHoKhau(phieu);
            frmTaoPhieu.AddPhieuEvent += FrmTaoPhieu_AddPhieuEvent;
            frmTaoPhieu.Show();
        }

        private void FrmTaoPhieu_AddPhieuEvent(object sender, PhieuThayDoiHoKhau cd)
        {
            phieu = cd;
            if (phieu != null)
            {
                checkB2.Checked = true;
                if (checkB1.Checked)
                    btnSoSanh.Enabled = true;
            }
        }

        private void BtnNhapBan_Click(object sender, EventArgs e)
        {
            FrmTaoBanKhaiNhanKhau frmTaoBan = new FrmTaoBanKhaiNhanKhau(banKhai);
            frmTaoBan.AddBanKhaiEvent += FrmTaoBan_AddBanKhaiEvent;
            frmTaoBan.Show();
        }

        private void FrmTaoBan_AddBanKhaiEvent(object sender, BanKhaiNhanKhau cd)
        {
            banKhai = cd;
            if (banKhai != null)
            {
                checkB1.Checked = true;
                if (checkB2.Checked)
                    btnSoSanh.Enabled = true;
            }
        }
    }
}
