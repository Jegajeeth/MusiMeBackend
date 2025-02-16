using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MusiMe.Domain.Model;
using MusiMe.Domain.Interface;

namespace MusiMe.Infrastructure.Data.Context
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        public DbSet<User> users {get; set;}
        public DbSet<Music> musics { get; set; }
        public DbSet<Channel> channels { get; set; }
        public DbSet<Playlist> playlists { get; set; }
        public DbSet<CredentialManagement> credentials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // foreach (var property in modelBuilder.Model.GetEntityTypes())
            // {
            //     property.ClrType
            // }
            // modelBuilder.Entity<Music>()
            //     .Property(datapoints => datapoints.Id)
            //     .IsRequired(true);
            // ;
        }
    }
}