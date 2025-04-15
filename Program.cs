using Microsoft.EntityFrameworkCore;
using ApiWeb.Domain.Repositories.Interfaces;
using ApiWeb.Domain.Repositories;
using ApiWeb.Domain.Services.Interfaces;
using ApiWeb.Domain.Services;
using System;
using Microsoft.EntityFrameworkCore
using ApiWeb.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("api-db"));

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ISupplierService, SupplierService>();

var app = builder.Build();

app.MapControllers();
app.Run();
