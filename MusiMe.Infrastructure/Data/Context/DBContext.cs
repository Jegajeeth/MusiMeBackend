using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MusiMe.Infrastructure.Data.Entities;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options) : base(options) { }

    public DbSet<UserManagement> userManagements {get; set;}
    public DbSet<Music> music { get; set; }
    public DbSet<Channel> channel { get; set; }
    public DbSet<Playlist> playlist { get; set; }
}