using System.Windows.Forms;

namespace QLSV.GUI.Forms
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuQuanLy;
        private ToolStripMenuItem menuKhoa;
        private ToolStripMenuItem menuLop;
        private ToolStripMenuItem menuMonHoc;
        private ToolStripMenuItem menuSinhVien;
        private ToolStripMenuItem menuThongKe;
        private ToolStripMenuItem menuThoat;
        private Label lblWelcome;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuanLy,
            this.menuThongKe,
            this.menuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1500, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuQuanLy
            // 
            this.menuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKhoa,
            this.menuLop,
            this.menuMonHoc,
            this.menuSinhVien,
            this.menuTaiKhoan,
            this.menuDangXuat});
            this.menuQuanLy.ForeColor = System.Drawing.Color.White;
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Size = new System.Drawing.Size(146, 45);
            this.menuQuanLy.Text = "Quản lý";
            // 
            // menuKhoa
            // 
            this.menuKhoa.Name = "menuKhoa";
            this.menuKhoa.Size = new System.Drawing.Size(359, 50);
            this.menuKhoa.Text = "Khoa";
            this.menuKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // menuLop
            // 
            this.menuLop.Name = "menuLop";
            this.menuLop.Size = new System.Drawing.Size(359, 50);
            this.menuLop.Text = "Lớp";
            this.menuLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // menuMonHoc
            // 
            this.menuMonHoc.Name = "menuMonHoc";
            this.menuMonHoc.Size = new System.Drawing.Size(359, 50);
            this.menuMonHoc.Text = "Môn học";
            this.menuMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // menuSinhVien
            // 
            this.menuSinhVien.Name = "menuSinhVien";
            this.menuSinhVien.Size = new System.Drawing.Size(359, 50);
            this.menuSinhVien.Text = "Sinh viên";
            this.menuSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // menuTaiKhoan
            // 
            this.menuTaiKhoan.Name = "menuTaiKhoan";
            this.menuTaiKhoan.Size = new System.Drawing.Size(359, 50);
            this.menuTaiKhoan.Text = "Tạo tài khoản";
            this.menuTaiKhoan.Click += new System.EventHandler(this.menuTaiKhoan_Click);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(359, 50);
            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // menuThongKe
            // 
            this.menuThongKe.ForeColor = System.Drawing.Color.White;
            this.menuThongKe.Name = "menuThongKe";
            this.menuThongKe.Size = new System.Drawing.Size(170, 45);
            this.menuThongKe.Text = "Thống kê";
            this.menuThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.ForeColor = System.Drawing.Color.White;
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(120, 45);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWelcome.Location = new System.Drawing.Point(0, 49);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.lblWelcome.Size = new System.Drawing.Size(272, 65);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Xin chào, Admin!";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1500, 750);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản Lý Sinh Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ToolStripMenuItem menuTaiKhoan;
        private ToolStripMenuItem menuDangXuat;
    }
}
