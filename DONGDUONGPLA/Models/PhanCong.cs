//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DONGDUONGPLA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhanCong
    {
        public int MaPC { get; set; }
        public string MaNV { get; set; }
        public string MaPB { get; set; }
        public Nullable<System.DateTime> NgayPC { get; set; }
        public Nullable<bool> HieuLuc { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        public virtual PhongBan PhongBan { get; set; }
    }
}
