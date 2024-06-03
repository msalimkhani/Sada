using Sada.Core.Application.Repositories;
using Sada.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Application.Nomre
{
    public class NomreHandler( IRepository<LessonPoint> _lpRepository, IRepository<Lesson> _lRepository)
    {
        public async Task<IEnumerable<Lesson>> RetriveLessons(int gradeId)
        {
            return await _lRepository.WhereAsync(lw => lw.GradeId == gradeId);
        }
        public async Task RegisterNomreForStudentByLessonId(int studentId, int lessonId, int point)
        {
            if (!(lessonId <= 0 || point < 0))
            {
                var nomre = new LessonPoint()
                {
                    LessonId = lessonId,
                    Point = point,
                    StudentId = studentId
                };
                _lpRepository.Add(nomre);
                await _lpRepository.SaveChangesAsync();
            }
        }
        public async Task RemoveNomreByLessonPointId(int lpId)
        {
            if(lpId > 0)
            {
                _lpRepository.Delete(lpId);
                await _lpRepository.SaveChangesAsync();
            }
        }
    }
}
