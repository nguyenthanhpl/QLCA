namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblNguoiDung")]
    public partial class tblNguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblNguoiDung()
        {
            tblChiTietSuatAns = new HashSet<tblChiTietSuatAn>();
            tblSuatAns = new HashSet<tblSuatAn>();
        }

        [StringLength(12)]
        [DisplayName("Mã nhân viên")]
        public string id { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập họ tên nhân viên")]
        [StringLength(50)]
        [DisplayName("Họ tên nhân viên")]
        public string hoten { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập tên đăng nhập")]
        [StringLength(50)]
        [DisplayName("Tên đăng nhập")]
        public string username { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập mật khẩu")]
        [StringLength(50)]
        [DisplayName("Mật khẩu")]
        public string password { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập mã phòng ban")]
        [StringLength(12)]
        [DisplayName("Mã phòng ban")]
        public string idphongban { get; set; }

        [DisplayName("Quyền đăng kí")]
        public bool? quyendangky { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập mã chức vụ")]
        [StringLength(12)]
        [DisplayName("Mã chức vụ")]
        public string idchucvu { get; set; }

        [DisplayName("Trạng thái")]
        public bool? trangthai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietSuatAn> tblChiTietSuatAns { get; set; }

        public virtual tblChucVu tblChucVu { get; set; }

        public virtual tblPhongBan tblPhongBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSuatAn> tblSuatAns { get; set; }
    }
}
