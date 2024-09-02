using Entities.Data;
using Microsoft.EntityFrameworkCore;
using Repositories.Generic;
using RepositoryContracts.Generic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
//builder.Services.AddScoped<,>


builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    //    option.UseInMemoryDatabase("server=.;Database=SMSDb;Trusted_Connection=True;TrustServerCertificate=Yes;");
    option.UseSqlite("Data Source=app-sms.db");
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
