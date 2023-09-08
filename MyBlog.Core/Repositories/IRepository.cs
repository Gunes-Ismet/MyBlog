using MyBlog.Core.Entities;
using System.Linq.Expressions;

namespace MyBlog.Core.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        Task CreateAsync(T entity);
        T Update(T entity);
        void Remove(T entity);
    }
}
