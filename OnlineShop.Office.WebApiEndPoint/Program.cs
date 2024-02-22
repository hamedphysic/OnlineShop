
using Microsoft.EntityFrameworkCore;
using Onlineshop.EFCore;
using System;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<OnlineshopDbContext>(x => x.UseSqlServer(connectionString));

builder.Services.AddIdentity<OnlineshopDmain.Aggregates.UserManagment.OnlineShopUser, OnlineshopDmain.Aggregates.UserManagment.OnlineShopRoll>().AddEntityFrameworkStores<OnlineshopDbContext>();






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
