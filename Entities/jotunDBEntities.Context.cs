﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jotun.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class jotunDBEntities : DbContext
    {
        public jotunDBEntities()
            : base("name=jotunDBEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<tblCategory> tblCategories { get; set; }
        public virtual DbSet<tblCustomer_location> tblCustomer_location { get; set; }
        public virtual DbSet<tblCustomer> tblCustomers { get; set; }
        public virtual DbSet<tblInvoice> tblInvoices { get; set; }
        public virtual DbSet<tblProductByUnit> tblProductByUnits { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblPurchaseBySupplier> tblPurchaseBySuppliers { get; set; }
        public virtual DbSet<tblPurchaseBySupplierDetail> tblPurchaseBySupplierDetails { get; set; }
        public virtual DbSet<tblSale> tblSales { get; set; }
        public virtual DbSet<tblSalesDetail> tblSalesDetails { get; set; }
        public virtual DbSet<tblShipper> tblShippers { get; set; }
        public virtual DbSet<tblSupplier> tblSuppliers { get; set; }
        public virtual DbSet<tblUnit> tblUnits { get; set; }
        public virtual DbSet<tbSalePayment> tbSalePayments { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<webpages_Membership> webpages_Membership { get; set; }
        public virtual DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public virtual DbSet<webpages_Roles> webpages_Roles { get; set; }
    }
}
