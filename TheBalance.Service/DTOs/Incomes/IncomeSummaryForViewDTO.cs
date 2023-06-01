//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

namespace TheBalance.Service.DTOs.Incomes
{
    public class IncomeSummaryForViewDTO
    {
        public string Totals { get; set; }
        public decimal Planned { get; set; }
        public decimal Actual { get; set; }
        public decimal Different{ get; set; }
    }
}
