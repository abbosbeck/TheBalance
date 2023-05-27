//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

using TheBalance.Domain.Commons;

namespace TheBalance.Domain.Entities.Incomes
{
    public class Income : Transaction
    {
        //Relationship
        public int IncomeSummaryId { get; set; }
        public IncomeSummary IncomeSummary { get; set; }
    }
}
