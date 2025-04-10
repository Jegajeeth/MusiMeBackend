using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusiMe.Domain.Model;

namespace MusiMe.Infrastructure.EntityConfigurations
{
    public class UsersConfiguration : EntityWithIdConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> userModelBuilder)
        {
            base.Configure(userModelBuilder);
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

        }
    }
}
