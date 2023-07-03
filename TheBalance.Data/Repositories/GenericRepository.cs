//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TheBalance.Data.DbContexts;
using TheBalance.Data.IRepositories;
using TheBalance.Domain.Commons;

namespace TheBalance.Data.Repositories
{
    public class GenericRepository<T> : IGeneriRepository<T> where T : Auditable
    {
        private TheBalanceDbContext dbContext;
        protected readonly DbSet<T> dbSet;
        public GenericRepository(TheBalanceDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<T>();
        }
        public async ValueTask<T> CreateAsync(T entity)
                => (await dbSet.AddAsync(entity)).Entity;

        public async ValueTask<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            var entity = await dbSet.FirstOrDefaultAsync(expression);

            if (entity == null)
                return false;
            else
            {
                dbSet.Remove(entity);
                return true;
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }
        public T UpdateAsync(T entity)
        {
            var result = dbSet.Update(entity).Entity;
            
            return result;

        }

        public async ValueTask SaveChangesAsync()
            => await dbContext.SaveChangesAsync();

        public async Task<T> GetById(int id)
        {
            var result = await dbSet.Where(x  => x.Id == id).FirstOrDefaultAsync();
            
            return result;
        }
    }
}