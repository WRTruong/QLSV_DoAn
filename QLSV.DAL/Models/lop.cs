namespace QLSV.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lop")]
    public partial class lop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lop()
        {
            sinhvien = new HashSet<sinhvien>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int malop { get; set; }

        [Required]
        [StringLength(100)]
        public string tenlop { get; set; }

        public int makhoa { get; set; }

        public virtual khoa khoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sinhvien> sinhvien { get; set; }
    }
}
