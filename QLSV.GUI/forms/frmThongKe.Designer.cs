namespace QLSV.GUI.Forms
{
    partial class frmThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();

            // cmbKhoa
            this.cmbKhoa.Location = new System.Drawing.Point(12, 12);
            this.cmbKhoa.Size = new System.Drawing.Size(150, 24);

            // cmbLop
            this.cmbLop.Location = new System.Drawing.Point(180, 12);
            this.cmbLop.Size = new System.Drawing.Size(150, 24);

            // cmbMonHoc
            this.cmbMonHoc.Location = new System.Drawing.Point(350, 12);
            this.cmbMonHoc.Size = new System.Drawing.Size(150, 24);

            // dgvThongKe
            this.dgvThongKe.Location = new System.Drawing.Point(12, 50);
            this.dgvThongKe.Size = new System.Drawing.Size(488, 300);
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.MultiSelect = false;

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(425, 360);
            this.btnRefresh.Size = new System.Drawing.Size(75, 25);
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // frmThongKe
            this.ClientSize = new System.Drawing.Size(512, 400);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.btnRefresh);
            this.Text = "Thống kê điểm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
