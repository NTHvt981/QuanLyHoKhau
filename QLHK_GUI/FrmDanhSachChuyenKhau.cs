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
    public partial class FrmDanhSachChuyenKhau : Form
    {
        PhieuChuyenKhauBUS bus = new PhieuChuyenKhauBUS();
        List<PhieuChuyenKhau> listPhieuChuyenKhau;
        PhieuChuyenKhau chuyenKhauSelect;
        public FrmDanhSachChuyenKhau()
        {
            InitializeComponent();

            dgvChuyenKhau.CellClick += DgvPhieuChuyenKhau_CellClick;

            btnTaiLai.Click += BtnTaiLai_Click;
            btnXemChiTiet.Click += BtnXemChiTiet_Click;

            dgvChuyenKhau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            this.Load += FrmDanhSachPhieuChuyenKhau_Load;
        }

        private void BtnXemChiTiet_Click(object sender, EventArgs e)
        {
            FrmChiTietChuyenKhau frm = new FrmChiTietChuyenKhau(chuyenKhauSelect);
            frm.Show(this);
        }

        private void FrmDanhSachPhieuChuyenKhau_Load(object sender, EventArgs e)
        {
            listPhieuChuyenKhau = bus.ReadAll();
            loadData_Vao_GridView();
        }

        private void BtnTaiLai_Click(object sender, EventArgs e)
        {
            listPhieuChuyenKhau = bus.ReadAll();
            loadData_Vao_GridView();
        }

        private void DgvPhieuChuyenKhau_CellClick(object sender, DataGridViewCellEventArgs e)
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
                chuyenKhauSelect = listPhieuChuyenKhau[numrow];
            }
        }

        private void loadData_Vao_GridView()
        {
            if (listPhieuChuyenKhau == null)
            {
                MessageBox.Show("Có lỗi khi đọc danh sách hộ khẩu từ CSDL");
                return;
            }


            dgvChuyenKhau.Columns.Clear();
            dgvChuyenKhau.DataSource = null;

            dgvChuyenKhau.AutoGenerateColumns = false;
            dgvChuyenKhau.AllowUserToAddRows = false;

            dgvChuyenKhau.DataSource = listPhieuChuyenKhau;

            DataGridViewTextBoxColumn clSo = new DataGridViewTextBoxColumn();
            clSo.Name = "congDan";
            clSo.HeaderText = "Họ tên người chuyển";
            clSo.DataPropertyName = "HoTen";
            dgvChuyenKhau.Columns.Add(clSo);

            DataGridViewTextBoxColumn clDiaChi = new DataGridViewTextBoxColumn();
            clDiaChi.Name = "hoKhauChuyenTu";
            clDiaChi.HeaderText = "Số hộ khẩu cũ";
            clDiaChi.DataPropertyName = "SoHKCu";
            dgvChuyenKhau.Columns.Add(clDiaChi);

            DataGridViewTextBoxColumn clLoaiSo = new DataGridViewTextBoxColumn();
            clLoaiSo.Name = "hoKhauChuyenDen";
            clLoaiSo.HeaderText = "Số hộ khẩu mới";
            clLoaiSo.DataPropertyName = "SoHKMoi";
            dgvChuyenKhau.Columns.Add(clLoaiSo);

            DataGridViewTextBoxColumn clNgayLap = new DataGridViewTextBoxColumn();
            clNgayLap.Name = "NgayCap";
            clNgayLap.HeaderText = "Ngày Chuyển khẩu";
            clNgayLap.DataPropertyName = "NgayChuyenKhau";
            dgvChuyenKhau.Columns.Add(clNgayLap);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvChuyenKhau.DataSource];
            myCurrencyManager.Refresh();

            dgvChuyenKhau.Invalidate();
        }
        private void enableSelect()
        {
            btnXemChiTiet.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void disableSelect()
        {
            btnXemChiTiet.Enabled = false;
            btnXoa.Enabled = false;
        }
    }
}
