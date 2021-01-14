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
    public partial class FrmTaoPhieuThayDoiHoKhau : Form
    {
        PhieuThayDoiHoKhau banKhai;
        public delegate void MyEvent(object sender, PhieuThayDoiHoKhau cd);
        public event MyEvent AddPhieuEvent;
        public FrmTaoPhieuThayDoiHoKhau(PhieuThayDoiHoKhau bk)
        {
            InitializeComponent();

            if (bk == null)
            {
                banKhai = new PhieuThayDoiHoKhau();
                banKhai.NgayCap = DateTime.Now;
                banKhai.NgaySinh = DateTime.Now;
            }
            else
                banKhai = bk;

            setData(banKhai);

            btnLuuThem.Click += BtnLuuThem_Click;
        }

        private void BtnLuuThem_Click(object sender, EventArgs e)
        {
            getData();
            AddPhieuEvent?.Invoke(this, banKhai);
            Close();
        }

        private void getData()
        {
            banKhai.DacDiemNhanDang = "";

            banKhai.HoTen = tbHoTen.Text;
            banKhai.NgheNghiep = tbNgheNghiep.Text;
            banKhai.NguoiCap = tbNguoiCap.Text;
            banKhai.NoiCap = tbNoiCap.Text;
            banKhai.QueQuan = tbQueQuan.Text;
            banKhai.SoCmndCccd = tbSoCmndCccd.Text;
            banKhai.SoHoSo = tbSoHoKhau.Text;
            banKhai.ChuHo = tbChuHo.Text;
            banKhai.DanToc = tbDanToc.Text;
            banKhai.TenThuongGoi = tbTenThuongGoi.Text;

            banKhai.TonGiao = tbTonGiao.Text;
            banKhai.DiaChiHoKhau = tbDiaChiHoKhau.Text;

            dtpNgayCap.Value = banKhai.NgayCap;
            dtpNgaySinh.Value = banKhai.NgaySinh;
        }

        private void setData(PhieuThayDoiHoKhau result)
        {
            tbChuHo.Text = result.ChuHo;
            tbDacDiem.Text = result.DacDiemNhanDang;
            tbDanToc.Text = result.DanToc;
            tbHoTen.Text = result.HoTen;
            tbNgheNghiep.Text = result.NgheNghiep;
            tbNguoiCap.Text = result.NguoiCap;
            tbNoiCap.Text = result.NoiCap;
            tbQueQuan.Text = result.QueQuan;
            tbSoCmndCccd.Text = result.SoCmndCccd;
            tbSoHoKhau.Text = result.SoHoSo;
            tbTenThuongGoi.Text = result.TenThuongGoi;
            dtpNgayCap.Value = result.NgayCap;
            dtpNgaySinh.Value = result.NgaySinh;

            tbTonGiao.Text = result.TonGiao;
            tbDiaChiHoKhau.Text = result.DiaChiHoKhau;
        }
    }
}
