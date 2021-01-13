﻿using QLHK_BUS;
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
    public partial class FrmDanhSachHoKhau : Form
    {
        HoKhauBUS hkBus = new HoKhauBUS();
        List<HoKhau> listHoKhau;
        HoKhau hoKhauSelected;

        public FrmDanhSachHoKhau()
        {
            InitializeComponent();

            dgvHoKhau.CellClick += DgvHoKhau_CellClick;

            btnTaiLai.Click += BtnTaiLai_Click;
            btnXemChiTiet.Click += BtnXemChiTiet_Click;
            btnXoa.Click += BtnXoa_Click;
            btnThem.Click += BtnThem_Click;

            tbTimKiem.TextChanged += TbTimKiem_TextChanged;
            tbTimKiem.Enter += tbTimKiem_Enter;
            tbTimKiem.Leave += tbTimKiem_Leave;
            tbTimKiem_SetText();

            dgvHoKhau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            this.Load += FrmDanhSachHoKhau_Load;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            FrmChiTietHoKhau frm = new FrmChiTietHoKhau(null);
            frm.Show();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnXemChiTiet_Click(object sender, EventArgs e)
        {
            FrmChiTietHoKhau frm = new FrmChiTietHoKhau(hoKhauSelected);
            frm.Show();
        }

        private void FrmDanhSachHoKhau_Load(object sender, EventArgs e)
        {
            listHoKhau = hkBus.ReadAll();
            loadData_Vao_GridView();
        }

        private void BtnTaiLai_Click(object sender, EventArgs e)
        {
            listHoKhau = hkBus.ReadAll();
            loadData_Vao_GridView();
        }

        private void TbTimKiem_TextChanged(object sender, EventArgs e)
        {
            listHoKhau = hkBus.ReadAllByKeyWord(tbTimKiem.Text);
            loadData_Vao_GridView();
        }

        private void DgvHoKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow == -1)
            {
                btnXemChiTiet.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnXemChiTiet.Enabled = true;
                btnXoa.Enabled = true;
                hoKhauSelected = listHoKhau[numrow];
            }
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
            if (listHoKhau == null)
            {
                MessageBox.Show("Có lỗi khi đọc danh sách hộ khẩu từ CSDL");
                return;
            }


            dgvHoKhau.Columns.Clear();
            dgvHoKhau.DataSource = null;

            dgvHoKhau.AutoGenerateColumns = false;
            dgvHoKhau.AllowUserToAddRows = false;

            dgvHoKhau.DataSource = listHoKhau;

            DataGridViewTextBoxColumn clSo = new DataGridViewTextBoxColumn();
            clSo.Name = "SoSo";
            clSo.HeaderText = "Số sổ HK";
            clSo.DataPropertyName = "SoSo";
            dgvHoKhau.Columns.Add(clSo);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "ChuHo";
            clTen.HeaderText = "Họ tên";
            clTen.DataPropertyName = "ChuHo";
            dgvHoKhau.Columns.Add(clTen);

            DataGridViewTextBoxColumn clDiaChi = new DataGridViewTextBoxColumn();
            clDiaChi.Name = "DiaChi";
            clDiaChi.HeaderText = "Địa chỉ";
            clDiaChi.DataPropertyName = "DiaChi";
            dgvHoKhau.Columns.Add(clDiaChi);

            DataGridViewTextBoxColumn clLoaiSo = new DataGridViewTextBoxColumn();
            clLoaiSo.Name = "LoaiSo";
            clLoaiSo.HeaderText = "Loại sổ";
            clLoaiSo.DataPropertyName = "LoaiSo";
            dgvHoKhau.Columns.Add(clLoaiSo);

            DataGridViewTextBoxColumn clNgayLap = new DataGridViewTextBoxColumn();
            clNgayLap.Name = "NgayLap";
            clNgayLap.HeaderText = "Ngày lập sổ";
            clNgayLap.DataPropertyName = "NgayLap";
            dgvHoKhau.Columns.Add(clNgayLap);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvHoKhau.DataSource];
            myCurrencyManager.Refresh();

            dgvHoKhau.Invalidate();
        }
    }
}