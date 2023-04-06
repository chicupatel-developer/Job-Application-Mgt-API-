﻿// <auto-generated />
using System;
using EF.Core.Job.Application.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF.Core.Job.Application.Migrations
{
    [DbContext(typeof(JobApplicationDBContext))]
    [Migration("20230208174641_initial-db-create")]
    partial class initialdbcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF.Core.Job.Application.Models.AppStatusLog", b =>
                {
                    b.Property<int>("AppStatusLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("AppStatusChangedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobApplicationId")
                        .HasColumnType("int");

                    b.HasKey("AppStatusLogId");

                    b.HasIndex("JobApplicationId");

                    b.ToTable("AppStatusLog");
                });

            modelBuilder.Entity("EF.Core.Job.Application.Models.JobApplication", b =>
                {
                    b.Property<int>("JobApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgencyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AppStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("AppliedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPersonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FollowUpNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobApplicationId");

                    b.ToTable("JobApplications");
                });

            modelBuilder.Entity("EF.Core.Job.Application.Models.JobResume", b =>
                {
                    b.Property<int>("JobResumeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobApplicationId")
                        .HasColumnType("int");

                    b.HasKey("JobResumeId");

                    b.HasIndex("JobApplicationId")
                        .IsUnique();

                    b.ToTable("JobResumes");
                });

            modelBuilder.Entity("EF.Core.Job.Application.Models.UserResumeCreate", b =>
                {
                    b.Property<int>("UserResumeCreateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ResumeCreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserIPAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserResumeCreateId");

                    b.ToTable("UserResumeCreate");
                });

            modelBuilder.Entity("EF.Core.Job.Application.Models.UserResumeEmail", b =>
                {
                    b.Property<int>("UserResumeEmailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ResumeEmailedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserResumeEmailId");

                    b.ToTable("UserResumeEmail");
                });

            modelBuilder.Entity("EF.Core.Job.Application.Models.AppStatusLog", b =>
                {
                    b.HasOne("EF.Core.Job.Application.Models.JobApplication", "JobApplication")
                        .WithMany("AppStatusLog")
                        .HasForeignKey("JobApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF.Core.Job.Application.Models.JobResume", b =>
                {
                    b.HasOne("EF.Core.Job.Application.Models.JobApplication", "JobApplication")
                        .WithOne("JobResume")
                        .HasForeignKey("EF.Core.Job.Application.Models.JobResume", "JobApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
