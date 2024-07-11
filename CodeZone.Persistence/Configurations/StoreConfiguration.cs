using CodeZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
