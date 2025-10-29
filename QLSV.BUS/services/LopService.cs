using System.Collections.Generic;
using System.Linq;
using QLSV.DAL.Models;

namespace QLSV.BUS.Services
{
    public class LopService
    {
        private readonly Model1 db = new Model1();

        public List<lop> GetAll()
        {
            return db.lop.ToList();
        }

        public List<lop> GetByKhoa(int makhoa)
        {
            return db.lop.Where(x => x.makhoa == makhoa).ToList();
        }

        public lop GetById(int id)
        {
            return db.lop.Find(id);
        }

        public void Add(lop l)
        {
            db.lop.Add(l);
            db.SaveChanges();
        }

        public void Update(lop l)
        {
            var existing = db.lop.Find(l.malop);
            if (existing != null)
            {
                existing.tenlop = l.tenlop;
                existing.makhoa = l.makhoa;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var l = db.lop.Find(id);
            if (l != null)
            {
                db.lop.Remove(l);
                db.SaveChanges();
            }
        }
    }
}
