using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.EntityConfig
{
    public class ExperienceConfig : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.ToTable("Experience");
            builder.HasKey(e => e.ExperienceId);
            builder.Property(e => e.ExperienceId).IsRequired();
            builder.Property(e => e.CompanyName).IsRequired();
            builder.Property(e => e.JobTitle).IsRequired();
            builder.Property(e => e.jobDescription).IsRequired();
            builder.Property(e => e.StartDate).IsRequired();
            builder.Property(e => e.EndDate);
            builder.HasOne<Resume>(e => e.resume)
            .WithMany(e => e.ExperienceList)
            .HasForeignKey(e => e.UserId);
        }
    }
}
