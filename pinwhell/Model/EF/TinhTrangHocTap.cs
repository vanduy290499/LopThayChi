namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinhTrangHocTap")]
    public partial class TinhTrangHocTap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TinhTrangHocTap()
        {
            Student = new HashSet<Student>();
        }

        [Key]
        public int MaTTHT { get; set; }

        [StringLength(50)]
        public string TinhTrangHT { get; set; }

        [StringLength(50)]
        public string LoiNhac { get; set; }

        public bool? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Student { get; set; }
    }
}
