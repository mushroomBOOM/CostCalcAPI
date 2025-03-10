﻿// <auto-generated />
using CostCalcAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CostCalcAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241120112021_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CostCalcAPI.Models.OverheadCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("OverheadCosts");
                });

            modelBuilder.Entity("CostCalcAPI.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("CostCalcAPI.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("StageId")
                        .HasColumnType("integer");

                    b.Property<decimal>("WeeklySalary")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("StageId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CostCalcAPI.Models.Stage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DurationWeeks")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Stages");
                });

            modelBuilder.Entity("CostCalcAPI.Models.OverheadCost", b =>
                {
                    b.HasOne("CostCalcAPI.Models.Project", null)
                        .WithMany("OverheadCosts")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("CostCalcAPI.Models.Role", b =>
                {
                    b.HasOne("CostCalcAPI.Models.Stage", null)
                        .WithMany("Roles")
                        .HasForeignKey("StageId");
                });

            modelBuilder.Entity("CostCalcAPI.Models.Stage", b =>
                {
                    b.HasOne("CostCalcAPI.Models.Project", null)
                        .WithMany("Stages")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("CostCalcAPI.Models.Project", b =>
                {
                    b.Navigation("OverheadCosts");

                    b.Navigation("Stages");
                });

            modelBuilder.Entity("CostCalcAPI.Models.Stage", b =>
                {
                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
