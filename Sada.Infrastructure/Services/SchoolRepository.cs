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
    public class SchoolRepository(SadaDbContext sadaDbContext) : IRepository<School>
    {
        public bool Add(School model)
        {
            try
            {
                sadaDbContext.Schools.Add(model);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(School model)
        {
            if(model == null) throw new ArgumentNullException("model");
            try
            {
                sadaDbContext.Schools.Remove(model);
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
            return sadaDbContext.Schools.ToList();
        }

        public async Task<ICollection<School>> GetAllAsync()
        {
            return await sadaDbContext.Schools.ToListAsync();
        }

        public void SaveChanges()
        {
            sadaDbContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await sadaDbContext.SaveChangesAsync();
        }

        public bool Update(School model)
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


        public IQueryable<School> Where(Expression<Func<School, bool>>? where = null)
        {
            IQueryable<School> query = sadaDbContext.Schools;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query;
        }
    }
}
