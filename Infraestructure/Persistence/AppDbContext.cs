using Domain.Entities;
using Infraestructure.EntityConfig;
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
