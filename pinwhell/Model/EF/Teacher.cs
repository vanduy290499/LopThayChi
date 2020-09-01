namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Teacher")]
    public partial class Teacher
    {
        [Key]
        public int MaGV { get; set; }

        [Display(Name ="Tên giáo viên")]
        [Required(ErrorMessage ="Bạn chưa nhập tên giáo viên")]
        [StringLength(100)]
        public string TenGV { get; set; }


        [Display(Name ="Facebook")]
        [Required(ErrorMessage ="Bạn chưa nhập facebook")]
        public string Fb { get; set; }

        [Display(Name ="Địa chỉ")]
        [Required(ErrorMessage ="Bạn chưa nhập địa chỉ")]
        public string DiaChi { set; get; }

        [Display(Name ="Trạng thái")]
        public bool? Status { get; set; }

        [Display(Name ="Số điện thoại")]
        [Required(ErrorMessage ="Bạn chưa nhập số điện thoại")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Số điện thoại không hợp lệ")]
        [StringLength(11,ErrorMessage ="số ký tự tối đa là 11 số")]
        public string sdt { get; set; }

        [Display(Name ="Email")]
        [Required(ErrorMessage ="Bạn chưa nhập Email")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Địa chỉ email không hợp lệ")]
        [StringLength(50)]
        public string email { get; set; }
    }
}
