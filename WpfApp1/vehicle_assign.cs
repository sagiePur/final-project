//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class vehicle_assign
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vehicle_assign()
        {
            this.transportation = new HashSet<transportation>();
        }
    
        public int Id { get; set; }
        public int vehicle_id { get; set; }
        public System.DateTime beginning_time { get; set; }
        public System.DateTime end_time { get; set; }
    
        public virtual vehicle vehicle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transportation> transportation { get; set; }
    }
}
