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
        public ClassBandiService(IRepository<SchoolClass> repository)
        {
            _repository = repository;
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
        public async Task<bool> RegisterStudentForClassAsync(int classId, Student student)  
        {
            var c = _repository.FindById(classId);
            if (c == null)
            {
                throw new EntityNotFoundException<SchoolClass>("Cannot Found SchoolClass With Given Id!");
            }
            if (c.Students == null)
            {
                return false;
            }
            else { c.Students.Add(student); }
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
        public async Task<bool> RemoveStudentForClassAsync(int classId, Student student)
        {
            var c = _repository.FindById(classId);
            if (c == null)
            {
                throw new EntityNotFoundException<SchoolClass>("Cannot Found SchoolClass With Given Id!");
            }
            if (c.Students == null)
            {
                return false;
            }
            else { c.Students.Remove(student); }
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
            var l = new List<Student>();
            l.Capacity = capacity;
            c.Students = l;
            _repository.Update(c);
            _repository.SaveChanges();
        }
        public void Dispose()
        {
            _repository.Dispose();
        }

        public ValueTask DisposeAsync()
        {
            return _repository.DisposeAsync();
        }
    }
}
