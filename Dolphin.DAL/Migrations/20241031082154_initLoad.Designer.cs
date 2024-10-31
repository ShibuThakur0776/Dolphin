﻿// <auto-generated />
using System;
using Dolphin.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dolphin.DAL.Migrations
{
    [DbContext(typeof(ApplicationManagerContext))]
    [Migration("20241031082154_initLoad")]
    partial class initLoad
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dolphin.DAL.Model.Tasks", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(10);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(3);

                    b.Property<DateTime>("End_Date")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(9);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnOrder(13);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnOrder(14);

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(12);

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(11);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(2);

                    b.Property<int>("Priority")
                        .HasColumnType("int")
                        .HasColumnOrder(5);

                    b.Property<decimal>("Progress")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnOrder(6);

                    b.Property<DateTime>("Start_Date")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(8);

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnOrder(4);

                    b.Property<int>("Story_Point")
                        .HasColumnType("int")
                        .HasColumnOrder(7);

                    b.HasKey("Id");

                    b.ToTable("tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
