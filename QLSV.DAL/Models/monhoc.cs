namespace QLSV.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("monhoc")]
    public partial class monhoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public monhoc()
        {
            diem = new HashSet<diem>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mamh { get; set; }

        [Required]
        [StringLength(150)]
        public string tenmh { get; set; }

        public int? sotinchi { get; set; }

        public int? makhoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<diem> diem { get; set; }

        public virtual khoa khoa { get; set; }
    }
}
