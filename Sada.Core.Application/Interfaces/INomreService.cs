using Sada.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Application.Interfaces
{
    public interface INomreService
    {
        Task<IEnumerable<Lesson>> RetriveLessons(int gradeId);
        Task RegisterNomreForStudentByLessonId(int studentId, int lessonId, int point);
        Task RemoveNomreByLessonPointId(int lpId);
        Task<IEnumerable<LessonPoint>> GetPoints(int studentId);
        Task<LessonPoint?> GetPoint(int studentId, int lessonId);
    }
}
