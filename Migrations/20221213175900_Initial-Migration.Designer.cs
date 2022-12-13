﻿// <auto-generated />
using System;
using ASP_CORE_BASIC_NET_6_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPCOREBASICNET6API.Migrations
{
    [DbContext(typeof(DBContextBase))]
    [Migration("20221213175900_Initial-Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASP_CORE_BASIC_NET_6_API.Models.Domain.Asset", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AssetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("AssetQuantity")
                        .HasColumnType("float");

                    b.Property<Guid>("WalletId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("WalletId");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("ASP_CORE_BASIC_NET_6_API.Models.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ASP_CORE_BASIC_NET_6_API.Models.Domain.UserDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserRoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.HasIndex("UserRoleId");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("ASP_CORE_BASIC_NET_6_API.Models.Domain.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("ASP_CORE_BASIC_NET_6_API.Models.Domain.Wallet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WalletName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserDetailsId")
                        .IsUnique()
                        .HasFilter("[UserDetailsId] IS NOT NULL");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("ASP_CORE_BASIC_NET_6_API.Models.Domain.Asset", b =>
                {
                    b.HasOne("ASP_CORE_BASIC_NET_6_API.Models.Domain.Wallet", null)
                        .WithMany("Assets")
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP_CORE_BASIC_NET_6_API.Models.Domain.UserDetails", b =>
                {
                    b.HasOne("ASP_CORE_BASIC_NET_6_API.Models.Domain.User", null)
                        .WithOne("UserDetails")
                        .HasForeignKey("ASP_CORE_BASIC_NET_6_API.Models.Domain.UserDetails", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP_CORE_BASIC_NET_6_API.Models.Domain.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleId");

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("ASP_CORE_BASIC_NET_6_API.Models.Domain.Wallet", b =>
                {
                    b.HasOne("ASP_CORE_BASIC_NET_6_API.Models.Domain.UserDetails", null)
                        .WithOne("Wallet")
                        .HasForeignKey("ASP_CORE_BASIC_NET_6_API.Models.Domain.Wallet", "UserDetailsId");
                });

            modelBuilder.Entity("ASP_CORE_BASIC_NET_6_API.Models.Domain.User", b =>
                {
                    b.Navigation("UserDetails");
                });

            modelBuilder.Entity("ASP_CORE_BASIC_NET_6_API.Models.Domain.UserDetails", b =>
                {
                    b.Navigation("Wallet");
                });

            modelBuilder.Entity("ASP_CORE_BASIC_NET_6_API.Models.Domain.Wallet", b =>
                {
                    b.Navigation("Assets");
                });
#pragma warning restore 612, 618
        }
    }
}