using System;
using System.Linq;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL.Models;

namespace QLSV.GUI.Forms
{
    public partial class frmLop : Form
    {
        private readonly LopService lopService = new LopService();
        private readonly KhoaService khoaService = new KhoaService();

        public frmLop()
        {
            InitializeComponent();
            LoadKhoa();
        }

        private void LoadKhoa()
        {
            cmbKhoa.DataSource = khoaService.GetAll();
            cmbKhoa.DisplayMember = "tenkhoa";
            cmbKhoa.ValueMember = "makhoa";
            cmbKhoa.SelectedIndexChanged += (s, e) => LoadData();
        }

        private void LoadData()
        {
            if (cmbKhoa.SelectedValue == null) return;
            int makhoa = (int)cmbKhoa.SelectedValue;
            dgvLop.DataSource = lopService.GetByKhoa(makhoa)
                .Select(l => new { l.malop, l.tenlop })
                .ToList();
        }

        private void dgvLop_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow != null)
                txtTenLop.Text = dgvLop.CurrentRow.Cells["tenlop"].Value.ToString();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            var l = new lop
            {
                tenlop = txtTenLop.Text.Trim(),
                makhoa = (int)cmbKhoa.SelectedValue
            };
            lopService.Add(l);
            LoadData();
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null) return;
            int id = (int)dgvLop.CurrentRow.Cells["malop"].Value;
            var l = new lop
            {
                malop = id,
                tenlop = txtTenLop.Text.Trim(),
                makhoa = (int)cmbKhoa.SelectedValue
            };
            lopService.Update(l);
            LoadData();
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null) return;
            int id = (int)dgvLop.CurrentRow.Cells["malop"].Value;
            lopService.Delete(id);
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();
    }
}
