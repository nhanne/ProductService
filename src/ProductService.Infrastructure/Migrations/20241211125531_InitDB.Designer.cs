﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProductService.Infrastructure;

#nullable disable

namespace ProductService.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241211125531_InitDB")]
    partial class InitDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProductService.Domain.Products.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("CostPrice")
                        .HasColumnType("real");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreateBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.PrimitiveCollection<List<string>>("Images")
                        .HasColumnType("text[]");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<float>("UnitPrice")
                        .HasColumnType("real");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdateBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Products", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
