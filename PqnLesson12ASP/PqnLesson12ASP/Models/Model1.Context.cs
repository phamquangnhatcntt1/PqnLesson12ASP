﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PqnLesson12ASP.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PhamQuangNhat_2210900115Entities1 : DbContext
    {
        public PhamQuangNhat_2210900115Entities1()
            : base("name=PhamQuangNhat_2210900115Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PqnSACH> PqnSACH { get; set; }
        public virtual DbSet<PqnTACGIA> PqnTACGIA { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}