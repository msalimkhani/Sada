using Microsoft.EntityFrameworkCore;
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
    public class SchoolClassRepository(SadaDbContext sadaDbContext) : IRepository<SchoolClass>
    {
        public bool Add(SchoolClass model)
        {
            try
            {
                sadaDbContext.Add(model);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(SchoolClass model)
        {
            try
            {
                sadaDbContext.Remove(model);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(int id)
        {
            return Delete(FindById(id));
        }

        public void Dispose()
        {
            sadaDbContext.Dispose();
        }

        public ValueTask DisposeAsync()
        {
            return sadaDbContext.DisposeAsync();
        }

        public SchoolClass? FindById(int id)
        {
            return sadaDbContext.SchoolClasses.Find(id);
        }

        public async Task<SchoolClass?> FindByIdAsync(int id)
        {
            return await sadaDbContext.SchoolClasses.FindAsync(id);
        }

        public SchoolClass? FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<SchoolClass?> FindByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public ICollection<SchoolClass> GetAll()
        {
            return sadaDbContext.SchoolClasses.ToList();
        }

        public async Task<ICollection<SchoolClass>> GetAllAsync()
        {
            return await sadaDbContext.SchoolClasses.ToListAsync();
        }

        public void SaveChanges()
        {
            sadaDbContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await sadaDbContext.SaveChangesAsync();
        }

        public bool Update(SchoolClass model)
        {
            try
            {
                sadaDbContext.Entry(model).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public IQueryable<SchoolClass> Where(Expression<Func<SchoolClass, bool>>? where = null)
        {
            IQueryable<SchoolClass> query = sadaDbContext.SchoolClasses;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query;
        }
    }
}
