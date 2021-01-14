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
                hoKhau.NgayLap = DateTime.Now;
            }
            else
            {
                SetSuaHoKhau();
                disableSua();
                rbKhong.Select();

                hoKhau = hk;
                listCongDan = congDanBUS.ReadAllByMaHoKhau(hoKhau.SoSo);
            }

            setData(hoKhau);
            disableSelect();

            SetDataGridView();

            btnLuuSua.Click += BtnLuuSua_Click;
            btnLuuThem.Click += BtnLuuThem_Click;
            btnQuayLai.Click += BtnQuayLai_Click;
            btnXemNhanKhau.Click += BtnXemNhanKhau_Click;
            btnThemNhanKhau.Click += BtnThemNhanKhau_Click;
            btnXoaNhanKhau.Click += BtnXoaNhanKhau_Click;

            rbCo.Click += RbCo_Click;
            rbKhong.Click += RbKhong_Click;

            tbTimKiem.TextChanged += TbTimKiem_TextChanged;
            tbTimKiem.Enter += tbTimKiem_Enter;
            tbTimKiem.Leave += tbTimKiem_Leave;
            tbTimKiem_SetText();

            loadData_Vao_GridView();
            dgvCongDan.CellClick += DgvCongDan_CellClick;
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

                if (congDanBUS.ExistInDatabase(congDan))
                {
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
                else
                {
                    result = congDanBUS.Add(congDan);

                    if (result)
                    {
                        MessageBox.Show("thêm nhân khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong thêm nhân khẩu");
                        return;
                    }
                }
            }

            foreach (CongDan congDan in listCongDanRemove)
            {
                result = congDanBUS.Delete(congDan);

                if (result)
                {
                    MessageBox.Show("xoá nhân khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong xoá nhân khẩu");
                    return;
                }
            }
        }

        private void BtnLuuThem_Click(object sender, EventArgs e)
        {
            getData();

            bool result;
            result = hoKhauBUS.Update(hoKhau);
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
            listCongDanRemove.Add(congDanSelect);
            listCongDan.Remove(congDanSelect);
            disableSelect();

            MessageBox.Show("Xoá nhân khẩu thành công\n chọn Lưu trong màn hình thông tin nhân khẩu để có thể cập nhật trong CSDL");

            dgvCongDan.DataSource = listCongDan;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvCongDan.DataSource];
            myCurrencyManager.Refresh();
            dgvCongDan.Invalidate();
        }

        private void BtnThemNhanKhau_Click(object sender, EventArgs e)
        {
            congDanThem = new CongDan();
            congDanThem.MaHoKhau = hoKhau.SoSo;
            congDanThem.DiaChiThuongTru = hoKhau.DiaChi;
            congDanThem.NgaySinh = DateTime.Now;

            FrmChiTietNhanKhau frm = new FrmChiTietNhanKhau(congDanThem);
            frm.AddCongDanEvent += Frm_AddCongDanEvent;
            frm.Show();
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
        private void TbTimKiem_TextChanged(object sender, EventArgs e)
        {
            //listHoKhau = hkBus.ReadAllByKeyWord(tbTimKiem.Text);
            //loadData_Vao_GridView();
        }

        protected void tbTimKiem_SetText()
        {
            tbTimKiem.Text = "Tìm kiếm";
            tbTimKiem.ForeColor = Color.Gray;
        }

        private void tbTimKiem_Enter(object sender, EventArgs e)
        {
            if (tbTimKiem.ForeColor == Color.Black)
                return;
            tbTimKiem.Text = "";
            tbTimKiem.ForeColor = Color.Black;
        }
        private void tbTimKiem_Leave(object sender, EventArgs e)
        {
            if (tbTimKiem.Text.Trim() == "")
                tbTimKiem_SetText();
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
            tbSoSo.Text = result.SoSo;
            tbChuSo.Text = result.ChuHo;
            tbLoaiSo.Text = result.LoaiSo;
            dtpNgayLap.Value = result.NgayLap;
            tbLyDoLap.Text = result.LyDoLap;
            tbNguoiLap.Text = result.NguoiLam;
            tbDiaChi.Text = result.DiaChi;
        }

        private void getData()
        {
            hoKhau.SoSo = tbSoSo.Text;
            hoKhau.ChuHo = tbChuSo.Text;
            hoKhau.LoaiSo = tbLoaiSo.Text;
            hoKhau.NgayLap = dtpNgayLap.Value;
            hoKhau.LyDoLap = tbLyDoLap.Text;
            hoKhau.NguoiLam = tbNguoiLap.Text;
            hoKhau.DiaChi = tbDiaChi.Text;
        }

        private void enableSua()
        {
            tbSoSo.Enabled = true;
            tbChuSo.Enabled = true;
            tbLoaiSo.Enabled = true;
            dtpNgayLap.Enabled = true;
            tbLyDoLap.Enabled = true;
            tbNguoiLap.Enabled = true;
            tbDiaChi.Enabled = true;

            btnLuuSua.Enabled = true;
            btnQuayLai.Enabled = true;
            btnThemNhanKhau.Enabled = true;
        }

        private void disableSua()
        {
            tbSoSo.Enabled = false;
            tbChuSo.Enabled = false;
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
        }

        private void disableSelect()
        {
            btnXemNhanKhau.Enabled = false;
            btnXoaNhanKhau.Enabled = false;
        }

        private void SetThemHoKhau()
        {
            lbSua.Visible = false;
            rbCo.Visible = false;
            rbKhong.Visible = false;
            btnQuayLai.Visible = false;
            btnLuuSua.Visible = false;
        }

        private void SetSuaHoKhau()
        {
            btnLuuThem.Visible = false;
        }
    }
}
