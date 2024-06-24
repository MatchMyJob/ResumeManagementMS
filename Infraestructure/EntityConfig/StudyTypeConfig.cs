using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure.Data;

namespace Infraestructure.EntityConfig
{
    public class StudyTypeConfig : IEntityTypeConfiguration<StudyType>
    {
        public void Configure(EntityTypeBuilder<StudyType> builder)
        {
            builder.ToTable("StudyType");
            builder.HasKey(s => s.StudyTypeId);
            builder.Property(s => s.StudyTypeId).IsRequired();
            builder.Property(s => s.Name).IsRequired();
            StudyTypeData.SeedData(builder);

        }
    }
}
