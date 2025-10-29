using System.Linq;
using QLSV.DAL.Models;

namespace QLSV.BUS.Services
{
    public class TaiKhoanService
    {
        private readonly Model1 db = new Model1();

        public taikhoan DangNhap(string ten, string mk)
        {
            return db.taikhoan.FirstOrDefault(x => x.tendangnhap == ten && x.matkhau == mk);
        }

        public bool DangKy(taikhoan tk)
        {
            if (db.taikhoan.Any(x => x.tendangnhap == tk.tendangnhap))
                return false;

            db.taikhoan.Add(tk);
            db.SaveChanges();
            return true;
        }
    }
}
