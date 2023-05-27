//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

using Microsoft.EntityFrameworkCore;
using TheBalance.Domain.Entities.Expenses;
using TheBalance.Domain.Entities.Incomes;

namespace TheBalance.Data.DbContexts
{
    public class TheBalanceDbContext : DbContext
    {
        public TheBalanceDbContext(DbContextOptions<TheBalanceDbContext> options) : base(options) { }

        public virtual DbSet<Income> Incomes { get; set; }
        public virtual DbSet<IncomeSummary> IncomeSummaries { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<ExpenseSummary> ExpenseSummaries { get; set; }
    }
}
