using Sada.Core.Application.Repositories;
using Sada.Core.Domain.Entities;
using Sada.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Infrastructure.Services
{
    public class GradeRepository(SadaDbContext sadaDbContext) : IRepository<Grade>
    {
        public bool Add(Grade model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Grade model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }

        public Grade? FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Grade?> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Grade? FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Grade?> FindByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public ICollection<Grade> GetAll()
        {
            return sadaDbContext.Grades.ToList();
        }

        public Task<ICollection<Grade>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public bool Update(Grade model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Grade> Where(Expression<Func<Grade, bool>> where)
        {
            throw new NotImplementedException();
        }
    }
}
