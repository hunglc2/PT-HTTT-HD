﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HTTTHD.WebAPI._02.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BANK_MANAGEMENTEntities : DbContext
    {
        public BANK_MANAGEMENTEntities()
            : base("name=BANK_MANAGEMENTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public DbSet<ACCOUNT_TYPE> ACCOUNT_TYPE { get; set; }
        public DbSet<BRANCH> BRANCHes { get; set; }
        public DbSet<CUSTOMER> CUSTOMERs { get; set; }
        public DbSet<EMPLOYEE> EMPLOYEEs { get; set; }
        public DbSet<OWNER> OWNERs { get; set; }
        public DbSet<POSITION_EMP> POSITION_EMP { get; set; }
        public DbSet<SAVINGS_ACCOUNT> SAVINGS_ACCOUNT { get; set; }
        public DbSet<TRANSACTION_TYPES> TRANSACTION_TYPES { get; set; }
        public DbSet<TRANSACTION> TRANSACTIONS { get; set; }
        public DbSet<TYPE_SAVINGS_ACCOUNT> TYPE_SAVINGS_ACCOUNT { get; set; }
    }
}
