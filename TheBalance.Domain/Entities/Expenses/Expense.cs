//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

using TheBalance.Domain.Commons;

namespace TheBalance.Domain.Entities.Expenses
{
    public class Expense : Transaction
    {
        // Relationship
        public int ExpenseSummaryId { get; set; }
        public ExpenseSummary ExpenseSummary { get; set; }
    }
}
