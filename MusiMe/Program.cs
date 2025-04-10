using MediatR;
using Microsoft.EntityFrameworkCore;
using MusiMe.Application.Repositories;
using MusiMe.Application.Usecases;
using MusiMe.Domain.Interface.Repositories;
using MusiMe.Domain.Model;
using MusiMe.Infrastructure.Data.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(Program).Assembly));

#region DIs

builder.Services.AddScoped<IPlaylistRepository ,PlaylistRepository>();
builder.Services.AddScoped<IRequestHandler<GetPlaylistByIdRequest, Playlist>, GetPlaylistByIdUsecase>();

#endregion

builder.Services.AddDbContextFactory<DBContext>(options => {
    options.UseNpgsql(builder.Configuration.GetConnectionString("ConnectionString"));
});

var app = builder.Build();

app.MapControllers();

app.Run();
