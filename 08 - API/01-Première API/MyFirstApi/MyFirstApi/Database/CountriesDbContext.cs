using MyFirstApi.Entity;
using Microsoft.EntityFrameworkCore;

namespace MyFirstApi.Database
{
    public class CountriesDbContext : DbContext
    {
        IConfiguration appConfig;

        public DbSet<Country> Countries { get; set; }

        public CountriesDbContext(IConfiguration config)
        {
            this.appConfig = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(this.appConfig.GetConnectionString("Default"));
        }
    }
}
