//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class transportation
    {
        public transportation()
        {
            this.transportation_passangers = new HashSet<transportation_passangers>();
        }
    
        public int Id { get; set; }
        public string vehicle_id { get; set; }
        public string license_id { get; set; }
        public System.DateTime beginning_time { get; set; }
        public System.DateTime end_time { get; set; }
        public double income { get; set; }
        public bool deleted { get; set; }
    
        public virtual license license { get; set; }
        public virtual ICollection<transportation_passangers> transportation_passangers { get; set; }
        public virtual vehicle vehicle { get; set; }
    }
}