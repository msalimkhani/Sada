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
    public class LessonPointRepository(SadaDbContext sadaDbContext) : IRepository<LessonPoint>
    {
        public bool Add(LessonPoint model)
        {
            try
            {
                sadaDbContext.LessonPoints.Add(model);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(LessonPoint model)
        {
            if (model == null) throw new ArgumentNullException("model");
            try
            {
                sadaDbContext.LessonPoints.Remove(model);
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

        public LessonPoint? FindById(int id)
        {
            return sadaDbContext.LessonPoints.Find(id);
        }

        public async Task<LessonPoint?> FindByIdAsync(int id)
        {
            return await sadaDbContext.LessonPoints.FindAsync(id);
        }

        public LessonPoint? FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<LessonPoint?> FindByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public ICollection<LessonPoint> GetAll()
        {
            return sadaDbContext.LessonPoints.ToList();
        }

        public async Task<ICollection<LessonPoint>> GetAllAsync()
        {
            return await sadaDbContext.LessonPoints.ToListAsync();
        }

        public void SaveChanges()
        {
            sadaDbContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await sadaDbContext.SaveChangesAsync();
        }

        public bool Update(LessonPoint model)
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

        public IQueryable<LessonPoint> Where(Expression<Func<LessonPoint, bool>> where)
        {
            IQueryable<LessonPoint> query = sadaDbContext.LessonPoints;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query;
        }
    }
}
