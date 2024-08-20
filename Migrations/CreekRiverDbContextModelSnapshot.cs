﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using campgrounds;

#nullable disable

namespace campgrounds.Migrations
{
    [DbContext(typeof(CreekRiverDbContext))]
    partial class CreekRiverDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("campgrounds.Models.Campsite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CampsiteTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CampsiteTypeId");

                    b.ToTable("Campsites");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CampsiteTypeId = 1,
                            ImageUrl = "https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site73.jpg",
                            Nickname = "Barred Owl"
                        },
                        new
                        {
                            Id = 2,
                            CampsiteTypeId = 2,
                            ImageUrl = "https://www.discovercrystalriverfl.com/imager/s3_us-east-1_amazonaws_com/crystalriver-2019/images/attractions/RV-Camping-in-Rock-Crusher-RV-Resort1-1_bc0d2157d501d4729a3d5631708a6b2e.jpg",
                            Nickname = "Barred Owl"
                        },
                        new
                        {
                            Id = 3,
                            CampsiteTypeId = 3,
                            ImageUrl = "https://dec.ny.gov/sites/default/files/styles/hero_background/public/2023-11/PrimitiveASD1.jpg?h=2f15d14c&itok=HbFnKfKL",
                            Nickname = "Barred Owl"
                        },
                        new
                        {
                            Id = 4,
                            CampsiteTypeId = 4,
                            ImageUrl = "https://www.hammockuniverse.com/cdn/shop/articles/Hammock-Universe-Blog-Featured-Image-10-TIPS-FOR-HAMMOCK-CAMPING-LIKE-A-PRO_900x.jpg?v=1678808670",
                            Nickname = "Barred Owl"
                        },
                        new
                        {
                            Id = 5,
                            CampsiteTypeId = 4,
                            ImageUrl = "https://www.rei.com/dam/content_team_042618_0128_hammock_setup.jpg",
                            Nickname = "Barred Owl"
                        },
                        new
                        {
                            Id = 6,
                            CampsiteTypeId = 1,
                            ImageUrl = "https://images.pexels.com/photos/1687845/pexels-photo-1687845.jpeg?auto=compress&cs=tinysrgb&w=600",
                            Nickname = "Barred Owl"
                        });
                });

            modelBuilder.Entity("campgrounds.Models.CampsiteType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CampsiteTypeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("FeePerNight")
                        .HasColumnType("numeric");

                    b.Property<int>("MaxReservationDays")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("CampsiteTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CampsiteTypeName = "Tent",
                            FeePerNight = 15.99m,
                            MaxReservationDays = 7
                        },
                        new
                        {
                            Id = 2,
                            CampsiteTypeName = "RV",
                            FeePerNight = 26.50m,
                            MaxReservationDays = 14
                        },
                        new
                        {
                            Id = 3,
                            CampsiteTypeName = "Primitive",
                            FeePerNight = 10.00m,
                            MaxReservationDays = 3
                        },
                        new
                        {
                            Id = 4,
                            CampsiteTypeName = "Hammock",
                            FeePerNight = 12m,
                            MaxReservationDays = 7
                        });
                });

            modelBuilder.Entity("campgrounds.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CampsiteId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CheckinDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CheckoutDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UserProfileId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CampsiteId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CampsiteId = 1,
                            CheckinDate = new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckoutDate = new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 2,
                            CampsiteId = 3,
                            CheckinDate = new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckoutDate = new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserProfileId = 1
                        });
                });

            modelBuilder.Entity("campgrounds.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "getbaked@gmail.com",
                            FirstName = "John",
                            LastName = "Doe"
                        });
                });

            modelBuilder.Entity("campgrounds.Models.Campsite", b =>
                {
                    b.HasOne("campgrounds.Models.CampsiteType", "CampsiteType")
                        .WithMany()
                        .HasForeignKey("CampsiteTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CampsiteType");
                });

            modelBuilder.Entity("campgrounds.Models.Reservation", b =>
                {
                    b.HasOne("campgrounds.Models.Campsite", "Campsite")
                        .WithMany("Reservations")
                        .HasForeignKey("CampsiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("campgrounds.Models.UserProfile", "UserProfile")
                        .WithMany("Reservations")
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campsite");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("campgrounds.Models.Campsite", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("campgrounds.Models.UserProfile", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
