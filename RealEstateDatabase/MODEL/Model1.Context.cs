﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealEstateDatabase.MODEL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class emlakEntities : DbContext
    {
        public emlakEntities()
            : base("name=emlakEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<dükkan> dükkan { get; set; }
        public virtual DbSet<ev_sahibi> ev_sahibi { get; set; }
        public virtual DbSet<kira_kayıt> kira_kayıt { get; set; }
        public virtual DbSet<kiracı> kiracı { get; set; }
        public virtual DbSet<kiralık_ev> kiralık_ev { get; set; }
        public virtual DbSet<mahalle> mahalle { get; set; }
        public virtual DbSet<satılık_ev> satılık_ev { get; set; }
        public virtual DbSet<satış_kaydı> satış_kaydı { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<şehir> şehir { get; set; }
        public virtual DbSet<temsilci> temsilci { get; set; }
        public virtual DbSet<yeni_ev_sahibi> yeni_ev_sahibi { get; set; }
    }
}
