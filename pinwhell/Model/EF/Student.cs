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

        [Display(Name ="Tên Học Sinh")]
        [StringLength(100)]
        public string HoTenHS { get; set; }

        [Display(Name ="Tên Phụ Huynh")]
        [StringLength(100)]
        public string HoTenPH { get; set; }

        [Display(Name ="Môn Học")]
        public int? MonHoc { get; set; }

        [Display(Name ="Lớp")]
        public int? Lop { get; set; }

        [Display(Name ="Học Phí")]
        public int? HocPhi { get; set; }

        [Display(Name = "Ngày Đăng Kí")]
        [Column(TypeName = "date")]
        public DateTime? NgayDangKi { get; set; }

        [Display(Name ="Ngày Bắt Đầu Học")]
        [Column(TypeName = "date")]
        public DateTime? NgayBatDauHoc { get; set; }

        [Display(Name ="Tình Trạng Học Tập")]
        public int? TinhTrangHT { get; set; }

        
        [Display(Name ="Tình Trạng Học Phí")]
        public int? TinhTrangHP { get; set; }

        [Display(Name ="Lời Nhắc")]
        public string LoiNhac { get; set; }

        [Display(Name ="Ngày Đóng Học Phí")]
        [Column(TypeName = "date")]
        public DateTime? NgayDongHocPhi { get; set; }

        [Display(Name ="Trạng Thái")]
        public bool? Status { get; set; }

        public virtual HocPhi HocPhi1 { get; set; }

        public virtual MonHoc MonHoc1 { get; set; }

        public virtual TinhTrangHocTap TinhTrangHocTap { get; set; }

        public virtual TinhTrangHocPhi TinhTrangHocPhi { get; set; }
    }
}
