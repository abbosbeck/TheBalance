//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

namespace TheBalance.Service.DTOs.Incomes
{
    public class IncomeForCreateDTO
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public IEnumerable<IncomeSummaryForViewDTO> IncomeSummary { get; set; }
    }
}
