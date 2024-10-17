using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace cohort_backend.wwwapi.Data
{
    public class DatabaseContext : DbContext
    {
        private string _connectionString;
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO: Seed data

            base.OnModelCreating(modelBuilder);
        }

        //public DbSet<Post> Post { get; set; }
        //public DbSet<User> Users { get; set; }
    }
}
