using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infraestructure.EntityConfig
{
    public class ResumeSkillConfig : IEntityTypeConfiguration<ResumeSkill>
    {
        public void Configure(EntityTypeBuilder<ResumeSkill> builder)
        {
            builder.ToTable("ResumeSkill");
            builder.HasKey(rs => new { rs.UserId, rs.SkillId });

            builder.HasOne<Resume>(r => r.resume)
            .WithMany(r => r.ResumeSkillList)
            .HasForeignKey(r => r.UserId);

            builder.HasOne<Skill>(s => s.skill)
            .WithMany(s => s.ResumeSkill)
            .HasForeignKey(s => s.SkillId);
        }
    }

}
