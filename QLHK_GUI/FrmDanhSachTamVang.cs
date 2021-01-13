using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QLHK_BUS;
using QLHK_DTO;

namespace QLHK_GUI
{
    public partial class FrmDanhSachTamVang : Form
    {
        PhieuTamVangBUS bus = new PhieuTamVangBUS();
        List<PhieuTamVang> listPhieuTamVang;
        PhieuTamVang phieuTamVangSelected = new PhieuTamVang();

        public FrmDanhSachTamVang()
        {
            InitializeComponent();

            dgvPhieuTamVang.CellClick += DgvPhieuTamVang_CellClick;

            btnTaiLai.Click += BtnTaiLai_Click;
            btnThem.Click += BtnThem_Click  ;
            btnXemChiTiet.Click += BtnXemChiTiet_Click;
            btnXoa.Click += BtnXoa_Click;

            tbTimKiem.TextChanged += TbTimKiem_TextChanged;
            tbTimKiem.Enter += tbTimKiem_Enter;
            tbTimKiem.Leave += tbTimKiem_Leave;
            tbTimKiem_SetText();
            disableSelect();

            dgvPhieuTamVang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvPhieuTamVang.DefaultCellStyle.ForeColor = Color.Black;

            listPhieuTamVang = bus.ReadAll();
            loadData_Vao_GridView();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            bool result = bus.Delete(phieuTamVangSelected);
            if (result)
            {
                listPhieuTamVang = bus.ReadAll();
                loadData_Vao_GridView();

                MessageBox.Show("Xoá phiếu tạm vắng thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi trong việc xoá phiếu tạm vắng");
            }
        }

        private void BtnXemChiTiet_Click(object sender, EventArgs e)
        {
            FrmChiTietPhieuTamVang frm = new FrmChiTietPhieuTamVang(phieuTamVangSelected);
            frm.Show();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            FrmChiTietPhieuTamVang frm = new FrmChiTietPhieuTamVang(null);
            frm.Show();
        }

        private void BtnTaiLai_Click(object sender, EventArgs e)
        {
            listPhieuTamVang = bus.ReadAll();
            loadData_Vao_GridView();
        }

        private void TbTimKiem_TextChanged(object sender, EventArgs e)
        {
            listPhieuTamVang = bus.ReadAllByKeyWord(tbTimKiem.Text);
            loadData_Vao_GridView();
        }

        private void DgvPhieuTamVang_CellClick(object sender, DataGridViewCellEventArgs e)
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
                phieuTamVangSelected = listPhieuTamVang[numrow];
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
            if (listPhieuTamVang == null)
            {
                MessageBox.Show("Có lỗi khi đọc danh sách hộ khẩu từ CSDL");
                return;
            }

            dgvPhieuTamVang.Columns.Clear();
            dgvPhieuTamVang.DataSource = null;

            dgvPhieuTamVang.AutoGenerateColumns = false;
            dgvPhieuTamVang.AllowUserToAddRows = false;

            dgvPhieuTamVang.DataSource = listPhieuTamVang;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Ma";
            clMa.HeaderText = "Mã";
            clMa.DataPropertyName = "Ma";
            dgvPhieuTamVang.Columns.Add(clMa);
            
            DataGridViewTextBoxColumn clHoTen = new DataGridViewTextBoxColumn();
            clHoTen.Name = "NguoiKhaiBao";
            clHoTen.HeaderText = "Họ tên";
            clHoTen.DataPropertyName = "NguoiKhaiBao";
            dgvPhieuTamVang.Columns.Add(clHoTen);

            DataGridViewTextBoxColumn clCmnd = new DataGridViewTextBoxColumn();
            clCmnd.Name = "SoCmndCccd";
            clCmnd.HeaderText = "Số cmnd/cccd";
            clCmnd.DataPropertyName = "SoCmndCccd";
            dgvPhieuTamVang.Columns.Add(clCmnd);

            DataGridViewTextBoxColumn clTgBD = new DataGridViewTextBoxColumn();
            clTgBD.Name = "ThoiGianBatDau";
            clTgBD.HeaderText = "Từ ngày";
            clTgBD.DataPropertyName = "ThoiGianBatDau";
            dgvPhieuTamVang.Columns.Add(clTgBD);

            DataGridViewTextBoxColumn clTgKT = new DataGridViewTextBoxColumn();
            clTgKT.Name = "ThoiGianKetThuc";
            clTgKT.HeaderText = "Đến ngày";
            clTgKT.DataPropertyName = "ThoiGianKetThuc";
            dgvPhieuTamVang.Columns.Add(clTgKT);

            DataGridViewTextBoxColumn clNoiTamTru = new DataGridViewTextBoxColumn();
            clNoiTamTru.Name = "NoiTamTru";
            clNoiTamTru.HeaderText = "Nơi tạm trú";
            clNoiTamTru.DataPropertyName = "NoiTamTru";
            dgvPhieuTamVang.Columns.Add(clNoiTamTru);
            

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvPhieuTamVang.DataSource];
            myCurrencyManager.Refresh();
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
