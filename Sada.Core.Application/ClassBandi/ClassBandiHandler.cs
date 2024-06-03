using Sada.Core.Application.Exceptions;
using Sada.Core.Application.Repositories;
using Sada.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Application.ClassBandi
{
    public class ClassBandiHandler(IRepository<SchoolClass> repository) : IDisposable, IAsyncDisposable
    {
        public async Task<bool> CreateClassAsync(SchoolClass schoolClass)
        {
            if (schoolClass == null)
            {
                return false;
            }
            repository.Add(schoolClass);
            try
            {
                await repository.SaveChangesAsync();
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
            repository.Update(schoolClass);
            try
            {
                await repository.SaveChangesAsync();
                return true;
            }
            catch (DBConcurrencyException ex)
            {

                throw new ClassBandiUnsuccesfulException(ex.Message, ex.InnerException);
            }
        }
        public async Task<bool> DeleteClassAsync(int classId)
        {
            repository.Delete(classId);
            try
            {
                await repository.SaveChangesAsync();
                return true;
            }
            catch (DBConcurrencyException ex)
            {

                throw new ClassBandiUnsuccesfulException(ex.Message, ex.InnerException);
            }
        }
        public async Task<bool> RegisterStudentForClassAsync(int classId, Student student)
        {
            var c = repository.FindById(classId);
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
                repository.Update(c);
                await repository.SaveChangesAsync();
                return true;
            }
            catch (DBConcurrencyException ex)
            {

                throw new ClassBandiUnsuccesfulException(ex.Message, ex.InnerException);
            }
        }
        public async Task<bool> RemoveStudentForClassAsync(int classId, Student student)
        {
            var c = repository.FindById(classId);
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
                repository.Update(c);
                await repository.SaveChangesAsync();
                return true;
            }
            catch (DBConcurrencyException ex)
            {

                throw new ClassBandiUnsuccesfulException(ex.Message, ex.InnerException);
            }
        }
        public void CreateClassStudentCapacity(int classId, int capacity)
        {
            var c = repository.FindById(classId);
            if (c == null)
            {
                throw new EntityNotFoundException<SchoolClass>("Cannot Found SchoolClass With Given Id!");
            }
            var l = new List<Student>();
            l.Capacity = capacity;
            c.Students = l;
            repository.Update(c);
            repository.SaveChanges();
        }
        public void Dispose()
        {
            repository.Dispose();
        }

        public ValueTask DisposeAsync()
        {
            return repository.DisposeAsync();
        }
    }
}
