﻿// <auto-generated />
using System;
using Dolphin.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Dolphin.DAL.Migrations
{
    [DbContext(typeof(ApplicationManagerContext))]
    [Migration("20241209181527_changedColumnNameInTask")]
    partial class changedColumnNameInTask
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Dolphin.DAL.Model.Tasks", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnOrder(10);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnOrder(8);

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnOrder(13);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnOrder(14);

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid")
                        .HasColumnOrder(12);

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnOrder(11);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnOrder(1);

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uuid")
                        .HasColumnOrder(9);

                    b.Property<int>("Priority")
                        .HasColumnType("integer")
                        .HasColumnOrder(4);

                    b.Property<decimal>("Progress")
                        .HasColumnType("numeric")
                        .HasColumnOrder(5);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnOrder(7);

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnOrder(3);

                    b.Property<int>("StoryPoint")
                        .HasColumnType("integer")
                        .HasColumnOrder(6);

                    b.HasKey("Id");

                    b.ToTable("tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
