using System.Linq.Expressions;

namespace LetheApi.Repositories;

public interface IGenericRepository<T> where T : class, new()
{
    IQueryable<T> Query();

    Task<IEnumerable<T>> GetAllAsync();
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

    Task<T?> GetFirstAsync();
    Task<T?> GetByIdAsync(int id);
    Task<T?> GetByAsync(Expression<Func<T, bool>> predicate);

    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);

    Task<int> SaveChangesAsync();
    int SaveChanges();
}