namespace QLHK_GUI
{
    partial class FrmDanhSachNhanKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvNhanKhau = new System.Windows.Forms.DataGridView();
            this.panelThaoTac = new System.Windows.Forms.Panel();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanKhau)).BeginInit();
            this.panelThaoTac.SuspendLayout();
            this.panelTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhanKhau
            // 
            this.dgvNhanKhau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanKhau.Location = new System.Drawing.Point(0, 137);
            this.dgvNhanKhau.Name = "dgvNhanKhau";
            this.dgvNhanKhau.RowHeadersWidth = 51;
            this.dgvNhanKhau.RowTemplate.Height = 24;
            this.dgvNhanKhau.Size = new System.Drawing.Size(882, 355);
            this.dgvNhanKhau.TabIndex = 11;
            // 
            // panelThaoTac
            // 
            this.panelThaoTac.Controls.Add(this.btnTaiLai);
            this.panelThaoTac.Controls.Add(this.btnXemChiTiet);
            this.panelThaoTac.Controls.Add(this.btnThem);
            this.panelThaoTac.Controls.Add(this.btnXoa);
            this.panelThaoTac.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelThaoTac.Location = new System.Drawing.Point(0, 492);
            this.panelThaoTac.Name = "panelThaoTac";
            this.panelThaoTac.Padding = new System.Windows.Forms.Padding(16);
            this.panelThaoTac.Size = new System.Drawing.Size(882, 61);
            this.panelThaoTac.TabIndex = 10;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTaiLai.Location = new System.Drawing.Point(496, 16);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(110, 29);
            this.btnTaiLai.TabIndex = 3;
            this.btnTaiLai.Text = "Tải dữ liệu";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXemChiTiet.Location = new System.Drawing.Point(606, 16);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(110, 29);
            this.btnXemChiTiet.TabIndex = 2;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThem.Location = new System.Drawing.Point(716, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 29);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXoa.Location = new System.Drawing.Point(791, 16);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 29);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // panelTimKiem
            // 
            this.panelTimKiem.Controls.Add(this.tbTimKiem);
            this.panelTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimKiem.Location = new System.Drawing.Point(0, 65);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Padding = new System.Windows.Forms.Padding(128, 8, 128, 8);
            this.panelTimKiem.Size = new System.Drawing.Size(882, 72);
            this.panelTimKiem.TabIndex = 9;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(128, 8);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(626, 24);
            this.tbTimKiem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(882, 65);
            this.label1.TabIndex = 8;
            this.label1.Text = "Danh sách phiếu tạm vắng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmDanhSachNhanKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.dgvNhanKhau);
            this.Controls.Add(this.panelThaoTac);
            this.Controls.Add(this.panelTimKiem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDanhSachNhanKhau";
            this.Text = "FrmDanhSachNhanKhau";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanKhau)).EndInit();
            this.panelThaoTac.ResumeLayout(false);
            this.panelTimKiem.ResumeLayout(false);
            this.panelTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhanKhau;
        private System.Windows.Forms.Panel panelThaoTac;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panelTimKiem;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Label label1;
    }
}