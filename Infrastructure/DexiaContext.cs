using DexiaApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace DexiaApi.Infrastructure;

public sealed class DexiaContext(DbContextOptions<DexiaContext> options) : DbContext(options)
{
   public DbSet<Cluster> Clusters => Set<Cluster>();
   public DbSet<Project> Projects => Set<Project>();

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder.ApplyConfigurationsFromAssembly(typeof(DexiaContext).Assembly);
   }
}