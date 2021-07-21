using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeList.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GradeList.Application.Interfaces
{
    public interface IGradeDbContext
    {
        DbSet<GradeSubject> GradeSubjects { get; set; }
    }
}
