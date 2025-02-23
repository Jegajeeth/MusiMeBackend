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
        public DbSet<CredentialManagement> credentials { get; set; }
        public DbSet<Author> authors { get; set; }

        protected ModelBuilder? modelBuilder;
        protected override void OnModelCreating(ModelBuilder _modelBuilder)
        {
            // foreach (var property in modelBuilder.Model.GetEntityTypes())
            // {
            //     property.ClrType
            // }
            // modelBuilder.Entity<Music>()
            //     .Property(datapoints => datapoints.Id)
            //     .IsRequired(true);
            // ;
            modelBuilder = _modelBuilder;
            #region user
                EntityTypeBuilder<User> userModelBuilder = modelBuilder.Entity<User>();

                setEntityId<User>();
        
            #endregion user

            #region Music
                EntityTypeBuilder<Music> musicModelBuilder = modelBuilder.Entity<Music>();

                setEntityId<Music>();

            #endregion Music

            #region Channel
                EntityTypeBuilder<Channel> channerModelBuilder = modelBuilder.Entity<Channel>();

                setEntityId<Channel>();

            #endregion Channel

            #region Playlist
                EntityTypeBuilder<Playlist> playlistModelBuilder = modelBuilder.Entity<Playlist>();

                setEntityId<Playlist>();
                
            #endregion Playlist

            #region Author
                EntityTypeBuilder<Author> authorModelBuilder = modelBuilder.Entity<Author>();

                setEntityId<Author>();
            #endregion Author
        }

        private void setEntityId<T>( bool IsRequired = true ) where T : IEntry
        {
            modelBuilder?.Entity<T>()
                .Property(p => p.Id)
                .IsRequired(required: IsRequired);
        }


    }
}