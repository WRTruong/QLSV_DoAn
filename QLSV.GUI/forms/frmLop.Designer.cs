namespace QLSV.GUI.Forms
{
    partial class frmLop
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.Button btnSuaLop;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();

            // cmbKhoa
            this.cmbKhoa.Location = new System.Drawing.Point(12, 12);
            this.cmbKhoa.Size = new System.Drawing.Size(200, 24);

            // txtTenLop
            this.txtTenLop.Location = new System.Drawing.Point(220, 12);
            this.txtTenLop.Size = new System.Drawing.Size(150, 22);

            // dgvLop
            this.dgvLop.Location = new System.Drawing.Point(12, 50);
            this.dgvLop.Size = new System.Drawing.Size(460, 250);
            this.dgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLop.MultiSelect = false;
            this.dgvLop.SelectionChanged += new System.EventHandler(this.dgvLop_SelectionChanged);

            // btnThemLop
            this.btnThemLop.Location = new System.Drawing.Point(12, 310);
            this.btnThemLop.Size = new System.Drawing.Size(75, 25);
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);

            // btnSuaLop
            this.btnSuaLop.Location = new System.Drawing.Point(100, 310);
            this.btnSuaLop.Size = new System.Drawing.Size(75, 25);
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);

            // btnXoaLop
            this.btnXoaLop.Location = new System.Drawing.Point(190, 310);
            this.btnXoaLop.Size = new System.Drawing.Size(75, 25);
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(380, 310);
            this.btnRefresh.Size = new System.Drawing.Size(75, 25);
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // frmLop
            this.ClientSize = new System.Drawing.Size(484, 351);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.btnThemLop);
            this.Controls.Add(this.btnSuaLop);
            this.Controls.Add(this.btnXoaLop);
            this.Controls.Add(this.btnRefresh);
            this.Text = "Quản lý Lớp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
