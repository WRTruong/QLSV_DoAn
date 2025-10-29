namespace QLSV.GUI.Forms
{
    partial class frmMonHoc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.NumericUpDown nudSoTinChi;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.Button btnSuaMH;
        private System.Windows.Forms.Button btnXoaMH;
        private System.Windows.Forms.Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.nudSoTinChi = new System.Windows.Forms.NumericUpDown();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.btnSuaMH = new System.Windows.Forms.Button();
            this.btnXoaMH = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTinChi)).BeginInit();
            this.SuspendLayout();

            // txtTenMH
            this.txtTenMH.Location = new System.Drawing.Point(12, 12);
            this.txtTenMH.Size = new System.Drawing.Size(200, 22);

            // nudSoTinChi
            this.nudSoTinChi.Location = new System.Drawing.Point(220, 12);
            this.nudSoTinChi.Minimum = 0;
            this.nudSoTinChi.Maximum = 50;

            // dgvMonHoc
            this.dgvMonHoc.Location = new System.Drawing.Point(12, 50);
            this.dgvMonHoc.Size = new System.Drawing.Size(460, 250);
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.MultiSelect = false;
            this.dgvMonHoc.SelectionChanged += new System.EventHandler(this.dgvMonHoc_SelectionChanged);

            // btnThemMH
            this.btnThemMH.Location = new System.Drawing.Point(12, 310);
            this.btnThemMH.Size = new System.Drawing.Size(75, 25);
            this.btnThemMH.Text = "Thêm";
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);

            // btnSuaMH
            this.btnSuaMH.Location = new System.Drawing.Point(100, 310);
            this.btnSuaMH.Size = new System.Drawing.Size(75, 25);
            this.btnSuaMH.Text = "Sửa";
            this.btnSuaMH.Click += new System.EventHandler(this.btnSuaMH_Click);

            // btnXoaMH
            this.btnXoaMH.Location = new System.Drawing.Point(190, 310);
            this.btnXoaMH.Size = new System.Drawing.Size(75, 25);
            this.btnXoaMH.Text = "Xóa";
            this.btnXoaMH.Click += new System.EventHandler(this.btnXoaMH_Click);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(380, 310);
            this.btnRefresh.Size = new System.Drawing.Size(75, 25);
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // frmMonHoc
            this.ClientSize = new System.Drawing.Size(484, 351);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.nudSoTinChi);
            this.Controls.Add(this.dgvMonHoc);
            this.Controls.Add(this.btnThemMH);
            this.Controls.Add(this.btnSuaMH);
            this.Controls.Add(this.btnXoaMH);
            this.Controls.Add(this.btnRefresh);
            this.Text = "Quản lý Môn Học";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTinChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
