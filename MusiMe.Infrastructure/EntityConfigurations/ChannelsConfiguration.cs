using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusiMe.Domain.Model;

namespace MusiMe.Infrastructure.EntityConfigurations
{
    public class ChannelsConfiguration : EntityWithIdConfiguration<Channel>
    {
        public override void Configure(EntityTypeBuilder<Channel> channelModelBuilder)
        {
            base.Configure(channelModelBuilder);

            //one - many relationship for the channel and playlist
            channelModelBuilder
                    .HasMany(c => c.Playlists)
                    .WithOne(p => p.Channel)
                    .HasForeignKey(p => p.PlaylistOwnerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired(false);
        }
    }
}
