using System;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL.Models;

namespace QLSV.GUI.Forms
{
    public partial class frmRegister : Form
    {
        private readonly TaiKhoanService tkService = new TaiKhoanService();

        public frmRegister()
        {
            InitializeComponent();
            LoadVaiTro();
        }

        private void LoadVaiTro()
        {
            // Chỉ cho chọn GiangVien hoặc SinhVien
            cmbVaiTro.Items.Clear();
            cmbVaiTro.Items.Add("GiangVien");
            cmbVaiTro.Items.Add("SinhVien");
            cmbVaiTro.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            string hoten = txtHoten.Text.Trim();
            string vaitro = cmbVaiTro.SelectedItem.ToString();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(hoten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            taikhoan tk = new taikhoan
            {
                tendangnhap = user,
                matkhau = pass,
                hoten = hoten,
                vaitro = vaitro
            };

            bool result = tkService.DangKy(tk);

            if (result)
            {
                MessageBox.Show("Tạo tài khoản thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
