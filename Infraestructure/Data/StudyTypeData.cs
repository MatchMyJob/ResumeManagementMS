﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class StudyTypeData
    {
        public static void SeedData(EntityTypeBuilder<StudyType> builder)
        {
            builder.HasData(
                new StudyType { StudyTypeId = 1, Name = "Primaria" },
                new StudyType { StudyTypeId = 2, Name = "Secundaria" },
                new StudyType { StudyTypeId = 3, Name = "Terciario" },
                new StudyType { StudyTypeId = 4, Name = "Universitario" },
                new StudyType { StudyTypeId = 5, Name = "Posgrado" },
                new StudyType { StudyTypeId = 6, Name = "Master" },
                new StudyType { StudyTypeId = 7, Name = "Doctorado" },
                new StudyType { StudyTypeId = 8, Name = "Curso" }
                );
        }
    }
}
