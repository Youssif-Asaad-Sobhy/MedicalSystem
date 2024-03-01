using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MS.Application;
using MS.Application.Interfaces;
using MS.Application.Middlewares;
using MS.Application.Services;
using MS.Data.Entities;
using MS.Infrastructure;
using MS.Infrastructure.Contexts;
using MS.Infrastructure.Seeder;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container
builder.Services.AddControllers();
builder.Services.Appplicatiion_CS(builder.Configuration);
builder.Services.Infrastructure_CS();
builder.Services.AddLogging();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>(
                options =>
                {
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                });
builder.Services.AddCors(corsoption =>
{
    corsoption.AddPolicy("MyPolicy", corspolicybuilder =>
    {
        corspolicybuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        //.withorigins(" domain");
    });
});

var app = builder.Build();

#region Seeding part
using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
    var RoleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    await RoleSeeder.SeedAsync(RoleManager);
    await UserSeeder.SeedAsync(userManager);
} 
#endregion

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseHttpsRedirection();
app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
