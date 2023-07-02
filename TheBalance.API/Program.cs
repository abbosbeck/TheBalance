using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TheBalance.Data.DbContexts;
using TheBalance.Data.IRepositories;
using TheBalance.Data.Repositories;
using TheBalance.Domain.Entities.Expenses;
using TheBalance.Service.Interfaces.Expenses;
using TheBalance.Service.Services.Expenses;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<TheBalanceDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TheBalanceDb")));

builder.Services.AddTransient<IExpenseService, ExpenseService>();
builder.Services.AddTransient<IGeneriRepository<Expense>, GenericRepository<Expense>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();