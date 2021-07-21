using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeList.Application.DTOs;
using GradeList.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GradeList.Application.UseCases
{
    public class GradeService
    {
        private readonly IGradeDbContext _context;
        public GradeService(IGradeDbContext context)
        {
            _context = context;

        }

        public async Task<List<GradeSubjectDto>> RetreiveGradeSubjectDtos(string criteria)
        {
            return string.IsNullOrEmpty(criteria)
                ? await _context.GradeSubjects.Select(gs=> new GradeSubjectDto
                {
                    Id = gs.Id,
                    Name = gs.Name
                }).ToListAsync()
                : await _context.GradeSubjects.Where(gs => gs.Name.Contains(criteria)).Select(gs => new GradeSubjectDto
                {
                    Id = gs.Id,
                    Name = gs.Name
                }).ToListAsync();

        }
    }
}
