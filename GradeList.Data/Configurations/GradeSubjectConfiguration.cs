using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeList.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GradeList.Data.Configurations
{
    public class GradeSubjectConfiguration : IEntityTypeConfiguration<GradeSubject>
    {
        public void Configure(EntityTypeBuilder<GradeSubject> builder)
        {
            builder
                .Property(b => b.Name)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
