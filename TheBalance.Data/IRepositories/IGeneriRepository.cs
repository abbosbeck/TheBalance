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
        ValueTask<bool> DeleteAsync(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetById(int id);
        ValueTask SaveChangesAsync();
    }
}
