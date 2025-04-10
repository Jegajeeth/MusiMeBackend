using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusiMe.Domain.Model;

namespace MusiMe.Infrastructure.EntityConfigurations
{
    public class PlaylistSongsConfiguration : IEntityTypeConfiguration<Playlistsong>
    {
        public void Configure(EntityTypeBuilder<Playlistsong> playlistSongsModelBuilder) 
        {
            playlistSongsModelBuilder
                .HasKey(ps => new { ps.SongId, ps.PlaylistId });
        }

    }
}
