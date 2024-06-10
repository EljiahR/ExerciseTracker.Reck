using ExerciseTracker.Data;
using ExerciseTracker.Models;
using ExerciseTracker.Repositories;
using ExerciseTracker.Repositories.Interfaces;
using ExerciseTracker.Services;
using ExerciseTracker.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

// Add services to the container.

//SqLite context
services.AddDbContext<ExerciseContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SqLiteString")), ServiceLifetime.Scoped);
//Sql Server context
//services.AddDbContext<ExerciseContext>(options =>
//    options.UseSqlite(builder.Configuration.GetConnectionString("SqlServerString")), ServiceLifetime.Scoped);

// Entity Framework Repo for PushUp model
services.AddScoped<IExerciseRepository<PushUp>, EFExerciseRepository<PushUp>>();
// Dapper Repo
services.AddScoped<IExerciseService<PushUp>, PushUpService>();

services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

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
