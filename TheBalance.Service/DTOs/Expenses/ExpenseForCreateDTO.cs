//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

using TheBalance.Service.DTOs.Incomes;

namespace TheBalance.Service.DTOs.Expenses
{
    public class ExpenseForCreateDTO
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public IEnumerable<ExpenseForViewDTO> ExpenseSummary { get; set; }
    }
}
