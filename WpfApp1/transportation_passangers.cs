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
    
    public partial class transportation_passangers
    {
        public int Id { get; set; }
        public int transportation_id { get; set; }
        public int passenger_id { get; set; }
        public bool deleted { get; set; }
    
        public virtual passenger passenger { get; set; }
        public virtual transportation transportation { get; set; }
    }
}
