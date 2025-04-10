using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusiMe.Domain.Model;

namespace MusiMe.Infrastructure.EntityConfigurations
{
    public class PlaylistsConfiguration : EntityWithIdConfiguration<Playlist>
    {
        public override void Configure(EntityTypeBuilder<Playlist> PlaylistModelBuilder)
        {
            base.Configure(PlaylistModelBuilder);
            PlaylistModelBuilder
                   .HasMany(p => p.PlaylistSongs)
                   .WithOne(ps => ps.Playlists)
                   .HasForeignKey(ps => ps.PlaylistId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
