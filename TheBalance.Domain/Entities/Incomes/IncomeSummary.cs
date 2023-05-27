//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

using TheBalance.Domain.Commons;

namespace TheBalance.Domain.Entities.Incomes
{
    public class IncomeSummary : TransactionSummary
    {
        //Relationship
        public virtual ICollection<Income> Incomes { get; set; }
    }
}
