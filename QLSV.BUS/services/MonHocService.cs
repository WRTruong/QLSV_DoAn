using System.Collections.Generic;
using System.Linq;
using QLSV.DAL.Models;

namespace QLSV.BUS.Services
{
    public class MonHocService
    {
        private readonly Model1 db = new Model1();

        public List<monhoc> GetAll()
        {
            return db.monhoc.ToList();
        }

        public monhoc GetById(int id)
        {
            return db.monhoc.Find(id);
        }

        public void Add(monhoc mh)
        {
            db.monhoc.Add(mh);
            db.SaveChanges();
        }

        public void Update(monhoc mh)
        {
            var existing = db.monhoc.Find(mh.mamh);
            if (existing != null)
            {
                existing.tenmh = mh.tenmh;
                existing.sotinchi = mh.sotinchi;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var mh = db.monhoc.Find(id);
            if (mh != null)
            {
                db.monhoc.Remove(mh);
                db.SaveChanges();
            }
        }
        public List<monhoc> GetByKhoa(int makhoa)
        {
            return db.monhoc.Where(x => x.makhoa == makhoa).ToList();
        }

    }
}
