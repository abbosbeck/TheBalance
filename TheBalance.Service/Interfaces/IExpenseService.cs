//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

using System.Linq.Expressions;
using TheBalance.Domain.Entities.Expenses;
using TheBalance.Service.DTOs.Expenses;

namespace TheBalance.Service.Interfaces
{
    public interface IExpenseService
    {
        ValueTask<IEnumerable<Expense>> GetAllAsync(Expression<Func<Expense, bool>> expression = null);
        ValueTask<Expense> CreateAsync(ExpenseForCreateDTO expense);
        ValueTask<bool> DeleteAsync(long id);
        ValueTask<Expense> UpdateAsync(long id, ExpenseForCreateDTO dto);
    }
}
