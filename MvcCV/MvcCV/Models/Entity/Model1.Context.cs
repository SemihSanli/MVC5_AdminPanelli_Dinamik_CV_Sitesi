﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCV.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCVEntities : DbContext
    {
        public DbCVEntities()
            : base("name=DbCVEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_About> Tbl_About { get; set; }
        public virtual DbSet<Tbl_Admin> Tbl_Admin { get; set; }
        public virtual DbSet<Tbl_Certificate> Tbl_Certificate { get; set; }
        public virtual DbSet<Tbl_Contact> Tbl_Contact { get; set; }
        public virtual DbSet<Tbl_Education> Tbl_Education { get; set; }
        public virtual DbSet<Tbl_Experience> Tbl_Experience { get; set; }
        public virtual DbSet<Tbl_MySkills> Tbl_MySkills { get; set; }
        public virtual DbSet<Tbl_Project> Tbl_Project { get; set; }
        public virtual DbSet<Tbl_SocialMedia> Tbl_SocialMedia { get; set; }
    }
}
