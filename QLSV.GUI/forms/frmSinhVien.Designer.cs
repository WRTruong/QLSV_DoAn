namespace QLSV.GUI.Forms
{
    partial class frmSinhVien
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.Button btnSuaSV;
        private System.Windows.Forms.Button btnXoaSV;
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
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.btnSuaSV = new System.Windows.Forms.Button();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();

            // ComboBox Khoa
            this.cmbKhoa.Location = new System.Drawing.Point(12, 12);
            this.cmbKhoa.Size = new System.Drawing.Size(150, 24);

            // ComboBox Lop
            this.cmbLop.Location = new System.Drawing.Point(180, 12);
            this.cmbLop.Size = new System.Drawing.Size(150, 24);

            // txtMaSV
            this.txtMaSV.Location = new System.Drawing.Point(12, 42);
            this.txtMaSV.Size = new System.Drawing.Size(150, 22);

            // txtTenSV
            this.txtTenSV.Location = new System.Drawing.Point(180, 42);
            this.txtTenSV.Size = new System.Drawing.Size(150, 22);

            // dtpNgaySinh
            this.dtpNgaySinh.Location = new System.Drawing.Point(350, 42);
            this.dtpNgaySinh.Size = new System.Drawing.Size(150, 22);

            // dgvSinhVien
            this.dgvSinhVien.Location = new System.Drawing.Point(12, 70);
            this.dgvSinhVien.Size = new System.Drawing.Size(488, 250);
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.SelectionChanged += new System.EventHandler(this.dgvSinhVien_SelectionChanged);

            // btnThemSV
            this.btnThemSV.Location = new System.Drawing.Point(12, 330);
            this.btnThemSV.Size = new System.Drawing.Size(75, 25);
            this.btnThemSV.Text = "Thêm";
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);

            // btnSuaSV
            this.btnSuaSV.Location = new System.Drawing.Point(100, 330);
            this.btnSuaSV.Size = new System.Drawing.Size(75, 25);
            this.btnSuaSV.Text = "Sửa";
            this.btnSuaSV.Click += new System.EventHandler(this.btnSuaSV_Click);

            // btnXoaSV
            this.btnXoaSV.Location = new System.Drawing.Point(190, 330);
            this.btnXoaSV.Size = new System.Drawing.Size(75, 25);
            this.btnXoaSV.Text = "Xóa";
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(425, 330);
            this.btnRefresh.Size = new System.Drawing.Size(75, 25);
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // frmSinhVien
            this.ClientSize = new System.Drawing.Size(512, 370);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.btnThemSV);
            this.Controls.Add(this.btnSuaSV);
            this.Controls.Add(this.btnXoaSV);
            this.Controls.Add(this.btnRefresh);
            this.Text = "Quản lý Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
