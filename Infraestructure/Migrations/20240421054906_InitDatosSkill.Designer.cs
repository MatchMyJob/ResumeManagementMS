﻿// <auto-generated />
using System;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infraestructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240421054906_InitDatosSkill")]
    partial class InitDatosSkill
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Experience", b =>
                {
                    b.Property<int>("ExperienceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExperienceId"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResumeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ExperienceId");

                    b.HasIndex("ResumeId");

                    b.ToTable("Experience", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Resume", b =>
                {
                    b.Property<int>("ResumeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResumeId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MinimunSalary")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ResumeId");

                    b.ToTable("Resume", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ResumeSkill", b =>
                {
                    b.Property<int>("ResumeId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("ResumeId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("ResumeSkill", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillId");

                    b.ToTable("Skill", (string)null);

                    b.HasData(
                        new
                        {
                            SkillId = 1,
                            Name = "Java"
                        },
                        new
                        {
                            SkillId = 2,
                            Name = "Javascript"
                        },
                        new
                        {
                            SkillId = 3,
                            Name = "C#"
                        },
                        new
                        {
                            SkillId = 4,
                            Name = "Python"
                        },
                        new
                        {
                            SkillId = 5,
                            Name = "Ruby"
                        },
                        new
                        {
                            SkillId = 6,
                            Name = "PHP"
                        },
                        new
                        {
                            SkillId = 7,
                            Name = "Swift"
                        },
                        new
                        {
                            SkillId = 8,
                            Name = "Go"
                        },
                        new
                        {
                            SkillId = 9,
                            Name = "Rust"
                        },
                        new
                        {
                            SkillId = 10,
                            Name = "Kotlin"
                        },
                        new
                        {
                            SkillId = 11,
                            Name = "TypeScript"
                        },
                        new
                        {
                            SkillId = 12,
                            Name = "C++"
                        },
                        new
                        {
                            SkillId = 13,
                            Name = "Scala"
                        },
                        new
                        {
                            SkillId = 14,
                            Name = "Perl"
                        },
                        new
                        {
                            SkillId = 15,
                            Name = "R"
                        },
                        new
                        {
                            SkillId = 16,
                            Name = "MATLAB"
                        },
                        new
                        {
                            SkillId = 17,
                            Name = "Haskell"
                        },
                        new
                        {
                            SkillId = 18,
                            Name = "Cobol"
                        },
                        new
                        {
                            SkillId = 19,
                            Name = "Lisp"
                        },
                        new
                        {
                            SkillId = 20,
                            Name = "Prolog"
                        },
                        new
                        {
                            SkillId = 21,
                            Name = "Ada"
                        },
                        new
                        {
                            SkillId = 22,
                            Name = "Fortran"
                        },
                        new
                        {
                            SkillId = 23,
                            Name = "Assembly (x86, ARM)"
                        },
                        new
                        {
                            SkillId = 24,
                            Name = ".NET"
                        },
                        new
                        {
                            SkillId = 25,
                            Name = "Spring"
                        },
                        new
                        {
                            SkillId = 26,
                            Name = "Django"
                        },
                        new
                        {
                            SkillId = 27,
                            Name = "React"
                        },
                        new
                        {
                            SkillId = 28,
                            Name = "Angular"
                        },
                        new
                        {
                            SkillId = 29,
                            Name = "Vue.js"
                        },
                        new
                        {
                            SkillId = 30,
                            Name = "Node.js"
                        },
                        new
                        {
                            SkillId = 31,
                            Name = "Express.js"
                        },
                        new
                        {
                            SkillId = 32,
                            Name = "Flask"
                        },
                        new
                        {
                            SkillId = 33,
                            Name = "Ruby on Rails"
                        },
                        new
                        {
                            SkillId = 34,
                            Name = "Laravel"
                        },
                        new
                        {
                            SkillId = 35,
                            Name = "Symfony"
                        },
                        new
                        {
                            SkillId = 36,
                            Name = "Hibernate"
                        },
                        new
                        {
                            SkillId = 37,
                            Name = "Xamarin"
                        },
                        new
                        {
                            SkillId = 38,
                            Name = "Unity"
                        },
                        new
                        {
                            SkillId = 39,
                            Name = "TensorFlow"
                        },
                        new
                        {
                            SkillId = 40,
                            Name = "PyTorch"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Study", b =>
                {
                    b.Property<int>("StudyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudyId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ResumeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudyTypeId")
                        .HasColumnType("int");

                    b.HasKey("StudyId");

                    b.HasIndex("ResumeId");

                    b.HasIndex("StudyTypeId");

                    b.ToTable("Study", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.StudyType", b =>
                {
                    b.Property<int>("StudyTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudyTypeId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudyTypeId");

                    b.ToTable("StudyType", (string)null);

                    b.HasData(
                        new
                        {
                            StudyTypeId = 1,
                            Name = "Secundaria basica"
                        },
                        new
                        {
                            StudyTypeId = 2,
                            Name = "Secundaria superior"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Experience", b =>
                {
                    b.HasOne("Domain.Entities.Resume", "Resume")
                        .WithMany("ExperienceList")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("Domain.Entities.ResumeSkill", b =>
                {
                    b.HasOne("Domain.Entities.Resume", "Resume")
                        .WithMany("ResumeSkills")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Skill", "Skill")
                        .WithMany("ResumeSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resume");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("Domain.Entities.Study", b =>
                {
                    b.HasOne("Domain.Entities.Resume", "Resume")
                        .WithMany("StudyList")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.StudyType", "StudyType")
                        .WithMany("StudyList")
                        .HasForeignKey("StudyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resume");

                    b.Navigation("StudyType");
                });

            modelBuilder.Entity("Domain.Entities.Resume", b =>
                {
                    b.Navigation("ExperienceList");

                    b.Navigation("ResumeSkills");

                    b.Navigation("StudyList");
                });

            modelBuilder.Entity("Domain.Entities.Skill", b =>
                {
                    b.Navigation("ResumeSkills");
                });

            modelBuilder.Entity("Domain.Entities.StudyType", b =>
                {
                    b.Navigation("StudyList");
                });
#pragma warning restore 612, 618
        }
    }
}
