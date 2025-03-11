using Microsoft.EntityFrameworkCore;
using MusiMe.Domain.Model;
using MusiMe.Domain.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MusiMe.Infrastructure.Data.Context
{
    public class DBContext(DbContextOptions<DBContext> options) : DbContext(options)
    {
        public DbSet<User> users {get; set;}
        public DbSet<Music> musics { get; set; }
        public DbSet<Channel> channels { get; set; }
        public DbSet<Playlist> playlists { get; set; }
        public DbSet<Credentials> credentials { get; set; }
        
        protected ModelBuilder? modelBuilder;
        protected override void OnModelCreating(ModelBuilder _modelBuilder)
        {
            modelBuilder = _modelBuilder;

            #region credentials
                setEntityId<Credentials>();
                EntityTypeBuilder<Credentials> credentialsModelBuilder = modelBuilder.Entity<Credentials>();
            #endregion credentials

            #region user
                setEntityId<User>();
                EntityTypeBuilder<User> userModelBuilder = modelBuilder.Entity<User>();

                userModelBuilder
                    .HasOne(u => u.Credentials)
                    .WithOne(c => c.User)
                    .HasForeignKey<Credentials>(c => c.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired(false);

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

            #endregion Channel

            #region Music
                setEntityId<Music>();

                EntityTypeBuilder<Music> musicModelBuilder = modelBuilder.Entity<Music>();

            #endregion Music

            #region Playlist
                setEntityId<Playlist>();

                EntityTypeBuilder<Playlist> playlistModelBuilder = modelBuilder.Entity<Playlist>();
                
            #endregion Playlist
        }

        private void setEntityId<T>( bool IsRequired = true ) where T : IEntry
        {
            modelBuilder?.Entity<T>()
                .Property(p => p.Id)
                .IsRequired(required: IsRequired);
        }


    }
}