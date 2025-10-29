using System;
using System.Linq;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL.Models;

namespace QLSV.GUI.Forms
{
    public partial class frmSinhVien : Form
    {
        private readonly SinhVienService svService = new SinhVienService();
        private readonly LopService lopService = new LopService();
        private readonly KhoaService khoaService = new KhoaService();
        private readonly taikhoan currentUser;

        public frmSinhVien(taikhoan user) : this()
        {
            currentUser = user;
            ApplyRolePermissions();
        }

        public frmSinhVien()
        {
            InitializeComponent();
            LoadKhoa();
        }

        private void ApplyRolePermissions()
        {
            if (currentUser == null) return;

            // Nếu là SinhVien thì ẩn các nút Thêm/Sửa/Xóa
            bool isStudent = currentUser.vaitro == "SinhVien";
            btnThemSV.Visible = btnSuaSV.Visible = btnXoaSV.Visible = !isStudent;
        }

        private void LoadKhoa()
        {
            cmbKhoa.DataSource = khoaService.GetAll();
            cmbKhoa.DisplayMember = "tenkhoa";
            cmbKhoa.ValueMember = "makhoa";
            cmbKhoa.SelectedIndexChanged += (s, e) => LoadLop();
        }

        private void LoadLop()
        {
            if (cmbKhoa.SelectedValue == null) return;
            int makhoa = (int)cmbKhoa.SelectedValue;
            cmbLop.DataSource = lopService.GetByKhoa(makhoa);
            cmbLop.DisplayMember = "tenlop";
            cmbLop.ValueMember = "malop";
            cmbLop.SelectedIndexChanged += (s, e) => LoadData();
        }

        private void LoadData()
        {
            if (cmbLop.SelectedValue == null) return;
            int malop = (int)cmbLop.SelectedValue;
            dgvSinhVien.DataSource = svService.GetByLop(malop)
                .Select(sv => new { sv.masv, sv.tensv, sv.ngaysinh })
                .ToList();
        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                txtMaSV.Text = dgvSinhVien.CurrentRow.Cells["masv"].Value.ToString();
                txtTenSV.Text = dgvSinhVien.CurrentRow.Cells["tensv"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(dgvSinhVien.CurrentRow.Cells["ngaysinh"].Value ?? DateTime.Now);
            }
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            var sv = new sinhvien
            {
                masv = txtMaSV.Text.Trim(),
                tensv = txtTenSV.Text.Trim(),
                ngaysinh = dtpNgaySinh.Value,
                malop = (int)cmbLop.SelectedValue
            };
            svService.Add(sv);
            LoadData();
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null) return;
            string masv = dgvSinhVien.CurrentRow.Cells["masv"].Value.ToString();
            var sv = new sinhvien
            {
                masv = masv,
                tensv = txtTenSV.Text.Trim(),
                ngaysinh = dtpNgaySinh.Value,
                malop = (int)cmbLop.SelectedValue
            };
            svService.Update(sv);
            LoadData();
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null) return;
            string masv = dgvSinhVien.CurrentRow.Cells["masv"].Value.ToString();
            svService.Delete(masv);
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();
    }
}
