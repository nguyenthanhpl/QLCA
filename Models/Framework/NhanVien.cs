namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            ChiTietSuatAns = new HashSet<ChiTietSuatAn>();
            Roles = new HashSet<Role>();
            SuatAns = new HashSet<SuatAn>();
        }

        [StringLength(10)]
        public string ID { get; set; }

        [Required]
        [StringLength(30)]
        public string HoTen { get; set; }

        public bool GioiTinh { get; set; }

        [Required]
        [StringLength(20)]
        public string DiaChi { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string SDT { get; set; }

        [Required]
        [StringLength(7)]
        public string IDPhongBan { get; set; }

        [Required]
        [StringLength(10)]
        public string username { get; set; }

        [Required]
        [StringLength(10)]
        public string upassword { get; set; }

        public bool trangthai { get; set; }

        [Required]
        [StringLength(20)]
        public string ChucVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSuatAn> ChiTietSuatAns { get; set; }

        public virtual PhongBan PhongBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Role> Roles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SuatAn> SuatAns { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
