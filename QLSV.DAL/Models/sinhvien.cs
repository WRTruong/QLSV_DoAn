namespace QLSV.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sinhvien")]
    public partial class sinhvien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sinhvien()
        {
            diem = new HashSet<diem>();
        }

        [Key]
        [StringLength(20)]
        public string masv { get; set; }

        [Required]
        [StringLength(100)]
        public string tensv { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysinh { get; set; }

        public int malop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<diem> diem { get; set; }

        public virtual lop lop { get; set; }
    }
}
