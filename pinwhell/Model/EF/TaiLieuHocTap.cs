namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiLieuHocTap")]
    public partial class TaiLieuHocTap
    {
        [Key]
        public int MaTL { get; set; }

        public int? MonHoc { get; set; }

        public string TaiLieu { get; set; }

        public virtual MonHoc MonHoc1 { get; set; }
    }
}
