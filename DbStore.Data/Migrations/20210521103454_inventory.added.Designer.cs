﻿// <auto-generated />
using System;
using DbStore.Data.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DbStore.Data.Migrations
{
    [DbContext(typeof(DbStoreContext))]
    [Migration("20210521103454_inventory.added")]
    partial class inventoryadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DbStore.Data.Address", b =>
                {
                    b.Property<long>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("character(128)")
                        .IsFixedLength(true)
                        .HasMaxLength(128);

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("character(128)")
                        .IsFixedLength(true)
                        .HasMaxLength(128);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("character(50)")
                        .IsFixedLength(true)
                        .HasMaxLength(50);

                    b.Property<string>("Pincode")
                        .IsRequired()
                        .HasColumnType("character(6)")
                        .IsFixedLength(true)
                        .HasMaxLength(6);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("character(50)")
                        .IsFixedLength(true)
                        .HasMaxLength(50);

                    b.HasKey("AddressId");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("DbStore.Data.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CategoryCode")
                        .IsRequired()
                        .HasColumnType("character varying(4)")
                        .HasMaxLength(4);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.HasKey("CategoryId");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("DbStore.Data.Inventory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("integer");

                    b.ToTable("inventories");
                });

            modelBuilder.Entity("DbStore.Data.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("character varying(4)")
                        .HasMaxLength(4);

                    b.Property<bool>("ProductInStock")
                        .HasColumnType("boolean")
                        .HasMaxLength(50);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("DbStore.Data.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("productCategories");
                });

            modelBuilder.Entity("DbStore.Data.ProductPrice", b =>
                {
                    b.Property<int>("ProductPriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CostPrice")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("Month")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("SellingPrice")
                        .HasColumnType("integer");

                    b.HasKey("ProductPriceId");

                    b.HasIndex("ProductId");

                    b.ToTable("productPrices");
                });

            modelBuilder.Entity("DbStore.Data.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("character(128)")
                        .IsFixedLength(true)
                        .HasMaxLength(128);

                    b.Property<string>("Rolename")
                        .IsRequired()
                        .HasColumnType("character(50)")
                        .IsFixedLength(true)
                        .HasMaxLength(50);

                    b.HasKey("RoleId");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("DbStore.Data.Staff", b =>
                {
                    b.Property<long>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("character(30)")
                        .IsFixedLength(true)
                        .HasMaxLength(30);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("character(1)")
                        .IsFixedLength(true)
                        .HasMaxLength(1);

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("character(30)")
                        .IsFixedLength(true)
                        .HasMaxLength(30);

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasColumnType("character(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<long>("Salary")
                        .HasColumnType("bigint");

                    b.HasKey("StaffId");

                    b.HasIndex("AddressId");

                    b.HasIndex("RoleId");

                    b.ToTable("staffs");
                });

            modelBuilder.Entity("DbStore.Data.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("SupplierAge")
                        .HasColumnType("integer")
                        .HasMaxLength(128);

                    b.Property<string>("SupplierEmail")
                        .IsRequired()
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("SupplierGender")
                        .IsRequired()
                        .HasColumnType("character varying(10)")
                        .HasMaxLength(10);

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("SupplierPhonenumber")
                        .IsRequired()
                        .HasColumnType("character(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.HasKey("SupplierId");

                    b.ToTable("suppliers");
                });

            modelBuilder.Entity("DbStore.Data.Product", b =>
                {
                    b.HasOne("DbStore.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbStore.Data.ProductCategory", b =>
                {
                    b.HasOne("DbStore.Data.Category", "category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbStore.Data.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbStore.Data.ProductPrice", b =>
                {
                    b.HasOne("DbStore.Data.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbStore.Data.Staff", b =>
                {
                    b.HasOne("DbStore.Data.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbStore.Data.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
