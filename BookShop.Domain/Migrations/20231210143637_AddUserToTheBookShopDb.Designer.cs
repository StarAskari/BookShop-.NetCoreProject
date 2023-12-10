﻿// <auto-generated />
using System;
using BookShop.Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookShop.Domain.Migrations
{
    [DbContext(typeof(BookShopDbContext))]
    [Migration("20231210143637_AddUserToTheBookShopDb")]
    partial class AddUserToTheBookShopDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookShop.Domain.Model.User", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("Id"), 1L, 1);

                    b.Property<string>("ConfirmedEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ConfirmedEmail");

                    b.Property<DateTime>("EditTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<int?>("Iterations")
                        .HasColumnType("int")
                        .HasColumnName("Iterations");

                    b.Property<DateTime?>("LastLoginDate")
                        .HasColumnType("datetime")
                        .HasColumnName("LastLoginDate");

                    b.Property<DateTime?>("LastPasswordChangeDate")
                        .HasColumnType("datetime")
                        .HasColumnName("LastPasswordChangeDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<int>("NoeUser")
                        .HasColumnType("int")
                        .HasColumnName("NoeUser");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("char(11)")
                        .HasColumnName("PhoneNumber")
                        .IsFixedLength();

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("UserName");

                    b.Property<string>("ValidDate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("ValidDate")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}