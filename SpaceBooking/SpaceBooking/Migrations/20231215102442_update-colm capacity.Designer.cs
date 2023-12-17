﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpaceBooking.DataContext;

#nullable disable

namespace SpaceBooking.Migrations
{
    [DbContext(typeof(Mydbcontext))]
    [Migration("20231215102442_update-colm capacity")]
    partial class updatecolmcapacity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SpaceBooking.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"), 1L, 1);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndHuors")
                        .HasColumnType("datetime2");

                    b.Property<int>("SpaceID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartHuors")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingID");

                    b.HasIndex("CustomerID")
                        .IsUnique();

                    b.HasIndex("SpaceID");

                    b.ToTable("bookings");
                });

            modelBuilder.Entity("SpaceBooking.Models.Categories", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SpaceBooking.Models.Customer", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("customerId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("work")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("customerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SpaceBooking.Models.Space", b =>
                {
                    b.Property<int>("SpaceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpaceID"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("CategoriesCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("spaceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpaceID");

                    b.HasIndex("CategoriesCategoryId");

                    b.ToTable("Spaces");
                });

            modelBuilder.Entity("SpaceBooking.Models.Booking", b =>
                {
                    b.HasOne("SpaceBooking.Models.Customer", null)
                        .WithOne("Booking")
                        .HasForeignKey("SpaceBooking.Models.Booking", "CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpaceBooking.Models.Space", "Spaces")
                        .WithMany()
                        .HasForeignKey("SpaceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Spaces");
                });

            modelBuilder.Entity("SpaceBooking.Models.Space", b =>
                {
                    b.HasOne("SpaceBooking.Models.Categories", "Categories")
                        .WithMany("Spaces")
                        .HasForeignKey("CategoriesCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("SpaceBooking.Models.Categories", b =>
                {
                    b.Navigation("Spaces");
                });

            modelBuilder.Entity("SpaceBooking.Models.Customer", b =>
                {
                    b.Navigation("Booking")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
