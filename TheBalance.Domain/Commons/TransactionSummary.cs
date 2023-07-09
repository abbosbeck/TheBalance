//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

namespace TheBalance.Domain.Commons
{
    public class TransactionSummary : Auditable
    {

        // Name: For example: Food, Gifts, Sport...
        public string Totals { get; set; }
        public decimal Planned { get; set; }
    }
}
