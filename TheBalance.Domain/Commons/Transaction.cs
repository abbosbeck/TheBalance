//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

namespace TheBalance.Domain.Commons
{
    public class Transaction : Auditable
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
    }
}
