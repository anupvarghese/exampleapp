﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GEMS3_GSApp.Repository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EffortDbEntities : DbContext
    {
        public EffortDbEntities()
            : base("name=EffortDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<IBOBTran> IBOBTrans { get; set; }
        public virtual DbSet<Tag_Details> Tag_Details { get; set; }
        public virtual DbSet<TagAssignment> TagAssignments { get; set; }
        public virtual DbSet<TagExceptionType> TagExceptionTypes { get; set; }
        public virtual DbSet<UserMaster> UserMasters { get; set; }
    }
}
