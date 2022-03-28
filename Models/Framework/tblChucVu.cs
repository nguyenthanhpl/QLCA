namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChucVu")]
    public partial class tblChucVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblChucVu()
        {
            tblNguoiDungs = new HashSet<tblNguoiDung>();
        }

        [StringLength(12)]
        public string id { get; set; }

        [Required]
        [StringLength(50)]
        public string tenchucvu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNguoiDung> tblNguoiDungs { get; set; }
    }
}
