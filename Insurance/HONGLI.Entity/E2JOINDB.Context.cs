﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HONGLI.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class E2JOINDB : DbContext
    {
        public E2JOINDB()
            : base("name=E2JOINDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Order_Base> Order_Base { get; set; }
        public virtual DbSet<Order_Deliver> Order_Deliver { get; set; }
        public virtual DbSet<Order_Pay> Order_Pay { get; set; }
        public virtual DbSet<Order_PolicyHolder> Order_PolicyHolder { get; set; }
        public virtual DbSet<Product_CommercialCategory> Product_CommercialCategory { get; set; }
        public virtual DbSet<Product_Company> Product_Company { get; set; }
        public virtual DbSet<Product_Product> Product_Product { get; set; }
        public virtual DbSet<Quote> Quote { get; set; }
        public virtual DbSet<Insured> Insured { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<User_Deliver> User_Deliver { get; set; }
        public virtual DbSet<User_Invoice> User_Invoice { get; set; }
        public virtual DbSet<User_PolicyHolder> User_PolicyHolder { get; set; }
        public virtual DbSet<Order_Item> Order_Item { get; set; }
    }
}
