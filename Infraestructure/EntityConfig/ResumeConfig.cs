using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using Infraestructure.Data;

namespace Infraestructure.EntityConfig
{
    public class ResumeConfig : IEntityTypeConfiguration<Resume>
    {
        public void Configure(EntityTypeBuilder<Resume> builder)
        {
            builder.ToTable("Resume");
            builder.HasKey(r => r.UserId);
            builder.Property(r => r.UserId).IsRequired();
            builder.Property(r => r.Description).IsRequired();
            builder.Property(r => r.MinimumSalary);
            builder.Property(r => r.Image);
            ResumeData.SeedData(builder);
        }
    }
}
