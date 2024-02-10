using Microsoft.EntityFrameworkCore;
using MS.Application;
using MS.Application.Interfaces;
using MS.Application.Services;
using MS.Infrastructure;
using MS.Infrastructure.Contexts;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
Application.Application_CS(builder.Services,builder.Configuration);
Infrastructure.Infrastucture_CS(builder.Services,builder.Configuration);
builder.Services.AddDbContext<Context>(
                options =>
                {
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                });

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
