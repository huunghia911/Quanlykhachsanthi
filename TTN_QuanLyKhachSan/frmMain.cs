using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyKhachSan
{
    public partial class frmMain : Form
    {
        public static string _taikhoan = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Form frmDN = new frmDangNhap();
            DialogResult tl;
            tl = frmDN.ShowDialog();
            if (tl != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            Form frm = new frmQuanLyNguoiDung();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngNhậpLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Form frmF1 = new frmHelp();
                frmF1.Show();
            }
        }

        private void btnVatDung_Click(object sender, EventArgs e)
        {
            Form frmTB = new frmThietBi();
            frmTB.ShowDialog();
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            Form frmThue = new frmThuePhong();
            frmThue.ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Form frmThanhToan = new frmThanhToan();
            frmThanhToan.ShowDialog();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            Form frmDV = new frmQuanLyDV();
            frmDV.ShowDialog();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            Form frmPhong = new frmPhong();
            frmPhong.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            Form frmKH = new frmQuanLyKhachHang();
            frmKH.ShowDialog();
        }

        private void btnSuDungDV_Click(object sender, EventArgs e)
        {
            Form frmSD = new frmSuDungDV();
            frmSD.ShowDialog();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmF1 = new frmHelp();
            frmF1.Show();
        }
    }
}
