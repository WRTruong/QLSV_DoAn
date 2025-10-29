using System;
using System.Linq;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL.Models;
using System.Collections.Generic;

namespace QLSV.GUI.Forms
{
    public partial class frmThongKe : Form
    {
        private readonly DiemService diemService = new DiemService();
        private readonly SinhVienService svService = new SinhVienService();
        private readonly LopService lopService = new LopService();
        private readonly KhoaService khoaService = new KhoaService();
        private readonly MonHocService monHocService = new MonHocService();
        private readonly taikhoan currentUser;

        public frmThongKe(taikhoan user)
        {
            InitializeComponent();
            currentUser = user;
            LoadKhoa();

            if (currentUser.vaitro == "SinhVien")
            {
                // Ẩn các combobox chọn lớp/khoa/môn
                cmbKhoa.Visible = false;
                cmbLop.Visible = false;
                cmbMonHoc.Visible = false;

                LoadData(); // Load dữ liệu chỉ của sinh viên
            }
        }

        private void LoadKhoa()
        {
            // Lấy danh sách khoa
            var khoaList = khoaService.GetAll();
            cmbKhoa.DataSource = khoaList;
            cmbKhoa.DisplayMember = "tenkhoa";
            cmbKhoa.ValueMember = "makhoa";

            cmbKhoa.SelectedIndexChanged += (s, e) =>
            {
                LoadLop();
                LoadMonHoc();
            };
        }

        private void LoadLop()
        {
            if (cmbKhoa.SelectedValue == null) return;
            int makhoa = (int)cmbKhoa.SelectedValue;

            List<lop> lopList = lopService.GetByKhoa(makhoa);

            // Nếu là Sinh viên, chỉ hiển thị lớp của chính sinh viên đó
            if (currentUser.vaitro == "SinhVien")
            {
                var sv = svService.GetByMaSV(currentUser.tendangnhap);
                if (sv != null)
                    lopList = lopList.Where(l => l.malop == sv.malop).ToList();
            }

            cmbLop.DataSource = lopList;
            cmbLop.DisplayMember = "tenlop";
            cmbLop.ValueMember = "malop";

            cmbLop.SelectedIndexChanged += (s, e) => LoadData();
        }

        private void LoadMonHoc()
        {
            if (cmbKhoa.SelectedValue == null) return;
            int makhoa = (int)cmbKhoa.SelectedValue;

            // Chỉ lấy môn học thuộc khoa
            var monList = monHocService.GetByKhoa(makhoa);

            cmbMonHoc.DataSource = monList;
            cmbMonHoc.DisplayMember = "tenmh";
            cmbMonHoc.ValueMember = "mamh";

            cmbMonHoc.SelectedIndexChanged += (s, e) => LoadData();
        }

        private void LoadData()
        {
            List<sinhvien> svList;

            if (currentUser.vaitro == "SinhVien")
            {
                // Sinh viên chỉ thấy thông tin bản thân
                svList = svService.GetAll()
                          .Where(s => s.masv == currentUser.tendangnhap)
                          .ToList();
            }
            else
            {
                if (cmbLop.SelectedValue == null) return;
                int malop = (int)cmbLop.SelectedValue;
                svList = svService.GetByLop(malop);
            }

            // Lấy tất cả điểm và môn học
            var allDiem = diemService.GetAll();
            var allMonHoc = monHocService.GetAll();

            var data = from sv in svList
                       join d in allDiem on sv.masv equals d.masv into dgGroup
                       from dg in dgGroup.DefaultIfEmpty()
                       join mh in allMonHoc on dg?.mamh equals mh.mamh into mhGroup
                       from mh in mhGroup.DefaultIfEmpty()
                           // Nếu là admin/giảng viên và đã chọn môn, lọc theo môn
                       where currentUser.vaitro == "SinhVien"
                             || cmbMonHoc.SelectedValue == null
                             || dg?.mamh == (int)cmbMonHoc.SelectedValue
                       select new
                       {
                           sv.masv,
                           sv.tensv,
                           MonHoc = mh?.tenmh ?? "Chưa có",
                           diemqt = dg?.diemqt,
                           diemck = dg?.diemck
                       };

            dgvThongKe.DataSource = data.ToList();
        }




        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
