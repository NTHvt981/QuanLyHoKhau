using QLHK_DTO;
using QLHK_BUS;
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
    public partial class FrmChiTietHoKhau : Form
    {
        HoKhau hoKhau;
        List<CongDan> listCongDan = new List<CongDan>(0);
        List<CongDan> listCongDanRemove = new List<CongDan>(0);
        CongDan congDanSelect;
        CongDanBUS congDanBUS = new CongDanBUS();
        HoKhauBUS hoKhauBUS = new HoKhauBUS();
        CongDan congDanThem = null;
        
        public FrmChiTietHoKhau(HoKhau hk)
        {
            InitializeComponent();
            if (hk == null)
            {
                SetThemHoKhau();

                hoKhau = new HoKhau();
                hoKhau.NgayCap = DateTime.Now;
            }
            else
            {
                SetSuaHoKhau();
                disableSua();
                rbKhong.Select();

                hoKhau = hk;
                setData(hoKhau);
                listCongDan = congDanBUS.ReadAllByMaHoKhau(hoKhau.SoHoKhau);
            }

            disableSelect();

            SetDataGridView();

            btnLuuSua.Click += BtnLuuSua_Click;
            btnLuuThem.Click += BtnLuuThem_Click;
            btnQuayLai.Click += BtnQuayLai_Click;

            btnXemNhanKhau.Click += BtnXemNhanKhau_Click;
            btnThemNhanKhau.Click += BtnThemNhanKhau_Click;
            btnXoaNhanKhau.Click += BtnXoaNhanKhau_Click;
            btnChonChuHo.Click += BtnChonChuHo_Click;

            rbCo.Click += RbCo_Click;
            rbKhong.Click += RbKhong_Click;

            loadData_Vao_GridView();
            dgvCongDan.CellClick += DgvCongDan_CellClick;

            tbDiaChi.TextChanged += TbDiaChi_TextChanged;
        }

        private void BtnChonChuHo_Click(object sender, EventArgs e)
        {
            if (congDanSelect == null) return;

            congDanSelect.SetChuHo(hoKhau);
            tbChuSo.Text = congDanSelect.HoTen;
        }

        private void TbDiaChi_TextChanged(object sender, EventArgs e)
        {
            foreach (CongDan congDan in listCongDan)
            {
                hoKhau.Update(congDan);
            }
        }

        private void BtnLuuSua_Click(object sender, EventArgs e)
        {
            getData();

            bool result;
            result = hoKhauBUS.Update(hoKhau);
            if (result)
            {
                MessageBox.Show("Cập nhật Hộ khẩu thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi trong Cập nhật hộ khẩu");
                return;
            }

            UpdateCongDanDatabase(ref result);
        }

        private void UpdateCongDanDatabase(ref bool result)
        {
            foreach (CongDan congDan in listCongDan)
            {
                hoKhau.Update(congDan);

                result = congDanBUS.Update(congDan);

                if (result)
                {
                    MessageBox.Show("Cập nhật nhân khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong Cập nhật nhân khẩu");
                    return;
                }
            }

            foreach (CongDan congDan in listCongDanRemove)
            {
                congDan.MaHoKhau = Init.STRING;
                congDan.DiaChiHoKhau = Init.STRING;

                result = congDanBUS.Update(congDan);

                if (result)
                {
                    MessageBox.Show("Cập nhật nhân khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong Cập nhật nhân khẩu");
                    return;
                }
            }
        }

        private void BtnLuuThem_Click(object sender, EventArgs e)
        {
            getData();

            string error = "";
            if (!hoKhauBUS.Validate(hoKhau, ref error))
            {
                MessageBox.Show(error);
                return;
            }

            bool result;
            result = hoKhauBUS.Add(hoKhau);
            if (result)
            {
                MessageBox.Show("Thêm Hộ khẩu thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi trong Thêm hộ khẩu");
                return;
            }

            UpdateCongDanDatabase(ref result);
        }

        private void BtnXoaNhanKhau_Click(object sender, EventArgs e)
        {
            if (!listCongDanRemove.Contains(congDanSelect))
                listCongDanRemove.Add(congDanSelect);

            if (listCongDan.Contains(congDanSelect))
                listCongDan.Remove(congDanSelect);

            disableSelect();

            MessageBox.Show("Xoá nhân khẩu thành công\n chọn Lưu trong màn hình thông tin nhân khẩu để có thể cập nhật trong CSDL");

            loadData_Vao_GridView();
        }

        private void BtnThemNhanKhau_Click(object sender, EventArgs e)
        {
            FrmDanhSachNhanKhau frm = new FrmDanhSachNhanKhau(FormType.CHI_TIET_HO_KHAU);
            frm.ValueEvent += Frm_ValueEvent;
            frm.Show(this);
        }

        private void Frm_ValueEvent(CongDan congDan)
        {
            hoKhau.Update(congDan);

            if (listCongDanRemove.Contains(congDan))
                listCongDanRemove.Remove(congDan);

            if (!listCongDan.Contains(congDan))
                listCongDan.Add(congDan);

            loadData_Vao_GridView();
        }

        private void Frm_AddCongDanEvent(object sender, CongDan cd)
        {
            listCongDan.Add(congDanThem);

            dgvCongDan.DataSource = listCongDan;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvCongDan.DataSource];
            myCurrencyManager.Refresh();
            dgvCongDan.Invalidate();
        }

        private void BtnXemNhanKhau_Click(object sender, EventArgs e)
        {
            FrmChiTietNhanKhau frm = new FrmChiTietNhanKhau(congDanSelect);
            frm.FormClosed += Frm_FormSuaNhanKhauClosed;
            frm.Show();
        }

        private void Frm_FormSuaNhanKhauClosed(object sender, FormClosedEventArgs e)
        {
            dgvCongDan.Invalidate();
        }

        private void DgvCongDan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow == -1)
            {
                disableSelect();
            }
            else
            {
                enableSelect();
                congDanSelect = listCongDan[numrow];
            }
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            setData(hoKhau);
        }

        private void RbKhong_Click(object sender, EventArgs e)
        {
            disableSua();
        }

        private void RbCo_Click(object sender, EventArgs e)
        {
            enableSua();
        }

        private void loadData_Vao_GridView()
        {
            if (listCongDan == null)
            {
                MessageBox.Show("Có lỗi khi đọc danh sách nhân khẩu");
                return;
            }

            dgvCongDan.DataSource = listCongDan;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvCongDan.DataSource];
            myCurrencyManager.Refresh();

            dgvCongDan.Invalidate();
        }

        private void SetDataGridView()
        {
            dgvCongDan.AutoGenerateColumns = false;
            dgvCongDan.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn clSo = new DataGridViewTextBoxColumn();
            clSo.Name = "HoTen";
            clSo.HeaderText = "Họ tên";
            clSo.DataPropertyName = "HoTen";
            dgvCongDan.Columns.Add(clSo);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "GioiTinh";
            clTen.HeaderText = "Giới tính";
            clTen.DataPropertyName = "GioiTinh";
            dgvCongDan.Columns.Add(clTen);

            DataGridViewTextBoxColumn clDiaChi = new DataGridViewTextBoxColumn();
            clDiaChi.Name = "NgaySinh";
            clDiaChi.HeaderText = "Ngày sinh";
            clDiaChi.DataPropertyName = "NgaySinh";
            dgvCongDan.Columns.Add(clDiaChi);

            DataGridViewTextBoxColumn clLoaiSo = new DataGridViewTextBoxColumn();
            clLoaiSo.Name = "QueQuan";
            clLoaiSo.HeaderText = "Quê quán";
            clLoaiSo.DataPropertyName = "QueQuan";
            dgvCongDan.Columns.Add(clLoaiSo);

            DataGridViewTextBoxColumn clNgayLap = new DataGridViewTextBoxColumn();
            clNgayLap.Name = "QuocTich";
            clNgayLap.HeaderText = "Quốc tịch";
            clNgayLap.DataPropertyName = "QuocTich";
            dgvCongDan.Columns.Add(clNgayLap);

            dgvCongDan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void setData(HoKhau result)
        {
            tbSoSo.Text = result.SoHoKhau;
            tbChuSo.Text = result.TenChuHo;
            tbLoaiSo.Text = result.LoaiSo;
            dtpNgayLap.Value = result.NgayCap;
            tbLyDoLap.Text = result.LyDoCap;
            tbNguoiLap.Text = result.NguoiCap;
            tbDiaChi.Text = result.DiaChi;
        }

        private void getData()
        {
            hoKhau.SoHoKhau = tbSoSo.Text;
            hoKhau.TenChuHo = tbChuSo.Text;
            hoKhau.LoaiSo = tbLoaiSo.Text;
            hoKhau.NgayCap = dtpNgayLap.Value;
            hoKhau.LyDoCap = tbLyDoLap.Text;
            hoKhau.NguoiCap = tbNguoiLap.Text;
            hoKhau.DiaChi = tbDiaChi.Text;
        }

        private void enableSua()
        {
            tbLoaiSo.Enabled = true;
            tbDiaChi.Enabled = true;

            btnLuuSua.Enabled = true;
            btnQuayLai.Enabled = true;
            btnThemNhanKhau.Enabled = true;
        }

        private void disableSua()
        {
            tbSoSo.Enabled = false;
            tbLoaiSo.Enabled = false;
            dtpNgayLap.Enabled = false;
            tbLyDoLap.Enabled = false;
            tbNguoiLap.Enabled = false;
            tbDiaChi.Enabled = false;

            btnLuuSua.Enabled = false;
            btnQuayLai.Enabled = false;
            btnThemNhanKhau.Enabled = false;
        }

        private void enableSelect()
        {
            btnXemNhanKhau.Enabled = true;
            btnXoaNhanKhau.Enabled = true;
            btnChonChuHo.Enabled = true;
        }

        private void disableSelect()
        {
            btnXemNhanKhau.Enabled = false;
            btnXoaNhanKhau.Enabled = false;
            btnChonChuHo.Enabled = false;
        }

        private void SetThemHoKhau()
        {
            lbSua.Visible = false;
            rbCo.Visible = false;
            rbKhong.Visible = false;
            btnQuayLai.Visible = false;
            btnLuuSua.Visible = false;

            tbNguoiLap.Text = TaiKhoan.TaiKhoanHienTai.TenHienThi;
            dtpNgayLap.Value = Init.DATE;
        }

        private void SetSuaHoKhau()
        {
            btnLuuThem.Visible = false;
        }
    }
}
