using Microsoft.EntityFrameworkCore;
using MusiMe.Infrastructure.Data.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextFactory<DBContext>(options => {
    options.UseNpgsql(builder.Configuration.GetConnectionString("ConnectionString"));
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
