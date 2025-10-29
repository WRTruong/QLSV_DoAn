using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLSV.DAL.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<diem> diem { get; set; }
        public virtual DbSet<khoa> khoa { get; set; }
        public virtual DbSet<lop> lop { get; set; }
        public virtual DbSet<monhoc> monhoc { get; set; }
        public virtual DbSet<sinhvien> sinhvien { get; set; }
        public virtual DbSet<taikhoan> taikhoan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
