using Docker.Dummy.Api.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Docker uses intern DNS so you use the name of the database service in ur compose
var server = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Docker" ? "db" : "localhost";

builder.Services.AddDbContext<UsersContext>(options =>
    options.UseMySQL($"server={server};port=3306;database=dummydb;user=dummyuser;pwd=dummypassword;"));

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
