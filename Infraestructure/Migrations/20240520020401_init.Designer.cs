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
    [Migration("20240520020401_init")]
    partial class init
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ExperienceId");

                    b.HasIndex("UserId");

                    b.ToTable("Experience", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Resume", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("MinimumSalary")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Resume", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("c5aa74a3-416d-411a-989e-b06c6ba067b6"),
                            Description = "Cv1",
                            Image = "...",
                            MinimumSalary = 100
                        },
                        new
                        {
                            UserId = new Guid("13e82a47-9bfe-4170-b94e-8ad3cbb13086"),
                            Description = "Cv2",
                            Image = "...",
                            MinimumSalary = 300
                        },
                        new
                        {
                            UserId = new Guid("189e1d58-3c3d-4b45-9156-9bf898cecec9"),
                            Description = "Cv3",
                            Image = "...",
                            MinimumSalary = 1000
                        });
                });

            modelBuilder.Entity("Domain.Entities.ResumeSkill", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "SkillId");

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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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
                        },
                        new
                        {
                            SkillId = 41,
                            Name = "Adobe Photoshop"
                        },
                        new
                        {
                            SkillId = 42,
                            Name = "Adobe Illustrator"
                        },
                        new
                        {
                            SkillId = 43,
                            Name = "Adobe InDesign"
                        },
                        new
                        {
                            SkillId = 44,
                            Name = "Sketch"
                        },
                        new
                        {
                            SkillId = 45,
                            Name = "CorelDRAW"
                        },
                        new
                        {
                            SkillId = 46,
                            Name = "AutoCAD"
                        },
                        new
                        {
                            SkillId = 47,
                            Name = "Revit"
                        },
                        new
                        {
                            SkillId = 48,
                            Name = "Legal Research"
                        },
                        new
                        {
                            SkillId = 49,
                            Name = "Litigation"
                        },
                        new
                        {
                            SkillId = 50,
                            Name = "Contract Drafting"
                        },
                        new
                        {
                            SkillId = 51,
                            Name = "Microsoft Office"
                        },
                        new
                        {
                            SkillId = 52,
                            Name = "Excel"
                        },
                        new
                        {
                            SkillId = 53,
                            Name = "Word"
                        },
                        new
                        {
                            SkillId = 54,
                            Name = "PowerPoint"
                        },
                        new
                        {
                            SkillId = 55,
                            Name = "Outlook"
                        },
                        new
                        {
                            SkillId = 56,
                            Name = "Adobe Premiere Pro"
                        },
                        new
                        {
                            SkillId = 57,
                            Name = "Final Cut Pro"
                        },
                        new
                        {
                            SkillId = 58,
                            Name = "Avid Media Composer"
                        },
                        new
                        {
                            SkillId = 59,
                            Name = "Blender"
                        },
                        new
                        {
                            SkillId = 60,
                            Name = "Maya"
                        },
                        new
                        {
                            SkillId = 61,
                            Name = "3ds Max"
                        },
                        new
                        {
                            SkillId = 62,
                            Name = "ZBrush"
                        },
                        new
                        {
                            SkillId = 63,
                            Name = "SketchUp"
                        },
                        new
                        {
                            SkillId = 64,
                            Name = "Illustration"
                        },
                        new
                        {
                            SkillId = 65,
                            Name = "Typography"
                        },
                        new
                        {
                            SkillId = 66,
                            Name = "Digital Painting"
                        },
                        new
                        {
                            SkillId = 67,
                            Name = "User Experience (UX) Design"
                        },
                        new
                        {
                            SkillId = 68,
                            Name = "User Interface (UI) Design"
                        },
                        new
                        {
                            SkillId = 69,
                            Name = "Wireframing"
                        },
                        new
                        {
                            SkillId = 70,
                            Name = "Prototyping"
                        },
                        new
                        {
                            SkillId = 71,
                            Name = "Information Architecture"
                        },
                        new
                        {
                            SkillId = 72,
                            Name = "Interaction Design"
                        },
                        new
                        {
                            SkillId = 73,
                            Name = "Brand Identity"
                        },
                        new
                        {
                            SkillId = 74,
                            Name = "Print Design"
                        },
                        new
                        {
                            SkillId = 75,
                            Name = "Packaging Design"
                        },
                        new
                        {
                            SkillId = 76,
                            Name = "Logo Design"
                        },
                        new
                        {
                            SkillId = 77,
                            Name = "Motion Graphics"
                        },
                        new
                        {
                            SkillId = 78,
                            Name = "2D Animation"
                        },
                        new
                        {
                            SkillId = 79,
                            Name = "3D Animation"
                        },
                        new
                        {
                            SkillId = 80,
                            Name = "Character Animation"
                        },
                        new
                        {
                            SkillId = 81,
                            Name = "Legal Writing"
                        },
                        new
                        {
                            SkillId = 82,
                            Name = "Corporate Law"
                        },
                        new
                        {
                            SkillId = 83,
                            Name = "Intellectual Property Law"
                        },
                        new
                        {
                            SkillId = 84,
                            Name = "Family Law"
                        },
                        new
                        {
                            SkillId = 85,
                            Name = "Environmental Law"
                        },
                        new
                        {
                            SkillId = 86,
                            Name = "Immigration Law"
                        },
                        new
                        {
                            SkillId = 87,
                            Name = "Real Estate Law"
                        },
                        new
                        {
                            SkillId = 88,
                            Name = "Bankruptcy Law"
                        },
                        new
                        {
                            SkillId = 89,
                            Name = "Criminal Law"
                        },
                        new
                        {
                            SkillId = 90,
                            Name = "Health Law"
                        },
                        new
                        {
                            SkillId = 91,
                            Name = "Tax Law"
                        },
                        new
                        {
                            SkillId = 92,
                            Name = "International Law"
                        },
                        new
                        {
                            SkillId = 93,
                            Name = "Administrative Law"
                        },
                        new
                        {
                            SkillId = 94,
                            Name = "Legal Compliance"
                        },
                        new
                        {
                            SkillId = 95,
                            Name = "Legal Consulting"
                        },
                        new
                        {
                            SkillId = 96,
                            Name = "Legal Research"
                        },
                        new
                        {
                            SkillId = 97,
                            Name = "Legal Writing"
                        },
                        new
                        {
                            SkillId = 98,
                            Name = "Legal Analysis"
                        },
                        new
                        {
                            SkillId = 99,
                            Name = "Legal Documentation"
                        },
                        new
                        {
                            SkillId = 100,
                            Name = "Data Entry"
                        },
                        new
                        {
                            SkillId = 101,
                            Name = "Typing"
                        },
                        new
                        {
                            SkillId = 102,
                            Name = "Proofreading"
                        },
                        new
                        {
                            SkillId = 103,
                            Name = "Document Formatting"
                        },
                        new
                        {
                            SkillId = 104,
                            Name = "Transcription"
                        },
                        new
                        {
                            SkillId = 105,
                            Name = "Virtual Assistance"
                        },
                        new
                        {
                            SkillId = 106,
                            Name = "Customer Service"
                        },
                        new
                        {
                            SkillId = 107,
                            Name = "Email Handling"
                        },
                        new
                        {
                            SkillId = 108,
                            Name = "Calendar Management"
                        },
                        new
                        {
                            SkillId = 109,
                            Name = "Travel Arrangements"
                        },
                        new
                        {
                            SkillId = 110,
                            Name = "Event Planning"
                        },
                        new
                        {
                            SkillId = 111,
                            Name = "Research"
                        },
                        new
                        {
                            SkillId = 112,
                            Name = "Social Media Management"
                        },
                        new
                        {
                            SkillId = 113,
                            Name = "Content Creation"
                        },
                        new
                        {
                            SkillId = 114,
                            Name = "Digital Marketing"
                        },
                        new
                        {
                            SkillId = 115,
                            Name = "Search Engine Optimization (SEO)"
                        },
                        new
                        {
                            SkillId = 116,
                            Name = "Search Engine Marketing (SEM)"
                        },
                        new
                        {
                            SkillId = 117,
                            Name = "Email Marketing"
                        },
                        new
                        {
                            SkillId = 118,
                            Name = "Graphic Design"
                        },
                        new
                        {
                            SkillId = 119,
                            Name = "Web Design"
                        },
                        new
                        {
                            SkillId = 120,
                            Name = "Video Editing"
                        },
                        new
                        {
                            SkillId = 121,
                            Name = "Audio Editing"
                        },
                        new
                        {
                            SkillId = 122,
                            Name = "Photography"
                        },
                        new
                        {
                            SkillId = 123,
                            Name = "Videography"
                        },
                        new
                        {
                            SkillId = 124,
                            Name = "Photo Editing"
                        },
                        new
                        {
                            SkillId = 125,
                            Name = "Image Retouching"
                        },
                        new
                        {
                            SkillId = 126,
                            Name = "Color Grading"
                        },
                        new
                        {
                            SkillId = 127,
                            Name = "Storyboarding"
                        },
                        new
                        {
                            SkillId = 128,
                            Name = "Scriptwriting"
                        },
                        new
                        {
                            SkillId = 129,
                            Name = "Creative Writing"
                        },
                        new
                        {
                            SkillId = 130,
                            Name = "Copywriting"
                        },
                        new
                        {
                            SkillId = 131,
                            Name = "Technical Writing"
                        },
                        new
                        {
                            SkillId = 132,
                            Name = "Editing"
                        },
                        new
                        {
                            SkillId = 133,
                            Name = "Translation"
                        },
                        new
                        {
                            SkillId = 134,
                            Name = "Localization"
                        },
                        new
                        {
                            SkillId = 135,
                            Name = "Subtitling"
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StarDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudyTypeId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudyId");

                    b.HasIndex("StudyTypeId");

                    b.HasIndex("UserId");

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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StudyTypeId");

                    b.ToTable("StudyType", (string)null);

                    b.HasData(
                        new
                        {
                            StudyTypeId = 1,
                            Name = "Primaria"
                        },
                        new
                        {
                            StudyTypeId = 2,
                            Name = "Secundaria"
                        },
                        new
                        {
                            StudyTypeId = 3,
                            Name = "Terciario"
                        },
                        new
                        {
                            StudyTypeId = 4,
                            Name = "Universitario"
                        },
                        new
                        {
                            StudyTypeId = 5,
                            Name = "Posgrado"
                        },
                        new
                        {
                            StudyTypeId = 6,
                            Name = "Master"
                        },
                        new
                        {
                            StudyTypeId = 7,
                            Name = "Doctorado"
                        },
                        new
                        {
                            StudyTypeId = 8,
                            Name = "Curso"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Experience", b =>
                {
                    b.HasOne("Domain.Entities.Resume", "resume")
                        .WithMany("ExperienceList")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("resume");
                });

            modelBuilder.Entity("Domain.Entities.ResumeSkill", b =>
                {
                    b.HasOne("Domain.Entities.Skill", "skill")
                        .WithMany("ResumeSkill")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Resume", "resume")
                        .WithMany("ResumeSkillList")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("resume");

                    b.Navigation("skill");
                });

            modelBuilder.Entity("Domain.Entities.Study", b =>
                {
                    b.HasOne("Domain.Entities.StudyType", "studyType")
                        .WithMany("StudyList")
                        .HasForeignKey("StudyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Resume", "resume")
                        .WithMany("StudyList")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("resume");

                    b.Navigation("studyType");
                });

            modelBuilder.Entity("Domain.Entities.Resume", b =>
                {
                    b.Navigation("ExperienceList");

                    b.Navigation("ResumeSkillList");

                    b.Navigation("StudyList");
                });

            modelBuilder.Entity("Domain.Entities.Skill", b =>
                {
                    b.Navigation("ResumeSkill");
                });

            modelBuilder.Entity("Domain.Entities.StudyType", b =>
                {
                    b.Navigation("StudyList");
                });
#pragma warning restore 612, 618
        }
    }
}
