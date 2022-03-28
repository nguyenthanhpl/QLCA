namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSuatAn")]
    public partial class tblSuatAn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSuatAn()
        {
            tblChiTietSuatAns = new HashSet<tblChiTietSuatAn>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(12)]
        public string idnguoidung { get; set; }

        public DateTime thoigian { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietSuatAn> tblChiTietSuatAns { get; set; }

        public virtual tblNguoiDung tblNguoiDung { get; set; }
    }
}
