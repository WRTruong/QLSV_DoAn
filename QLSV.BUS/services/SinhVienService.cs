using System.Collections.Generic;
using System.Linq;
using QLSV.DAL.Models;

namespace QLSV.BUS.Services
{
    public class SinhVienService
    {
        private readonly Model1 db = new Model1();

        // Lấy tất cả sinh viên
        public List<sinhvien> GetAll()
        {
            return db.sinhvien.ToList();
        }

        // Lấy sinh viên theo mã lớp
        public List<sinhvien> GetByLop(int malop)
        {
            return db.sinhvien.Where(x => x.malop == malop).ToList();
        }

        // Lấy sinh viên theo mã sinh viên (masv)
        public sinhvien GetByMaSV(string masv)
        {
            return db.sinhvien.FirstOrDefault(x => x.masv == masv);
        }

        // Thêm sinh viên mới
        public void Add(sinhvien sv)
        {
            db.sinhvien.Add(sv);
            db.SaveChanges();
        }

        // Cập nhật sinh viên
        public void Update(sinhvien sv)
        {
            var existing = db.sinhvien.Find(sv.masv);
            if (existing != null)
            {
                existing.tensv = sv.tensv;
                existing.ngaysinh = sv.ngaysinh;
                existing.malop = sv.malop;
                db.SaveChanges();
            }
        }

        // Xóa sinh viên
        public void Delete(string masv)
        {
            var sv = db.sinhvien.Find(masv);
            if (sv != null)
            {
                db.sinhvien.Remove(sv);
                db.SaveChanges();
            }
        }
    }
}
