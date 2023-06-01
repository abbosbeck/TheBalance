//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

using System.Linq.Expressions;
using TheBalance.Domain.Entities.Expenses;
using TheBalance.Service.DTOs.Expenses;

namespace TheBalance.Service.Interfaces.Expenses
{
    public interface IExpenseService : IGenericService<ExpenseForViewDTO,  ExpenseForCreateDTO>
    {
    }
}
