using Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options) { }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.ApplyConfiguration(new CountryConfiguration());
        //    //modelBuilder.ApplyConfiguration(new CountryDetailsConfiguration());
        //    SeedDatabase(modelBuilder);
        //    base.OnModelCreating(modelBuilder);
        //}

        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryDetails> CountryDetails { get; set; }
    }
}
