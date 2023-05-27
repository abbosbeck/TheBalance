//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

using TheBalance.Domain.Commons;

namespace TheBalance.Domain.Entities.Expenses
{
    public class ExpenseSummary : TransactionSummary
    {
        //Relationship
        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
