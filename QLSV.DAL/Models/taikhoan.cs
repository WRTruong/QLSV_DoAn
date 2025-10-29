namespace QLSV.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("taikhoan")]
    public partial class taikhoan
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string tendangnhap { get; set; }

        [Required]
        [StringLength(100)]
        public string matkhau { get; set; }

        [StringLength(100)]
        public string hoten { get; set; }

        [StringLength(20)]
        public string vaitro { get; set; }
    }
}
