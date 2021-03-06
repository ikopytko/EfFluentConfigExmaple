﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test;

namespace Test.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    partial class ShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("Test.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Street");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Test.Shipment", b =>
                {
                    b.Property<int>("ShipmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DeliveryAddressAddressId");

                    b.HasKey("ShipmentId");

                    b.HasIndex("DeliveryAddressAddressId");

                    b.ToTable("Shipments");
                });

            modelBuilder.Entity("Test.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BillingAddressAddressId");

                    b.Property<int?>("DefaultAddressAddressId");

                    b.Property<string>("Name");

                    b.HasKey("UserId");

                    b.HasIndex("BillingAddressAddressId");

                    b.HasIndex("DefaultAddressAddressId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Test.Shipment", b =>
                {
                    b.HasOne("Test.Address", "DeliveryAddress")
                        .WithMany()
                        .HasForeignKey("DeliveryAddressAddressId");
                });

            modelBuilder.Entity("Test.User", b =>
                {
                    b.HasOne("Test.Address", "BillingAddress")
                        .WithMany()
                        .HasForeignKey("BillingAddressAddressId");

                    b.HasOne("Test.Address", "DefaultAddress")
                        .WithMany()
                        .HasForeignKey("DefaultAddressAddressId");
                });
#pragma warning restore 612, 618
        }
    }
}
