using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusiMe.Domain.Interface;

namespace MusiMe.Infrastructure.EntityConfigurations
{
    public class EntityWithIdConfiguration<T>: IEntityTypeConfiguration<T> where T : IEntry
    {
        public virtual void Configure(EntityTypeBuilder<T> Entity)
        {
            Entity
                .Property(p => p.Id)
                .IsRequired(required: true);
        }
    }
}
