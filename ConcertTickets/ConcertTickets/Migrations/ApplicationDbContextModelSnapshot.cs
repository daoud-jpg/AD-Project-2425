﻿// <auto-generated />
using System;
using ConcertTickets.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConcertTickets.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConcertTickets.Data.CustomUser", b =>
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

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasMemberCard")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MemberCardNumber")
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("ConcertTickets.Data.Entities.Concert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Concerts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Artist = "Taylor Swift",
                            Date = new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Koning Boudewijn Stadion, Brussel"
                        },
                        new
                        {
                            Id = 2,
                            Artist = "Taylor Swift",
                            Date = new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Koning Boudewijn Stadion, Brussel"
                        },
                        new
                        {
                            Id = 3,
                            Artist = "Charli XCX",
                            Date = new DateTime(2025, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Vorst Nationaal, Brussel"
                        },
                        new
                        {
                            Id = 4,
                            Artist = "Compact Disk Dummies",
                            Date = new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Ancienne Belgique, Brussel"
                        },
                        new
                        {
                            Id = 5,
                            Artist = "Compact Disk Dummies",
                            Date = new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Ancienne Belgique, Brussel"
                        },
                        new
                        {
                            Id = 6,
                            Artist = "Coldplay",
                            Date = new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Sportpaleis, Antwerpen"
                        },
                        new
                        {
                            Id = 7,
                            Artist = "Dua Lipa",
                            Date = new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Werchter"
                        },
                        new
                        {
                            Id = 8,
                            Artist = "Dua Lipa",
                            Date = new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Werchter"
                        });
                });

            modelBuilder.Entity("ConcertTickets.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("DiscountApplied")
                        .HasColumnType("bit");

                    b.Property<int>("NnumTickets")
                        .HasColumnType("int");

                    b.Property<bool>("Paid")
                        .HasColumnType("bit");

                    b.Property<int>("TicketOfferId")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TicketOfferId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ConcertTickets.Data.Entities.TicketOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ConcertId")
                        .HasColumnType("int");

                    b.Property<int>("NumTickets")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("TicketType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConcertId");

                    b.ToTable("TicketOffers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcertId = 1,
                            NumTickets = 10,
                            Price = 200.0,
                            TicketType = "Golden Circle"
                        },
                        new
                        {
                            Id = 2,
                            ConcertId = 1,
                            NumTickets = 50,
                            Price = 50.0,
                            TicketType = "Standing"
                        },
                        new
                        {
                            Id = 3,
                            ConcertId = 1,
                            NumTickets = 60,
                            Price = 60.0,
                            TicketType = "Seated"
                        },
                        new
                        {
                            Id = 4,
                            ConcertId = 2,
                            NumTickets = 1000,
                            Price = 200.0,
                            TicketType = "Golden Circle"
                        },
                        new
                        {
                            Id = 5,
                            ConcertId = 2,
                            NumTickets = 19000,
                            Price = 50.0,
                            TicketType = "Standing"
                        },
                        new
                        {
                            Id = 6,
                            ConcertId = 2,
                            NumTickets = 20000,
                            Price = 60.0,
                            TicketType = "Seated"
                        },
                        new
                        {
                            Id = 7,
                            ConcertId = 3,
                            NumTickets = 0,
                            Price = 100.0,
                            TicketType = "Golden Circle"
                        },
                        new
                        {
                            Id = 8,
                            ConcertId = 3,
                            NumTickets = 0,
                            Price = 28.0,
                            TicketType = "Standing"
                        },
                        new
                        {
                            Id = 9,
                            ConcertId = 3,
                            NumTickets = 0,
                            Price = 32.0,
                            TicketType = "Seated"
                        },
                        new
                        {
                            Id = 10,
                            ConcertId = 4,
                            NumTickets = 2000,
                            Price = 28.0,
                            TicketType = "Standing"
                        },
                        new
                        {
                            Id = 11,
                            ConcertId = 4,
                            NumTickets = 1800,
                            Price = 32.0,
                            TicketType = "Seated"
                        },
                        new
                        {
                            Id = 12,
                            ConcertId = 5,
                            NumTickets = 2000,
                            Price = 28.0,
                            TicketType = "Standing"
                        },
                        new
                        {
                            Id = 13,
                            ConcertId = 5,
                            NumTickets = 7800,
                            Price = 32.0,
                            TicketType = "Seated"
                        },
                        new
                        {
                            Id = 14,
                            ConcertId = 6,
                            NumTickets = 400,
                            Price = 150.0,
                            TicketType = "Golden Circle"
                        },
                        new
                        {
                            Id = 15,
                            ConcertId = 6,
                            NumTickets = 4000,
                            Price = 65.0,
                            TicketType = "Standing"
                        },
                        new
                        {
                            Id = 16,
                            ConcertId = 6,
                            NumTickets = 4000,
                            Price = 55.0,
                            TicketType = "Seated"
                        },
                        new
                        {
                            Id = 17,
                            ConcertId = 7,
                            NumTickets = 1000,
                            Price = 124.0,
                            TicketType = "Golden Circle"
                        },
                        new
                        {
                            Id = 18,
                            ConcertId = 7,
                            NumTickets = 20000,
                            Price = 67.0,
                            TicketType = "Standing"
                        },
                        new
                        {
                            Id = 19,
                            ConcertId = 8,
                            NumTickets = 2000,
                            Price = 36.0,
                            TicketType = "Standing"
                        },
                        new
                        {
                            Id = 20,
                            ConcertId = 8,
                            NumTickets = 7800,
                            Price = 40.0,
                            TicketType = "Seated"
                        });
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

            modelBuilder.Entity("ConcertTickets.Data.Entities.Order", b =>
                {
                    b.HasOne("ConcertTickets.Data.Entities.TicketOffer", "TicketOffer")
                        .WithMany()
                        .HasForeignKey("TicketOfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TicketOffer");
                });

            modelBuilder.Entity("ConcertTickets.Data.Entities.TicketOffer", b =>
                {
                    b.HasOne("ConcertTickets.Data.Entities.Concert", "Concert")
                        .WithMany("TicketOffers")
                        .HasForeignKey("ConcertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Concert");
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
                    b.HasOne("ConcertTickets.Data.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ConcertTickets.Data.CustomUser", null)
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

                    b.HasOne("ConcertTickets.Data.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ConcertTickets.Data.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConcertTickets.Data.Entities.Concert", b =>
                {
                    b.Navigation("TicketOffers");
                });
#pragma warning restore 612, 618
        }
    }
}
