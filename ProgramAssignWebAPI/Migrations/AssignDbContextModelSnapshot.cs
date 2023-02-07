﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProgramAssignWebAPI.Data;

#nullable disable

namespace ProgramAssignWebAPI.Migrations
{
    [DbContext(typeof(AssignDbContext))]
    partial class AssignDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProgramAssignWebAPI.Models.Domain.ProgramsTracker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Program")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechTrack")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProgramsTracker");
                });

            modelBuilder.Entity("ProgramAssignWebAPI.Models.Domain.ResourceMangerAssignments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("Date");

                    b.Property<string>("HistoryProgramTrackerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PeriodEnd")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("PeriodEnd");

                    b.Property<DateTime>("PeriodStart")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("PeriodStart");

                    b.Property<string>("ProgramStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProgramsTrackerId")
                        .HasColumnType("int");

                    b.Property<string>("ResourceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SMEStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("Date");

                    b.Property<string>("TechTrack")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VAMID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProgramsTrackerId");

                    b.ToTable("ResourceMangerAssignments", (string)null);

                    b.ToTable(tb => tb.IsTemporal(ttb =>
                            {
                                ttb.UseHistoryTable("ResourceMangerAssignmentsHistory");
                                ttb
                                    .HasPeriodStart("PeriodStart")
                                    .HasColumnName("PeriodStart");
                                ttb
                                    .HasPeriodEnd("PeriodEnd")
                                    .HasColumnName("PeriodEnd");
                            }));
                });

            modelBuilder.Entity("ProgramAssignWebAPI.Models.Domain.TechTracks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TechTrack")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TechTracks");
                });

            modelBuilder.Entity("ProgramAssignWebAPI.Models.Domain.UserInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VAMId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("ProgramAssignWebAPI.Models.Domain.ResourceMangerAssignments", b =>
                {
                    b.HasOne("ProgramAssignWebAPI.Models.Domain.ProgramsTracker", "ProgramsTracker")
                        .WithMany()
                        .HasForeignKey("ProgramsTrackerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProgramsTracker");
                });
#pragma warning restore 612, 618
        }
    }
}
