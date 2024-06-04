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
    public class SchoolRepository(SadaDbContext sadaDbContext) : IRepository<School>
    {
        public bool Add(School model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(School model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            sadaDbContext.Dispose();
        }

        public ValueTask DisposeAsync()
        {
            return sadaDbContext.DisposeAsync();
        }

        public School? FindById(int id)
        {
            return sadaDbContext.Schools.Find(id);
        }

        public async Task<School?> FindByIdAsync(int id)
        {
            return await sadaDbContext.Schools.FindAsync(id);
        }

        public School? FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<School?> FindByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public ICollection<School> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<School>> GetAllAsync()
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

        public bool Update(School model)
        {
            throw new NotImplementedException();
        }


        public IQueryable<School> Where(Expression<Func<School, bool>>? where = null)
        {
            IQueryable<School> query = (IQueryable<School>)sadaDbContext.SchoolClasses;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query;
        }
    }
}
