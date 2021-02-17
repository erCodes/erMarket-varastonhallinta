﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using erMarket_varastonhallinta_Dal.Dao;

namespace erMarket_varastonhallinta_Dal.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210215154429_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("erMarket_varastonhallinta_Dal.Dao.LogDbClasses.LogData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NewAmount")
                        .HasColumnType("int");

                    b.Property<int>("OldAmount")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<string>("ProductsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserAction")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ChangeLog");
                });

            modelBuilder.Entity("erMarket_varastonhallinta_Dal.Dao.LogDbClasses.LogProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategorysId")
                        .HasColumnType("int");

                    b.Property<string>("CategorysName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LogDataId")
                        .HasColumnType("int");

                    b.Property<int?>("LogDataId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LogDataId");

                    b.HasIndex("LogDataId1");

                    b.ToTable("LogProductCategory");
                });

            modelBuilder.Entity("erMarket_varastonhallinta_Dal.Dao.ProductDbClasses.DaoCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategorysId")
                        .HasColumnType("int");

                    b.Property<string>("CategorysName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("erMarket_varastonhallinta_Dal.Dao.ProductDbClasses.DaoProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DaoStoreId")
                        .HasColumnType("int");

                    b.Property<int>("InStock")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("QuantityChanged")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DaoStoreId");

                    b.ToTable("DaoProduct");
                });

            modelBuilder.Entity("erMarket_varastonhallinta_Dal.Dao.ProductDbClasses.DaoProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategorysId")
                        .HasColumnType("int");

                    b.Property<string>("CategorysName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DaoProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DaoProductId");

                    b.ToTable("DaoProductCategory");
                });

            modelBuilder.Entity("erMarket_varastonhallinta_Dal.Dao.ProductDbClasses.DaoStore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StoresId")
                        .HasColumnType("int");

                    b.Property<string>("Supervisor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("erMarket_varastonhallinta_Dal.Dao.LogDbClasses.LogProductCategory", b =>
                {
                    b.HasOne("erMarket_varastonhallinta_Dal.Dao.LogDbClasses.LogData", null)
                        .WithMany("Categories")
                        .HasForeignKey("LogDataId");

                    b.HasOne("erMarket_varastonhallinta_Dal.Dao.LogDbClasses.LogData", null)
                        .WithMany("NewCategories")
                        .HasForeignKey("LogDataId1");
                });

            modelBuilder.Entity("erMarket_varastonhallinta_Dal.Dao.ProductDbClasses.DaoProduct", b =>
                {
                    b.HasOne("erMarket_varastonhallinta_Dal.Dao.ProductDbClasses.DaoStore", null)
                        .WithMany("Products")
                        .HasForeignKey("DaoStoreId");
                });

            modelBuilder.Entity("erMarket_varastonhallinta_Dal.Dao.ProductDbClasses.DaoProductCategory", b =>
                {
                    b.HasOne("erMarket_varastonhallinta_Dal.Dao.ProductDbClasses.DaoProduct", null)
                        .WithMany("Categories")
                        .HasForeignKey("DaoProductId");
                });
#pragma warning restore 612, 618
        }
    }
}