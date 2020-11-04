﻿// <auto-generated />
using System;
using ItemCatalogService.Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ItemCatalogService.Data.Migrations
{
    [DbContext(typeof(ItemContext))]
    [Migration("20201104110803_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("ItemCatalogService.Adress", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<Guid?>("ContactPersonId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("SellerCompanyId")
                        .HasColumnType("uuid");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("StreetAdress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("ID");

                    b.HasIndex("ContactPersonId");

                    b.HasIndex("SellerCompanyId");

                    b.ToTable("Adresses");
                });

            modelBuilder.Entity("ItemCatalogService.Answer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AnswerText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("ItemCatalogService.ContactPerson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<Guid?>("SellerCompanyId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SellerCompanyId");

                    b.ToTable("ContactPeople");
                });

            modelBuilder.Entity("ItemCatalogService.EMail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ContactPersonId")
                        .HasColumnType("uuid");

                    b.Property<string>("EMailAdress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ContactPersonId");

                    b.HasIndex("UserId");

                    b.ToTable("EMails");
                });

            modelBuilder.Entity("ItemCatalogService.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("BuyPrice")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Description")
                        .HasColumnType("integer");

                    b.Property<decimal>("Discount")
                        .HasColumnType("numeric");

                    b.Property<int>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("integer");

                    b.Property<decimal>("SellPrice")
                        .HasColumnType("numeric");

                    b.Property<Guid?>("SellerCompanyId")
                        .HasColumnType("uuid");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SellerCompanyId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("ItemCatalogService.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ItemId")
                        .HasColumnType("uuid");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("UserId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ItemCatalogService.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ItemId")
                        .HasColumnType("uuid");

                    b.Property<int>("RatingValue")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("ItemCatalogService.SellerCompany", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("SellerCompanies");
                });

            modelBuilder.Entity("ItemCatalogService.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ItemCatalogService.Adress", b =>
                {
                    b.HasOne("ItemCatalogService.ContactPerson", null)
                        .WithMany("WorkLocationAdresses")
                        .HasForeignKey("ContactPersonId");

                    b.HasOne("ItemCatalogService.SellerCompany", null)
                        .WithMany("LocationAdresses")
                        .HasForeignKey("SellerCompanyId");
                });

            modelBuilder.Entity("ItemCatalogService.Answer", b =>
                {
                    b.HasOne("ItemCatalogService.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ItemCatalogService.ContactPerson", b =>
                {
                    b.HasOne("ItemCatalogService.SellerCompany", null)
                        .WithMany("Contacts")
                        .HasForeignKey("SellerCompanyId");
                });

            modelBuilder.Entity("ItemCatalogService.EMail", b =>
                {
                    b.HasOne("ItemCatalogService.ContactPerson", null)
                        .WithMany("EMails")
                        .HasForeignKey("ContactPersonId");

                    b.HasOne("ItemCatalogService.User", null)
                        .WithMany("EMails")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ItemCatalogService.Item", b =>
                {
                    b.HasOne("ItemCatalogService.SellerCompany", "SellerCompany")
                        .WithMany()
                        .HasForeignKey("SellerCompanyId");

                    b.Navigation("SellerCompany");
                });

            modelBuilder.Entity("ItemCatalogService.Question", b =>
                {
                    b.HasOne("ItemCatalogService.Item", null)
                        .WithMany("Questions")
                        .HasForeignKey("ItemId");

                    b.HasOne("ItemCatalogService.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ItemCatalogService.Rating", b =>
                {
                    b.HasOne("ItemCatalogService.Item", null)
                        .WithMany("Ratings")
                        .HasForeignKey("ItemId");

                    b.HasOne("ItemCatalogService.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ItemCatalogService.ContactPerson", b =>
                {
                    b.Navigation("EMails");

                    b.Navigation("WorkLocationAdresses");
                });

            modelBuilder.Entity("ItemCatalogService.Item", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("ItemCatalogService.SellerCompany", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("LocationAdresses");
                });

            modelBuilder.Entity("ItemCatalogService.User", b =>
                {
                    b.Navigation("EMails");
                });
#pragma warning restore 612, 618
        }
    }
}
