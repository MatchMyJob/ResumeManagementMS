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
    public class StudyConfig : IEntityTypeConfiguration<Study>
    {
        public void Configure(EntityTypeBuilder<Study> builder)
        {
            builder.ToTable("Study");
            builder.HasKey(s => s.StudyId);
            builder.Property(s => s.StudyId).IsRequired();
            builder.Property(s => s.Description).IsRequired();
            builder.Property(s => s.StarDate).IsRequired();
            builder.Property(s => s.EndDate).IsRequired();

            builder.HasOne<Resume>(r => r.resume)
            .WithMany(r => r.StudyList)
            .HasForeignKey(r => r.UserId);

            builder.HasOne<StudyType>(s => s.studyType)
            .WithMany(s => s.StudyList)
            .HasForeignKey(s => s.StudyTypeId);
        }
    }
}
