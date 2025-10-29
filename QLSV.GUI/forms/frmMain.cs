using System;
using System.Windows.Forms;
using QLSV.DAL.Models;

namespace QLSV.GUI.Forms
{
    public partial class frmMain : Form
    {
        private readonly taikhoan currentUser;

        public frmMain(taikhoan user)
        {
            InitializeComponent();
            IsMdiContainer = true;
            currentUser = user;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = currentUser != null
                ? $"Xin chào, {currentUser.tendangnhap} ({currentUser.vaitro})"
                : "Chào mừng đến với hệ thống QLSV";

            ApplyRolePermissions();

            OpenForm(new frmThongKe(currentUser));
        }

        private void ApplyRolePermissions()
        {
            // Mặc định hiển thị tất cả menu
            menuKhoa.Visible = menuLop.Visible = menuMonHoc.Visible = menuSinhVien.Visible = menuThongKe.Visible = menuTaiKhoan.Visible = true;

            if (currentUser.vaitro == "SinhVien")
            {
                // Sinh viên chỉ xem Thống kê
                menuKhoa.Visible = menuLop.Visible = menuMonHoc.Visible = menuSinhVien.Visible = menuTaiKhoan.Visible = false;
            }
            else if (currentUser.vaitro == "GiangVien")
            {
                // Giảng viên chỉ quản lý Sinh viên và Thống kê
                menuKhoa.Visible = menuLop.Visible = menuMonHoc.Visible = false;
                menuSinhVien.Visible = true;
                menuTaiKhoan.Visible = false; // chỉ Admin tạo tài khoản
            }
            // Admin hiển thị tất cả
        }

        private void OpenForm(Form frm)
        {
            foreach (Form child in this.MdiChildren)
                child.Close();

            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        // Các event click
        private void btnKhoa_Click(object sender, EventArgs e) => OpenForm(new frmKhoa());
        private void btnLop_Click(object sender, EventArgs e) => OpenForm(new frmLop());
        private void btnMonHoc_Click(object sender, EventArgs e) => OpenForm(new frmMonHoc());
        private void btnSinhVien_Click(object sender, EventArgs e) => OpenForm(new frmSinhVien(currentUser));
        private void btnThongKe_Click(object sender, EventArgs e) => OpenForm(new frmThongKe(currentUser));

        private void menuTaiKhoan_Click(object sender, EventArgs e)
        {
            if (currentUser.vaitro == "Admin")
                OpenForm(new frmRegister());
            else
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                new frmLogin().Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
