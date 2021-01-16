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
    public partial class FrmDanhSachNhanKhau : Form
    {
        CongDanBUS bus = new CongDanBUS();
        List<CongDan> listCongDan;
        CongDan congDanSelected = new CongDan();
        FormType formType;

        public delegate void MyEvent(CongDan congDan);
        public event MyEvent ValueEvent;
        public FrmDanhSachNhanKhau(FormType t)
        {
            InitializeComponent();

            formType = t;

            dgvNhanKhau.CellClick += DgvNhanKhau_CellClick;

            btnTaiLai.Click += BtnTaiLai_Click;
            btnThem.Click += BtnThem_Click;
            btnXemChiTiet.Click += BtnXemChiTiet_Click;
            btnXoa.Click += BtnXoa_Click;

            btnHoKhau.Click += BtnHoKhau_Click;
            btnPhieuTamVang.Click += BtnPhieuTamVang_Click;

            tbTimKiem.TextChanged += TbTimKiem_TextChanged;
            tbTimKiem.Enter += tbTimKiem_Enter;
            tbTimKiem.Leave += tbTimKiem_Leave;
            tbTimKiem_SetText();
            disableSelect();

            dgvNhanKhau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvNhanKhau.DefaultCellStyle.ForeColor = Color.Black;

            listCongDan = bus.ReadAll();
            loadData_Vao_GridView();
        }

        private void BtnPhieuTamVang_Click(object sender, EventArgs e)
        {
            ValueEvent?.Invoke(congDanSelected);
            Close();
        }

        private void BtnHoKhau_Click(object sender, EventArgs e)
        {
            ValueEvent?.Invoke(congDanSelected);
            Close();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            bool result = bus.Delete(congDanSelected);
            if (result)
            {
                listCongDan = bus.ReadAll();
                loadData_Vao_GridView();

                MessageBox.Show("Xoá nhân khẩu thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi trong việc xoá nhân khẩu");
            }
        }

        private void BtnXemChiTiet_Click(object sender, EventArgs e)
        {
            FrmChiTietNhanKhau frm = new FrmChiTietNhanKhau(congDanSelected);
            frm.Show(this);
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            FrmChiTietNhanKhau frm = new FrmChiTietNhanKhau(null);
            frm.Show(this);
        }

        private void BtnTaiLai_Click(object sender, EventArgs e)
        {
            listCongDan = bus.ReadAll();
            loadData_Vao_GridView();
        }

        private void TbTimKiem_TextChanged(object sender, EventArgs e)
        {
            listCongDan = bus.ReadAllByKeyWord(tbTimKiem.Text);
            loadData_Vao_GridView();
        }

        private void DgvNhanKhau_CellClick(object sender, DataGridViewCellEventArgs e)
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
                congDanSelected = listCongDan[numrow];
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
            if (listCongDan == null)
            {
                MessageBox.Show("Có lỗi khi đọc danh sách hộ khẩu từ CSDL");
                return;
            }

            dgvNhanKhau.Columns.Clear();
            dgvNhanKhau.DataSource = null;

            dgvNhanKhau.AutoGenerateColumns = false;
            dgvNhanKhau.AllowUserToAddRows = false;

            dgvNhanKhau.DataSource = listCongDan;

            DataGridViewTextBoxColumn clHoTen = new DataGridViewTextBoxColumn();
            clHoTen.Name = "HoTen";
            clHoTen.HeaderText = "Họ tên";
            clHoTen.DataPropertyName = "HoTen";
            dgvNhanKhau.Columns.Add(clHoTen);

            DataGridViewTextBoxColumn clCMND = new DataGridViewTextBoxColumn();
            clCMND.Name = "SoCmnd";
            clCMND.HeaderText = "Số CMND";
            clCMND.DataPropertyName = "SoCmnd";
            dgvNhanKhau.Columns.Add(clCMND);

            DataGridViewTextBoxColumn clCCCD = new DataGridViewTextBoxColumn();
            clCCCD.Name = "SoCccd";
            clCCCD.HeaderText = "Số CCCD";
            clCCCD.DataPropertyName = "SoCccd";
            dgvNhanKhau.Columns.Add(clCCCD);

            DataGridViewTextBoxColumn clGT = new DataGridViewTextBoxColumn();
            clGT.Name = "GioiTinh";
            clGT.HeaderText = "Giới tính";
            clGT.DataPropertyName = "GioiTinh";
            dgvNhanKhau.Columns.Add(clGT);

            DataGridViewTextBoxColumn clQQ = new DataGridViewTextBoxColumn();
            clQQ.Name = "QueQuan";
            clQQ.HeaderText = "Quê quán";
            clQQ.DataPropertyName = "QueQuan";
            dgvNhanKhau.Columns.Add(clQQ);

            DataGridViewTextBoxColumn clQT = new DataGridViewTextBoxColumn();
            clQT.Name = "QuocTich";
            clQT.HeaderText = "Quốc tịch";
            clQT.DataPropertyName = "QuocTich";
            dgvNhanKhau.Columns.Add(clQT);

            DataGridViewTextBoxColumn clDC = new DataGridViewTextBoxColumn();
            clDC.Name = "diaChiThuongTru";
            clDC.HeaderText = "Địa chỉ";
            clDC.DataPropertyName = "diaChiThuongTru";
            dgvNhanKhau.Columns.Add(clDC);


        CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvNhanKhau.DataSource];
            myCurrencyManager.Refresh();
        }

        private void enableSelect()
        {
            btnXemChiTiet.Enabled = true;
            btnXoa.Enabled = true;

            switch (formType)
            {
                case FormType.MAIN:
                    break;
                case FormType.CHI_TIET_HO_KHAU:
                    btnHoKhau.Enabled = true;
                    break;
                case FormType.CHI_TIET_PHIEU_TAM_VANG:
                    btnPhieuTamVang.Enabled = true;
                    break;
                case FormType.CHI_TIET_PHIEU_TAM_TRU:
                    break;
                default:
                    break;
            }
        }

        private void disableSelect()
        {
            btnXemChiTiet.Enabled = false;
            btnXoa.Enabled = false;
            btnHoKhau.Enabled = false;
            btnPhieuTamVang.Enabled = false;
        }
    }
}
