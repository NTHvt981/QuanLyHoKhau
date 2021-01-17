namespace QLHK_GUI
{
    partial class FrmDanhSachChuyenKhau
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
            this.panelThaoTac = new System.Windows.Forms.Panel();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvChuyenKhau = new System.Windows.Forms.DataGridView();
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenKhau)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThaoTac
            // 
            this.panelThaoTac.Controls.Add(this.btnXemChiTiet);
            this.panelThaoTac.Controls.Add(this.btnTaiLai);
            this.panelThaoTac.Controls.Add(this.btnXoa);
            this.panelThaoTac.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelThaoTac.Location = new System.Drawing.Point(0, 509);
            this.panelThaoTac.Name = "panelThaoTac";
            this.panelThaoTac.Size = new System.Drawing.Size(882, 44);
            this.panelThaoTac.TabIndex = 18;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXemChiTiet.Location = new System.Drawing.Point(603, 0);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(162, 44);
            this.btnXemChiTiet.TabIndex = 2;
            this.btnXemChiTiet.Text = "Xem chi tiết phiếu";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTaiLai.Location = new System.Drawing.Point(0, 0);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(82, 44);
            this.btnTaiLai.TabIndex = 3;
            this.btnTaiLai.Text = "Tải dữ liệu";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXoa.Location = new System.Drawing.Point(765, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 44);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xoá phiếu";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // dgvChuyenKhau
            // 
            this.dgvChuyenKhau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChuyenKhau.Location = new System.Drawing.Point(0, 137);
            this.dgvChuyenKhau.Name = "dgvChuyenKhau";
            this.dgvChuyenKhau.RowHeadersWidth = 51;
            this.dgvChuyenKhau.RowTemplate.Height = 24;
            this.dgvChuyenKhau.Size = new System.Drawing.Size(882, 416);
            this.dgvChuyenKhau.TabIndex = 17;
            // 
            // panelTimKiem
            // 
            this.panelTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimKiem.Location = new System.Drawing.Point(0, 65);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Padding = new System.Windows.Forms.Padding(128, 8, 128, 8);
            this.panelTimKiem.Size = new System.Drawing.Size(882, 72);
            this.panelTimKiem.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(882, 65);
            this.label1.TabIndex = 15;
            this.label1.Text = "Danh sách phiếu chuyển khẩu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmDanhSachChuyenKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panelThaoTac);
            this.Controls.Add(this.dgvChuyenKhau);
            this.Controls.Add(this.panelTimKiem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDanhSachChuyenKhau";
            this.Text = "FrmDanhSachChuyenKhau";
            this.panelThaoTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenKhau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThaoTac;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvChuyenKhau;
        private System.Windows.Forms.Panel panelTimKiem;
        private System.Windows.Forms.Label label1;
    }
}