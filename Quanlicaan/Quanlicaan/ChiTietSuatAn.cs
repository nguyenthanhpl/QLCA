//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quanlicaan
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietSuatAn
    {
        public int ID { get; set; }
        public int IDUser { get; set; }
        public int Soluong { get; set; }
        public Nullable<int> IDSuatAn { get; set; }
        public int IDCaan { get; set; }
        public System.DateTime Thoigiandat { get; set; }
    
        public virtual CaAn CaAn { get; set; }
        public virtual SuatAn SuatAn { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}