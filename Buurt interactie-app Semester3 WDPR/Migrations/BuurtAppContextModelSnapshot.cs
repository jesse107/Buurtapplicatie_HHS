﻿// <auto-generated />
using System;
using Buurt_interactie_app_Semester3_WDPR.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Buurt_interactie_app_Semester3_WDPR.Migrations
{
    [DbContext(typeof(BuurtAppContext))]
    partial class BuurtAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Buurt_interactie_app_Semester3_WDPR.Areas.Identity.Data.BuurtAppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AnoNummer")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Postcode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BuurtAppUser");
                });

            modelBuilder.Entity("Buurt_interactie_app_Semester3_WDPR.Models.AnoniemeMelding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AfbeeldingURL")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CategorieNaam")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<bool>("Open")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Sudo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Tijdstip")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("CategorieNaam");

                    b.ToTable("AnoniemeMelding");
                });

            modelBuilder.Entity("Buurt_interactie_app_Semester3_WDPR.Models.BuurtbewonerAno", b =>
                {
                    b.Property<string>("AnoId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("SudoId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnoId");

                    b.ToTable("Pseudonyms");
                });

            modelBuilder.Entity("Buurt_interactie_app_Semester3_WDPR.Models.Categorie", b =>
                {
                    b.Property<string>("Naam")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Naam");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("Buurt_interactie_app_Semester3_WDPR.Models.Likes", b =>
                {
                    b.Property<int>("MeldingId")
                        .HasColumnType("int");

                    b.Property<string>("BuurtbewonerId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("MeldingId", "BuurtbewonerId");

                    b.HasIndex("BuurtbewonerId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("Buurt_interactie_app_Semester3_WDPR.Models.Melding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AfbeeldingURL")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BuurtbewonerId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("CategorieNaam")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<bool>("Open")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Tijdstip")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("BuurtbewonerId");

                    b.HasIndex("CategorieNaam");

                    b.ToTable("Melding");
                });

            modelBuilder.Entity("Buurt_interactie_app_Semester3_WDPR.Models.Reactie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BuurtbewonerId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("MeldingId")
                        .HasColumnType("int");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Tijdstip")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("BuurtbewonerId");

                    b.HasIndex("MeldingId");

                    b.ToTable("Reactie");
                });

            modelBuilder.Entity("Buurt_interactie_app_Semester3_WDPR.Models.UserView", b =>
                {
                    b.Property<int>("MeldingId")
                        .HasColumnType("int");

                    b.Property<string>("BuurtbewonerId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("MeldingId", "BuurtbewonerId");

                    b.HasIndex("BuurtbewonerId");

                    b.ToTable("UserViews");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Buurt_interactie_app_Semester3_WDPR.Models.Buurtbewoner", b =>
                {
                    b.HasBaseType("Buurt_interactie_app_Semester3_WDPR.Areas.Identity.Data.BuurtAppUser");

                    b.HasDiscriminator().HasValue("Buurtbewoner");
                });

            modelBuilder.Entity("Buurt_interactie_app_Semester3_WDPR.Models.AnoniemeMelding", b =>
                {
                    b.HasOne("Buurt_interactie_app_Semester3_WDPR.Models.Categorie", "Categorie")
                        .WithMany()
                        .HasForeignKey("CategorieNaam")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Buurt_interactie_app_Semester3_WDPR.Models.Likes", b =>
                {
                    b.HasOne("Buurt_interactie_app_Semester3_WDPR.Models.Buurtbewoner", "Buurtbewoner")
                        .WithMany("Liked")
                        .HasForeignKey("BuurtbewonerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Buurt_interactie_app_Semester3_WDPR.Models.Melding", "Melding")
                        .WithMany("Likes")
                        .HasForeignKey("MeldingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Buurt_interactie_app_Semester3_WDPR.Models.Melding", b =>
                {
                    b.HasOne("Buurt_interactie_app_Semester3_WDPR.Models.Buurtbewoner", "Buurtbewoner")
                        .WithMany("Meldingen")
                        .HasForeignKey("BuurtbewonerId");

                    b.HasOne("Buurt_interactie_app_Semester3_WDPR.Models.Categorie", "Categorie")
                        .WithMany()
                        .HasForeignKey("CategorieNaam")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Buurt_interactie_app_Semester3_WDPR.Models.Reactie", b =>
                {
                    b.HasOne("Buurt_interactie_app_Semester3_WDPR.Models.Buurtbewoner", "Buurtbewoner")
                        .WithMany("Reacties")
                        .HasForeignKey("BuurtbewonerId");

                    b.HasOne("Buurt_interactie_app_Semester3_WDPR.Models.Melding", "Melding")
                        .WithMany("Reacties")
                        .HasForeignKey("MeldingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Buurt_interactie_app_Semester3_WDPR.Models.UserView", b =>
                {
                    b.HasOne("Buurt_interactie_app_Semester3_WDPR.Models.Buurtbewoner", "Buurtbewoner")
                        .WithMany("Viewed")
                        .HasForeignKey("BuurtbewonerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Buurt_interactie_app_Semester3_WDPR.Models.Melding", "Melding")
                        .WithMany("AantalViews")
                        .HasForeignKey("MeldingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Buurt_interactie_app_Semester3_WDPR.Areas.Identity.Data.BuurtAppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Buurt_interactie_app_Semester3_WDPR.Areas.Identity.Data.BuurtAppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Buurt_interactie_app_Semester3_WDPR.Areas.Identity.Data.BuurtAppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Buurt_interactie_app_Semester3_WDPR.Areas.Identity.Data.BuurtAppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
