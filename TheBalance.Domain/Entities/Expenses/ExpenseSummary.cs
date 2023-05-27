//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

using TheBalance.Domain.Commons;

namespace TheBalance.Domain.Entities.Expenses
{
    public class ExpenseSummary : Auditable
    {
        public string Totals { get; set; }
        public decimal Planned { get; set; }

        //Relationship
        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
