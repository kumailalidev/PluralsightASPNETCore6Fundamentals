using BethanysPieShop.Models;

var builder = WebApplication.CreateBuilder(args);

// Registering services

builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IPieRepository, MockPieRepository>();

builder.Services.AddControllersWithViews();

// Building web application
var app = builder.Build();

// Adding middleware components

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

app.MapDefaultControllerRoute();

app.Run();
