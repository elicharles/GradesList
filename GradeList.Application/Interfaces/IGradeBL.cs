using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeList.Application.DTOs;

namespace GradeList.Application.Interfaces
{
    public interface IGradeBL
    {
        Task<List<GradeSubjectDto>> RetreiveGradeSubjectDtos(string criteria);
    }
}
