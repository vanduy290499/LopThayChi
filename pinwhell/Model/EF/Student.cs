namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [Key]
        public int MaHS { get; set; }

        [StringLength(100)]
        public string HoTenHS { get; set; }

        [StringLength(100)]
        public string HoTenPH { get; set; }

        public int? MonHoc { get; set; }

        public int? Lop { get; set; }

        public int? HocPhi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDangKi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBatDauHoc { get; set; }

        public int? TinhTrangHT { get; set; }

        public int? TinhTrangHP { get; set; }

        public string LoiNhac { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDongHocPhi { get; set; }

        public bool? Status { get; set; }

        public virtual HocPhi HocPhi1 { get; set; }

        public virtual MonHoc MonHoc1 { get; set; }

        public virtual TinhTrangHocTap TinhTrangHocTap { get; set; }

        public virtual TinhTrangHocPhi TinhTrangHocPhi { get; set; }
    }
}
