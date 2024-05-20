using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Infraestructure.Data
{
    public class ResumeData
    {
        public static void SeedData(EntityTypeBuilder<Resume> builder)
        {
            builder.HasData(
                new Resume { UserId = Guid.NewGuid(), Description = "Cv1", MinimumSalary = 100, Image = "..." },
                new Resume { UserId = Guid.NewGuid(), Description = "Cv2", MinimumSalary = 300, Image = "..." },
                new Resume { UserId = Guid.NewGuid(), Description = "Cv3", MinimumSalary = 1000, Image = "..." }
                );
        }
    }
}
