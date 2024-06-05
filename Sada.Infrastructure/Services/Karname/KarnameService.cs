using Microsoft.Extensions.DependencyInjection;
using Sada.Core.Application.Interfaces;
using Sada.Core.Application.Repositories;
using Sada.Core.Domain.Entities;
using Sada.Core.Domain.Models;

namespace Sada.Infrastructure.Services;

public class KarnameService : IKarnameService
{
    private IRepository<Student> _stRepo;
    private IRepository<LessonPoint> _lpRepo;
    public KarnameService(IRepository<Student> stRepo, IRepository<LessonPoint> lpRepo)
    {
        _stRepo = stRepo;
        _lpRepo = lpRepo;
    }
    public KarnameModel GenerateKarnameByStudentId(int studentId)
    {
        KarnameModel model = new KarnameModel();
        model.StId = studentId;
        model.KarnameId = studentId;
        model.StName = _stRepo.FindById(studentId).Name;
        var points = _lpRepo.Where(p=>p.StudentId == studentId);
        model.Points = points.ToList();
        model.AvarageScore = points.Select(p => p.Point).Sum() / points.Count();
        return model;
    }
}
