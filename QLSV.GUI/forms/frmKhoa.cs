using System;
using System.Linq;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL.Models;

namespace QLSV.GUI.Forms
{
    public partial class frmKhoa : Form
    {
        private readonly KhoaService khoaService = new KhoaService();

        public frmKhoa()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvKhoa.DataSource = khoaService.GetAll()
                .Select(k => new { k.makhoa, k.tenkhoa })
                .ToList();
        }

        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow != null)
                txtTenKhoa.Text = dgvKhoa.CurrentRow.Cells["tenkhoa"].Value.ToString();
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            var k = new khoa { tenkhoa = txtTenKhoa.Text.Trim() };
            khoaService.Add(k);
            LoadData();
        }

        private void btnSuaKhoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow == null) return;
            int id = (int)dgvKhoa.CurrentRow.Cells["makhoa"].Value;
            var k = new khoa { makhoa = id, tenkhoa = txtTenKhoa.Text.Trim() };
            khoaService.Update(k);
            LoadData();
        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow == null) return;
            int id = (int)dgvKhoa.CurrentRow.Cells["makhoa"].Value;
            khoaService.Delete(id);
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
