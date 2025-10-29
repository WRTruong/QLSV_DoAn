using QLSV.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.GUI.Forms
{
    internal static class Program
    {
        public static taikhoan CurrentUser; // Lưu user đăng nhập

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Chạy form đăng nhập trước
            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // Khi đăng nhập thành công, CurrentUser đã được gán
                    Application.Run(new frmMain(CurrentUser));
                }
            }
        }
    }
}
