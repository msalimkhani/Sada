﻿using Microsoft.EntityFrameworkCore;
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
            try
            {
                sadaDbContext.Grades.Add(model);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Grade model)
        {
            if (model == null) throw new ArgumentNullException("model");
            try
            {
                sadaDbContext.Grades.Remove(model);
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

        public Grade? FindById(int id)
        {
            return sadaDbContext.Grades.Find(id);
        }

        public async Task<Grade?> FindByIdAsync(int id)
        {
            return await sadaDbContext.Grades.FindAsync(id);
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

        public async Task<ICollection<Grade>> GetAllAsync()
        {
            return await sadaDbContext.Grades.ToListAsync();
        }

        public void SaveChanges()
        {
            sadaDbContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await sadaDbContext.SaveChangesAsync();
        }

        public bool Update(Grade model)
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

        public IQueryable<Grade> Where(Expression<Func<Grade, bool>> where)
        {
            IQueryable<Grade> query = (IQueryable<Grade>)sadaDbContext.Grades;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query;
        }
    }
}
