﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbEntities : DbContext
    {
        public dbEntities()
            : base("name=dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<customer> customer { get; set; }
        public DbSet<employee_type> employee_type { get; set; }
        public DbSet<expense> expense { get; set; }
        public DbSet<license> license { get; set; }
        public DbSet<passenger> passenger { get; set; }
        public DbSet<transportation> transportation { get; set; }
        public DbSet<transportation_passangers> transportation_passangers { get; set; }
        public DbSet<vehicle> vehicle { get; set; }
        public DbSet<employee> employee { get; set; }
    }
}
