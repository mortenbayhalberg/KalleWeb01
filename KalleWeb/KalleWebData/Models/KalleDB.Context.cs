﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KalleWebData.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NyKalleDB : DbContext
    {
        public NyKalleDB()
            : base("name=NyKalleDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblFrame> tblFrame { get; set; }
        public virtual DbSet<tblSpil> tblSpil { get; set; }
        public virtual DbSet<tblSpiller> tblSpiller { get; set; }
    }
}
