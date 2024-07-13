using CodeZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CodeZone.Persistence.Data
{
    public class CodeZoneContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreItem> StoresItems { get; set; }
        public CodeZoneContext(DbContextOptions contextOptions) : base(contextOptions) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
