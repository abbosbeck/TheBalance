//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

using TheBalance.Domain.Entities.Expenses;
using TheBalance.Service.DTOs.Incomes;

namespace TheBalance.Service.DTOs.Expenses
{
    public class ExpenseForCreateDTO
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        
        public int ExpenseSummaryId { get; set; }
        //public IEnumerable<ExpenseForViewDTO> ExpenseSummary { get; set; }

        public static implicit operator Expense(ExpenseForCreateDTO dto)
        {
            return new Expense()
            {
                Amount = dto.Amount,
                Description = dto.Description,
                Date = dto.Date,
                ExpenseSummaryId = dto.ExpenseSummaryId,
            };
        }
    }
}
