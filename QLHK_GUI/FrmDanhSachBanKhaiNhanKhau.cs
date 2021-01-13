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
    public partial class FrmDanhSachBanKhaiNhanKhau : Form
    {
        BanKhaiNhanKhauBUS bus = new BanKhaiNhanKhauBUS();
        List<BanKhaiNhanKhau> listBanKhaiNhanKhau;
        BanKhaiNhanKhau phieuBanKhaiNhanKhauSelected = new BanKhaiNhanKhau();
        public FrmDanhSachBanKhaiNhanKhau()
        {
            InitializeComponent();

            dgvBanKhaiNhanKhau.CellClick += DgvBanKhaiNhanKhau_CellClick;

            btnTaiLai.Click += BtnTaiLai_Click;
            btnThem.Click += BtnThem_Click;
            btnXemChiTiet.Click += BtnXemChiTiet_Click;
            btnXoa.Click += BtnXoa_Click;

            tbTimKiem.TextChanged += TbTimKiem_TextChanged;
            tbTimKiem.Enter += tbTimKiem_Enter;
            tbTimKiem.Leave += tbTimKiem_Leave;
            tbTimKiem_SetText();
            disableSelect();

            dgvBanKhaiNhanKhau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvBanKhaiNhanKhau.DefaultCellStyle.ForeColor = Color.Black;

            listBanKhaiNhanKhau = bus.ReadAll();
            loadData_Vao_GridView();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            bool result = bus.Delete(phieuBanKhaiNhanKhauSelected);
            if (result)
            {
                listBanKhaiNhanKhau = bus.ReadAll();
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
            FrmChiTietBanKhaiNhanKhau frm = new FrmChiTietBanKhaiNhanKhau(phieuBanKhaiNhanKhauSelected);
            frm.Show();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            FrmChiTietBanKhaiNhanKhau frm = new FrmChiTietBanKhaiNhanKhau(null);
            frm.Show();
        }

        private void BtnTaiLai_Click(object sender, EventArgs e)
        {
            listBanKhaiNhanKhau = bus.ReadAll();
            loadData_Vao_GridView();
        }

        private void TbTimKiem_TextChanged(object sender, EventArgs e)
        {
            listBanKhaiNhanKhau = bus.ReadAllByKeyword(tbTimKiem.Text);
            loadData_Vao_GridView();
        }

        private void DgvBanKhaiNhanKhau_CellClick(object sender, DataGridViewCellEventArgs e)
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
                phieuBanKhaiNhanKhauSelected = listBanKhaiNhanKhau[numrow];
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
            if (listBanKhaiNhanKhau == null)
            {
                MessageBox.Show("Có lỗi khi đọc danh sách hộ khẩu từ CSDL");
                return;
            }

            dgvBanKhaiNhanKhau.Columns.Clear();
            dgvBanKhaiNhanKhau.DataSource = null;

            dgvBanKhaiNhanKhau.AutoGenerateColumns = false;
            dgvBanKhaiNhanKhau.AllowUserToAddRows = false;

            dgvBanKhaiNhanKhau.DataSource = listBanKhaiNhanKhau;

            DataGridViewTextBoxColumn clHoTen = new DataGridViewTextBoxColumn();
            clHoTen.Name = "HoTen";
            clHoTen.HeaderText = "Họ tên";
            clHoTen.DataPropertyName = "HoTen";
            dgvBanKhaiNhanKhau.Columns.Add(clHoTen);

            DataGridViewTextBoxColumn clCmnd = new DataGridViewTextBoxColumn();
            clCmnd.Name = "SoCmndCccd";
            clCmnd.HeaderText = "Số cmnd/cccd";
            clCmnd.DataPropertyName = "SoCmndCccd";
            dgvBanKhaiNhanKhau.Columns.Add(clCmnd);

            DataGridViewTextBoxColumn clTgBD = new DataGridViewTextBoxColumn();
            clTgBD.Name = "DiaChiHoKhau";
            clTgBD.HeaderText = "Địa chỉ hộ khẩu";
            clTgBD.DataPropertyName = "DiaChiHoKhau";
            dgvBanKhaiNhanKhau.Columns.Add(clTgBD);

            DataGridViewTextBoxColumn clTgKT = new DataGridViewTextBoxColumn();
            clTgKT.Name = "NgayCap";
            clTgKT.HeaderText = "Ngày cấp";
            clTgKT.DataPropertyName = "NgayCap";
            dgvBanKhaiNhanKhau.Columns.Add(clTgKT);

            DataGridViewTextBoxColumn clNoiTamTru = new DataGridViewTextBoxColumn();
            clNoiTamTru.Name = "NoiCap";
            clNoiTamTru.HeaderText = "Nơi cấp";
            clNoiTamTru.DataPropertyName = "NoiCap";
            dgvBanKhaiNhanKhau.Columns.Add(clNoiTamTru);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvBanKhaiNhanKhau.DataSource];
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
