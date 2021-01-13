namespace QLHK_GUI
{
    partial class FrmDanhSachTamVang
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.panelThaoTac = new System.Windows.Forms.Panel();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvPhieuTamVang = new System.Windows.Forms.DataGridView();
            this.panelTimKiem.SuspendLayout();
            this.panelThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTamVang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(866, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách phiếu tạm vắng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTimKiem
            // 
            this.panelTimKiem.Controls.Add(this.tbTimKiem);
            this.panelTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimKiem.Location = new System.Drawing.Point(8, 73);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Padding = new System.Windows.Forms.Padding(128, 8, 128, 8);
            this.panelTimKiem.Size = new System.Drawing.Size(866, 72);
            this.panelTimKiem.TabIndex = 5;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(128, 8);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(610, 24);
            this.tbTimKiem.TabIndex = 0;
            // 
            // panelThaoTac
            // 
            this.panelThaoTac.Controls.Add(this.btnTaiLai);
            this.panelThaoTac.Controls.Add(this.btnXemChiTiet);
            this.panelThaoTac.Controls.Add(this.btnThem);
            this.panelThaoTac.Controls.Add(this.btnXoa);
            this.panelThaoTac.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelThaoTac.Location = new System.Drawing.Point(8, 484);
            this.panelThaoTac.Name = "panelThaoTac";
            this.panelThaoTac.Padding = new System.Windows.Forms.Padding(16);
            this.panelThaoTac.Size = new System.Drawing.Size(866, 61);
            this.panelThaoTac.TabIndex = 6;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTaiLai.Location = new System.Drawing.Point(480, 16);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(110, 29);
            this.btnTaiLai.TabIndex = 3;
            this.btnTaiLai.Text = "Tải dữ liệu";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXemChiTiet.Location = new System.Drawing.Point(590, 16);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(110, 29);
            this.btnXemChiTiet.TabIndex = 2;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThem.Location = new System.Drawing.Point(700, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 29);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXoa.Location = new System.Drawing.Point(775, 16);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 29);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // dgvPhieuTamVang
            // 
            this.dgvPhieuTamVang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuTamVang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuTamVang.Location = new System.Drawing.Point(8, 145);
            this.dgvPhieuTamVang.Name = "dgvPhieuTamVang";
            this.dgvPhieuTamVang.RowHeadersWidth = 51;
            this.dgvPhieuTamVang.RowTemplate.Height = 24;
            this.dgvPhieuTamVang.Size = new System.Drawing.Size(866, 339);
            this.dgvPhieuTamVang.TabIndex = 7;
            // 
            // FrmCapTamVang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.dgvPhieuTamVang);
            this.Controls.Add(this.panelThaoTac);
            this.Controls.Add(this.panelTimKiem);
            this.Controls.Add(this.label1);
            this.Name = "FrmCapTamVang";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "FrmCapTamVang";
            this.panelTimKiem.ResumeLayout(false);
            this.panelTimKiem.PerformLayout();
            this.panelThaoTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTamVang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTimKiem;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Panel panelThaoTac;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvPhieuTamVang;
    }
}