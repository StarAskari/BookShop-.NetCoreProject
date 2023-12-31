using BookShop.Application.FluentValidations;
using BookShop.Domain.Context;
using BookShop.Domain.Model;
using BookShop.Application.StartUp;
using BookShop.Infrastructure;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(typeof(Program));
#region ConnectionToDb
var connectionString = builder.Configuration.GetConnectionString("BookShopConnection");
builder.Services.AddDbContext<BookShopDbContext>(x => x.UseSqlServer(connectionString));
#endregion

builder.Services.RegisterInjectionServices();
builder.Services.FluentValidationService();
builder.Services.AutoMapperConfiguration();


// Add services to the container.
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
