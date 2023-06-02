//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

using System.Linq.Expressions;
using System.Net;
using Microsoft.EntityFrameworkCore;
using TheBalance.Data.IRepositories;
using TheBalance.Domain.Entities.Expenses;
using TheBalance.Service.DTOs.Expenses;
using TheBalance.Service.Interfaces.Expenses;

namespace TheBalance.Service.Services.Expenses
{
    public class ExpenseService : IExpenseService
    {
        private readonly IGeneriRepository<Expense> expenseRepository;
        public ExpenseService(IGeneriRepository<Expense> expenseRepository)
        {
            this.expenseRepository = expenseRepository;
        }
        public async ValueTask<Expense> CreateAsync(ExpenseForCreateDTO expense)
        {
            var createdExpense = await expenseRepository.CreateAsync((Expense) expense);

            if(createdExpense == null) 
            {
                // throw better implementen expemtion
                throw new InvalidOperationException();
            }
            await expenseRepository.SaveChangesAsync();

            return createdExpense;
        }

        public async ValueTask<bool> DeleteAsync(long id)
        {
            var isDeleted = await expenseRepository.DeleteAsync(x => x.Id == id);

            if(!isDeleted)
            {
                // HttpsStatusCodeExpetion qaytarilishi shart!

                //throw new HttpStatusCodeExeption(400, "User not found!");

                throw new InvalidOperationException();
            }
            await expenseRepository.SaveChangesAsync();
            
            return isDeleted;
        }

        public async ValueTask<IEnumerable<Expense>> GetAllAsync(Expression<Func<Expense, bool>> expression = null)
        {
            var expenses = expenseRepository.GetAll(expression).Include(x => x.ExpenseSummary);

            if(expenses == null)
            {
                // throw exeption
            }

            return expenses;
        }

        public ValueTask<Expense> UpdateAsync(long id, ExpenseForCreateDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
