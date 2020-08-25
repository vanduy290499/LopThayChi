namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongBao")]
    public partial class ThongBao
    {
        [Key]
        public int MaTB { get; set; }

        public string BaiViet { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        public int? Chitietthongbao { get; set; }

        public bool? Status { get; set; }

        public virtual Detail_Thongbao Detail_Thongbao { get; set; }
    }
}
