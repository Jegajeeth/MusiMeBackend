using Microsoft.EntityFrameworkCore;
using MusiMe.Domain.Model;
using MusiMe.Domain.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
        
        protected ModelBuilder? modelBuilder;
        protected override void OnModelCreating(ModelBuilder _modelBuilder)
        {
            modelBuilder = _modelBuilder;

            #region credentials
                setEntityId<Credential>();
                EntityTypeBuilder<Credential> credentialsModelBuilder = modelBuilder.Entity<Credential>();
            #endregion credentials

            #region user
                setEntityId<User>();
                EntityTypeBuilder<User> userModelBuilder = modelBuilder.Entity<User>();

                // one - one relationship between the user and credentials
                userModelBuilder
                    .HasOne(u => u.Credential)
                    .WithOne(c => c.User)
                    .HasForeignKey<Credential>(c => c.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired(false);

                // one - one relationship between the user and channel
                userModelBuilder
                    .HasOne(u => u.Channel)
                    .WithOne(c => c.User)
                    .HasForeignKey<Channel>(u => u.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired(false);

            #endregion user

            #region Channel
                setEntityId<Channel>();

                EntityTypeBuilder<Channel> channerModelBuilder = modelBuilder.Entity<Channel>();

                //one - many relationship for the channel and playlist
                channerModelBuilder
                    .HasMany(c => c.Playlists)
                    .WithOne(p => p.Channel)
                    .HasForeignKey(p => p.PlaylistOwnerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired(false);

            #endregion Channel

            #region Song
                setEntityId<Song>();

                EntityTypeBuilder<Song> songModelBuilder = modelBuilder.Entity<Song>();
                songModelBuilder
                    .HasMany(s => s.PlaylistSongs)
                    .WithOne(ps => ps.Songs)
                    .HasForeignKey(ps => ps.SongId)
                    .OnDelete(DeleteBehavior.Cascade);

            #endregion Song

            #region Playlist
                setEntityId<Playlist>();

                EntityTypeBuilder<Playlist> playlistModelBuilder = modelBuilder.Entity<Playlist>();
                playlistModelBuilder
                    .HasMany(p => p.PlaylistSongs)
                    .WithOne(ps => ps.Playlists)
                    .HasForeignKey(ps => ps.PlaylistId)
                    .OnDelete(DeleteBehavior.Cascade);
            #endregion Playlist

            #region playlistSong
                EntityTypeBuilder<Playlistsong> playlistsongsModelBuilder = modelBuilder.Entity<Playlistsong>();
                playlistsongsModelBuilder
                    .HasKey(ps => new { ps.SongId, ps.PlaylistId });
            #endregion playlistSong
        }

        private void setEntityId<T>( bool IsRequired = true ) where T : IEntry
        {
            modelBuilder?.Entity<T>()
                .Property(p => p.Id)
                .IsRequired(required: IsRequired);
        }


    }
}