namespace QLSV.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("diem")]
    public partial class diem
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string masv { get; set; }

        public int mamh { get; set; }

        public double? diemqt { get; set; }

        public double? diemck { get; set; }

        public virtual monhoc monhoc { get; set; }

        public virtual sinhvien sinhvien { get; set; }
    }
}
