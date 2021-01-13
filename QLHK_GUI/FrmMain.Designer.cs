namespace QLHK_GUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.picBoxIcon = new System.Windows.Forms.PictureBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnTamVang = new System.Windows.Forms.Button();
            this.btnTamTru = new System.Windows.Forms.Button();
            this.btnChuyenKhau = new System.Windows.Forms.Button();
            this.panelSubForm = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelLeft.Controls.Add(this.btnExit);
            this.panelLeft.Controls.Add(this.btnChuyenKhau);
            this.panelLeft.Controls.Add(this.btnTamTru);
            this.panelLeft.Controls.Add(this.btnTamVang);
            this.panelLeft.Controls.Add(this.btnTraCuu);
            this.panelLeft.Controls.Add(this.panelTopLeft);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(3);
            this.panelLeft.Size = new System.Drawing.Size(219, 613);
            this.panelLeft.TabIndex = 0;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.Controls.Add(this.picBoxIcon);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopLeft.Location = new System.Drawing.Point(3, 3);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Padding = new System.Windows.Forms.Padding(8);
            this.panelTopLeft.Size = new System.Drawing.Size(213, 153);
            this.panelTopLeft.TabIndex = 0;
            // 
            // picBoxIcon
            // 
            this.picBoxIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("picBoxIcon.Image")));
            this.picBoxIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxIcon.InitialImage")));
            this.picBoxIcon.Location = new System.Drawing.Point(8, 8);
            this.picBoxIcon.Name = "picBoxIcon";
            this.picBoxIcon.Size = new System.Drawing.Size(197, 137);
            this.picBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIcon.TabIndex = 0;
            this.picBoxIcon.TabStop = false;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTraCuu.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Location = new System.Drawing.Point(3, 156);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(213, 37);
            this.btnTraCuu.TabIndex = 1;
            this.btnTraCuu.Text = "Quản lý hộ khẩu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // btnTamVang
            // 
            this.btnTamVang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTamVang.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamVang.Location = new System.Drawing.Point(3, 193);
            this.btnTamVang.Name = "btnTamVang";
            this.btnTamVang.Size = new System.Drawing.Size(213, 37);
            this.btnTamVang.TabIndex = 2;
            this.btnTamVang.Text = "Cấp giấy tạm vắng";
            this.btnTamVang.UseVisualStyleBackColor = true;
            // 
            // btnTamTru
            // 
            this.btnTamTru.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTamTru.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamTru.Location = new System.Drawing.Point(3, 230);
            this.btnTamTru.Name = "btnTamTru";
            this.btnTamTru.Size = new System.Drawing.Size(213, 37);
            this.btnTamTru.TabIndex = 3;
            this.btnTamTru.Text = "Cấp giấy tạm trú";
            this.btnTamTru.UseVisualStyleBackColor = true;
            // 
            // btnChuyenKhau
            // 
            this.btnChuyenKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChuyenKhau.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenKhau.Location = new System.Drawing.Point(3, 267);
            this.btnChuyenKhau.Name = "btnChuyenKhau";
            this.btnChuyenKhau.Size = new System.Drawing.Size(213, 37);
            this.btnChuyenKhau.TabIndex = 4;
            this.btnChuyenKhau.Text = "Chuyển khẩu";
            this.btnChuyenKhau.UseVisualStyleBackColor = true;
            // 
            // panelSubForm
            // 
            this.panelSubForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubForm.Location = new System.Drawing.Point(219, 0);
            this.panelSubForm.Name = "panelSubForm";
            this.panelSubForm.Size = new System.Drawing.Size(886, 613);
            this.panelSubForm.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Location = new System.Drawing.Point(3, 579);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(213, 31);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 613);
            this.Controls.Add(this.panelSubForm);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Quản lý hộ khẩu";
            this.panelLeft.ResumeLayout(false);
            this.panelTopLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.PictureBox picBoxIcon;
        private System.Windows.Forms.Button btnChuyenKhau;
        private System.Windows.Forms.Button btnTamTru;
        private System.Windows.Forms.Button btnTamVang;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Panel panelSubForm;
        private System.Windows.Forms.Button btnExit;
    }
}

