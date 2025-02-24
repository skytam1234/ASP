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
    
    public partial class HangHoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangHoa()
        {
            this.BanBes = new HashSet<BanBe>();
            this.ChiTietHDs = new HashSet<ChiTietHD>();
            this.YeuThiches = new HashSet<YeuThich>();
        }
    
        public int MaHH { get; set; }
        public string TenHH { get; set; }
        public string TenAlias { get; set; }
        public int MaLoai { get; set; }
        public string MoTaDonVi { get; set; }
        public Nullable<double> DonGia { get; set; }
        public string Hinh { get; set; }
        public System.DateTime NgaySX { get; set; }
        public double GiamGia { get; set; }
        public int SoLanXem { get; set; }
        public string MoTa { get; set; }
        public string MaNCC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BanBe> BanBes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHD> ChiTietHDs { get; set; }
        public virtual Loai Loai { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YeuThich> YeuThiches { get; set; }
    }
}
