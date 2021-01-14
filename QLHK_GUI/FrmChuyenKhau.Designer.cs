namespace QLHK_GUI
{
    partial class FrmChuyenKhau
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
            this.btnNhapBan = new System.Windows.Forms.Button();
            this.btnNhapPhieu = new System.Windows.Forms.Button();
            this.btnSoSanh = new System.Windows.Forms.Button();
            this.btnChuyenKhau = new System.Windows.Forms.Button();
            this.checkB3 = new System.Windows.Forms.CheckBox();
            this.checkB1 = new System.Windows.Forms.CheckBox();
            this.checkB2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnNhapBan
            // 
            this.btnNhapBan.Location = new System.Drawing.Point(12, 12);
            this.btnNhapBan.Name = "btnNhapBan";
            this.btnNhapBan.Size = new System.Drawing.Size(246, 37);
            this.btnNhapBan.TabIndex = 0;
            this.btnNhapBan.Text = "Nhập bản khai nhân khẩu";
            this.btnNhapBan.UseVisualStyleBackColor = true;
            // 
            // btnNhapPhieu
            // 
            this.btnNhapPhieu.Location = new System.Drawing.Point(12, 55);
            this.btnNhapPhieu.Name = "btnNhapPhieu";
            this.btnNhapPhieu.Size = new System.Drawing.Size(246, 37);
            this.btnNhapPhieu.TabIndex = 1;
            this.btnNhapPhieu.Text = "Nhập phiếu thay đổi hộ khẩu";
            this.btnNhapPhieu.UseVisualStyleBackColor = true;
            // 
            // btnSoSanh
            // 
            this.btnSoSanh.Location = new System.Drawing.Point(12, 98);
            this.btnSoSanh.Name = "btnSoSanh";
            this.btnSoSanh.Size = new System.Drawing.Size(246, 60);
            this.btnSoSanh.TabIndex = 2;
            this.btnSoSanh.Text = "So sánh bản khai nhân khẩu\r\nvới phiếu thay đổi hộ khẩu";
            this.btnSoSanh.UseVisualStyleBackColor = true;
            // 
            // btnChuyenKhau
            // 
            this.btnChuyenKhau.Location = new System.Drawing.Point(12, 164);
            this.btnChuyenKhau.Name = "btnChuyenKhau";
            this.btnChuyenKhau.Size = new System.Drawing.Size(246, 37);
            this.btnChuyenKhau.TabIndex = 3;
            this.btnChuyenKhau.Text = "Thực thi việc chuyển khẩu";
            this.btnChuyenKhau.UseVisualStyleBackColor = true;
            // 
            // checkB3
            // 
            this.checkB3.AutoSize = true;
            this.checkB3.Enabled = false;
            this.checkB3.Location = new System.Drawing.Point(306, 119);
            this.checkB3.Name = "checkB3";
            this.checkB3.Size = new System.Drawing.Size(242, 21);
            this.checkB3.TabIndex = 4;
            this.checkB3.Text = "bản khai với phiếu thay đổi hợp lệ";
            this.checkB3.UseVisualStyleBackColor = true;
            // 
            // checkB1
            // 
            this.checkB1.AutoSize = true;
            this.checkB1.Enabled = false;
            this.checkB1.Location = new System.Drawing.Point(306, 21);
            this.checkB1.Name = "checkB1";
            this.checkB1.Size = new System.Drawing.Size(242, 21);
            this.checkB1.TabIndex = 5;
            this.checkB1.Text = "bản khai với phiếu thay đổi hợp lệ";
            this.checkB1.UseVisualStyleBackColor = true;
            // 
            // checkB2
            // 
            this.checkB2.AutoSize = true;
            this.checkB2.Enabled = false;
            this.checkB2.Location = new System.Drawing.Point(306, 64);
            this.checkB2.Name = "checkB2";
            this.checkB2.Size = new System.Drawing.Size(176, 21);
            this.checkB2.TabIndex = 6;
            this.checkB2.Text = "Có bản khai nhân khẩu";
            this.checkB2.UseVisualStyleBackColor = true;
            // 
            // FrmChuyenKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.checkB2);
            this.Controls.Add(this.checkB1);
            this.Controls.Add(this.checkB3);
            this.Controls.Add(this.btnChuyenKhau);
            this.Controls.Add(this.btnSoSanh);
            this.Controls.Add(this.btnNhapPhieu);
            this.Controls.Add(this.btnNhapBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmChuyenKhau";
            this.Text = "FrmChuyenKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhapBan;
        private System.Windows.Forms.Button btnNhapPhieu;
        private System.Windows.Forms.Button btnSoSanh;
        private System.Windows.Forms.Button btnChuyenKhau;
        private System.Windows.Forms.CheckBox checkB3;
        private System.Windows.Forms.CheckBox checkB1;
        private System.Windows.Forms.CheckBox checkB2;
    }
}