namespace QLHK_GUI
{
    partial class FrmChiTietPhieuTamVang
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
            this.tbNguoiCapPhieu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbLyDo = new System.Windows.Forms.TextBox();
            this.tbNoiTamTru = new System.Windows.Forms.TextBox();
            this.dtpTgKt = new System.Windows.Forms.DateTimePicker();
            this.dtpTgBd = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.rbKhong = new System.Windows.Forms.RadioButton();
            this.rbCo = new System.Windows.Forms.RadioButton();
            this.btnLuuSua = new System.Windows.Forms.Button();
            this.lbSua = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.dtpNgayGhi = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLuuThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNguoiCapPhieu
            // 
            this.tbNguoiCapPhieu.Location = new System.Drawing.Point(168, 475);
            this.tbNguoiCapPhieu.Name = "tbNguoiCapPhieu";
            this.tbNguoiCapPhieu.Size = new System.Drawing.Size(671, 22);
            this.tbNguoiCapPhieu.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 475);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 17);
            this.label12.TabIndex = 54;
            this.label12.Text = "Người cấp phiếu";
            // 
            // tbLyDo
            // 
            this.tbLyDo.Location = new System.Drawing.Point(168, 438);
            this.tbLyDo.Name = "tbLyDo";
            this.tbLyDo.Size = new System.Drawing.Size(671, 22);
            this.tbLyDo.TabIndex = 50;
            // 
            // tbNoiTamTru
            // 
            this.tbNoiTamTru.Location = new System.Drawing.Point(168, 403);
            this.tbNoiTamTru.Name = "tbNoiTamTru";
            this.tbNoiTamTru.Size = new System.Drawing.Size(484, 22);
            this.tbNoiTamTru.TabIndex = 49;
            // 
            // dtpTgKt
            // 
            this.dtpTgKt.Location = new System.Drawing.Point(481, 368);
            this.dtpTgKt.Name = "dtpTgKt";
            this.dtpTgKt.Size = new System.Drawing.Size(265, 22);
            this.dtpTgKt.TabIndex = 48;
            // 
            // dtpTgBd
            // 
            this.dtpTgBd.Location = new System.Drawing.Point(168, 368);
            this.dtpTgBd.Name = "dtpTgBd";
            this.dtpTgBd.Size = new System.Drawing.Size(264, 22);
            this.dtpTgBd.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 438);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Lý do";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Nơi tạm trú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tạm vắng từ";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(220, 26);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(491, 46);
            this.lbTitle.TabIndex = 29;
            this.lbTitle.Text = "Thông tin phiếu tạm vắng";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbKhong
            // 
            this.rbKhong.AutoSize = true;
            this.rbKhong.Checked = true;
            this.rbKhong.Location = new System.Drawing.Point(168, 650);
            this.rbKhong.Name = "rbKhong";
            this.rbKhong.Size = new System.Drawing.Size(70, 21);
            this.rbKhong.TabIndex = 59;
            this.rbKhong.TabStop = true;
            this.rbKhong.Text = "Không";
            this.rbKhong.UseVisualStyleBackColor = true;
            // 
            // rbCo
            // 
            this.rbCo.AutoSize = true;
            this.rbCo.Location = new System.Drawing.Point(116, 650);
            this.rbCo.Name = "rbCo";
            this.rbCo.Size = new System.Drawing.Size(46, 21);
            this.rbCo.TabIndex = 58;
            this.rbCo.TabStop = true;
            this.rbCo.Text = "Có";
            this.rbCo.UseVisualStyleBackColor = true;
            // 
            // btnLuuSua
            // 
            this.btnLuuSua.Location = new System.Drawing.Point(244, 646);
            this.btnLuuSua.Name = "btnLuuSua";
            this.btnLuuSua.Size = new System.Drawing.Size(64, 29);
            this.btnLuuSua.TabIndex = 57;
            this.btnLuuSua.Text = "Lưu";
            this.btnLuuSua.UseVisualStyleBackColor = true;
            // 
            // lbSua
            // 
            this.lbSua.AutoSize = true;
            this.lbSua.Location = new System.Drawing.Point(38, 650);
            this.lbSua.Name = "lbSua";
            this.lbSua.Size = new System.Drawing.Size(71, 17);
            this.lbSua.TabIndex = 56;
            this.lbSua.Text = "Chỉnh sửa";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(325, 646);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(107, 29);
            this.btnQuayLai.TabIndex = 60;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // dtpNgayGhi
            // 
            this.dtpNgayGhi.Enabled = false;
            this.dtpNgayGhi.Location = new System.Drawing.Point(168, 515);
            this.dtpNgayGhi.Name = "dtpNgayGhi";
            this.dtpNgayGhi.Size = new System.Drawing.Size(264, 22);
            this.dtpNgayGhi.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 515);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 61;
            this.label11.Text = "Ngày cấp phiếu";
            // 
            // btnLuuThem
            // 
            this.btnLuuThem.Location = new System.Drawing.Point(680, 646);
            this.btnLuuThem.Name = "btnLuuThem";
            this.btnLuuThem.Size = new System.Drawing.Size(159, 29);
            this.btnLuuThem.TabIndex = 63;
            this.btnLuuThem.Text = "Xác nhận thêm";
            this.btnLuuThem.UseVisualStyleBackColor = true;
            // 
            // FrmChiTietPhieuTamVang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 703);
            this.Controls.Add(this.btnLuuThem);
            this.Controls.Add(this.dtpNgayGhi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.rbKhong);
            this.Controls.Add(this.rbCo);
            this.Controls.Add(this.btnLuuSua);
            this.Controls.Add(this.lbSua);
            this.Controls.Add(this.tbNguoiCapPhieu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbLyDo);
            this.Controls.Add(this.tbNoiTamTru);
            this.Controls.Add(this.dtpTgKt);
            this.Controls.Add(this.dtpTgBd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmChiTietPhieuTamVang";
            this.Text = "FrmChiTietPhieuTamVang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNguoiCapPhieu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbLyDo;
        private System.Windows.Forms.TextBox tbNoiTamTru;
        private System.Windows.Forms.DateTimePicker dtpTgKt;
        private System.Windows.Forms.DateTimePicker dtpTgBd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.RadioButton rbKhong;
        private System.Windows.Forms.RadioButton rbCo;
        private System.Windows.Forms.Button btnLuuSua;
        private System.Windows.Forms.Label lbSua;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.DateTimePicker dtpNgayGhi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLuuThem;
    }
}