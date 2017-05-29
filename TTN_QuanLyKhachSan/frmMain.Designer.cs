namespace TTN_QuanLyKhachSan
{
    partial class frmMain
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
            this.mnuChucNang = new System.Windows.Forms.MenuStrip();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNguoiDung = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnVatDung = new System.Windows.Forms.Button();
            this.btnThuePhong = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnSuDungDV = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.mnuChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuChucNang
            // 
            this.mnuChucNang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuChucNang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem});
            this.mnuChucNang.Location = new System.Drawing.Point(0, 0);
            this.mnuChucNang.Name = "mnuChucNang";
            this.mnuChucNang.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mnuChucNang.Size = new System.Drawing.Size(409, 29);
            this.mnuChucNang.TabIndex = 0;
            this.mnuChucNang.Text = "menuStrip1";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpLạiToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.đăngNhậpToolStripMenuItem.Text = "Tài khoản";
            // 
            // đăngNhậpLạiToolStripMenuItem
            // 
            this.đăngNhậpLạiToolStripMenuItem.Name = "đăngNhậpLạiToolStripMenuItem";
            this.đăngNhậpLạiToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.đăngNhậpLạiToolStripMenuItem.Text = "Đăng nhập lại";
            this.đăngNhậpLạiToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpLạiToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(102, 23);
            this.hướngDẫnToolStripMenuItem.Text = "Trợ giúp (F1)";
            this.hướngDẫnToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem_Click);
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.Location = new System.Drawing.Point(31, 53);
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.Size = new System.Drawing.Size(164, 40);
            this.btnNguoiDung.TabIndex = 0;
            this.btnNguoiDung.Text = "Quản lý người dùng";
            this.btnNguoiDung.UseVisualStyleBackColor = true;
            this.btnNguoiDung.Click += new System.EventHandler(this.btnNguoiDung_Click);
            this.btnNguoiDung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            // 
            // btnPhong
            // 
            this.btnPhong.Location = new System.Drawing.Point(31, 99);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(164, 40);
            this.btnPhong.TabIndex = 1;
            this.btnPhong.Text = "Quản lý phòng";
            this.btnPhong.UseVisualStyleBackColor = true;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            this.btnPhong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            // 
            // btnVatDung
            // 
            this.btnVatDung.Location = new System.Drawing.Point(31, 145);
            this.btnVatDung.Name = "btnVatDung";
            this.btnVatDung.Size = new System.Drawing.Size(164, 40);
            this.btnVatDung.TabIndex = 2;
            this.btnVatDung.Text = "Quản lý vật dụng";
            this.btnVatDung.UseVisualStyleBackColor = true;
            this.btnVatDung.Click += new System.EventHandler(this.btnVatDung_Click);
            this.btnVatDung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            // 
            // btnThuePhong
            // 
            this.btnThuePhong.Location = new System.Drawing.Point(211, 99);
            this.btnThuePhong.Name = "btnThuePhong";
            this.btnThuePhong.Size = new System.Drawing.Size(164, 40);
            this.btnThuePhong.TabIndex = 5;
            this.btnThuePhong.Text = "Quản lý thuê phong";
            this.btnThuePhong.UseVisualStyleBackColor = true;
            this.btnThuePhong.Click += new System.EventHandler(this.btnThuePhong_Click);
            this.btnThuePhong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(31, 191);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(164, 40);
            this.btnKhachHang.TabIndex = 3;
            this.btnKhachHang.Text = "Quản lý khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            this.btnKhachHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            // 
            // btnSuDungDV
            // 
            this.btnSuDungDV.Location = new System.Drawing.Point(211, 145);
            this.btnSuDungDV.Name = "btnSuDungDV";
            this.btnSuDungDV.Size = new System.Drawing.Size(164, 40);
            this.btnSuDungDV.TabIndex = 6;
            this.btnSuDungDV.Text = "Quản lý sử dụng dịch vụ";
            this.btnSuDungDV.UseVisualStyleBackColor = true;
            this.btnSuDungDV.Click += new System.EventHandler(this.btnSuDungDV_Click);
            this.btnSuDungDV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(211, 191);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(164, 40);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            this.btnThanhToan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            // 
            // btnDichVu
            // 
            this.btnDichVu.Location = new System.Drawing.Point(211, 53);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(164, 40);
            this.btnDichVu.TabIndex = 4;
            this.btnDichVu.Text = "Quản lý dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = true;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            this.btnDichVu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 257);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnSuDungDV);
            this.Controls.Add(this.btnDichVu);
            this.Controls.Add(this.btnThuePhong);
            this.Controls.Add(this.btnVatDung);
            this.Controls.Add(this.btnPhong);
            this.Controls.Add(this.btnNguoiDung);
            this.Controls.Add(this.mnuChucNang);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MainMenuStrip = this.mnuChucNang;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.mnuChucNang.ResumeLayout(false);
            this.mnuChucNang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuChucNang;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.Button btnNguoiDung;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnVatDung;
        private System.Windows.Forms.Button btnThuePhong;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnSuDungDV;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}

