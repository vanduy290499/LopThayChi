namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Blog")]
    public partial class Blog
    {
        [Key]
        public int MaBL { get; set; }

        [StringLength(1000)]
        public string Baiviet { get; set; }

        public int? ChiTietBlog { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaytao { get; set; }

        public virtual Detail_BLog Detail_BLog { get; set; }
    }
}
