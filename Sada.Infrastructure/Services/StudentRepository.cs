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
    public class StudentRepository(SadaDbContext sadaDbContext) : IRepository<Student>
    {
        public bool Add(Student model)
        {
            try
            {
                sadaDbContext.Students.Add(model);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Student model)
        {
            if (model == null) throw new ArgumentNullException("model");
            try
            {
                sadaDbContext.Students.Remove(model);
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

        public Student? FindById(int id)
        {
            return sadaDbContext.Students.Find(id);
        }

        public async Task<Student?> FindByIdAsync(int id)
        {
            return await sadaDbContext.Students.FindAsync(id);
        }

        public Student? FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Student?> FindByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public ICollection<Student> GetAll()
        {
            return sadaDbContext.Students.ToList();
        }

        public async Task<ICollection<Student>> GetAllAsync()
        {
            return await sadaDbContext.Students.ToListAsync();
        }

        public void SaveChanges()
        {
            sadaDbContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await sadaDbContext.SaveChangesAsync();
        }

        public bool Update(Student model)
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

        public IQueryable<Student> Where(Expression<Func<Student, bool>> where)
        {
            IQueryable<Student> query = sadaDbContext.Students;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query;
        }
    }
}
