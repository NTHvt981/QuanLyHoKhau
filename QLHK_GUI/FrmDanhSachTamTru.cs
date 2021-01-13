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
    public partial class FrmDanhSachTamTru : Form
    {
        PhieuTamTruBUS bus = new PhieuTamTruBUS();
        List<PhieuTamTru> listPhieuTamTru;
        PhieuTamTru phieuTamTruSelected = new PhieuTamTru();
        public FrmDanhSachTamTru()
        {
            InitializeComponent();

            dgvPhieuTamTru.CellClick += DgvPhieuTamTru_CellClick;

            btnTaiLai.Click += BtnTaiLai_Click;
            btnThem.Click += BtnThem_Click;
            btnXemChiTiet.Click += BtnXemChiTiet_Click;
            btnXoa.Click += BtnXoa_Click;

            tbTimKiem.TextChanged += TbTimKiem_TextChanged;
            tbTimKiem.Enter += tbTimKiem_Enter;
            tbTimKiem.Leave += tbTimKiem_Leave;
            tbTimKiem_SetText();

            dgvPhieuTamTru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvPhieuTamTru.DefaultCellStyle.ForeColor = Color.Black;

            this.Load += FrmDanhSachTamTru_Load;
            this.Shown += FrmDanhSachTamTru_Shown;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            bool result = bus.Delete(phieuTamTruSelected);
            if (result)
            {
                listPhieuTamTru = bus.ReadAll();
                loadData_Vao_GridView();

                MessageBox.Show("Xoá phiếu tạm trú thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi trong việc xoá phiếu tạm trú");
            }
        }

        private void FrmDanhSachTamTru_Shown(object sender, EventArgs e)
        {
            disableSelect();
        }

        private void BtnXemChiTiet_Click(object sender, EventArgs e)
        {
            FrmChiTietPhieuTamTru frm = new FrmChiTietPhieuTamTru(phieuTamTruSelected);
            frm.Show();
        }

        private void FrmDanhSachTamTru_Load(object sender, EventArgs e)
        {
            listPhieuTamTru = bus.ReadAll();
            loadData_Vao_GridView();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            FrmChiTietPhieuTamTru frm = new FrmChiTietPhieuTamTru(null);
            frm.Show();
        }

        private void BtnTaiLai_Click(object sender, EventArgs e)
        {
            listPhieuTamTru = bus.ReadAll();
            loadData_Vao_GridView();
        }

        private void TbTimKiem_TextChanged(object sender, EventArgs e)
        {
            listPhieuTamTru = bus.ReadAllByKeyWord(tbTimKiem.Text);
            loadData_Vao_GridView();
        }

        private void DgvPhieuTamTru_CellClick(object sender, DataGridViewCellEventArgs e)
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
                phieuTamTruSelected = listPhieuTamTru[numrow];
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
            if (listPhieuTamTru == null)
            {
                MessageBox.Show("Có lỗi khi đọc danh sách hộ khẩu từ CSDL");
                return;
            }

            dgvPhieuTamTru.Columns.Clear();
            dgvPhieuTamTru.DataSource = null;

            dgvPhieuTamTru.AutoGenerateColumns = false;
            dgvPhieuTamTru.AllowUserToAddRows = false;

            dgvPhieuTamTru.DataSource = listPhieuTamTru;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Ma";
            clMa.HeaderText = "Mã";
            clMa.DataPropertyName = "Ma";
            dgvPhieuTamTru.Columns.Add(clMa);

            DataGridViewTextBoxColumn clHoTen = new DataGridViewTextBoxColumn();
            clHoTen.Name = "NguoiKhaiBao";
            clHoTen.HeaderText = "Họ tên";
            clHoTen.DataPropertyName = "NguoiKhaiBao";
            dgvPhieuTamTru.Columns.Add(clHoTen);

            DataGridViewTextBoxColumn clNoiTamTru = new DataGridViewTextBoxColumn();
            clNoiTamTru.Name = "NoiTamTru";
            clNoiTamTru.HeaderText = "Nơi tạm trú";
            clNoiTamTru.DataPropertyName = "NoiTamTru";
            dgvPhieuTamTru.Columns.Add(clNoiTamTru);

            DataGridViewTextBoxColumn clTgBD = new DataGridViewTextBoxColumn();
            clTgBD.Name = "LyDo";
            clTgBD.HeaderText = "Lý do";
            clTgBD.DataPropertyName = "LyDo";
            dgvPhieuTamTru.Columns.Add(clTgBD);

            DataGridViewTextBoxColumn clTgKT = new DataGridViewTextBoxColumn();
            clTgKT.Name = "NgayGhi";
            clTgKT.HeaderText = "Ngày ghi";
            clTgKT.DataPropertyName = "NgayGhi";
            dgvPhieuTamTru.Columns.Add(clTgKT);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvPhieuTamTru.DataSource];
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
