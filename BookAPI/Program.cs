using BookAPI.Models;
using BookAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<BookdbContext>();
builder.Services.AddScoped<KonyvInterface, KonyvService>();
builder.Services.AddScoped<NemzetisegInterface, NemzetisegService>();
builder.Services.AddScoped<SzerzoInterface, SzerzoService>();

// Add services to the container.

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
