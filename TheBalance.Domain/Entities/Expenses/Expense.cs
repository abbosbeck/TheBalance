//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

using TheBalance.Domain.Commons;

namespace TheBalance.Domain.Entities.Expenses
{
    public class Expense : Auditable
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }

        // Relationship
        public int ExpenseSummaryId { get; set; }
        public ExpenseSummary ExpenseSummary { get; set; }
    }
}
