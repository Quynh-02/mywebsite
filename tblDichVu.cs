//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLPhongKham
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDichVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDichVu()
        {
            this.tblHenKham = new HashSet<tblHenKham>();
        }
    
        public int ID { get; set; }
        public string TenDichVu { get; set; }
        public Nullable<int> IDLoaiDichVu { get; set; }
        public string Mota { get; set; }
        public Nullable<int> DonGia { get; set; }
    
        public virtual tblLoaiDichVu tblLoaiDichVu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHenKham> tblHenKham { get; set; }
    }
}
