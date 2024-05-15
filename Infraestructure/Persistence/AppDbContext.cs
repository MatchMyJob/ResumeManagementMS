using Domain.Entities;
//using Infraestructure.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Study> Studies { get; set; }
        public DbSet<ResumeSkill> ResumesSkills { get; set; }
        public DbSet<StudyType> StudiesTypes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resume>(entity =>
                {
                    entity.ToTable("Resume");
                    entity.HasKey(e => e.ResumeId);
                    entity.Property(e => e.ResumeId).ValueGeneratedOnAdd();
                });

            modelBuilder.Entity<Skill>(entity =>
                {
                    entity.ToTable("Skill");
                    entity.HasKey(e => e.SkillId);
                    entity.Property(e => e.SkillId);
                    entity.HasData(
                        new Skill{
                            SkillId = 1,
                            Name = "Java",
                        },

                        new Skill{
                            SkillId = 2,
                            Name = "Javascript",
                        },

                         new Skill
                         {
                             SkillId = 3,
                             Name = "C#",
                         },

                         new Skill
                         {
                             SkillId = 4,
                             Name = "Python",
                         },

                         new Skill
                         {
                             SkillId = 5,
                             Name = "Ruby",
                         },

                         new Skill
                         {
                             SkillId = 6,
                             Name = "PHP",
                         },

                         new Skill
                         {
                             SkillId = 7,
                             Name = "Swift",
                         },

                         new Skill
                         {
                             SkillId = 8,
                             Name = "Go",
                         },

                         new Skill
                         {
                             SkillId = 9,
                             Name = "Rust",
                         },

                         new Skill
                         {
                             SkillId = 10,
                             Name = "Kotlin",
                         },

                         new Skill
                         {
                             SkillId = 11,
                             Name = "TypeScript",
                         },

                         new Skill
                         {
                             SkillId = 12,
                             Name = "C++",
                         },

                         new Skill
                         {
                             SkillId = 13,
                             Name = "Scala",
                         },

                         new Skill
                         {
                             SkillId = 14,
                             Name = "Perl",
                         },

                         new Skill
                         {
                             SkillId = 15,
                             Name = "R",
                         },

                         new Skill
                         {
                             SkillId = 16,
                             Name = "MATLAB",
                         },

                         new Skill
                         {
                             SkillId = 17,
                             Name = "Haskell",
                         },

                         new Skill
                         {
                             SkillId = 18,
                             Name = "Cobol",
                         },

                         new Skill
                         {
                             SkillId = 19,
                             Name = "Lisp",
                         },

                         new Skill
                         {
                             SkillId = 20,
                             Name = "Prolog",
                         },

                         new Skill
                         {
                             SkillId = 21,
                             Name = "Ada",
                         },

                         new Skill
                         {
                             SkillId = 22,
                             Name = "Fortran",
                         }, 
                         
                         new Skill
                         {
                             SkillId = 23,
                             Name = "Assembly (x86, ARM)",
                         },

                         new Skill
                         {
                             SkillId = 24,
                             Name = ".NET",
                         },

                         new Skill
                         {
                             SkillId = 25,
                             Name = "Spring",
                         },

                         new Skill
                         {
                             SkillId = 26,
                             Name = "Django",
                         },

                         new Skill
                         {
                             SkillId = 27,
                             Name = "React",
                         },

                         new Skill
                         {
                             SkillId = 28,
                             Name = "Angular",
                         },

                         new Skill
                         {
                             SkillId = 29,
                             Name = "Vue.js",
                         },

                         new Skill
                         {
                             SkillId = 30,
                             Name = "Node.js",
                         },

                         new Skill
                         {
                             SkillId = 31,
                             Name = "Express.js",
                         },

                         new Skill
                         {
                             SkillId = 32,
                             Name = "Flask",
                         },

                         new Skill
                         {
                             SkillId = 33,
                             Name = "Ruby on Rails",
                         },

                         new Skill
                         {
                             SkillId = 34,
                             Name = "Laravel",
                         },

                         new Skill
                         {
                             SkillId = 35,
                             Name = "Symfony",
                         },

                         new Skill
                         {
                             SkillId = 36,
                             Name = "Hibernate",
                         },

                         new Skill
                         {
                             SkillId = 37,
                             Name = "Xamarin",
                         },

                         new Skill
                         {
                             SkillId = 38,
                             Name = "Unity",
                         },

                         new Skill
                         {
                             SkillId = 39,
                             Name = "TensorFlow",
                         },
                         new Skill
                         {
                             SkillId = 40,
                             Name = "PyTorch",
                         }
                    );
                });

            modelBuilder.Entity<StudyType>(entity =>
                {
                    entity.ToTable("StudyType");
                    entity.HasKey(e => e.StudyTypeId);
                    entity.Property(e => e.StudyTypeId);
                    entity.HasData(
                        new StudyType{
                            StudyTypeId = 1,
                            Name = "Secundaria basica"
                        },

                        new StudyType{
                            StudyTypeId = 2,
                            Name = "Secundaria superior"
                        },

                        new StudyType
                        {
                            StudyTypeId = 3,
                            Name = "Terciario"
                        },

                        new StudyType
                        {
                            StudyTypeId = 4,
                            Name = "Universitario"
                        }
                    );
                });

            modelBuilder.Entity<Experience>(entity =>
                {
                    entity.ToTable("Experience");
                    entity.HasKey(e => e.ExperienceId);
                    entity.Property(e => e.ExperienceId).ValueGeneratedOnAdd();
                    entity.HasOne<Resume>(e => e.Resume)
                    .WithMany(e => e.ExperienceList)
                    .HasForeignKey(e => e.ResumeId);
                });

            modelBuilder.Entity<Study>(entity =>
                {
                    entity.ToTable("Study");
                    entity.HasKey(e => e.StudyId);
                    entity.Property(e => e.StudyId).ValueGeneratedOnAdd();
                    
                    entity.HasOne<Resume>(e => e.Resume)
                    .WithMany(e => e.StudyList)
                    .HasForeignKey(e => e.ResumeId);

                    entity.HasOne<StudyType>(e => e.StudyType)
                    .WithMany(e => e.StudyList)
                    .HasForeignKey(e => e.StudyTypeId);
                });

            modelBuilder.Entity<ResumeSkill>(entity =>
                {
                    entity.ToTable("ResumeSkill");
                    entity.HasKey(e => new { e.ResumeId , e.SkillId });

                    entity.HasOne<Resume>(e => e.Resume)
                    .WithMany(e => e.ResumeSkills)
                    .HasForeignKey(e => e.ResumeId);

                    entity.HasOne<Skill>(e => e.Skill)
                    .WithMany(e => e.ResumeSkills)
                    .HasForeignKey(e => e.SkillId);
                });
        }
    }
}
