namespace QLSV.GUI.Forms
{
    partial class frmKhoa
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Button btnThemKhoa;
        private System.Windows.Forms.Button btnSuaKhoa;
        private System.Windows.Forms.Button btnXoaKhoa;
        private System.Windows.Forms.Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.btnThemKhoa = new System.Windows.Forms.Button();
            this.btnSuaKhoa = new System.Windows.Forms.Button();
            this.btnXoaKhoa = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.ColumnHeadersHeight = 34;
            this.dgvKhoa.Location = new System.Drawing.Point(12, 50);
            this.dgvKhoa.MultiSelect = false;
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.RowHeadersWidth = 62;
            this.dgvKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoa.Size = new System.Drawing.Size(460, 250);
            this.dgvKhoa.TabIndex = 0;
            this.dgvKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellContentClick);
            this.dgvKhoa.SelectionChanged += new System.EventHandler(this.dgvKhoa_SelectionChanged);
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(12, 12);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(200, 26);
            this.txtTenKhoa.TabIndex = 1;
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.Location = new System.Drawing.Point(220, 10);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Size = new System.Drawing.Size(75, 25);
            this.btnThemKhoa.TabIndex = 2;
            this.btnThemKhoa.Text = "Thêm";
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click);
            // 
            // btnSuaKhoa
            // 
            this.btnSuaKhoa.Location = new System.Drawing.Point(300, 10);
            this.btnSuaKhoa.Name = "btnSuaKhoa";
            this.btnSuaKhoa.Size = new System.Drawing.Size(75, 25);
            this.btnSuaKhoa.TabIndex = 3;
            this.btnSuaKhoa.Text = "Sửa";
            this.btnSuaKhoa.Click += new System.EventHandler(this.btnSuaKhoa_Click);
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.Location = new System.Drawing.Point(380, 10);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Size = new System.Drawing.Size(75, 25);
            this.btnXoaKhoa.TabIndex = 4;
            this.btnXoaKhoa.Text = "Xóa";
            this.btnXoaKhoa.Click += new System.EventHandler(this.btnXoaKhoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(380, 310);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 25);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmKhoa
            // 
            this.ClientSize = new System.Drawing.Size(484, 351);
            this.Controls.Add(this.dgvKhoa);
            this.Controls.Add(this.txtTenKhoa);
            this.Controls.Add(this.btnThemKhoa);
            this.Controls.Add(this.btnSuaKhoa);
            this.Controls.Add(this.btnXoaKhoa);
            this.Controls.Add(this.btnRefresh);
            this.Name = "frmKhoa";
            this.Text = "Quản lý Khoa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
