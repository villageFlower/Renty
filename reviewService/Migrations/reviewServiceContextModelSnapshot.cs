﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using reviewService.Data;

namespace reviewService.Migrations
{
    [DbContext(typeof(reviewServiceContext))]
    partial class reviewServiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("reviewService.Models.Review", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AccountId")
                        .HasColumnType("bigint");

                    b.Property<long>("OfferId")
                        .HasColumnType("bigint");

                    b.Property<string>("ReviewContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReviewGrade")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Review");
                });
#pragma warning restore 612, 618
        }
    }
}