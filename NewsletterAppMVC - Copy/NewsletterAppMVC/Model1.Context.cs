﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewsletterAppMVC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    // this class establishes database connection via DbContext
    public partial class NewsletterEntities : DbContext
    {
        // instantiates db object with connection string via Web.config
        public NewsletterEntities()
            : base("name=NewsletterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        
        // creates a mapped SignUp model accessible in controller
        public virtual DbSet<SignUp> SignUps { get; set; }
    }
}