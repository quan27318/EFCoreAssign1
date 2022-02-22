using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using EFCore.Services;
using EFCore.Responsitory;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StudentDbContext>(
    options => options.UseSqlServer("Server=ADMIN-PC;Initial Catalog=DBName;Integrated Security=True")
);
builder.Services.AddTransient<IStudent , StudentServices>();
builder.Services.AddTransient<IStudentResponsitory, StudentResponsitory>();
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
