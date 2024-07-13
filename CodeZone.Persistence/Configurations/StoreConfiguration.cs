using CodeZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeZone.Persistence.Configurations
{
    internal class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(50);
            builder.HasMany(e => e.Items)
               .WithMany(e => e.Stores)
               .UsingEntity(typeof(StoreItem));
        }
    }
}
