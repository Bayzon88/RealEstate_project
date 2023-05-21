﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealEstate_API.Data;

#nullable disable

namespace RealEstate_API.Migrations
{
    [DbContext(typeof(MyLesseeDBContext))]
    partial class MyLesseeDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RealEstate_API.Models.Account", b =>
                {
                    b.Property<Guid>("AcctId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastLoginTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.HasKey("AcctId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AcctId = new Guid("c903e2ee-f6b8-43bf-acbc-d5dce2d05a09"),
                            CreationTime = new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3533),
                            Email = "beltranalvaro08@gmail.com",
                            Gender = "Male",
                            LastLoginTime = new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3565),
                            Name = "Alvaro Beltran",
                            Password = "alvaro1234",
                            Phone = 123456789L
                        },
                        new
                        {
                            AcctId = new Guid("a0445060-ade5-4c45-93e5-b4a53785b0e7"),
                            CreationTime = new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3568),
                            Email = "tuyichen90@gmail.com",
                            Gender = "Female",
                            LastLoginTime = new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3570),
                            Name = "Tuyi Chen",
                            Password = "tuyi1234",
                            Phone = 123456789L
                        },
                        new
                        {
                            AcctId = new Guid("1ef4c507-437a-49cb-bd6e-7e0b2f48c80e"),
                            CreationTime = new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3572),
                            Email = "katya.menesesr@gmail.com",
                            Gender = "Female",
                            LastLoginTime = new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3574),
                            Name = "Katya Meneses",
                            Password = "katya1234",
                            Phone = 123456789L
                        },
                        new
                        {
                            AcctId = new Guid("7ff64216-4433-47c0-80c6-4cf57da15deb"),
                            CreationTime = new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3577),
                            Email = "antonvinokurov101@gmail.com",
                            Gender = "Male",
                            LastLoginTime = new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3578),
                            Name = "Anton Vinokurov",
                            Password = "anton1234",
                            Phone = 123456789L
                        });
                });

            modelBuilder.Entity("RealEstate_API.Models.HouseType", b =>
                {
                    b.Property<int>("HouseTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HouseTypeId"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HouseTypeId");

                    b.ToTable("HouseTypes");

                    b.HasData(
                        new
                        {
                            HouseTypeId = 1,
                            Type = "Detached House"
                        },
                        new
                        {
                            HouseTypeId = 2,
                            Type = "Semi-Detached House"
                        },
                        new
                        {
                            HouseTypeId = 3,
                            Type = "Townhouse"
                        },
                        new
                        {
                            HouseTypeId = 4,
                            Type = "Bungalow"
                        },
                        new
                        {
                            HouseTypeId = 5,
                            Type = "Split-level House"
                        },
                        new
                        {
                            HouseTypeId = 6,
                            Type = "Cottage"
                        },
                        new
                        {
                            HouseTypeId = 7,
                            Type = "Condominium"
                        },
                        new
                        {
                            HouseTypeId = 8,
                            Type = "Apartment"
                        },
                        new
                        {
                            HouseTypeId = 9,
                            Type = "Others"
                        });
                });

            modelBuilder.Entity("RealEstate_API.Models.Listing", b =>
                {
                    b.Property<int>("ListingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ListingId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BedroomNo")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HouseTypeId")
                        .HasColumnType("int");

                    b.Property<int>("LandlordId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ListingTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ParkingNo")
                        .HasColumnType("int");

                    b.Property<double>("RentalPrice")
                        .HasColumnType("float");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<double>("TotalArea")
                        .HasColumnType("float");

                    b.Property<int>("ValidDays")
                        .HasColumnType("int");

                    b.Property<int>("WashroomNo")
                        .HasColumnType("int");

                    b.HasKey("ListingId");

                    b.HasIndex("HouseTypeId");

                    b.ToTable("Listings");

                    b.HasData(
                        new
                        {
                            ListingId = 1,
                            Address = "1080 Mississauga Road, Mississauga, ON",
                            BedroomNo = 5,
                            Description = "Beautiful detached house with simple furniture provided",
                            HouseTypeId = 1,
                            LandlordId = 1,
                            ListingTime = new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3710),
                            ParkingNo = 3,
                            RentalPrice = 2400.0,
                            Status = true,
                            TotalArea = 240.0,
                            ValidDays = 30,
                            WashroomNo = 5
                        },
                        new
                        {
                            ListingId = 2,
                            Address = "2072 Dundas Road West, Mississauga, ON",
                            BedroomNo = 5,
                            Description = "Beautiful semi-detached house with simple furniture provided",
                            HouseTypeId = 2,
                            LandlordId = 1,
                            ListingTime = new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3717),
                            ParkingNo = 2,
                            RentalPrice = 2300.0,
                            Status = true,
                            TotalArea = 200.0,
                            ValidDays = 30,
                            WashroomNo = 5
                        },
                        new
                        {
                            ListingId = 3,
                            Address = "1688 Mississauga Vally, Mississauga, ON",
                            BedroomNo = 5,
                            Description = "Beautiful townhouse with simple furniture provided",
                            HouseTypeId = 3,
                            LandlordId = 1,
                            ListingTime = new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3720),
                            ParkingNo = 2,
                            RentalPrice = 2300.0,
                            Status = true,
                            TotalArea = 200.0,
                            ValidDays = 30,
                            WashroomNo = 3
                        },
                        new
                        {
                            ListingId = 4,
                            Address = "568 Burnhamthorpe Road West, Mississauga, ON",
                            BedroomNo = 3,
                            Description = "Beautiful Bungalow",
                            HouseTypeId = 4,
                            LandlordId = 1,
                            ListingTime = new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3722),
                            ParkingNo = 1,
                            RentalPrice = 2200.0,
                            Status = true,
                            TotalArea = 180.0,
                            ValidDays = 30,
                            WashroomNo = 3
                        },
                        new
                        {
                            ListingId = 5,
                            Address = "1266 Erindale Station Road, Mississauga, ON",
                            BedroomNo = 3,
                            Description = "Beautiful split-level House",
                            HouseTypeId = 5,
                            LandlordId = 1,
                            ListingTime = new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3724),
                            ParkingNo = 1,
                            RentalPrice = 2200.0,
                            Status = true,
                            TotalArea = 170.0,
                            ValidDays = 30,
                            WashroomNo = 3
                        },
                        new
                        {
                            ListingId = 6,
                            Address = "760 Dunlop Street East, Barrie, ON",
                            BedroomNo = 4,
                            Description = "Beautiful cottage with a small yard",
                            HouseTypeId = 6,
                            LandlordId = 1,
                            ListingTime = new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3728),
                            ParkingNo = 2,
                            RentalPrice = 2800.0,
                            Status = true,
                            TotalArea = 160.0,
                            ValidDays = 30,
                            WashroomNo = 4
                        },
                        new
                        {
                            ListingId = 7,
                            Address = "640 Grand Park Drive, Mississauga, ON",
                            BedroomNo = 2,
                            Description = "Beautiful condominium with security",
                            HouseTypeId = 7,
                            LandlordId = 1,
                            ListingTime = new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3730),
                            ParkingNo = 1,
                            RentalPrice = 1800.0,
                            Status = true,
                            TotalArea = 80.0,
                            ValidDays = 30,
                            WashroomNo = 2
                        },
                        new
                        {
                            ListingId = 8,
                            Address = "395 Wolfedale Road, Mississauga, ON",
                            BedroomNo = 2,
                            Description = "Beautiful apartment",
                            HouseTypeId = 8,
                            LandlordId = 1,
                            ListingTime = new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3732),
                            ParkingNo = 1,
                            RentalPrice = 1600.0,
                            Status = true,
                            TotalArea = 80.0,
                            ValidDays = 30,
                            WashroomNo = 2
                        },
                        new
                        {
                            ListingId = 9,
                            Address = "115 Eighth Line, Oakville, ON",
                            BedroomNo = 5,
                            Description = "Nothing special",
                            HouseTypeId = 9,
                            LandlordId = 1,
                            ListingTime = new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3735),
                            ParkingNo = 3,
                            RentalPrice = 2400.0,
                            Status = true,
                            TotalArea = 240.0,
                            ValidDays = 30,
                            WashroomNo = 5
                        });
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

            modelBuilder.Entity("RealEstate_API.Models.Listing", b =>
                {
                    b.HasOne("RealEstate_API.Models.HouseType", "HouseType")
                        .WithMany()
                        .HasForeignKey("HouseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HouseType");
                });
#pragma warning restore 612, 618
        }
    }
}
