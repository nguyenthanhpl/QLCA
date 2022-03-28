namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChiTietSuatAn")]
    public partial class tblChiTietSuatAn
    {
        public int id { get; set; }

        public long idsuatan { get; set; }

        [Required]
        [StringLength(12)]
        public string idnguoian { get; set; }

        public int idcaan { get; set; }

        public int soluong { get; set; }

        public DateTime thoigian { get; set; }

        public virtual tblCaAn tblCaAn { get; set; }

        public virtual tblNguoiDung tblNguoiDung { get; set; }

        public virtual tblSuatAn tblSuatAn { get; set; }
    }
}
