using Microsoft.EntityFrameworkCore;
using Models;
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
        public System.Data.Entity.DbSet<Order> Orders { get; set; }
        public System.Data.Entity.DbSet<Courier> Couriers { get; set; }
        public System.Data.Entity.DbSet<Feedback> Feedbacks { get; set; }
        public System.Data.Entity.DbSet<Payment> Payments { get; set; }
        public System.Data.Entity.DbSet<ProductFeedback> ProductFeedbacks { get; set; }
        public System.Data.Entity.DbSet<StoreProduct> storeProducts { get; set; }
        public System.Data.Entity.DbSet<ProductOffer> productOffers { get; set; }
        public System.Data.Entity.DbSet<SupplierStore> SupplierStores { get; set; }
        public System.Data.Entity.DbSet<Admin> Admins { get; set; }
        public System.Data.Entity.DbSet<Contact> Contacts { get; set; }

        public System.Data.Entity.DbSet<AdminUser> AdminUsers { get; set; }
        public System.Data.Entity.DbSet<AdminProduct> AdminProducts { get; set; }
>>>>>>> d6e0b85c95a90919ccb9039a53ed974b4576d60d

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new StoreEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OfferEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CourierEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentEnityConfiguration());
            modelBuilder.ApplyConfiguration(new FeedbackEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AdminEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ContactEntityConfiguration());

            modelBuilder.Entity<SupplierStore>().HasKey(ss => new { ss.Store_ID, ss.Supllier_ID });
            modelBuilder.Entity<SupplierStore>()
            .HasOne<Supplier>(s => s.supplier)
            .WithMany(sp => sp.SupllierStores)
            .HasForeignKey(sp => sp.Supllier_ID);

            modelBuilder.Entity<SupplierStore>()
            .HasOne<Store>(s => s.store)
            .WithMany(sp => sp.SupllierStores)
            .HasForeignKey(sp => sp.Store_ID);


            modelBuilder.Entity<StoreProduct>().HasKey(sp => new { sp.Store_ID, sp.Product_ID});
            modelBuilder.Entity<StoreProduct>()
            .HasOne<Product>(p => p.product)
            .WithMany(sp => sp.StoresProducts)
            .HasForeignKey(sp => sp.Product_ID);

            modelBuilder.Entity<StoreProduct>()
            .HasOne<Store>(s => s.store)
            .WithMany(sp => sp.StoresProducts)
            .HasForeignKey(sp => sp.Store_ID);

            modelBuilder.Entity<ProductOffer>().HasKey(po => new { po.Offer_ID, po.Product_ID });
            modelBuilder.Entity<ProductOffer>()
            .HasOne<Product>(p => p.product)
            .WithMany(po => po.ProductOffers)
            .HasForeignKey(pf => pf.Product_ID);

            modelBuilder.Entity<ProductOffer>()
            .HasOne<Offer>(f => f.offer)
            .WithMany(po => po.ProductOffers)
            .HasForeignKey(pf => pf.Offer_ID);

            modelBuilder.Entity<ProductFeedback>().HasKey(pf => new { pf.Feedback_ID, pf.Product_ID });
            modelBuilder.Entity<ProductFeedback>()
            .HasOne<Product>(p => p.Product)
            .WithMany(pf => pf.productFeedbacks)
            .HasForeignKey(pf => pf.Product_ID);

            modelBuilder.Entity<ProductFeedback>()
            .HasOne<Feedback>(f => f.Feedback)
            .WithMany(pf => pf.productFeedbacks)
            .HasForeignKey(pf => pf.Feedback_ID);

<<<<<<< HEAD
          
=======
            modelBuilder.Entity<AdminUser>().HasKey(Au => new { Au.User_ID, Au.Admin_ID });
            modelBuilder.Entity<AdminUser>()
            .HasOne<Admin>(a => a.Admin)
            .WithMany(Au => Au.AdminUsers)
            .HasForeignKey(a => a.Admin_ID);

            modelBuilder.Entity<AdminUser>()
            .HasOne<User>(u => u.User)
            .WithMany(Au => Au.AdminUsers)
            .HasForeignKey(u => u.User_ID);

            modelBuilder.Entity<AdminProduct>().HasKey(Ap => new { Ap.Product_ID, Ap.Admin_ID });
            modelBuilder.Entity<AdminProduct>()
            .HasOne<Admin>(a => a.Admin)
            .WithMany(Ap => Ap.AdminProducts)
            .HasForeignKey(a => a.Admin_ID);

            modelBuilder.Entity<AdminProduct>()
            .HasOne<Product>(p => p.Product)
            .WithMany(Ap => Ap.AdminProducts)
            .HasForeignKey(p => p.Product_ID);

            modelBuilder.Entity<AdminStore>().HasKey(As => new { As.Store_ID, As.Admin_ID });
            modelBuilder.Entity<AdminStore>()
            .HasOne<Admin>(a => a.Admin)
            .WithMany(As => As.AdminStores)
            .HasForeignKey(a => a.Admin_ID);

            modelBuilder.Entity<AdminStore>()
            .HasOne<Store>(s => s.Store)
            .WithMany(As => As.AdminStores)
            .HasForeignKey(a => a.Store_ID);
>>>>>>> d6e0b85c95a90919ccb9039a53ed974b4576d60d

            modelBuilder.Entity<Product>()
            .HasOne<Supplier>(s => s.supplier)
            .WithMany(g => g.Products)
            .HasForeignKey(s => s.CurrentSupplierID);

            modelBuilder.Entity<Product>()
             .HasOne<Category>(s => s.category)
             .WithMany(p => p.Products)
             .HasForeignKey(s => s.CurrentCategoryID);

            modelBuilder.Entity<Order>()
            .HasOne<Courier>(c => c.Courier)
            .WithMany(o => o.Orders)
            .HasForeignKey(c => c.CurrentCourierID);

            modelBuilder.Entity<Order>()
            .HasOne<Payment>(p => p.Payment)
            .WithMany(o => o.Orders)
            .HasForeignKey(p => p.CurrentPaymentID);

            modelBuilder.Entity<Order>()
            .HasOne<User>(u => u.User)
            .WithMany(o => o.Orders)
            .HasForeignKey(u => u.CurrentUserID);

            modelBuilder.Entity<Feedback>()
            .HasOne<User>(u => u.User)
            .WithMany(f => f.Feedbacks)
            .HasForeignKey(u => u.CurrentUserID);

            modelBuilder.Entity<Admin>()
            .HasOne<Contact>(c=>c.Contact)
            .WithMany(a => a.Admins)
            .HasForeignKey(a => a.CurrentContactID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
