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
    public class ClassStutentRepository(SadaDbContext sadaDbContext) : IRepository<ClassStudent>
    {
        public bool Add(ClassStudent model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ClassStudent model)
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

        public ClassStudent? FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ClassStudent?> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public ClassStudent? FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ClassStudent?> FindByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public ICollection<ClassStudent> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<ClassStudent>> GetAllAsync()
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

        public bool Update(ClassStudent model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ClassStudent> Where(Expression<Func<ClassStudent, bool>> where)
        {
            throw new NotImplementedException();
        }
    }
}
