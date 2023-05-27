namespace TheBalance.Domain.Commons
{
    public class TransactionSummary : Auditable
    {
        public string Totals { get; set; }
        public decimal Planned { get; set; }
    }
}
