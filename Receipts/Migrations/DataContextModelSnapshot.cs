﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Receipts.Data.DataBase;

namespace Receipts.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Models.Receipt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("Models.Receipt", b =>
                {
                    b.OwnsMany("Models.IngredientRecipe", "Ingredients", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("TEXT");

                            b1.Property<DateTime>("CreatedDate")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Ingredient")
                                .HasColumnType("TEXT");

                            b1.Property<DateTime>("ModifiedDate")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Quantity")
                                .HasColumnType("TEXT");

                            b1.Property<Guid>("ReceiptId")
                                .HasColumnType("TEXT");

                            b1.Property<Guid?>("ReceiptId1")
                                .HasColumnType("TEXT");

                            b1.HasKey("Id");

                            b1.HasIndex("ReceiptId");

                            b1.HasIndex("ReceiptId1");

                            b1.ToTable("IngredientRecipe");

                            b1.WithOwner()
                                .HasForeignKey("ReceiptId");

                            b1.HasOne("Models.Receipt", "Receipt")
                                .WithMany()
                                .HasForeignKey("ReceiptId1");

                            b1.Navigation("Receipt");
                        });

                    b.OwnsMany("Models.StepRecipe", "Steps", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("TEXT");

                            b1.Property<DateTime>("CreatedDate")
                                .HasColumnType("TEXT");

                            b1.Property<DateTime>("ModifiedDate")
                                .HasColumnType("TEXT");

                            b1.Property<Guid>("ReceiptId")
                                .HasColumnType("TEXT");

                            b1.Property<Guid?>("ReceiptId1")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Step")
                                .HasColumnType("TEXT");

                            b1.HasKey("Id");

                            b1.HasIndex("ReceiptId");

                            b1.HasIndex("ReceiptId1");

                            b1.ToTable("StepRecipe");

                            b1.WithOwner()
                                .HasForeignKey("ReceiptId");

                            b1.HasOne("Models.Receipt", "Receipt")
                                .WithMany()
                                .HasForeignKey("ReceiptId1");

                            b1.Navigation("Receipt");
                        });

                    b.Navigation("Ingredients");

                    b.Navigation("Steps");
                });
#pragma warning restore 612, 618
        }
    }
}
