﻿// <auto-generated />
using System;
using GiftWishlist.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GiftWishlist.Data.Migrations
{
    [DbContext(typeof(WishContext))]
    [Migration("20201209033400_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10");

            modelBuilder.Entity("GiftWishlist.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageURL")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("PurchaseURL")
                        .HasColumnType("TEXT");

                    b.Property<int?>("WishlistId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WishlistId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            ImageURL = "",
                            IsComplete = false,
                            Name = "Socks",
                            Price = 12.00m,
                            PurchaseURL = ""
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            ImageURL = "",
                            IsComplete = false,
                            Name = "Mug",
                            Price = 10.00m,
                            PurchaseURL = "",
                            WishlistId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            ImageURL = "",
                            IsComplete = false,
                            Name = "Gaming Mouse",
                            Price = 50.00m,
                            PurchaseURL = "",
                            WishlistId = 2
                        });
                });

            modelBuilder.Entity("GiftWishlist.Models.Wishlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Wishlists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DueDate = new DateTime(2020, 12, 8, 19, 33, 59, 684, DateTimeKind.Local).AddTicks(9207),
                            Name = "Secret Santa 2020",
                            Password = ""
                        },
                        new
                        {
                            Id = 2,
                            DueDate = new DateTime(2020, 5, 14, 13, 0, 2, 0, DateTimeKind.Unspecified),
                            Name = "SSD Completion Party",
                            Password = "ssd"
                        },
                        new
                        {
                            Id = 3,
                            DueDate = new DateTime(2020, 12, 8, 19, 33, 59, 687, DateTimeKind.Local).AddTicks(9799),
                            Name = "Secret Santa 2020",
                            Password = ""
                        });
                });

            modelBuilder.Entity("GiftWishlist.Models.Item", b =>
                {
                    b.HasOne("GiftWishlist.Models.Wishlist", null)
                        .WithMany("Items")
                        .HasForeignKey("WishlistId");
                });
#pragma warning restore 612, 618
        }
    }
}