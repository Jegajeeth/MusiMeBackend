using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusiMe.Domain.Model;

namespace MusiMe.Infrastructure.EntityConfigurations
{
    public class SongsConfiguration : EntityWithIdConfiguration<Song>
    {
        public override void Configure(EntityTypeBuilder<Song> songModelBuilder)
        {
            base.Configure(songModelBuilder);
            songModelBuilder
                    .HasMany(s => s.PlaylistSongs)
                    .WithOne(ps => ps.Songs)
                    .HasForeignKey(ps => ps.SongId)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
