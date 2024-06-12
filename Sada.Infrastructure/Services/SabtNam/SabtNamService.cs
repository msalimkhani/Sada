using Sada.Core.Application.Exceptions;
using Sada.Core.Application.Interfaces;
using Sada.Core.Application.Repositories;
using Sada.Core.Domain.Entities;
using System.Data;

namespace Sada.Infrastructure.Services
{
    public class SabtNamService(IRepository<Student> repository) : ISabtNamService
    {

        public async Task<bool> RegisterStudentAsync(Student student)
        {
            if(student == null)
            {
                return false;
            }
            repository.Add(student);
            try
            {
                await repository.SaveChangesAsync();
                return true;
            }
            catch (DBConcurrencyException ex)
            {
                throw new StudentRegisterUnsucessfullException(ex.Message, ex.InnerException);
            }
        }
        
        public void Dispose()
        {
            repository.Dispose();
        }

        public async ValueTask DisposeAsync()
        {
            await repository.DisposeAsync();
        }

        public async Task SaveChangesAsync()
        {
            await repository.SaveChangesAsync();
        }

        public async Task Edit(Student student)
        {
            if (student == null) { throw new ArgumentNullException(); }
            repository.Add(student);
            try
            {
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task Delete(int stId)
        {
            repository.Delete(stId);
            try
            {
                await repository.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
