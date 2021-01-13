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
    public partial class FrmChiTietCmnd : Form
    {
        Cmnd cmnd;
        public FrmChiTietCmnd(Cmnd cmnd)
        {
            InitializeComponent();

            this.cmnd = cmnd;

            SetData();
        }

        private void SetData()
        {
            tbHoTen.Text = cmnd.HoTen;
            tbSoCmnd.Text = cmnd.SoCmnd;
            tbQueQuan.Text = cmnd.QueQuan;
            tbDanToc.Text = cmnd.DanToc;
            tbTonGiao.Text = cmnd.TonGiao;
            tbDiaChi.Text = cmnd.DiaChiHoKhau;
            tbDacDiem.Text = cmnd.DacDiemNhanDang;
            tbNoiCap.Text = cmnd.NoiCap;
            tbNguoiCap.Text = cmnd.NguoiCap;

            dtpNgayCap.Value = cmnd.NgayCap;
            dtpNgaySinh.Value = cmnd.NgaySinh;
        }
    }
}
