﻿// <auto-generated />
using System;
using FullCars.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FullCars.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FullCars.Models.Car", b =>
                {
                    b.Property<int>("Id_car")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_car"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("N_Stock")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id_car");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id_car = 13,
                            Description = "a1.png",
                            Marque = "Audi",
                            N_Stock = 13,
                            Price = 48000.0
                        },
                        new
                        {
                            Id_car = 3,
                            Description = "b1.png",
                            Marque = "BMW",
                            N_Stock = 15,
                            Price = 35000.0
                        },
                        new
                        {
                            Id_car = 6,
                            Description = "b2.jpg",
                            Marque = "BMW",
                            N_Stock = 18,
                            Price = 42000.0
                        },
                        new
                        {
                            Id_car = 9,
                            Description = "b3.jpg",
                            Marque = "BMW",
                            N_Stock = 10,
                            Price = 38000.0
                        },
                        new
                        {
                            Id_car = 12,
                            Description = "b4.jpg",
                            Marque = "BMW",
                            N_Stock = 19,
                            Price = 32000.0
                        },
                        new
                        {
                            Id_car = 15,
                            Description = "b5.jpg",
                            Marque = "BMW",
                            N_Stock = 15,
                            Price = 37000.0
                        },
                        new
                        {
                            Id_car = 2,
                            Description = "h1.jpg",
                            Marque = "Honda",
                            N_Stock = 8,
                            Price = 22000.0
                        },
                        new
                        {
                            Id_car = 19,
                            Description = "j1.jpg",
                            Marque = "Jaguar",
                            N_Stock = 16,
                            Price = 35000.0
                        },
                        new
                        {
                            Id_car = 4,
                            Description = "m1.jpg",
                            Marque = "Mercedes",
                            N_Stock = 12,
                            Price = 40000.0
                        },
                        new
                        {
                            Id_car = 7,
                            Description = "m2.jpg",
                            Marque = "Mercedes",
                            N_Stock = 14,
                            Price = 38000.0
                        },
                        new
                        {
                            Id_car = 10,
                            Description = "m3.jpg",
                            Marque = "Mercedes",
                            N_Stock = 22,
                            Price = 45000.0
                        },
                        new
                        {
                            Id_car = 16,
                            Description = "m4.jpg",
                            Marque = "Mercedes",
                            N_Stock = 14,
                            Price = 42000.0
                        },
                        new
                        {
                            Id_car = 18,
                            Description = "p1.jpg",
                            Marque = "Porsche",
                            N_Stock = 12,
                            Price = 40000.0
                        },
                        new
                        {
                            Id_car = 1,
                            Description = "t1.jpg",
                            Marque = "Toyota",
                            N_Stock = 10,
                            Price = 25000.0
                        },
                        new
                        {
                            Id_car = 14,
                            Description = "te1.jpg",
                            Marque = "Tesla",
                            N_Stock = 11,
                            Price = 34000.0
                        },
                        new
                        {
                            Id_car = 5,
                            Description = "v1.jpg",
                            Marque = "Volkswagen",
                            N_Stock = 20,
                            Price = 28000.0
                        },
                        new
                        {
                            Id_car = 8,
                            Description = "v2.jpg",
                            Marque = "Volkswagen",
                            N_Stock = 16,
                            Price = 32000.0
                        },
                        new
                        {
                            Id_car = 11,
                            Description = "v3.png",
                            Marque = "Volkswagen",
                            N_Stock = 17,
                            Price = 30000.0
                        },
                        new
                        {
                            Id_car = 17,
                            Description = "v5.jpg",
                            Marque = "Volkswagen",
                            N_Stock = 18,
                            Price = 29000.0
                        },
                        new
                        {
                            Id_car = 20,
                            Description = "v6.jpg",
                            Marque = "Volkswagen",
                            N_Stock = 20,
                            Price = 33000.0
                        });
                });

            modelBuilder.Entity("FullCars.Models.CartItems", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("CarName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CarPrice")
                        .HasColumnType("float");

                    b.Property<int>("Id_clt")
                        .HasColumnType("int");

                    b.Property<int>("nbr_cars_in_card")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_clt");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("FullCars.Models.Client", b =>
                {
                    b.Property<int>("Id_clt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_clt"));

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_clt");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("FullCars.Models.Commande", b =>
                {
                    b.Property<int>("Id_commande")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_commande"));

                    b.Property<DateTime>("Date_com")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_car")
                        .HasColumnType("int");

                    b.Property<int>("Id_clt")
                        .HasColumnType("int");

                    b.HasKey("Id_commande");

                    b.HasIndex("Id_car");

                    b.HasIndex("Id_clt");

                    b.ToTable("Commandes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FullCars.Models.CartItems", b =>
                {
                    b.HasOne("FullCars.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("Id_clt")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("FullCars.Models.Commande", b =>
                {
                    b.HasOne("FullCars.Models.Car", "Car")
                        .WithMany("Commandes")
                        .HasForeignKey("Id_car")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FullCars.Models.Client", "Client")
                        .WithMany("Commandes")
                        .HasForeignKey("Id_clt")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Client");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FullCars.Models.Car", b =>
                {
                    b.Navigation("Commandes");
                });

            modelBuilder.Entity("FullCars.Models.Client", b =>
                {
                    b.Navigation("Commandes");
                });
#pragma warning restore 612, 618
        }
    }
}
