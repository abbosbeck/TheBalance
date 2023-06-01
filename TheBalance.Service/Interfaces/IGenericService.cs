using System.Linq.Expressions;
using TheBalance.Domain.Entities.Expenses;
using TheBalance.Service.DTOs.Expenses;

namespace TheBalance.Service.Interfaces
{
    public interface IGenericService<Tout, Tin> where Tout : class
    {
        ValueTask<IEnumerable<Tout>> GetAllAsync(Expression<Func<Tout, bool>> expression = null);
        ValueTask<Tout> CreateAsync(Tin expense);
        ValueTask<bool> DeleteAsync(long id);
        ValueTask<Tout> UpdateAsync(long id, Tin dto);
    }
}
