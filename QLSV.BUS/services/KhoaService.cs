using System.Collections.Generic;
using System.Linq;
using QLSV.DAL.Models;

namespace QLSV.BUS.Services
{
    public class KhoaService
    {
        private readonly Model1 db = new Model1();

        public List<khoa> GetAll()
        {
            return db.khoa.ToList();
        }

        public khoa GetById(int id)
        {
            return db.khoa.Find(id);
        }

        public void Add(khoa k)
        {
            db.khoa.Add(k);
            db.SaveChanges();
        }

        public void Update(khoa k)
        {
            var existing = db.khoa.Find(k.makhoa);
            if (existing != null)
            {
                existing.tenkhoa = k.tenkhoa;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var k = db.khoa.Find(id);
            if (k != null)
            {
                db.khoa.Remove(k);
                db.SaveChanges();
            }
        }
    }
}
