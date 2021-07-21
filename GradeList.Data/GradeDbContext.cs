using GradeList.Application.Interfaces;
using GradeList.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace GradeList.Data
{
    public class GradeDbContext : DbContext, IGradeDbContext
    {
        public GradeDbContext(DbContextOptions<GradeDbContext> options) : base(options)
        {
            
        }
        public DbSet<GradeSubject> GradeSubjects { get; set; }
    }
}
