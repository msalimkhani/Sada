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
    public class LessonRepository(SadaDbContext sadaDbContext) : IRepository<Lesson>
    {
        public bool Add(Lesson model)
        {
            try
            {
                sadaDbContext.Lessons.Add(model);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Lesson model)
        {
            if (model == null) throw new ArgumentNullException("model");
            try
            {
                sadaDbContext.Lessons.Remove(model);
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

        public Lesson? FindById(int id)
        {
            return sadaDbContext.Lessons.Find(id);
        }

        public async Task<Lesson?> FindByIdAsync(int id)
        {
            return await sadaDbContext.Lessons.FindAsync(id);
        }

        public Lesson? FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Lesson?> FindByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public ICollection<Lesson> GetAll()
        {
            return sadaDbContext.Lessons.ToList();
        }

        public async Task<ICollection<Lesson>> GetAllAsync()
        {
            return await sadaDbContext.Lessons.ToListAsync();
        }

        public void SaveChanges()
        {
            sadaDbContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await sadaDbContext.SaveChangesAsync();
        }

        public bool Update(Lesson model)
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

        public IQueryable<Lesson> Where(Expression<Func<Lesson, bool>> where)
        {
            IQueryable<Lesson> query = (IQueryable<Lesson>)sadaDbContext.Lessons;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query;
        }
    }
}
