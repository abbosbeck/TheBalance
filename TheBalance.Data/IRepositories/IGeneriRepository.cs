//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

using System.Linq.Expressions;

namespace TheBalance.Data.IRepositories
{
    public interface IGeneriRepository<T> where T : class
    {
        ValueTask<T> CreateAsync(T entity);
        T Update(T entity);
        ValueTask<T> DeleteAsync(Expression<Func<T, bool>> expression);
        ValueTask<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null);
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression,
            string[] includes = null,
            bool isTracking = true);
        ValueTask SaveChangesAsync();
    }
}
