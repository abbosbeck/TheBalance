//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

using System.Linq.Expressions;
using TheBalance.Data.IRepositories;
using TheBalance.Domain.Entities.Expenses;
using TheBalance.Service.DTOs.Expenses;
using TheBalance.Service.Exceptions;
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
                throw new TheBalanceException(400, "Creation failed!");
            }
            await expenseRepository.SaveChangesAsync();

            return createdExpense;
        }

        public async ValueTask<bool> DeleteAsync(long id)
        {
            var isDeleted = await expenseRepository.DeleteAsync(x => x.Id == id);

            if(!isDeleted)
            {
                throw new TheBalanceException(404, "Item not found!");
            }
            await expenseRepository.SaveChangesAsync();
            
            return isDeleted;
        }

        public async ValueTask<IEnumerable<Expense>> GetAllAsync(Expression<Func<Expense, bool>> expression = null)
        {
            var expenses = await expenseRepository.GetAllAsync();

            if(expenses == null)
            {
                throw new TheBalanceException(404, "Expenses not found!");
            }

            return expenses;
        }

        public async ValueTask<Expense> GetByIdAsync(int id)
        {
            var expense = await expenseRepository.GetById(id);

            if (expense == null)
                throw new TheBalanceException(404, "Expense not found!");

            return expense;
        }

        public async ValueTask<Expense> UpdateAsync(int id, ExpenseForCreateDTO dto)
        {
            var newExpense = new Expense();
            newExpense = (Expense)dto;
            newExpense.Id = id;

            var result = expenseRepository.UpdateAsync(newExpense);
            await expenseRepository.SaveChangesAsync();

            return result;

        }
    }
}
