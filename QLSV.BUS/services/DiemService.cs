using System.Collections.Generic;
using System.Linq;
using QLSV.DAL.Models;

namespace QLSV.BUS.Services
{
    public class DiemService
    {
        private readonly Model1 db = new Model1();

        public List<diem> GetAll()
        {
            return db.diem.ToList();
        }

        public List<diem> GetBySinhVien(string masv)
        {
            return db.diem.Where(x => x.masv == masv).ToList();
        }

        public diem GetById(int id)
        {
            return db.diem.Find(id);
        }

        public void Add(diem d)
        {
            db.diem.Add(d);
            db.SaveChanges();
        }

        public void Update(diem d)
        {
            var existing = db.diem.Find(d.id);
            if (existing != null)
            {
                existing.masv = d.masv;
                existing.mamh = d.mamh;
                existing.diemqt = d.diemqt;
                existing.diemck = d.diemck;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var d = db.diem.Find(id);
            if (d != null)
            {
                db.diem.Remove(d);
                db.SaveChanges();
            }
        }
    }
}
