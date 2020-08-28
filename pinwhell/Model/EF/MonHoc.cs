namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonHoc")]
    public partial class MonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonHoc()
        {
            Student = new HashSet<Student>();
            TaiLieuHocTap = new HashSet<TaiLieuHocTap>();
        }

        [Key]
        public int MaMH { get; set; }

        [Display(Name ="Tên Môn Học")]
        [Required(ErrorMessage ="Chưa Nhập Môn Học")]
        [StringLength(50)]
        public string TenMH { get; set; }

        [Display(Name ="Trạng Thái")]
        public bool? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Student { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiLieuHocTap> TaiLieuHocTap { get; set; }
    }
}
