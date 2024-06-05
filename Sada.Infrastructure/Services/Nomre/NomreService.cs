using Microsoft.Extensions.DependencyInjection;
using Sada.Core.Application.Interfaces;
using Sada.Core.Application.Repositories;
using Sada.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Infrastructure.Services;

public class NomreService : INomreService
{
    private IRepository<LessonPoint> _lpRepository;
    private IRepository<Lesson> _lRepository;
    public NomreService(IRepository<LessonPoint> lpRepository, IRepository<Lesson> lRepository)
    {
        this._lpRepository = lpRepository;
        this._lRepository = lRepository;
    }
    public IEnumerable<Lesson> RetriveLessons(int gradeId)
    {
        return _lRepository.Where(lw => lw.GradeId == gradeId).ToList();
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
