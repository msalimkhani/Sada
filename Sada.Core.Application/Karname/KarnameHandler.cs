﻿using Sada.Core.Application.Repositories;
using Sada.Core.Domain.Entities;
using Sada.Core.Domain.Models;

namespace Sada.Core.Application.Karname
{
    public class KarnameHandler(IRepository<Student> _stRepo, IRepository<LessonPoint> _lpRepo)
    {
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
}
