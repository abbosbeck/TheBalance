//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

using TheBalance.Service.DTOs.Incomes;

namespace TheBalance.Service.DTOs.Expenses
{
    public class ExpenseForViewDTO
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public IncomeSummaryForViewDTO IncomeSummary { get; set; }
    }
}
