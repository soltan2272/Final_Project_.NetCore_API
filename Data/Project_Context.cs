using Microsoft.EntityFrameworkCore;

using Models;
using Models.Configration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class Project_Context: Microsoft.EntityFrameworkCore.DbContext
    {
        public System.Data.Entity.DbSet<User> Users { get; set; }
        public System.Data.Entity.DbSet<Supplier> Suplliers { get; set; }

        public System.Data.Entity.DbSet<Store> Stores { get; set; }
        public System.Data.Entity.DbSet<Offer> Offers { get; set; }
        public System.Data.Entity.DbSet<Product> Products { get; set; }

        public System.Data.Entity.DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new StoreEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OfferEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());

            modelBuilder.Entity<SupplierStore>().HasKey(ss => new { ss.Store_ID, ss.Supllier_ID });

            modelBuilder.Entity<Product>()
            .HasOne<Supplier>(s => s.supplier)
            .WithMany(g => g.Products)
            .HasForeignKey(s => s.CurrentSupplierID);

            modelBuilder.Entity<StoreProduct>().HasKey(sp => new { sp.Store_ID, sp.Product_ID});
            modelBuilder.Entity<ProductOffer>().HasKey(po => new { po.Offer_ID, po.Product_ID });

            modelBuilder.Entity<Product>()
             .HasOne<Category>(s => s.category)
             .WithMany(g => g.Products)
             .HasForeignKey(s => s.CurrentCategoryID);
    
            base.OnModelCreating(modelBuilder);
        }
    }
}
