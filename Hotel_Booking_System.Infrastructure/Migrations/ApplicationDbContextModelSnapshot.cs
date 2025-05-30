﻿// <auto-generated />
using System;
using Hotel_Booking_System.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel_Booking_System.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hotel_Booking_System.Domain.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("PriceinDoller")
                        .HasColumnType("float");

                    b.Property<int>("RoomSize")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Classic Single Room",
                            ImageUrl = "https://www.classichotel.al/wp-content/uploads/2019/07/Optimized-single1.jpg",
                            Name = "Room 1",
                            Occupancy = 1,
                            PriceinDoller = 30.0,
                            RoomSize = 260
                        },
                        new
                        {
                            Id = 2,
                            Description = "Deluxe Double Room",
                            ImageUrl = "https://www.pearlhotelnyc.com/hs-fs/hubfs/2.jpg?width=1488&height=992&name=2.jpg",
                            Name = "Room 2",
                            Occupancy = 2,
                            PriceinDoller = 50.0,
                            RoomSize = 400
                        },
                        new
                        {
                            Id = 3,
                            Description = "Executive Suite",
                            ImageUrl = "https://image-tc.galaxy.tf/wijpeg-eyy6alr2se13uffg555o3iapg/executive-suite-room-2_wide.jpg",
                            Name = "Room 3",
                            Occupancy = 3,
                            PriceinDoller = 90.0,
                            RoomSize = 600
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
