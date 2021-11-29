﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(Project_Context))]
    partial class Project_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentContactID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("CurrentContactID");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("Models.AdminProduct", b =>
                {
                    b.Property<int>("Product_ID")
                        .HasColumnType("int");

                    b.Property<int>("Admin_ID")
                        .HasColumnType("int");

                    b.HasKey("Product_ID", "Admin_ID");

                    b.HasIndex("Admin_ID");

                    b.ToTable("AdminProducts");
                });

            modelBuilder.Entity("Models.AdminStore", b =>
                {
                    b.Property<int>("Store_ID")
                        .HasColumnType("int");

                    b.Property<int>("Admin_ID")
                        .HasColumnType("int");

                    b.HasKey("Store_ID", "Admin_ID");

                    b.HasIndex("Admin_ID");

                    b.ToTable("AdminStore");
                });

            modelBuilder.Entity("Models.AdminSupplier", b =>
                {
                    b.Property<int>("Admin_ID")
                        .HasColumnType("int");

                    b.Property<int>("Supplier_ID")
                        .HasColumnType("int");

                    b.HasKey("Admin_ID", "Supplier_ID");

                    b.HasIndex("Supplier_ID");

                    b.ToTable("AdminSuppliers");
                });

            modelBuilder.Entity("Models.AdminUser", b =>
                {
                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.Property<int>("Admin_ID")
                        .HasColumnType("int");

                    b.HasKey("User_ID", "Admin_ID");

                    b.HasIndex("Admin_ID");

                    b.ToTable("AdminUsers");
                });

            modelBuilder.Entity("Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Models.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Facebook")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Twitter")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("Models.Courier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Date")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Courier");
                });

            modelBuilder.Entity("Models.Feedback", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("CurrentUserID");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("Models.Offer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Discount_Percentage")
                        .HasMaxLength(15)
                        .HasColumnType("real");

                    b.Property<DateTime>("End_Date")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start_Date")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Offer");
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentCourierID")
                        .HasColumnType("int");

                    b.Property<int>("CurrentPaymentID")
                        .HasColumnType("int");

                    b.Property<int>("CurrentUserID")
                        .HasColumnType("int");

                    b.Property<string>("Delivery_Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Order_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CurrentCourierID");

                    b.HasIndex("CurrentPaymentID");

                    b.HasIndex("CurrentUserID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Models.Payment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasMaxLength(10)
                        .HasColumnType("float");

                    b.Property<string>("Card_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Ccv")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("Credit_Number")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<DateTime>("Expire_Date")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("Payment_Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentCategoryID")
                        .HasColumnType("int");

                    b.Property<int>("CurrentSupplierID")
                        .HasColumnType("int");

                    b.Property<int>("CurrentUserID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<float>("Price")
                        .HasMaxLength(20)
                        .HasColumnType("real");

                    b.Property<int>("Rate")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CurrentCategoryID");

                    b.HasIndex("CurrentSupplierID");

                    b.HasIndex("UserID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Models.ProductFeedback", b =>
                {
                    b.Property<int>("Feedback_ID")
                        .HasColumnType("int");

                    b.Property<int>("Product_ID")
                        .HasColumnType("int");

                    b.HasKey("Feedback_ID", "Product_ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("ProductFeedbacks");
                });

            modelBuilder.Entity("Models.ProductOffer", b =>
                {
                    b.Property<int>("Offer_ID")
                        .HasColumnType("int");

                    b.Property<int>("Product_ID")
                        .HasColumnType("int");

                    b.HasKey("Offer_ID", "Product_ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("productOffers");
                });

            modelBuilder.Entity("Models.Store", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("ID");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("Models.StoreProduct", b =>
                {
                    b.Property<int>("Store_ID")
                        .HasColumnType("int");

                    b.Property<int>("Product_ID")
                        .HasColumnType("int");

                    b.HasKey("Store_ID", "Product_ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("storeProducts");
                });

            modelBuilder.Entity("Models.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Credit_Card")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("SSN")
                        .HasMaxLength(14)
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("Models.SupplierStore", b =>
                {
                    b.Property<int>("Store_ID")
                        .HasColumnType("int");

                    b.Property<int>("Supllier_ID")
                        .HasColumnType("int");

                    b.HasKey("Store_ID", "Supllier_ID");

                    b.HasIndex("Supllier_ID");

                    b.ToTable("SupplierStores");
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adrress")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("Date_Of_Birth")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Full_Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<int>("SSN")
                        .HasMaxLength(14)
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Models.Admin", b =>
                {
                    b.HasOne("Models.Contact", "Contact")
                        .WithMany("Admins")
                        .HasForeignKey("CurrentContactID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("Models.AdminProduct", b =>
                {
                    b.HasOne("Models.Admin", "Admin")
                        .WithMany("AdminProducts")
                        .HasForeignKey("Admin_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Product", "Product")
                        .WithMany("AdminProducts")
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Models.AdminStore", b =>
                {
                    b.HasOne("Models.Admin", "Admin")
                        .WithMany("AdminStores")
                        .HasForeignKey("Admin_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Store", "Store")
                        .WithMany("AdminStores")
                        .HasForeignKey("Store_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("Models.AdminSupplier", b =>
                {
                    b.HasOne("Models.Admin", "Admin")
                        .WithMany("AdminSuppliers")
                        .HasForeignKey("Admin_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Supplier", "Supplier")
                        .WithMany("AdminSuppliers")
                        .HasForeignKey("Supplier_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Models.AdminUser", b =>
                {
                    b.HasOne("Models.Admin", "Admin")
                        .WithMany("AdminUsers")
                        .HasForeignKey("Admin_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.User", "User")
                        .WithMany("AdminUsers")
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.Feedback", b =>
                {
                    b.HasOne("Models.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("CurrentUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.HasOne("Models.Courier", "Courier")
                        .WithMany("Orders")
                        .HasForeignKey("CurrentCourierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Payment", "Payment")
                        .WithMany("Orders")
                        .HasForeignKey("CurrentPaymentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("CurrentUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courier");

                    b.Navigation("Payment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.HasOne("Models.Category", "category")
                        .WithMany("Products")
                        .HasForeignKey("CurrentCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Supplier", "supplier")
                        .WithMany("Products")
                        .HasForeignKey("CurrentSupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.User", "User")
                        .WithMany("Products")
                        .HasForeignKey("UserID");

                    b.Navigation("category");

                    b.Navigation("supplier");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.ProductFeedback", b =>
                {
                    b.HasOne("Models.Feedback", "Feedback")
                        .WithMany("productFeedbacks")
                        .HasForeignKey("Feedback_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Product", "Product")
                        .WithMany("productFeedbacks")
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feedback");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Models.ProductOffer", b =>
                {
                    b.HasOne("Models.Offer", "offer")
                        .WithMany("ProductOffers")
                        .HasForeignKey("Offer_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Product", "product")
                        .WithMany("ProductOffers")
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("offer");

                    b.Navigation("product");
                });

            modelBuilder.Entity("Models.StoreProduct", b =>
                {
                    b.HasOne("Models.Product", "product")
                        .WithMany("StoresProducts")
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Store", "store")
                        .WithMany("StoresProducts")
                        .HasForeignKey("Store_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("store");
                });

            modelBuilder.Entity("Models.SupplierStore", b =>
                {
                    b.HasOne("Models.Store", "store")
                        .WithMany("SupllierStores")
                        .HasForeignKey("Store_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Supplier", "supplier")
                        .WithMany("SupllierStores")
                        .HasForeignKey("Supllier_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("store");

                    b.Navigation("supplier");
                });

            modelBuilder.Entity("Models.Admin", b =>
                {
                    b.Navigation("AdminProducts");

                    b.Navigation("AdminStores");

                    b.Navigation("AdminSuppliers");

                    b.Navigation("AdminUsers");
                });

            modelBuilder.Entity("Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Models.Contact", b =>
                {
                    b.Navigation("Admins");
                });

            modelBuilder.Entity("Models.Courier", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Models.Feedback", b =>
                {
                    b.Navigation("productFeedbacks");
                });

            modelBuilder.Entity("Models.Offer", b =>
                {
                    b.Navigation("ProductOffers");
                });

            modelBuilder.Entity("Models.Payment", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.Navigation("AdminProducts");

                    b.Navigation("productFeedbacks");

                    b.Navigation("ProductOffers");

                    b.Navigation("StoresProducts");
                });

            modelBuilder.Entity("Models.Store", b =>
                {
                    b.Navigation("AdminStores");

                    b.Navigation("StoresProducts");

                    b.Navigation("SupllierStores");
                });

            modelBuilder.Entity("Models.Supplier", b =>
                {
                    b.Navigation("AdminSuppliers");

                    b.Navigation("Products");

                    b.Navigation("SupllierStores");
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Navigation("AdminUsers");

                    b.Navigation("Feedbacks");

                    b.Navigation("Orders");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
