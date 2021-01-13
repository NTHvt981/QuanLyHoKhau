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
    public partial class FrmChiTietPhieuTamTru : Form
    {
        PhieuTamTru phieuTamTru;
        PhieuTamTruBUS bus = new PhieuTamTruBUS();
        public FrmChiTietPhieuTamTru(PhieuTamTru phieu)
        {
            InitializeComponent();

            if (phieu == null)
            {
                SetThemState();

                phieuTamTru = new PhieuTamTru();
                phieuTamTru.NgayGhi = DateTime.Now;
            }
            else
            {
                SetSuaState();
                disableSua();
                rbKhong.Select();

                phieuTamTru = phieu;
            }

            setData(phieuTamTru);

            btnLuuSua.Click += BtnLuu_Click;
            btnLuuThem.Click += BtnLuuThem_Click;
            btnQuayLai.Click += BtnQuayLai_Click;

            rbCo.Click += RbCo_Click;
            rbKhong.Click += RbKhong_Click;

            printDoc.PrintPage += PrintDoc_PrintPage;
            btnIn.Click += BtnIn_Click;
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {
            printRD.Document = printDoc;
            printRD.ShowDialog();
        }

        private void PrintDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void BtnLuuThem_Click(object sender, EventArgs e)
        {
            getData();

            string error = "";
            if (!bus.Validate(phieuTamTru, ref error))
            {
                MessageBox.Show(error);
                return;
            }

            bool result = bus.Add(phieuTamTru);
            if (result)
                MessageBox.Show("Thêm phiếu tạm trú thành công");
            else
                MessageBox.Show("Có lỗi trong việc thêm phiếu tạm trú");
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            setData(phieuTamTru);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            getData();

            string error = "";
            if (!bus.Validate(phieuTamTru, ref error))
            {
                MessageBox.Show(error);
                return;
            }

            bool result = bus.Update(phieuTamTru);
            if (result)
                MessageBox.Show("Cập nhật phiếu tạm trú thành công");
            else
                MessageBox.Show("có lỗi trong việc cập nhật phiếu tạm trú");
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
            phieuTamTru.NguoiKhaiBao = tbNguoiKhaiBao.Text;
            phieuTamTru.LyDo = tbLyDo.Text;
            phieuTamTru.NoiTamTru = tbNoiTamTru.Text;
            phieuTamTru.NoiGhi = tbNoiLap.Text;
            phieuTamTru.NgayGhi = DateTime.Now;
            phieuTamTru.TenCanBo = tbTenCanBo.Text;

            dtpNgayGhi.Value = phieuTamTru.NgayGhi;
        }

        private void setData(PhieuTamTru result)
        {
            tbNguoiKhaiBao.Text = result.NguoiKhaiBao;
            tbLyDo.Text = result.LyDo;
            tbNoiTamTru.Text = result.NoiTamTru;
            tbNoiLap.Text = result.NoiGhi;
            dtpNgayGhi.Value = result.NgayGhi;
            tbTenCanBo.Text = result.TenCanBo;
        }

        private void enableSua()
        {
            tbNguoiKhaiBao.Enabled = true;
            tbTenCanBo.Enabled = true;
            tbNoiLap.Enabled = true;
            tbLyDo.Enabled = true;
            tbNoiTamTru.Enabled = true;

            btnLuuSua.Enabled = true;
            btnQuayLai.Enabled = true;
        }

        private void disableSua()
        {
            tbNguoiKhaiBao.Enabled = false;
            tbTenCanBo.Enabled = false;
            tbNoiLap.Enabled = false;
            tbLyDo.Enabled = false;
            tbNoiTamTru.Enabled = false;

            btnLuuSua.Enabled = false;
            btnQuayLai.Enabled = false;

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
    }
}
