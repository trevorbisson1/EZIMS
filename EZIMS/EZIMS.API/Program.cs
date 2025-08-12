
using EZIMS.MODELS;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration.GetConnectionString("db") ?? throw new InvalidOperationException("Missing Connection String");
var db_version = new MariaDbServerVersion(new Version(11, 8, 3));// Specify your MariaDB server version

// Add services to the container.
builder.Services.AddDbContext<EZIMSApiDBContext>(options =>
    options.UseMySql(connection, db_version)
);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
