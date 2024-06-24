using Domain.Entities;
using Infraestructure.EntityConfig;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Diagnostics.Metrics;

namespace Infraestructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Experience> experiences { get; set; }
        public DbSet<Resume> resumes { get; set; }
        public DbSet<ResumeSkill> resumeSkills { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<Study> studys { get; set; }
        public DbSet<StudyType> studyTypes { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExperienceConfig());
            modelBuilder.ApplyConfiguration(new ResumeConfig());
            modelBuilder.ApplyConfiguration(new ResumeSkillConfig());
            modelBuilder.ApplyConfiguration(new SkillConfig());
            modelBuilder.ApplyConfiguration(new StudyConfig());
            modelBuilder.ApplyConfiguration(new StudyTypeConfig());

        }
    }
}
