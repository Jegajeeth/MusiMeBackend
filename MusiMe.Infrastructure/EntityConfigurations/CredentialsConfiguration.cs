using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusiMe.Domain.Model;

namespace MusiMe.Infrastructure.EntityConfigurations
{
    public class CredentialsConfiguration : EntityWithIdConfiguration<Credential>
    {
        public override void Configure(EntityTypeBuilder<Credential> CredentialModelBuilder)
        {
            base.Configure(CredentialModelBuilder);
        }
    }
}
