using System;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL.Models;

namespace QLSV.GUI.Forms
{
    public partial class frmLogin : Form
    {
        private readonly TaiKhoanService tkService = new TaiKhoanService();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var tk = tkService.DangNhap(txtUser.Text, txtPass.Text);

            if (tk == null)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lưu user vào Program.CurrentUser
            Program.CurrentUser = tk;

            // Trả về DialogResult.OK để Program.cs biết đăng nhập thành công
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
