using Microsoft.EntityFrameworkCore;
using MusiMe.Domain.Model;

namespace MusiMe.Infrastructure.Data.Context
{
    public class DBContext(DbContextOptions<DBContext> options) : DbContext(options)
    {
        public DbSet<User> users {get; set;}
        public DbSet<Song> songs { get; set; }
        public DbSet<Channel> channels { get; set; }
        public DbSet<Playlist> playlists { get; set; }
        public DbSet<Credential> credentials { get; set; }
        public DbSet<Playlistsong> playlistsongs { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EntityConfigurations.CredentialsConfiguration());
            modelBuilder.ApplyConfiguration(new EntityConfigurations.UsersConfiguration());
            modelBuilder.ApplyConfiguration(new EntityConfigurations.ChannelsConfiguration());
            modelBuilder.ApplyConfiguration(new EntityConfigurations.SongsConfiguration());
            modelBuilder.ApplyConfiguration(new EntityConfigurations.PlaylistsConfiguration());
            modelBuilder.ApplyConfiguration(new EntityConfigurations.PlaylistSongsConfiguration());
        }
    }
}