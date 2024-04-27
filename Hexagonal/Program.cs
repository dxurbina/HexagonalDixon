using Hexagonal;
using Hexagonal.Shared.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options => options.UseLazyLoadingProxies(true).UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnection")));
builder.Services.AddUserExtension();
builder.Services.AddCategoryExtension();
builder.Services.AddNoteExtension();
builder.Services.AddTagExtension();
builder.Services.AddNotesTagsExtension();

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
