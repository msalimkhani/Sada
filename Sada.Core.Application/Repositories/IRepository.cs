using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Application.Repositories
{
    public interface IRepository<TModel> : IDisposable, IAsyncDisposable where TModel : class
    {
        ICollection<TModel> GetAll();
        IQueryable<TModel> Where(Expression<Func<TModel, bool>> where);
        TModel? FindById(int id);
        TModel? FindByName(string name);
        Task<ICollection<TModel>> GetAllAsync();
        Task<TModel?> FindByIdAsync(int id);
        Task<TModel?> FindByNameAsync(string name);
        bool Add(TModel model);
        bool Update(TModel model);
        bool Delete(TModel model);
        bool Delete(int id);
        void SaveChanges();
        Task SaveChangesAsync();

    }
}
