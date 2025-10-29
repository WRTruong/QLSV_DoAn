using System.Windows.Forms;

namespace QLSV.GUI.Forms
{
    partial class frmRegister
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelRegister;
        private Label lblTitle;
        private Label lblUser;
        private Label lblPass;
        private Label lblConfirm;
        private Label lblHoten;
        private Label lblRole;
        private TextBox txtUser;
        private TextBox txtPass;
        private TextBox txtConfirm;
        private TextBox txtHoten;
        private ComboBox cmbVaiTro;
        private Button btnRegister;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelRegister = new Panel();
            this.lblTitle = new Label();
            this.lblUser = new Label();
            this.lblPass = new Label();
            this.lblConfirm = new Label();
            this.lblHoten = new Label();
            this.lblRole = new Label();
            this.txtUser = new TextBox();
            this.txtPass = new TextBox();
            this.txtConfirm = new TextBox();
            this.txtHoten = new TextBox();
            this.cmbVaiTro = new ComboBox();
            this.btnRegister = new Button();
            this.btnCancel = new Button();

            // panelRegister
            this.panelRegister.BackColor = System.Drawing.Color.White;
            this.panelRegister.BorderStyle = BorderStyle.FixedSingle;
            this.panelRegister.Location = new System.Drawing.Point(250, 50);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(400, 450);
            this.panelRegister.TabIndex = 0;

            // lblTitle
            this.lblTitle.Text = "ĐĂNG KÝ";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Size = new System.Drawing.Size(250, 40);
            this.lblTitle.Location = new System.Drawing.Point(80, 20);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblUser
            this.lblUser.Text = "Tài khoản:";
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUser.Location = new System.Drawing.Point(40, 80);
            this.lblUser.AutoSize = true;

            // txtUser
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUser.Location = new System.Drawing.Point(180, 77);
            this.txtUser.Size = new System.Drawing.Size(180, 32);

            // lblPass
            this.lblPass.Text = "Mật khẩu:";
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPass.Location = new System.Drawing.Point(40, 130);
            this.lblPass.AutoSize = true;

            // txtPass
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPass.Location = new System.Drawing.Point(180, 127);
            this.txtPass.Size = new System.Drawing.Size(180, 32);
            this.txtPass.PasswordChar = '●';

            // lblConfirm
            this.lblConfirm.Text = "Xác nhận mật khẩu:";
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblConfirm.Location = new System.Drawing.Point(40, 180);
            this.lblConfirm.AutoSize = true;

            // txtConfirm
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirm.Location = new System.Drawing.Point(180, 177);
            this.txtConfirm.Size = new System.Drawing.Size(180, 32);
            this.txtConfirm.PasswordChar = '●';

            // lblHoten
            this.lblHoten.Text = "Họ tên:";
            this.lblHoten.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblHoten.Location = new System.Drawing.Point(40, 230);
            this.lblHoten.AutoSize = true;

            // txtHoten
            this.txtHoten.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHoten.Location = new System.Drawing.Point(180, 227);
            this.txtHoten.Size = new System.Drawing.Size(180, 32);

            // lblRole
            this.lblRole.Text = "Vai trò:";
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRole.Location = new System.Drawing.Point(40, 280);
            this.lblRole.AutoSize = true;

            // cmbVaiTro
            this.cmbVaiTro.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbVaiTro.Location = new System.Drawing.Point(180, 277);
            this.cmbVaiTro.Size = new System.Drawing.Size(180, 32);
            this.cmbVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbVaiTro.Items.AddRange(new object[] { "GiangVien", "SinhVien" });

            // btnRegister
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegister.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(70, 350);
            this.btnRegister.Size = new System.Drawing.Size(120, 40);
            this.btnRegister.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Location = new System.Drawing.Point(210, 350);
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Thêm controls vào panelRegister
            this.panelRegister.Controls.Add(this.lblTitle);
            this.panelRegister.Controls.Add(this.lblUser);
            this.panelRegister.Controls.Add(this.txtUser);
            this.panelRegister.Controls.Add(this.lblPass);
            this.panelRegister.Controls.Add(this.txtPass);
            this.panelRegister.Controls.Add(this.lblConfirm);
            this.panelRegister.Controls.Add(this.txtConfirm);
            this.panelRegister.Controls.Add(this.lblHoten);
            this.panelRegister.Controls.Add(this.txtHoten);
            this.panelRegister.Controls.Add(this.lblRole);
            this.panelRegister.Controls.Add(this.cmbVaiTro);
            this.panelRegister.Controls.Add(this.btnRegister);
            this.panelRegister.Controls.Add(this.btnCancel);

            // frmRegister
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.panelRegister);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";
        }
    }
}
