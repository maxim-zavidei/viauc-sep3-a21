﻿// <auto-generated />
using System;
using DataAccessTier.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataAccessTier.Migrations
{
    [DbContext(typeof(CalendarDbContext))]
    [Migration("20211201095829_NewTables")]
    partial class NewTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("DataAccessTier.Model.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .HasColumnType("text");

                    b.Property<string>("StreetName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("DataAccessTier.Model.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AddressId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("DataAccessTier.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsSharingCalendar")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataAccessTier.Model.Event", b =>
                {
                    b.HasOne("DataAccessTier.Model.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("DataAccessTier.Model.User", null)
                        .WithMany("Events")
                        .HasForeignKey("UserId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("DataAccessTier.Model.User", b =>
                {
                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
