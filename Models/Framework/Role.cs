namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Role
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string IDUser { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string URole { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
