using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sada.Core.Application.Exceptions;
using Sada.Core.Application.Interfaces;
using Sada.Core.Application.Repositories;
using Sada.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Infrastructure.Services
{
    public class ClassBandiService : IClassBandiService
    {
        private IRepository<SchoolClass> _repository;
        private IRepository<Student> _studentRepository;
        private IRepository<ClassStudent> classStudentRepo;
        public ClassBandiService(IRepository<SchoolClass> repository, IRepository<Student> studentRepository, IRepository<ClassStudent> classStudentRepo)
        {
            _repository = repository;
            _studentRepository = studentRepository;
            this.classStudentRepo = classStudentRepo;
        }
        public async Task<bool> CreateClassAsync(SchoolClass schoolClass)
        {
            if (schoolClass == null)
            {
                return false;
            }
            _repository.Add(schoolClass);
            try
            {
                await _repository.SaveChangesAsync();
                return true;
            }
            catch (DBConcurrencyException ex)
            {

                throw new ClassBandiUnsuccesfulException(ex.Message, ex.InnerException);
            }
        }
        public async Task<bool> UpdateClassAsync(SchoolClass schoolClass)
        {
            if (schoolClass == null)
            {
                return false;
            }
            _repository.Update(schoolClass);
            try
            {
                await _repository.SaveChangesAsync();
                return true;
            }
            catch (DBConcurrencyException ex)
            {

                throw new ClassBandiUnsuccesfulException(ex.Message, ex.InnerException);
            }
        }
        public async Task<bool> DeleteClassAsync(int classId)
        {
            _repository.Delete(classId);
            try
            {
                await _repository.SaveChangesAsync();
                return true;
            }
            catch (DBConcurrencyException ex)
            {

                throw new ClassBandiUnsuccesfulException(ex.Message, ex.InnerException);
            }
        }
        public async Task<bool> RegisterStudentForClassAsync(int classId, int stId)
        {
            var c = _repository.FindById(classId);
            if (c == null)
            {
                throw new EntityNotFoundException<SchoolClass>("Cannot Found SchoolClass With Given Id!");
            }
            if (c.Availble <= 0)
            {
                return false;
            }
            else
            {
                var stclass = new ClassStudent()
                {
                    ClassId = classId,
                    StudentId = stId
                };
                classStudentRepo.Add(stclass);
                c.Count++;
            }
            try
            {
                _repository.Update(c);
                await _repository.SaveChangesAsync();
                return true;
            }
            catch (DBConcurrencyException ex)
            {

                throw new ClassBandiUnsuccesfulException(ex.Message, ex.InnerException);
            }
        }
        public async Task<bool> RemoveStudentForClassAsync(int classId, int stId)
        {
            var c = _repository.FindById(classId);
            if (c == null)
            {
                throw new EntityNotFoundException<SchoolClass>("Cannot Found SchoolClass With Given Id!");
            }
            else 
            {
                classStudentRepo.Delete(await classStudentRepo.Where(c => c.ClassId == classId && c.StudentId == stId).FirstOrDefaultAsync());
                c.Count--;
            }
            try
            {
                _repository.Update(c);
                await _repository.SaveChangesAsync();
                return true;
            }
            catch (DBConcurrencyException ex)
            {

                throw new ClassBandiUnsuccesfulException(ex.Message, ex.InnerException);
            }
        }
        public void CreateClassStudentCapacity(int classId, int capacity)
        {
            var c = _repository.FindById(classId);
            if (c == null)
            {
                throw new EntityNotFoundException<SchoolClass>("Cannot Found SchoolClass With Given Id!");
            }
            c.Capacity = capacity;
        }
        public void Dispose()
        {
            _repository.Dispose();
        }

        public ValueTask DisposeAsync()
        {
            return _repository.DisposeAsync();
        }

        public async Task<SchoolClass?> GetClassById(int id)
        {
            return await _repository.FindByIdAsync(id);
        }
    }
}
