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

        [StringLength(100)]
        public string TenGV { get; set; }

        [StringLength(50)]
        public string Fb { get; set; }
    }
}
