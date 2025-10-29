using System;
using System.Linq;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL.Models;

namespace QLSV.GUI.Forms
{
    public partial class frmMonHoc : Form
    {
        private readonly MonHocService monHocService = new MonHocService();

        public frmMonHoc()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvMonHoc.DataSource = monHocService.GetAll()
                .Select(m => new { m.mamh, m.tenmh, m.sotinchi })
                .ToList();
        }

        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow != null)
            {
                txtTenMH.Text = dgvMonHoc.CurrentRow.Cells["tenmh"].Value.ToString();
                nudSoTinChi.Value = Convert.ToInt32(dgvMonHoc.CurrentRow.Cells["sotinchi"].Value ?? 0);
            }
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            var mh = new monhoc
            {
                tenmh = txtTenMH.Text.Trim(),
                sotinchi = (int)nudSoTinChi.Value
            };
            monHocService.Add(mh);
            LoadData();
        }

        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow == null) return;
            int id = (int)dgvMonHoc.CurrentRow.Cells["mamh"].Value;
            var mh = new monhoc
            {
                mamh = id,
                tenmh = txtTenMH.Text.Trim(),
                sotinchi = (int)nudSoTinChi.Value
            };
            monHocService.Update(mh);
            LoadData();
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow == null) return;
            int id = (int)dgvMonHoc.CurrentRow.Cells["mamh"].Value;
            monHocService.Delete(id);
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();
    }
}
