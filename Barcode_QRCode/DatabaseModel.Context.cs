﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Barcode_QRCode
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MidPortal_DBEntities1 : DbContext
    {
        public MidPortal_DBEntities1()
            : base("name=MidPortal_DBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Mlz_Depo> Mlz_Depo { get; set; }
        public DbSet<Mlz_Depo_Raf_Urun_Detay> Mlz_Depo_Raf_Urun_Detay { get; set; }
        public DbSet<Mlz_Depo_Alan> Mlz_Depo_Alan { get; set; }
        public DbSet<Mlz_Depo_Alan_Urun> Mlz_Depo_Alan_Urun { get; set; }
        public DbSet<Mlz_Depo_Raf> Mlz_Depo_Raf { get; set; }
        public DbSet<Mlz_Depo_Raf_Urun> Mlz_Depo_Raf_Urun { get; set; }
    }
}
