﻿// <auto-generated />
using System;
using GiftWishlist.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GiftWishlist.Migrations
{
    [DbContext(typeof(WishContext))]
    partial class WishContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("OwnerEmail")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("PurchaseURL")
                        .HasColumnType("TEXT");

                    b.Property<int>("WishlistID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WishlistID");

                    b.ToTable("Items");
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
                            DueDate = new DateTime(2020, 12, 9, 10, 36, 35, 990, DateTimeKind.Local).AddTicks(478),
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
                            DueDate = new DateTime(2020, 12, 9, 10, 36, 35, 993, DateTimeKind.Local).AddTicks(3492),
                            Name = "Secret Santa 2020",
                            Password = ""
                        });
                });

            modelBuilder.Entity("GiftWishlist.Models.Item", b =>
                {
                    b.HasOne("GiftWishlist.Models.Wishlist", null)
                        .WithMany("Items")
                        .HasForeignKey("WishlistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}