namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        public int MaTK { get; set; }

        [StringLength(100)]
        public string Hoten { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? SDT { get; set; }

        [StringLength(50)]
        public string Fb { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string Quyen { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public bool? Status { get; set; }
    }
}
